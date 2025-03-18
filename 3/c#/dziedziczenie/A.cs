using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    internal class A
    {
        private String privateString;
        protected String protectedString;
        public String publicString;
        internal String internalString;

        private String privateFunc()
        {
            return "Metoda private";
        }
        internal String internalFunc()
        {
            return "Metoda internal";
        }
        protected String protectedFunc()
        {
            return "Metoda protected";
        }
        public String publicFunc()
        {
            return "Metoda public";
        }
        public void podsumowanie()
        {
            Console.WriteLine();
        }
    }
}
