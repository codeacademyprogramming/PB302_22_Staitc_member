using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Product
    {
        private string _name;
        public double Price;
        public static double TotalIncome;
        public string[] Ingredients = new string[0];

        public Product()
        {
            TotalIncome = 0;
            Ingredients =new string[]{ "Su"};
        }

        static Product()
        {
            TotalIncome = 100;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (CheckName(value))
                {
                    _name= value;
                }
            }
        }

        public void Sell()
        {
            TotalIncome += Price;
        }

        public static bool CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;

            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i])) return false;
            }

            return true;
        }
        public void AddIngredient(string name)
        {
            Array.Resize(ref this.Ingredients, Ingredients.Length+1);
            Ingredients[Ingredients.Length-1] = name;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {this.Name} - Price: {Price}");
        }
    }
}
