using System;
using System.Collections.Generic;
using System.Linq;
using LinqApp.Comparator;
using LinqApp.Generator;
using LinqApp.Model;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectionInt = GenerateInt(50);
            var collectionObj = GenerateObj(50);
            var collectionObj2 = GenerateObj(23);
            var mergedCollection = collectionObj.Concat(collectionObj2).ToList();
            
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

            // union unique
            var resA = collectionObj.Union(collectionObj2, new ObjComparator()).ToList();
            // except
            var resB = collectionObj.Except(collectionObj2, new ObjComparator()).ToList();
            // repeatable elements by name property
            var resD = mergedCollection.GroupBy(i => i.Name).SelectMany(grp => grp.Skip(1)).ToList();
            var resL = resD.Max(i => i.Count);
            
            Console.WriteLine("-- Debug --");
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