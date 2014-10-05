using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;


namespace nfoReader
{
    public partial class mainWnd : Form
    {
        string version = "0.0.5";

        public mainWnd(string nfoPath)
        {
            InitializeComponent();
            this.nfoBox.KeyDown += new KeyEventHandler(nfo_KeyDown);
            this.Text = "devvis nfo-reader - v" + version;

            if (nfoPath != "")
            {
                readNfoFromPath(nfoPath);
            }
        }

        private void readNfoFromPath(string nfoPath)
        {
            Encoding enc = Encoding.GetEncoding(865);
            if (File.Exists(nfoPath))
            {
                if (Path.GetExtension(nfoPath) == ".nfo")
                {
                    StreamReader file = new StreamReader(nfoPath, enc);
                    nfoBox.Text = file.ReadToEnd();
                    file.Close();
                }
            }
            else
            {
                MessageBox.Show("Unable to open file. (Does it exist?)", "devvis nfo-reader");
            }
        }

        void nfo_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    /*
                    settingsWnd wnd = new settingsWnd();
                    wnd.Show();
                    */
                    MessageBox.Show("devvis nfo-reader v"+version+@"

A simple program that displays nfo-files the way they should be displayed.

This program is a Free program licensed under the MIT-license.

See http://github.com/devvis/nfoReader for sourcecode (and yes, the icon is butt-ugly).", "devvis nfo-reader", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        private void nfoBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void nfoBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    string nfo = a.GetValue(0).ToString();
                    this.Activate();
                    readNfoFromPath(nfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while opening NFO-file. " + ex.Message);
            }
        }
    }
}
