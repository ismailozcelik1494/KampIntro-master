using GameProject.Concrete;
using GameProject.Entity;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UyeKaydı();
            Console.WriteLine("------------------");
            KampanyaKaydı();
            Console.WriteLine("------------------");
            SatışYap();
        }

        private static void SatışYap()
        {
            User member = new User();
            member.Id = 2;
            member.FirstName = "Jerem";
            member.LastName = "YILDIZ";

            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Şok Şok Şok, Çok Ucuz";

            Game game = new Game();
            game.Id = 1;
            game.GameName = "Fifa 2020";
            game.Price = 15;
            game.Version = 5;

            OrderManager orderManager = new OrderManager();
            orderManager.Sell(member, campaign, game);
        }

        public static void KampanyaKaydı()
        {
            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Şok Ucuz Kampanya";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Update(campaign);
            campaignManager.Remove(campaign);
            campaignManager.Remove(campaign);
        }

        public static void UyeKaydı()
        {
            User user = new User();
            User user2 = new User();

            user.Id = 1;
            user.FirstName = "Mehmet";
            user.LastName = "EKİCİ";
            user.IdentityNumber = 123456789;
            user.BirthOfYear = "1980";
            user.Abc = "Salih";

            user2.Id = 2;
            user2.FirstName = "Veli";
            user2.LastName = "KAHRAMAN";
            user2.IdentityNumber = 123456789;
            user2.BirthOfYear = "2000";
            user2.Abc = "Veli";

            UserManager memberManager = new UserManager(new UserValidationManager());
            memberManager.Register(user);
            memberManager.Register(user2);
            memberManager.Update(user, user.Abc);
            memberManager.Remove(user);
        }
    }
}
