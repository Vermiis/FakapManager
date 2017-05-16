using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakapManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckVal_Click(object sender, EventArgs e)
        {
            lblKeyValue.Text = FakapManager.ReadWrite.ShowValue(txtbRegKey.Text, txtbRegEntry.Text);
        }

        

        private void btnKronosSet_Click(object sender, EventArgs e)
        {
            string key = "";
            string valname = "";
            
            Registry.SetValue(key, valname, KronosDBName.Text);
            Registry.SetValue(key, valname, KronosPath1.Text);
            Registry.SetValue(key, valname, KronosPath2.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var x= cmbRoots.SelectedIndex;
            switch (x)
            {
                case 1:
                    {
                        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(txtbSubKey.Text, true))
                        {
                            if (key == null)
                            {
                                lblResult.Text = "Wpis nie istnieje, albo podales zla sciezke";
                                
                            }
                            else
                            {
                                key.DeleteValue(txtbValName.Text);
                            }
                        }


                    }
                    break;
                case 2:
                    {
                        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(txtbSubKey.Text, true))
                        {
                            if (key == null)
                            {
                                lblResult.Text = "Wpis nie istnieje, albo podales zla sciezke";
                            }
                            else
                            {
                                key.DeleteValue(txtbValName.Text);
                            }
                        }

                    }
                    break;
                default:
                    break;
            }

        }
    }
}
