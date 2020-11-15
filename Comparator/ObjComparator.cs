using System;
using System.Collections.Generic;
using LinqApp.Model;

namespace LinqApp.Comparator
{
    public class ObjComparator : IEqualityComparer<Obj>
    {
        public bool Equals(Obj x, Obj y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(Obj obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}