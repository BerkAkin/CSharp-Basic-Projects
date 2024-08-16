using System;
using System.Collections.Generic;

namespace VotingApp
{
    class VoteController
    {
        public void startVotingProcess()
        {
            Console.Write("Oylama İşlemi Başladı. Kategoriler: ");
            Console.WriteLine("HORROR, COMEDY, ROMANCE, DRAMA, ACTION, WESTERN");
            int voteStat = 1;
            while (voteStat > 0)
            {
                Console.WriteLine("Oy Veren Kişinin Adı?");
                string name = Console.ReadLine();

                UserController.Register(name);

                Console.WriteLine("Oy Verilecek Kategori?");
                string category = Console.ReadLine();

                ActionVote(category, name);

                Console.WriteLine("Oy verme işlemi devam edecek mi?");
                int islem = Convert.ToInt32(Console.ReadLine());
                if (islem > 0)
                {
                    continue;
                }
                else
                {
                    break;
                }

            }


        }
        public void ActionVote(string vote, string voter)
        {
            if (vote == null && voter == null)
            {
                Console.WriteLine("Hata: Oy veren Ya da Oy Boş");
                return;
            }
            else
            {
                Categories.VoteToCategory(vote);
                Console.WriteLine("Oylama Tamamlandı. Oranları görmek için 1'e basınız");
                short secim = Convert.ToInt16(Console.ReadLine());
                if (secim == 1)
                {
                    this.ActionShowPercentages();
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim");
                }
            }
        }

        public void ActionShowPercentages()
        {
            Categories.Percentages();
        }
    }
}