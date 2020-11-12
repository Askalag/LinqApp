using System.Collections.Generic;

namespace LinqApp.Generator
{
    public interface IGenerator<T>
    {
        List<T> Generate(int amount);
    }
}