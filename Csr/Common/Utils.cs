using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using System.Security.Cryptography;

namespace Csr.Common
{
    public static class Utils
    {
        /// <summary>
        /// Data Protection 지정하기
        /// </summary>
        /// <param name="services"></param>
        /// <param name="keyPath">키경로</param>
        /// <param name="applicationName">어플리케이션 이름</param>
        /// <param name="cryptoType">암호화 방식</param>
        public static void SetDataProtection(IServiceCollection services, string keyPath, string applicationName, CryptoType cryptoType)
        {
            var builder = services.AddDataProtection()
                .PersistKeysToFileSystem(new DirectoryInfo(keyPath))
                .SetDefaultKeyLifetime(TimeSpan.FromDays(14))
                .SetApplicationName(applicationName);

            switch (cryptoType)
            {
                case CryptoType.Unmanaged:
                    //AES - Advanced Encryption Standard - Two-way : 암호화, 복호화
                    builder.UseCryptographicAlgorithms(
                            new AuthenticatedEncryptorConfiguration()
                            {
                                EncryptionAlgorithm = EncryptionAlgorithm.AES_256_CBC,
                                //SHA - One-way : 암호화
                                ValidationAlgorithm = ValidationAlgorithm.HMACSHA512 //256 -> 512
                            });
                    break;
                case CryptoType.Managed:
                    builder.UseCustomCryptographicAlgorithms(
                        new ManagedAuthenticatedEncryptorConfiguration()
                        {
                            // A type that subclasses SymmetricAlgorithm
                            EncryptionAlgorithmType = typeof(Aes),
                            // Specified in bits
                            EncryptionAlgorithmKeySize = 256,
                            // A type that subclasses KeyedHashAlgorithm
                            ValidationAlgorithmType = typeof(HMACSHA512) //256에서 512로
                        });
                    break;
                case CryptoType.CngCbc:
                    //Windows CNG algorithm using CBC-mode encryption
                    //Cryptography API : Next Generation
                    //C
#pragma warning disable CA1416 // 플랫폼 호환성 유효성 검사    - 윈도우에서만 사용가능 하다네
                    builder.UseCustomCryptographicAlgorithms(
                        new CngCbcAuthenticatedEncryptorConfiguration()
                        {
                            // Passed to BCryptOpenAlgorithmProvider
                            EncryptionAlgorithm = "AES",
                            EncryptionAlgorithmProvider = null,
                            // Specified in bits
                            EncryptionAlgorithmKeySize = 256,
                            // Passed to BCryptOpenAlgorithmProvider
                            HashAlgorithm = "SHA512",   //256 -> 512
                            HashAlgorithmProvider = null
                        });
#pragma warning restore CA1416 // 플랫폼 호환성 유효성 검사
                    break;
                case CryptoType.CngGcm:
                    // Windows CNG algorithm using Galois/Counter Mode encryption 
#pragma warning disable CA1416 // 플랫폼 호환성 유효성 검사
                    builder.UseCustomCryptographicAlgorithms(
                        new CngGcmAuthenticatedEncryptorConfiguration()
                        {
                            // Passed to BCryptOpenAlgorithmProvider
                            EncryptionAlgorithm = "AES",
                            EncryptionAlgorithmProvider = null,

                            // Specified in bits
                            EncryptionAlgorithmKeySize = 256
                        });
#pragma warning restore CA1416 // 플랫폼 호환성 유효성 검사
                    break;
                default:
                    break;
            }
        }
    }

    public enum CryptoType
    {
        Unmanaged = 1,
        Managed = 2,
        CngCbc = 3,
        CngGcm = 4
    }
}
