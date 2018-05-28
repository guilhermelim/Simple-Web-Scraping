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
            String regularExpression = "<span itemprop=\"upvoteCount\" class=\"vote-count-post \">\\d+</span>"; // ENCONTRA NA STRING NÚMEROS DECIMAIS USANDO A EXPRESSÃO REGULAR: \d+ 
            String replaceClearFirst = "<span itemprop=\"upvoteCount\" class=\"vote-count-post \">"; // DEFINE O INÍCIO DO TEXTO PARA APAGAR
            String replaceClearSecond = "</span>"; // DEFINE O FINAL DO TEXTO PARA APAGAR

            // OBTENDO OS DADOS
            RegexTools regexTools = new RegexTools();
            regexTools.NewDocument(paginaWeb); // CARREGANDO O REGEXTOOLS COM O DOCUMENTO            
            String countVotes = regexTools.Run(regularExpression, replaceClearFirst, replaceClearSecond); // OBTEMOS A QUANTIDADE DE VOTOS.
            Console.WriteLine("Quantidade de votos: " + countVotes);
            Console.ReadKey();
        }
    }
}
