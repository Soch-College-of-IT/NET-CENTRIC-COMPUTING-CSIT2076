using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksStoreConsoleApplication
{   
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("BaseClass.Method1");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("DerivedClass.Method1");
        }
    }

    class BaseMethodHiding
    {
        public void Method1()
        {
            Console.WriteLine("BaseMethodHiding.Method1");
        }
    }

    class DerivedMethodHiding : BaseMethodHiding
    {
        public new void Method1()
        {
            Console.WriteLine("DerivedMethodHiding.Method1");
        }
    }
}
