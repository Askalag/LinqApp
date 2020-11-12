using System;
using System.Collections.Generic;
using System.Linq;
using LinqApp.Generator;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectionInt = GenerateInt(50);
            var collectionObj = GenerateObj(50);
            
            var resT = from i in collectionInt
                orderby i descending 
                where i < 30
                select i;
            
            var resM = collectionInt
                .Where(i => i < 20)
                .OrderBy(i => i);

            var resG = from obj in collectionObj
                orderby obj.Id, obj.Name
                where obj.Name.Contains("It's me 1")
                select obj;
            
            var resY = from obj in collectionObj
                where obj.Name.Contains("It's me 2")
                select obj.Name;

            var resF = from obj in collectionObj
                group obj by obj.Id;

            Console.WriteLine("--");
        }

        private static List<int> GenerateInt(int amount)
        {
            IGenerator<int> generator = new NumberGenerator();
            return generator.Generate(amount);
        }
        private static List<Obj> GenerateObj(int amount)
        {
            IGenerator<Obj> generator = new ObjGenerator();
            return generator.Generate(amount);
        }
    }
}