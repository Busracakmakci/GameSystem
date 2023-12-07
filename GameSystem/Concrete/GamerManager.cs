using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer game)
        {
            Console.WriteLine("Game mygame added ") ;
        }

        public void Delete(Gamer game)
        {
            Console.WriteLine("Game mygame deleted ");
        }

      
    }
}
