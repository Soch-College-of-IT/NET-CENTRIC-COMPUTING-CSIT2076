using System;
using System.Linq;

namespace Programs{
    internal class LINQDemo{
        static void Main(string[] args){
            string[] fruits = {"apple", "mango", "orange", "passionfruit", "grape"};
            var query = from fruit in fruits
                where fruit.Length > 5
                select fruit;
            foreach (var fruit in query){
                Console.WriteLine(fruit);
            }
        }
    }
}