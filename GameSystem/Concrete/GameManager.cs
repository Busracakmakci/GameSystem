using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game) {

            Console.WriteLine("Game added") ;
        }

        public void Delete(Game game) { 
            Console.WriteLine("Game deleted");
        }

        public void Update(Game game) { 
            Console.WriteLine("Game updated") ;
        }

    }
}
