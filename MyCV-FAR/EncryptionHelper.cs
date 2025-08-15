using System;
using System.Security.Cryptography;
using System.Text;

namespace MyCVToolkit
{
    public class EncryptionHelper
    {
        // Encrypt a string to Base64 using Windows DPAPI
        public static string EncryptString(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
                return string.Empty;

            byte[] data = Encoding.UTF8.GetBytes(plainText);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encrypted);
        }

        // Decrypt a Base64 string using Windows DPAPI
        public static string DecryptString(string encryptedText)
        {
            if (string.IsNullOrEmpty(encryptedText))
                return string.Empty;

        try
        {
            byte[] data = Convert.FromBase64String(encryptedText);
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decrypted);
        }
        catch
        {
            // If it's not valid Base64 or can't decrypt, return blank
            return string.Empty;
        }
        }
    }
}
