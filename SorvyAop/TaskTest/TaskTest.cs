using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorvy;

namespace TaskTest
{
    [log(Type =AopType.Ctor)]
    [haha]
    class TaskTest
    {
        [log1]
        public string wo()
        {
            var wof = "fwef";
            return wof;
        }
        [log2(Type =AopType.Get)]
        public string p { get; set; }
        [log3]
        public TaskTest(string i) { }
    }
    public class log : Sorvy.BaseAop
    {
        public override void After(ExceEventArg method)
        {
            Console.WriteLine("111");
           
        }
        public override void Before(ExceEventArg method)
        {
           
        }

        public override void Exception(ExceEventArg method)
        {
        }
    }
    public class log1 : log {

    }
    public class log2 : log { }
    public class log3 : log2 { }

    public class haha : Attribute
    { }
}
