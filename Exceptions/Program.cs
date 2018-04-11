using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcul division = new Calcul(10, 0);

            try
            {
                division.diviser();

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //************SUITE DU PROGRAMME**************

            Console.WriteLine("Je continue mon programme");

        }
    }
}
