using System;
using ConsoleApp4.Adapters;
using ConsoleApp4.Concrete;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() 
            { 
                Name="Resul",
                Surname="Ozdemir",
            };

            Game game = new Game()
            {
                GameName = "GTA 5",
                Author = "Rockstar Games",
                Price = 20,
            };

            Campaign campaign = new Campaign()
            {
                GameName = "GTA 5",
                Discount = 10,
            };

            CustomerMenager customerMenager = new CustomerMenager(new MernisServiceAdapter());

            customerMenager.Add(customer);
            customerMenager.Update(customer);
            //customerMenager.Delete(customer);

            Console.WriteLine("----------------------");

            GameManager gameManager = new GameManager();
            gameManager.Sell(customer, game);

            Console.WriteLine("----------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(game, campaign);
            campaignManager.Update(game, campaign);
            campaignManager.Delete(game, campaign);


        }
    }
}
