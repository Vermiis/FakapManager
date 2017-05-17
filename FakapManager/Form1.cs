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
            string key = @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Next!\Kronos NET\General";

            if (KronosDBName.TextLength != 0 && KronosPath1.TextLength != 0 && KronosPath2.TextLength != 0)
            {
                Registry.SetValue(key, "DataBaseName", KronosDBName.Text);
                Registry.SetValue(key, "Path", KronosPath1.Text);
                Registry.SetValue(key, "PathData", KronosPath2.Text);
            }
            else
                lblKronosErr.Text = "Niepoprawne wpisy";
           
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.SetValue(txtBoxKey.Text, txtbValueName.Text, txtValueUpdate.Text);
            }
            catch (Exception ext)
            {

                throw;
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var x = cmbRoots.SelectedIndex;
            switch (x)
            {
                case 0:
                    {
                        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(txtbSubKey.Text, true))
                        {
                            if (key == null)
                            {
                                lblResult.Text = "Wpis nie istnieje, albo podales zla sciezke";

                            }
                            else
                            {
                                try
                                {
                                    key.DeleteValue(txtbValName.Text);
                                }
                                catch (Exception exc)
                                {

                                    lblResult.Text=exc.Message;
                                }
                                
                            }
                        }


                    }
                    break;
                case 1:
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
