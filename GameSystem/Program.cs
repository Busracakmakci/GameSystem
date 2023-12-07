using GameSystem.Concrete;
using GameSystem.Entities;
using System.Data;

namespace GameSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaign campaign1 = new Campaign { CompaignId = "001", CompaignName = "Summer Compaign", DiscountAmount = 50, Description = "%33 free" };
            Campaign campaign2 = new Campaign { CompaignId = "002", CompaignName = "Winter Sale", DiscountAmount = 30, Description = "%25 indirimli" };
            Campaign campaign3 = new Campaign { CompaignId = "003", CompaignName = "New Year's Eve Special", DiscountAmount = 20, Description = "%15 indirimli" };



            Game game1 = new Game { Id = 9, Name = "Angry Bird", UnitPrice = 150, Campaign = campaign1 };
            Game game2 = new Game { Id = 8, Name = "Need For Speed", UnitPrice = 100, Campaign = campaign3 };
            Game game3 = new Game { Id = 7, Name = "Gta", UnitPrice = 150, Campaign = campaign1 };

            Gamer gamer1 = new Gamer { Id = 1, Name = "Busra", Surname = "cakmakci", BirthYear = 1995 };
            Gamer gamer2 = new Gamer
            {
                Id = 2,
                Name = "Kivanc",
                Surname = "Tatlitug",
                BirthYear = 1984,
                PurschasedGAme = game1
            };
            Gamer[] gamers = new Gamer[] { gamer1, gamer2 };

            foreach (Gamer gamer in gamers)
            {
                Console.WriteLine($"ID: {gamer.Id}, Name: {gamer.Name}, Surname: {gamer.Surname}, BirthYear: {gamer.BirthYear}");

                
                if (gamer.PurschasedGAme != null)
                {
                    Console.WriteLine($"Purchased Game - ID: {gamer.PurschasedGAme.Id}, " +
                        $"Name: {gamer.PurschasedGAme.Name}, Unit Price: {gamer.PurschasedGAme.UnitPrice}");
                }

                Console.WriteLine();
            }
            CampaingManager campaignManager = new CampaingManager();
            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);

            UpdateGamerInfo(gamer1, "Johnny", "Doerson", 1988);
            PurchaseGame(gamer2, game2);
        }
        // Kampanya indirimlerini güncelleme fonksiyonu
        static void UpdateCampaignDiscount(Campaign campaign, int newDiscount)
        {
            campaign.DiscountAmount = newDiscount;
            Console.WriteLine($"Campaign {campaign.CompaignName} discount updated to {newDiscount}%");
        }
        // Oyuncu bilgilerini güncelleme fonksiyonu 
        static void UpdateGamerInfo(Gamer gamer, string newName, string newSurname, int newBirthYear)
        {
            gamer.Name = newName;
            gamer.Surname = newSurname;
            gamer.BirthYear = newBirthYear;
            Console.WriteLine($"{gamer.Name}'s info updated: Name: {newName}, Surname: {newSurname}, Birth Year: {newBirthYear}");
        }
        // Oyuncunun yeni oyun satın alma fonksiyonu 
        static void PurchaseGame(Gamer gamer, Game game)
        {
            gamer.PurschasedGAme = game;
            Console.WriteLine($"{gamer.Name} purchased {game.Name} for {game.UnitPrice} units.");
        }

    }
}