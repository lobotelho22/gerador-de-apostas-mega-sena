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

        List<int> listaDezenas = new List<int>();

        private void PopulateLista(int[] listaMatriz)
        {
            foreach (var item in listaMatriz)
            {
                listaDezenas.Add(item);
            }
        }

        private void PopulateDezenas()
        {
            for (var item = 0; item < dezenas.Length; item += 1)
            {
                dezenas[item] = item + 1;
            }
        }

        public string MaisSorteados()
        {
            Console.WriteLine("");
            string msgReturn = $"Essas foram as dezenas mais sorteadas ao longo da história da Mega-Sena: {string.Join(", ", maisSorteados)}";
            return msgReturn;
        }

        public string CriarApostaMaisSorteados()
        {
            int[] aposta = new int[6];
            Random rnd = new Random();
            PopulateLista(maisSorteados);

            int i = 0;
            
            while (aposta.Contains(0))
            {
                int limit = maisSorteados.Length - 1;
                int index = rnd.Next(0, limit);
                int num = listaDezenas[index];

                if (!aposta.Contains(num))
                {
                    aposta[i] = num;
                    i += 1;
                }
            }

            Array.Sort(aposta);
            return $"Sua aposta: {string.Join(", ", aposta)}";
        }

         public string CriarAposta()
        {
            int[] aposta = new int[6];
            Random rnd = new Random();
            PopulateDezenas();
            PopulateLista(dezenas);

            int i = 0;
            
            while (aposta.Contains(0))
            {
                int limit = dezenas.Length - 1;
                int index = rnd.Next(0, limit);
                int num = listaDezenas[index];

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