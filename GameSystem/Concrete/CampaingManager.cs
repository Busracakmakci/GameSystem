using GameSystem.Abstract;
using GameSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSystem.Concrete
{
    public class CampaingManager : ICampaignService
    { 
            

        public void Add(Campaign campaign)
        {
                Console.WriteLine("Compaign added");
            
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Compaign deleted") ;
        }

        public void Update(Campaign campaign)
        {
        Console.WriteLine("Compaign Uptaded");
         }
    }

   
}
