using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates.Classes
{
    class MethodsForString
    {
        public delegate string StringDelegate(string line);

        public static string CutString(string line) =>  line.Substring(0, 12);        

        public static string RemoveSpaces(string line) => line.TrimEnd();

        public static string AddSymbols(string line) => line.Insert(line.Length, "...");
    }
}
