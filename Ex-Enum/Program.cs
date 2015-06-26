using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ====== Start ======");

            DBop _dBop = DBop.Update;

            if (_dBop == DBop.Add)
                Console.WriteLine(" if true");



            Console.WriteLine(" ====== End ======");
            Console.ReadKey();
        }

        internal enum DBop
        {
            no = 1,
            Add = 2,
            Update = 3,
            Del = 4
        };
    }
}
