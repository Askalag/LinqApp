using System.Collections.Generic;
using LinqApp.Model;

namespace LinqApp.Generator
{
    public class ObjGenerator : IGenerator<Obj>
    {
        public List<Obj> Generate(int amount)
        {
            var resultList = new List<Obj>();
            for (var i = 0; i < amount; i++)
            {
                var obj = new Obj()
                {
                    Id = i,
                    Name = "It's me " + i,
                    Count = amount + i
                };
                resultList.Add(obj);
            }
            return resultList;
        }
    }
}