//#define DEVELOPMENT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace FGP2
{
    class LicenseCheck
    {
        string license_key = "2604EB06EED64B767F2C19253C56726A";    // TODO change this to proper key

        /// <summary>
        /// Checks if the product is registered, and whether the product key is valid.
        /// </summary> 
        /// <remarks>
        /// Called at the beginning of the application launch, 
        /// And when registering product key
        /// </remarks>
        public bool isValidProductKey()
        {
#if DEVELOPMENT
            return true;
#else
            // Check if username or product key is entered
            if ((Properties.Settings.Default.User_Name.Length > 0) &&
                (Properties.Settings.Default.Product_Key.Length > 0))
            {

                // Generate combined key
                string combinedKey = license_key + Properties.Settings.Default.User_Name;

                // Encrypt it
                string encrypted = encryptCombinedKey(combinedKey);

                System.Diagnostics.Debug.WriteLine("User name: " + Properties.Settings.Default.User_Name);
                System.Diagnostics.Debug.WriteLine("Product key: " + Properties.Settings.Default.Product_Key);
                // Compare the encrypted combined key and the product key
                if (Properties.Settings.Default.Product_Key.Equals(encrypted))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
#endif
        }

        /// <summary>
        /// Encrypts the combined key to generate the product key
        /// </summary>
        /// <param name="key">
        /// Secret key and user name combined
        /// </param>
        /// <returns>
        /// First 16 characters of Encrypted string
        /// </returns>
        string encryptCombinedKey(string key)
        {
            //UnicodeEncoding UE = new UnicodeEncoding();
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] hashValue;
            byte[] message = encoding.GetBytes(key);
            SHA256Managed hashString = new SHA256Managed();

            hashValue = hashString.ComputeHash(message);

            string fullkey = ByteArrayToHexString(hashValue);
            return fullkey.Substring(0, 16);
        }

        // Function:    Converts the byte array to hex string
        // Input:       byte array
        // Output:      hexadecimal equivalent string
        // Notes:       none
        string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }

        // UNUSED function
        //byte[] HexStringToByteArray(string hex)
        //{
        //    int length = hex.Length;
        //    byte[] bytes = new byte[length / 2];
        //    for (int i = 0; i < length; i += 2)
        //    {
        //        bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        //    }
        //    return bytes;
        //}
    }
}
