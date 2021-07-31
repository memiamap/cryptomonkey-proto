using System;
using System.Security.Cryptography;

namespace MPL.CryptoMonkey.Cryptography.Core
{
    /// <summary>
    /// A class that defines an implementation of the RSA asymmetric algorithm.
    /// </summary>
    public class RsaAsymmetricAlgorithm : IAsymmetricAlgorithm
    {
        #region Interfaces
        #region _IAsymmetricAlgorithm_
        #region __Methods__
        bool IAsymmetricAlgorithm.DecryptData(byte[] privateKey, byte[] encryptedData, out byte[] data)
        {
            bool returnValue = false;

            // Defaults
            data = default;

            try
            {
                using RSACryptoServiceProvider rsa = new();
                rsa.ImportRSAPrivateKey(privateKey, out _);
                data = rsa.Decrypt(encryptedData, RSAEncryptionPadding.OaepSHA256);
                returnValue = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return returnValue;
        }

        bool IAsymmetricAlgorithm.EncryptData(byte[] publicKey, byte[] data, out byte[] encryptedData)
        {
            bool returnValue = false;

            // Defaults
            encryptedData = default;

            try
            {
                using RSACryptoServiceProvider rsa = new();
                rsa.ImportRSAPublicKey(publicKey, out _);
                encryptedData = rsa.Encrypt(data, RSAEncryptionPadding.OaepSHA256);
                returnValue = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return returnValue;
        }

        bool IAsymmetricAlgorithm.GenerateKeyPair(out byte[] privateKey, out byte[] publicKey)
        {
            bool returnValue = false;

            // Defaults
            privateKey = default;
            publicKey = default;

            try
            {
                using RSACryptoServiceProvider rsa = new();
                privateKey = rsa.ExportRSAPrivateKey();
                publicKey = rsa.ExportRSAPublicKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return returnValue;
        }

        #endregion
        #region __Properties__
        int IAsymmetricAlgorithm.AlgorithmID => 1;

        #endregion
        #endregion
        #endregion
    }
}