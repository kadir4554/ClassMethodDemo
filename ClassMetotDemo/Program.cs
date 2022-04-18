using ClassMetHodDemo;
using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.Id = 1;
            costumer1.CostumerName = "Kadir";
            costumer1.CostumerSurname = "Eğriboyun";
            costumer1.CostumerEmail = "kadir@gmail.com";

            Costumer costumer2= new Costumer {Id=2,CostumerName="Engin",CostumerSurname="Demiroğ" ,CostumerEmail="engin@gmail.com"};

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Delete(costumer2);

            Costumer []costumers=new Costumer[] {costumer1,costumer2};
            costumerManager.ListCostumers(costumers);

        }
    }
}