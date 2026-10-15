/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 14/10/2026
 * Time: 04:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace ProyectoBD
{
	/// <summary>
	/// Description of Encriptardor.
	/// </summary>
public class Encriptador
{
    // Nota: La llave debe ser de 32 bytes (256 bits) y el IV de 16 bytes. 
    // Se recomienda almacenarlas de forma segura en el archivo app.config o variables de entorno.
    private static readonly byte[] Key = Encoding.UTF8.GetBytes("01234567890123456789012345678901"); 
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("0123456789012345"); 

    public static string Cifrar(string textoPlano)
    {
        if (string.IsNullOrEmpty(textoPlano)) return textoPlano;
        byte[] encrypted;
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(textoPlano);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }
        return Convert.ToBase64String(encrypted);
    }

    public static string Descifrar(string textoCifrado)
    {
        if (string.IsNullOrEmpty(textoCifrado)) return textoCifrado;
        string textoPlano = null;
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            try
            {
                using (MemoryStream msDecrypt = new MemoryStream(FromBase64Safe(textoCifrado)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            textoPlano = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            catch
            {
                textoPlano = "[No descifrado / Error]";
            }
        }
        return textoPlano;
    }

    private static byte[] FromBase64Safe(string base64)
    {
        try { return Convert.FromBase64String(base64); }
        catch { return new byte[0]; }
    }
}
}