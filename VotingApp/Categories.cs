using System;
using System.Collections.Generic;

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
            foreach (Category category in categories)
            {
                if (category.Name == cat)
                {
                    category.VoteCount++;
                    totalVotes++;
                    category.Percent = (category.VoteCount / totalVotes) * 100;
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