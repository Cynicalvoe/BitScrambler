using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BitScrambler
{
    public partial class Window : Form
    {
        public List<string> Files { get; private set; }

        public Info InfoDialog { get; set; }

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            Files = new List<string>();
            InfoDialog = new Info();

            this.ResetApplication();
            this.succLabel.Visible = false;

            // Show the terms at launch
            InfoDialog.TopMost = true;
            InfoDialog.Show();
        }

        /* Event Listeners */

        private void selectFileBtn_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }

        private void selectFolderBtn_Click(object sender, EventArgs e)
        {
            DialogResult r = this.openFolderDialog.ShowDialog();

            if (r == DialogResult.OK)
            {
                if (File.GetAttributes(this.openFolderDialog.SelectedPath).HasFlag(FileAttributes.Directory))
                {
                    PrepareFiles(BuildFileList(this.openFolderDialog.SelectedPath, new List<string>()));
                }
                else
                {
                    LogError("That isn't a directory!");
                }
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            PrepareFiles(new List<string>(this.openFileDialog.FileNames));
        }

        private void begin_Click(object sender, EventArgs e)
        {
            if (Files.Count > 0)
            {
                if (this.encKey.Text.Length > 4)
                {
                    ProcessOperation();
                    ResetApplication();
                }
                else
                {
                    LogError("Encryption key must be 5 characters or longer");
                }
            }
            else
            {
                LogError("You must select a file first");
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            InfoDialog.Show();
        }

        /* Private Functions */

        private List<string> BuildFileList(String path, List<string> results)
        {
            string[] fs = Directory.GetFileSystemEntries(path);

            foreach (string file in fs)
            {
                if (File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                {
                    BuildFileList(file, results);
                }
                else
                {
                    results.Add(file);
                }
            }

            return results;
        }

        private void PrepareFiles(List<string> files)
        {
            Files = files;
            this.filesSelected.Text = $"{Files.Count} file(s) selected";
            this.filesSelected.Visible = true;
        }

        private void ProcessOperation()
        {
            // Change labels
            this.succLabel.Visible = false;
            this.workingLabel.Visible = true;

            // Begin processing
            if (this.encRadio.Checked && !this.decRadio.Checked)
            {
                Files.AsParallel().ForAll(file => { Encrypt(file); });

            }
            else if (this.decRadio.Checked && !this.encRadio.Checked)
            {
                Files.AsParallel().ForAll(file => { Decrypt(file); });
            }
            else
            {
                LogError("Not sure how you pulled that off, but nice work.");
            }
            
            // The code above is blocking, so this label will display when all files have been processed
            this.succLabel.Visible = true;
        }

        private void ResetApplication()
        {
            // Remove errors and other labels
            this.errorMsg.Visible = false;
            this.workingLabel.Visible = false;

            // Reset files selected
            this.Files.Clear();
            this.filesSelected.Visible = false;
        }

        private void LogError(string text)
        {
            this.errorMsg.Text = text;
            this.errorMsg.Visible = true;
        }

        /// <summary>
        /// Encrypt a file according to the key from the Windows Form, and stores the IV within the file.
        /// </summary>
        /// <param name="file">The file's complete path.</param>
        private void Encrypt(string file)
        {
            Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(this.encKey.Text, new UnicodeEncoding().GetBytes("#F,g*8z!p0O`"));

            using (FileStream fse = new FileStream(file + ".enc", FileMode.Create))
            {
                RijndaelManaged rmc = new RijndaelManaged();
                rmc.Key = key.GetBytes(rmc.KeySize / 8);
                rmc.GenerateIV();

                using (FileStream fsi = new FileStream(file, FileMode.Open))
                {
                    fse.Write(rmc.IV, 0, rmc.BlockSize / 8);

                    using (CryptoStream cs = new CryptoStream(fse, rmc.CreateEncryptor(rmc.Key, rmc.IV), CryptoStreamMode.Write))
                    {
                        int data;
                        while ((data = fsi.ReadByte()) != -1)
                        {
                            cs.WriteByte((byte)data);
                        }
                    }
                }
            }

            System.IO.File.Delete(file);
        }

        /// <summary>
        /// Decrypt a file according to the key from the Windows Form, and the IV stored within the file.
        /// </summary>
        /// <param name="file">The file's complete path.</param>
        private void Decrypt(string file)
        {
            if (file.EndsWith(".enc"))
            {
                try
                {
                    Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(this.encKey.Text, new UnicodeEncoding().GetBytes("#F,g*8z!p0O`"));

                    using (FileStream fsd = new FileStream(file.Substring(0, file.LastIndexOf(".enc")), FileMode.Create))
                    {
                        RijndaelManaged rmc = new RijndaelManaged();
                        rmc.Key = key.GetBytes(rmc.KeySize / 8);

                        using (FileStream fsi = new FileStream(file, FileMode.Open))
                        {
                            byte[] bytes = new byte[rmc.BlockSize / 8];
                            fsi.Read(bytes, 0, bytes.Length);
                            rmc.IV = bytes;

                            using (CryptoStream cs = new CryptoStream(fsd, rmc.CreateDecryptor(rmc.Key, rmc.IV), CryptoStreamMode.Write))
                            {
                                int data;
                                while ((data = fsi.ReadByte()) != -1)
                                {
                                    cs.WriteByte((byte)data);
                                }
                            }
                        }
                    }

                    System.IO.File.Delete(file);
                }
                catch (CryptographicException)
                {
                    // Delete the partially-decrypted file, so the user is not confused and extra data isn't put on disk.
                    System.IO.File.Delete(file.Substring(0, file.LastIndexOf(".enc")));
                    
                    //TODO: Open a new Form that will display the error? What if decrypting directory with 1,000 files?
                }
            }
        }
    }
}
