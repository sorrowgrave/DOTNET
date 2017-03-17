using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using RSAExtensions;
using System.Threading;
using System.ComponentModel;

namespace AESExtensions
{
    public partial class AESEncryption
    {
        public static void AES_Encrypt(string fileName, string targetName, byte[] passwordBytes, BackgroundWorker worker)
        {
            int chunkSize = 128;
            int highestPercentageReached = 0;

            // Set your salt here, change it to meet your flavor:

            byte[] saltBytes = passwordBytes;

            // Example:
            saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

            //Open input and output streams
            using (FileStream fsOutput = File.OpenWrite(targetName))
            {
                using (FileStream fsInput = File.OpenRead(fileName))
                {

                    using (RijndaelManaged AES = new RijndaelManaged())
                    {
                        AES.KeySize = 256;
                        AES.BlockSize = 128;

                        AES.Key = key.GetBytes(AES.KeySize / 8);
                        AES.IV = key.GetBytes(AES.BlockSize / 8);

                        AES.Mode = CipherMode.CBC;

                        fsOutput.Write(BitConverter.GetBytes(fsInput.Length), 0, 8);
                        fsOutput.Write(AES.IV, 0, 16);

                            using (CryptoStream cs = new CryptoStream(fsOutput, AES.CreateEncryptor(), CryptoStreamMode.Write))
                            {

                                for (long i = 0; i < fsInput.Length; i += chunkSize)
                                {
                                    byte[] chunkData = new byte[chunkSize];
                                    int bytesRead = 0;
                                    while ((bytesRead = fsInput.Read(chunkData, 0, chunkSize)) > 0)
                                    {
                                        cs.Write(chunkData, 0, bytesRead);
                                    }

                                    int percentComplete = (int)((double) i / (double) fsInput.Length * 100);

                                    if (percentComplete > highestPercentageReached)
                                    {
                                        highestPercentageReached = percentComplete;
                                        worker.ReportProgress(percentComplete);
                                    }

                                }
                                cs.FlushFinalBlock();
                            }            

                    }
                }            
            }
        }



        public static void AES_Decrypt(string fileName, string targetName, byte[] passwordBytes, BackgroundWorker worker)
        {
            int highestPercentageReached = 0;
            int chunkSize = 128;
            // Set your salt here to meet your flavor:
            byte[] saltBytes = passwordBytes;
            // Example:
            saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (FileStream fsInput = File.OpenRead(fileName))
            {
                using (FileStream fsOutput = File.OpenWrite(targetName))
                {
                    byte[] buffer = new byte[8];
                    fsInput.Read(buffer, 0, 8);

                    long fileLength = BitConverter.ToInt64(buffer, 0);



                    using (RijndaelManaged AES = new RijndaelManaged())
                    {
                        AES.KeySize = 256;
                        AES.BlockSize = 128;

                        var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);

                        AES.Key = key.GetBytes(AES.KeySize / 8);
                        AES.IV = key.GetBytes(AES.BlockSize / 8);

                        AES.Mode = CipherMode.CBC;

                        byte[] IVBytes = new byte[16];
                        fsInput.Read(IVBytes, 0, 16);


                        using (CryptoStream cs = new CryptoStream(fsOutput, AES.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            for (long i = 0; i < fsInput.Length; i += chunkSize)
                            {
                                byte[] chunkData = new byte[chunkSize];
                                int bytesRead = 0;
                                while ((bytesRead = fsInput.Read(chunkData, 0, chunkSize)) > 0)
                                {
                                    cs.Write(chunkData, 0, bytesRead);
                                }

                                int percentComplete = (int)((double)i / (double)fsInput.Length * 100);

                                if (percentComplete > highestPercentageReached)
                                {
                                    highestPercentageReached = percentComplete;
                                    worker.ReportProgress(percentComplete);
                                }
                            }
                        }

                    }
                }

            }
        }



        //public void EncryptFile()
        //{
        //    string file = "C:\\SampleFile.DLL";
        //    string password = "abcd1234";

        //    byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
        //    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

        //    // Hash the password with SHA256
        //    passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        //    byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

        //    string fileEncrypted = "C:\\SampleFileEncrypted.DLL";

        //    File.WriteAllBytes(fileEncrypted, bytesEncrypted);
        //}
        //public void DecryptFile()
        //{
        //    string fileEncrypted = "C:\\SampleFileEncrypted.DLL";
        //    string password = "abcd1234";

        //    byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
        //    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        //    passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        //    byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

        //    string file = "C:\\SampleFile.DLL";
        //    File.WriteAllBytes(file, bytesDecrypted);
        //}

        //public static string Encrypt(string text, byte[] passwordBytes)
        //{
        //    byte[] originalBytes = Encoding.UTF8.GetBytes(text);
        //    byte[] encryptedBytes = null;

        //    // Hash the password with SHA256
        //    passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        //    // Getting the salt size
        //    int saltSize = GetSaltSize(passwordBytes);
        //    // Generating salt bytes
        //    byte[] saltBytes = GetRandomBytes(saltSize);

        //    // Appending salt bytes to original bytes
        //    byte[] bytesToBeEncrypted = new byte[saltBytes.Length + originalBytes.Length];
        //    for (int i = 0; i < saltBytes.Length; i++)
        //    {
        //        bytesToBeEncrypted[i] = saltBytes[i];
        //    }
        //    for (int i = 0; i < originalBytes.Length; i++)
        //    {
        //        bytesToBeEncrypted[i + saltBytes.Length] = originalBytes[i];
        //    }

        //    //encryptedBytes = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

        //    return Convert.ToBase64String(encryptedBytes);
        //}

        //public static string Decrypt(string decryptedText, byte[] passwordBytes)
        //{
        //    byte[] bytesToBeDecrypted = Convert.FromBase64String(decryptedText);

        //    // Hash the password with SHA256
        //    passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        //    byte[] decryptedBytes = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

        //    // Getting the size of salt
        //    int saltSize = GetSaltSize(passwordBytes);

        //    // Removing salt bytes, retrieving original bytes
        //    byte[] originalBytes = new byte[decryptedBytes.Length - saltSize];
        //    for (int i = saltSize; i < decryptedBytes.Length; i++)
        //    {
        //        originalBytes[i - saltSize] = decryptedBytes[i];
        //    }

        //    return Encoding.UTF8.GetString(originalBytes);
        //}

        public static int GetSaltSize(byte[] passwordBytes)
        {
            var key = new Rfc2898DeriveBytes(passwordBytes, passwordBytes, 1000);
            byte[] ba = key.GetBytes(2);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ba.Length; i++)
            {
                sb.Append(Convert.ToInt32(ba[i]).ToString());
            }
            int saltSize = 0;
            string s = sb.ToString();
            foreach (char c in s)
            {
                int intc = Convert.ToInt32(c.ToString());
                saltSize = saltSize + intc;
            }

            return saltSize;
        }

        public static byte[] GetRandomBytes(int length)
        {
            byte[] ba = new byte[length];
            RNGCryptoServiceProvider.Create().GetBytes(ba);
            return ba;
        }
    }
}
