using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqApp.Extension
{
    public class C
    {
        private delegate string Fu(string str);
       
        public void Calc(string str)
        {
            var coll = new Dictionary<string, Fu>()
            {
                {"1", delegate(string s) { return s + "_ext1";}},
                {"2", s => s + "_ext2"},
                {"3", Ext3},
                
            }; 
            Console.WriteLine(coll["1"](str));
            Console.WriteLine(coll["2"](str));
            Console.WriteLine(coll["3"](str));
        }
        
        private string Ext3(string str)
        {
            return str + "_ext3";
        }
    }
}