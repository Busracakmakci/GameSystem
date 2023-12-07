using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    public class SalesManager :ISalesService
    {
        public void SellGame(Gamer gamer, Game game) {
            Console.WriteLine($"{gamer.Name} {gamer.Surname} {game.Name} oyunu satın alindi. ");
        }
        public void SellGameWithGame(Gamer gamer, Game game, Campaign compaign)
        {
            decimal discountedPrice = game.UnitPrice - compaign.DiscountAmount;
            Console.WriteLine($"{gamer.Name}{gamer.Surname}{game.Name}{compaign.CompaignName} ile satin alindi");

        }
    }
}
