using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DkppKVbaSmv
{
    class FoodType
    {
        public string name;
        public int protein, carbs, fat;
        static int counter = 0;

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter++;
        }

        public string toString()
        {
            string ispis = (this.name + ": p - " + this.protein + "%, c - " + this.carbs + "%, f - " + this.fat + "%.");
            return ispis;
        }

        static int getNumberOfInstances()
        {
            return counter;
        }
    }

    class Food
    {
        FoodType type;
        int weight;

        public Food(FoodType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public int Weight { get => weight; set => weight = value; }
        internal FoodType Type { get => type; set => type = value; }

        public string toString()
        {
            string ispis = (this.type.name + ": p - " + this.type.protein + "%, c - " + this.type.carbs + "%, f - " + this.type.fat + "%, w - " + this.weight + "g."); 
            return ispis;
        }

        public double Protein { get => type.protein; set => type.protein = (type.protein / 100 * this.weight); }
        public double Carbs { get => type.carbs; set => type.carbs = (type.carbs / 100 * this.weight); }
        public double Fat { get => type.fat; set => type.fat = (type.fat / 100 * this.weight); }

        public string toStringInGrams()
        {
            string ispis = (type.name + ": p - " + Math.Round(Convert.ToDecimal(type.protein), 1) + "g, c - " + Math.Round(Convert.ToDecimal(type.carbs), 1) + "g, f - " + Math.Round(Convert.ToDecimal(type.fat), 1) + "g, w - " + Math.Round(Convert.ToDecimal(this.weight), 1) + "g.");
            return ispis;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FoodType foodType = new FoodType("Banana", 4, 93, 3);
            Food food = new Food(foodType, 110);
            Console.WriteLine(food.toStringInGrams());
            Console.ReadKey();

        }
    }
}
