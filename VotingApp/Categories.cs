using System;
using System.Collections.Generic;
using System.Linq;

namespace VotingApp
{
    static class Categories
    {
        private static int totalVotes = 0;
        private static List<Category> categories = new List<Category> {
            new Category("HORROR", 0,0),
            new Category("COMEDY", 0,0),
            new Category("ROMANCE", 0,0),
            new Category("DRAMA", 0,0),
            new Category("ACTION", 0,0),
            new Category("WESTERN", 0,0),
        };
        public static List<Category> CategoryList { get => categories; }

        public static void VoteToCategory(string cat)
        {
            string cate = cat.ToUpper();
            var category = categories.FirstOrDefault(c => c.Name == cate);
            if (category != null)
            {
                category.VoteCount++;
                totalVotes++;

                foreach (var catg in categories)
                {
                    catg.Percent = totalVotes > 0 ? (double)catg.VoteCount / totalVotes * 100 : 0.0;
                }
            }
        }

        public static void Percentages()
        {
            Console.WriteLine("----------Oy Oranları----------");
            foreach (Category category in categories)
            {
                Console.WriteLine(category.Name + ": " + category.Percent);
            }
        }
    }
}