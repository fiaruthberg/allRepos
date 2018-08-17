using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2_Work_with_list_of_Costumers
{
    class Costumer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }


    }

    class Parser
    {
        internal List<Costumer> CreateListOfCostumers(string v)
        {
            List<Costumer> list = new List<Costumer>();
            var allLines = File.ReadAllLines(v);
            
            foreach (var line in allLines.Skip(1))
            {
                var splittedLine = line.Split(',');
                var id = splittedLine[0];
                var firstName = splittedLine[1];
                var lastName = splittedLine[2];
                var email = splittedLine[3];
                var gender = splittedLine[4];
                var age = splittedLine[5];
                
                var costumer = new Costumer();
                costumer.Id = id;
                costumer.FirstName = firstName;
                costumer.LastName = lastName;
                costumer.Email = email;
                costumer.Gender = gender;
                costumer.Age = int.Parse(age);


                list.Add(costumer);


            }
                return list;
        }
    }
}
