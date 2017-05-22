using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace FakapManager
{
    public class ReadWrite
    {
        public static string ShowValue(string key, string valname)
        {
            return Registry.GetValue(key, valname, "NotFound").ToString();
            
            
        }

        public static void ChangeValue(string key, string valname, string val)
        {
            Registry.SetValue(key, valname, val);
        }

        public static void DeleteValue(string SubKeyName, string valname)
        {

           
            var o = Convert.ToInt32(Console.ReadLine());
            switch (o)
            {
                case 1:
                    {
                        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(SubKeyName, true))
                        {
                            if (key == null)
                            {
                                
                                Console.WriteLine("Wpis nie istnieje, albo podales zla sciezke (ma byc bez HKEY...)");
                            }
                            else
                            {
                                key.DeleteValue(valname);
                            }
                        }


                    }
                    break;
                case 2:
                    {
                        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(SubKeyName, true))
                        {
                            if (key == null)
                            {
                                Console.WriteLine("Wpis nie istnieje, albo podales zla sciezke (ma byc bez HKEY...)");
                            }
                            else
                            {
                                key.DeleteValue(valname);
                            }
                        }

                    }
                    break;
                default:
                    break;
            }


        }

        public static void DeleteSubKeyTree(string SubKeyName, string subkey)
        {
            Console.WriteLine("1-Current User, 2- Local machine");
            var o = Convert.ToInt32(Console.ReadLine());
            switch (o)
            {
                case 1:
                    {
                        using (RegistryKey key = Registry.CurrentUser.OpenSubKey(SubKeyName, true))
                        {
                            if (key == null)
                            {
                                Console.WriteLine("Wpis nie istnieje");
                            }
                            else
                            {
                                key.DeleteSubKeyTree(subkey);

                            }
                        }


                    }
                    break;
                case 2:
                    {
                        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(SubKeyName, true))
                        {
                            if (key == null)
                            {
                                Console.WriteLine("Wpis nie istnieje");
                            }
                            else
                            {
                                key.DeleteSubKeyTree(SubKeyName);
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