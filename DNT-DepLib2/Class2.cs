using System;
using System.Collections.Generic;
using System.Text;

namespace Lib2
{
    public class LibClass2
    {
        public static void Hello()
        {
            Lib1.LibClass1.Hello();
        }
    }
}
