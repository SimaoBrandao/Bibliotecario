using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CamadaNegocio
{
    public class ClienteSMTP
    {
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("1234567890123456"); // Substitua por uma chave de 16/24/32 caracteres
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("1234567890123456"); // Substitua por 16 caracteres

        public static string CarregarDadosClienteSMTP(string nomeArquivo)
        {
            string caminhoCompleto = ObterCaminhoArquivo(nomeArquivo);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (FileStream fs = new FileStream(caminhoCompleto, FileMode.Open, FileAccess.Read))
                using (CryptoStream cs = new CryptoStream(fs, aes.CreateDecryptor(), CryptoStreamMode.Read))
                using (StreamReader reader = new StreamReader(cs))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        private static string ObterCaminhoArquivo(string nomeArquivo)
        {
            // Obtém o diretório da aplicação onde as DLLs estão localizadas
            string diretorioBase = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(diretorioBase, nomeArquivo);
        }

    }
}
