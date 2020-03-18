using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66PartialMethods
{
   public partial class Demo
    {
        partial void Display();
     
        public void Show()
        {
            Display();
        }
    }
}
