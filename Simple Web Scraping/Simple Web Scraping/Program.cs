using Simple_Web_Scraping.Tools;
using System;

namespace Simple_Web_Scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEB SCRAPING – COMO FAZER COLETA DE DADOS WEB?");
            // DEFINIÇÕES DE PESQUISA NO DOCUMENTO
            String paginaWeb = DownloadWebPageString.Run("https://pt.stackoverflow.com/questions/302606/");
            String regularExpression = "<span itemprop=\"upvoteCount\" class=\"vote-count-post \">\\d+</span>"; // // ENCONTRA NA STRING TEXTO USANDO A EXPRESSÃO REGULAR: \d+ 
            String replaceClearFirst = "<span itemprop=\"upvoteCount\" class=\"vote-count-post \">"; // APAGA O INÍCIO DO TEXTO
            String replaceClearSecond = "</span>";                    // APAGA O FINAL DO TEXTO

            // OBTENDO OS DADOS
            RegexTools regexTools = new RegexTools();
            regexTools.NewDocument(paginaWeb); // CARREGANDO O REGEXTOOLS COM O DOCUMENTO            
            String countVotes = regexTools.Run(regularExpression, replaceClearFirst, replaceClearSecond); // OBTEMOS A QUANTIDADE DE VOTOS.
            Console.WriteLine("Quantidade de votos: " + countVotes);
            Console.ReadKey();
        }
    }
}
