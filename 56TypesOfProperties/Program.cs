using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56TypesOfProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            // d.V1 = 10; 
            Console.WriteLine(d.V1);
            d.V2 = 20;
            // Console.WriteLine(d.V2);
            // d.V3 = 20;
            Console.WriteLine(d.V3);
            d.V4 = 20;
            //Console.WriteLine(d.V4);  
        }
    }

    class Demo
    {
        private int v1;
    private int v2;
    private int v3;
    private int v4;

    // Read only property
    public int V1
    {
        get { return v1; }
    }

    // Write only property
    public int V2
    {
        set { v2 = value; }
    }

    // Private write only property
    public int V3
    {
        private set { v3 = value; }
        get { return v3; }
    }

    // Private read only property
    public int V4
    {
        set { v4 = value; }
        private get { return v4; }
    }
}
    
    
}
