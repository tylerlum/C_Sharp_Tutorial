using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes the chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes the salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes the bbq ribs");
        }
    }
}
