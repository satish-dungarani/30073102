using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PasswordManagerSystem.Helpers
{
    public static class FormHelper
    {
        public static void ClearForm(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox box)
                {
                    box.Clear();
                }
            }
        }

        public static void MinimizeForm(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public static void CloseForm(Form form)
        {
            //form.Close();
            Application.Exit();
        }

        public enum ApplicationType
        {
            Website = 1,
            Software = 2,
            Game = 3
        }


        static readonly string security_key = "studentssouthwales";

        public static string EncryptData(string data)
        {
            var key = GetHashedKey(security_key).Substring(0, 32);
            var secret_iv = GenerateRandomBytes(16);
            var encryptionIV = GetHashedKey(secret_iv).Substring(0, 16);

            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(encryptionIV);
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedData;

                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] dataBytes = Encoding.UTF8.GetBytes(data);
                        csEncrypt.Write(dataBytes, 0, dataBytes.Length);
                        csEncrypt.FlushFinalBlock();
                        encryptedData = msEncrypt.ToArray();
                    }
                }

                string base64EncryptedData = Convert.ToBase64String(encryptedData);
                string encryptedString = base64EncryptedData + "." + encryptionIV;
                return Uri.EscapeDataString(encryptedString);
            }
        }

        public static string DecryptData(string encryptedString)
        {
            string decryptedData = "";
            encryptedString = Uri.UnescapeDataString(encryptedString);
            string[] parts = encryptedString.Split('.');

            var key = GetHashedKey(security_key).Substring(0, 32);
            var encryptionIV = parts[1];

            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(encryptionIV);
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                byte[] encryptedData = Convert.FromBase64String(parts[0]);

                using (var msDecrypt = new System.IO.MemoryStream(encryptedData))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            decryptedData = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decryptedData;
        }

        private static string GetHashedKey(string input)
        {
            using (var sha512 = SHA512.Create())
            {
                byte[] hashBytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in hashBytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        private static string GenerateRandomBytes(int length)
        {
            byte[] randomBytes = new byte[length];
            using (var rngCryptoSP = new RNGCryptoServiceProvider())
                rngCryptoSP.GetBytes(randomBytes);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in randomBytes)
                sb.Append(b.ToString("x2"));

            return sb.ToString();
        }
    }
}
