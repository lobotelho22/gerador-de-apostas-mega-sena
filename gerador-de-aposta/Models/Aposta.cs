using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gerador_de_aposta.Models
{
    public class Aposta
    {
        private readonly int[] maisSorteados = [2, 4, 10, 11, 17, 18, 22, 32, 35, 37, 38, 40, 41, 42, 46, 51, 56, 57];

        private int[] dezenas = new int[60];

        List<int> listaMaisSorteados = new List<int>();

        private void PopulateLista()
        {
            foreach (var item in maisSorteados)
            {
                listaMaisSorteados.Add(item);
            }
        }

        public string MaisSorteados()
        {
            Console.WriteLine("");
            string msgReturn = $"Essas foram as dezenas mais sorteadas ao longo da história da Mega-Sena: {string.Join(", ", maisSorteados)}";
            return msgReturn;
        }

        public string ApostaEntreOsMais()
        {
            int[] aposta = new int[6];
            Random rnd = new Random();
            PopulateLista();

            int i = 0;
            
            while (aposta.Contains(0))
            {
                int limit = maisSorteados.Length - 1;
                int index = rnd.Next(0, limit);
                int num = listaMaisSorteados[index];

                if (!aposta.Contains(num))
                {
                    aposta[i] = num;
                    i += 1;
                }
            }

            Array.Sort(aposta);
            return $"Sua aposta: {string.Join(", ", aposta)}";
        }
    }
}