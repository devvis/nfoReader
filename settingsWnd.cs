using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace nfoReader
{
    public partial class settingsWnd : Form
    {
        public settingsWnd()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerProgram()
        {
            /*
            // register the actual program
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Classes\\nfoReader.file.enc", true);
            if (key == null)
            {
                key = Registry.CurrentUser.CreateSubKey("Software\\Classes\\nfoReader.file.enc");
                key.CreateSubKey("DefaultIcon");
                RegistryKey program = Registry.CurrentUser.OpenSubKey("Software\\Classes\\nfoReader.file.enc\\DefaultIcon", true);
                program.SetValue("", Application.ExecutablePath + ",0");
                program.Close();
            }
            key.SetValue("", "nfoReader.file.enc");
            key.Close();

            // register the extension
            RegistryKey ext = Registry.CurrentUser.OpenSubKey("Software\\Classes\\nfoReader.file.enc\\Shell\\")
            */
            MessageBox.Show("I'm not currently implemented.", "devvis nfo-reader");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.nfoFilesCheck.Checked == true)
            {
                registerProgram();
            }
            this.Close();
        }
    }
}
