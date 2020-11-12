using System;
using System.Collections.Generic;

namespace LinqApp.Generator
{
    public class NumberGenerator : IGenerator<int>
    {
        private readonly Random _random = new Random();
        
        public List<int> Generate(int amount)
        {
            var result = new List<int>();
            for (var i = 0; i < amount; i++)
            {
                result.Add(_random.Next(0, amount));
            }

            return result;
        }
    }
}