using ConsoleApp4.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Concrete
{
    class GameManager : IGameService
    {
        public void Sell(Customer customer, Game game)
        {
            Console.WriteLine(game.GameName + " was purchased by " + customer.Name);
        }
    }
}
