using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace laba10_10
{
    class StaticClass
    {
        public static void Method(object sender, NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Коллекция изменена");
        }
    }
}
