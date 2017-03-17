using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Numerics;

namespace RSAExtensions
{
    public static class RSAEncryption
    {

        //public static byte[] PublicEncryption(this RSACryptoServiceProvider rsa, byte[] data)
        //{
        //    //if (!IsPublicKeyLoaded)  // is the public key has been loaded?
        //    //    throw new CryptographicException
        //    //        ("Public Key must be loaded before using the Public Encryption method!");


        //    // Converting the byte array data into a BigInteger instance

        //    int maxDataLength = (rsa.KeySize / 8) - 6;
        //    if (data.Length > maxDataLength)
        //        throw new ArgumentOutOfRangeException("data", string.Format(
        //            "Maximum data length for the current key size ({0} bits) is {1} bytes (current length: {2} bytes)",
        //            rsa.KeySize, maxDataLength, data.Length));

        //    BigInteger bnData = GetBig(AddPadding(data));

        //    RSAParameters rsaParams = rsa.ExportParameters(false);
        //    BigInteger Modulus = GetBig(rsaParams.Modulus);
        //    BigInteger Exponent = GetBig(rsaParams.Exponent);


        //    // (bnData ^ Exponent) % Modulus - This Encrypt the data using the public Exponent
        //    BigInteger encData = BigInteger.ModPow(bnData, Exponent, Modulus);
        //    return encData.ToByteArray();

        //}
            public static byte[] PrivateEncryption(this RSACryptoServiceProvider rsa, byte[] data)
            {
                if (data == null)
                    throw new ArgumentNullException("data");
                if (rsa.PublicOnly)
                    throw new InvalidOperationException("Private key is not loaded");

                int maxDataLength = (rsa.KeySize / 8) - 6;
                if (data.Length > maxDataLength)
                    throw new ArgumentOutOfRangeException("data", string.Format(
                        "Maximum data length for the current key size ({0} bits) is {1} bytes (current length: {2} bytes)",
                        rsa.KeySize, maxDataLength, data.Length));

                // Add 4 byte padding to the data, and convert to BigInteger struct
                BigInteger numData = GetBig(AddPadding(data));

                RSAParameters rsaParams = rsa.ExportParameters(true);
                BigInteger D = GetBig(rsaParams.D);
                BigInteger Modulus = GetBig(rsaParams.Modulus);
                BigInteger encData = BigInteger.ModPow(numData, D, Modulus);

                return encData.ToByteArray();
            }

            public static byte[] PublicDecryption(this RSACryptoServiceProvider rsa, byte[] cipherData)
            {
                if (cipherData == null)
                    throw new ArgumentNullException("cipherData");

                BigInteger numEncData = new BigInteger(cipherData);

                RSAParameters rsaParams = rsa.ExportParameters(false);
                BigInteger Exponent = GetBig(rsaParams.Exponent);
                BigInteger Modulus = GetBig(rsaParams.Modulus);

                BigInteger decData = BigInteger.ModPow(numEncData, Exponent, Modulus);

                byte[] data = decData.ToByteArray();
                byte[] result = new byte[data.Length - 1];
                Array.Copy(data, result, result.Length);
                result = RemovePadding(result);

                Array.Reverse(result);
                return result;
            }

            private static BigInteger GetBig(byte[] data)
            {
                byte[] inArr = (byte[])data.Clone();
                Array.Reverse(inArr);  // Reverse the byte order
                byte[] final = new byte[inArr.Length + 1];  // Add an empty byte at the end, to simulate unsigned BigInteger (no negatives!)
                Array.Copy(inArr, final, inArr.Length);

                return new BigInteger(final);
            }

            // Add 4 byte random padding, first bit *Always On*
            private static byte[] AddPadding(byte[] data)
            {
                Random rnd = new Random();
                byte[] paddings = new byte[4];
                rnd.NextBytes(paddings);
                paddings[0] = (byte)(paddings[0] | 128);

                byte[] results = new byte[data.Length + 4];

                Array.Copy(paddings, results, 4);
                Array.Copy(data, 0, results, 4, data.Length);
                return results;
            }

            private static byte[] RemovePadding(byte[] data)
            {
                byte[] results = new byte[data.Length - 4];
                Array.Copy(data, results, results.Length);
                return results;
            }


        }
    
}
