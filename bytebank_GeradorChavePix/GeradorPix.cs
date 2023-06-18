using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_GeradorChavePix
{
    /// <summary>
    /// Classe que gera chaves PIX usando o formato Guid.
    /// </summary>
    public static class GeradorPix
    {
        /// <summary>
        /// Método que retorna uma chave aleatória de PIX.
        /// </summary>
        /// <returns>Retorna uma chave PIX no formato string</returns>
        public static string GetChavePix()
        {
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Método que retorna uma lista aleatória de chaves PIX.
        /// </summary>
        /// <param name="numeroChaves"></param> Quantidade de chaves a serem geradas
        /// <returns>Retorna uma lista de strings de chaves Pix.</returns>

        public static List<string> GetChavesPix(int numeroChaves)
        {
            if(numeroChaves <= 0)
            {
                return null;
            }
            else
            {
                var chaves = new List<string>();
                for (int i = 0; i < numeroChaves; i++)
                {
                    chaves.Add(Guid.NewGuid().ToString());
                }

                return chaves;
            }
        }
    }
}
