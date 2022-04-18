using ClassMetHodDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CostumerManager
    {
        public void Add(Costumer costumer)
        {
            Console.WriteLine(costumer.CostumerName+" "+costumer.CostumerSurname+" eklendi");
        }
        public void Delete(Costumer costumer)
        {
            Console.WriteLine(costumer.CostumerName+" "+costumer.CostumerSurname+" silindi");
        }
        public void ListCostumers(params Costumer[] costumers)
        {
            foreach (Costumer costumer in costumers)
            {
                Console.WriteLine(costumer.Id+" "+costumer.CostumerName+" "+costumer.CostumerSurname+" "+costumer.CostumerEmail);
            }
            Console.WriteLine("Müşteriler Listelendi");
        }
    }
}
