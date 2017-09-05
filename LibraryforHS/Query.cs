using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryforHS
{
    public static class Query
    {
        public static void Room()
        {

        }
        public static void AddAnimal ()
        {
            AddName();
            Categorize();
            Room("Intake");
            SetFood();
            Shots();
        }
        public static void Room (string status)
        {

        }
        public static void Categorize()
        {

        }
        public static void Adoption()
        {
            Room("Adopted");
            PopTheChampagne();
        }
        public static void SetFood()
        {

        }
        public static void PopTheChampagne()
        {
            Console.WriteLine("**********");
            Console.WriteLine("Congrats!");
            Console.WriteLine("**********");
        }
        public static void AddName()
        {

        }
        public static void Shots()
        {

        }
        public static void Shots(bool given)
        {

        }
    }
}
