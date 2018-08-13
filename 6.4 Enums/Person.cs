using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4_Enums
{
    enum Sport
    {
        Tennis, Rugby, Soccer, Hurling, Squash
    }
    enum Gender
    {
        Female, Male, Other
    }
    class Person
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public Sport FavoriteSport { get; set; }

        internal string LikeRugby()
        {
            if (FavoriteSport == Sport.Rugby)
            {
                string likeRugby = $"{FirstName} likes to play rugby!";
                return likeRugby;
            } else
            {

                string dontLikeRugby = $"{FirstName} doesn't like to play rugby!";
                return dontLikeRugby;
            }
        }
        internal void WriteInfo()
        {
           
            Console.WriteLine($"{FirstName} is {Gender}" +
                              $"\n{FirstName} like to play {FavoriteSport}" +
                              $"\n{FirstName} ");
        }
        private static void GetName()
        {
            foreach (string sport in Enum.GetNames(typeof(Sport)))
            {
                Console.WriteLine($"{sport}");
            }


        }


    }
    
}
