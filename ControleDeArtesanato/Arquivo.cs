using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControleDeArtesanato
{
    internal class Arquivo
    {
        public string Nome { get; }
        public string[] Parametros;
        public string Diretorio;
        public Arquivo(string nome) {
            Nome = nome;
            Diretorio = @".\ControleArtesanato\" + nome + ".txt";
            CriarArquivo(Diretorio);
        }
        private void CriarArquivo(string caminhoDoArquivo)
        {
            //O arquivo não é criado se já houver
            if (!File.Exists(caminhoDoArquivo))
            {
                using (StreamWriter sw = File.CreateText(caminhoDoArquivo))
                {
                    sw.WriteLine();
                }
            }
        }
        public void AddLinha(string text)
        {
                var linhas = File.ReadAllLines(Diretorio).ToList(); //Cria uma lista com as linhas do arquivo
                linhas.Insert(0, text); // Adiciona o texto no inicio da lista
                // Escreve as linhas restantes de volta para o arquivo
                File.WriteAllLines(Diretorio, linhas);
            
        }
        public void RemoveLinha(string text)
        {
            // Lê todas as linhas do arquivo
            var linhas = File.ReadAllLines(Diretorio).ToList();

            // Remove a linha desejada
            linhas.Remove(text);

            // Escreve as linhas restantes de volta para o arquivo
            File.WriteAllLines(Diretorio, linhas);
        }
        public string GetLinha()
        {
            return File.ReadAllText(Diretorio); //Retorna todo o texto do arquivo
        }
    }
}
