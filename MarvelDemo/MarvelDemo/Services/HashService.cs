using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using MarvelDemo.Core.Services;

namespace MarvelDemo.Services
{
    public class HashService : IHashService
    {
        public string CreateMd5Hash(string input)
        {
            var md5 = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
            var buffer = CryptographicBuffer.ConvertStringToBinary(input, BinaryStringEncoding.Utf8);
            var hashed = md5.HashData(buffer);
            var result = CryptographicBuffer.EncodeToHexString(hashed);

            return result;
        }
    }
}
