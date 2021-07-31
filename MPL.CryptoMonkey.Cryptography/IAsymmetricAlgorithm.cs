using System;

namespace MPL.CryptoMonkey.Cryptography
{
    /// <summary>
    /// An interface that defines an asymmetric algorithm.
    /// </summary>
    public interface IAsymmetricAlgorithm
    {
        #region Methods
        /// <summary>
        /// Decrypt the specified encrypted data using the specified encrypted private key.
        /// </summary>
        /// <param name="privateKey">An array of byte containing the private key.</param>
        /// <param name="encryptedData">An array of byte containing the data to decrypt.</param>
        /// <param name="data">An array of byte that will be set to the decrypted data.</param>
        /// <returns>A bool indicating success.</returns>
        bool DecryptData(byte[] privateKey, byte[] encryptedData, out byte[] data);
        
        /// <summary>
        /// Encrypts the specified data using the specified public key.
        /// </summary>
        /// <param name="publicKey">An array out byte containing the public key.</param>
        /// <param name="data">An array of byte containing the data to encrypt.</param>
        /// <param name="encryptedData">An array of byte that will be set to the encrypted data.</param>
        /// <returns>A bool indicating success.</returns>
        bool EncryptData(byte[] publicKey, byte[] data, out byte[] encryptedData);

        /// <summary>
        /// Generates a new private\public keypair for the asymmetric algorith,
        /// </summary>
        /// <param name="privateKey">An array of byte that will be set to the private key.</param>
        /// <param name="publicKey">An array of byte that will be set to the public key.</param>
        /// <returns>A bool indicating success.</returns>
        bool GenerateKeyPair(out byte[] privateKey, out byte[] publicKey);

        #endregion

        #region Properties
        /// <summary>
        /// Gets the identifier of the asymmetric algorithm.
        /// </summary>
        int AlgorithmID { get; }

        #endregion
    }
}