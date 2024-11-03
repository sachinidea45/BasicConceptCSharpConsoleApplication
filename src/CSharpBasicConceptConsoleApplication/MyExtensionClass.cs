using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptCSharpConsoleApplication
{
    internal class MyExtensionClass
    {
    }

    #region Extension Method Class and Implementation

    public class MyWithoutExtensionClass
    {
    }

    public static class XX
    {
        public static void MyExtensionMethods(this MyWithoutExtensionClass obj)
        {
            Console.WriteLine("My Extension Methods");
        }
    }

    #endregion Extension Method Class and Implementation
}
