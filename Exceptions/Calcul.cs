using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Calcul
    {
        private int var1;

        public int Var1
        {
            get { return var1; }
            set { var1 = value; }
        }

        private int var2;

        public int Var2
        {
            get { return var2; }
            set { var2 = value; }
        }

        private int resultat;

        public int Resultat
        {
            get { return resultat; }
            set { resultat = value; }
        }

        public int somme()
        {
            resultat = var1 + var2;
            return resultat;
        }

        public Calcul(int _var1, int _var2)
        {
            var1 = _var1;
            var2 = _var2;
        }

        public void diviser()
        {
            if (var2 == 0)
            {
                throw new Exception("Division par zéro impossible");                
            }
            resultat = var1 / var2;
        }

    }
}
