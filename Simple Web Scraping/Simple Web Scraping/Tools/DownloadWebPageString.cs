using System;
using System.Net;

namespace Simple_Web_Scraping.Tools
{
    class DownloadWebPageString
    {
        static public String Run(String _url)
        {
            try
            {
                WebClient webClient = new WebClient();
                return webClient.DownloadString(_url);
            }
            catch (Exception)
            {
                return "Não foi possivel baixar a pagina web.";
            }
        }

    }

}
