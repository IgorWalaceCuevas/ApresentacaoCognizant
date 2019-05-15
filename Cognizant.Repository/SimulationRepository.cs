using Cognizant.Domain.Entities.Partial;
using Cognizant.Domain.Interface.Repository;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cognizant.Repository
{
    public class SimulationRepository : RepositoryBase<Simulation>, ISimulationRepository
    {
    
        public async Task<decimal> GetDolarFromUOLAsync()
        {
            var url = "http://economia.uol.com.br/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();            
            htmlDocument.LoadHtml(html);

            var values = htmlDocument.DocumentNode.Descendants("a").Where(node => node.GetAttributeValue("class", "").Equals("subtituloGrafico subtituloGraficoValor")).ToList();

            return  Convert.ToDecimal(values.FirstOrDefault().InnerText.Replace("R$","").Trim());                        
        }
    }
}
