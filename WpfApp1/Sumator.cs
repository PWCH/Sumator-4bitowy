using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Sumator
    {
        private bool A1 = false;
        private bool A2 = false;
        private bool Cin = false;
        private bool Cout = false;
        private bool S;

        public void Sprawdz()
        {
            if((A1 == true && A2 == true && Cin == false)||
               (A1 == true && A2 == false && Cin == true)||
               (A1 == false && A2 ==true && Cin == true))
            {
                Cout = true;
                S = false;
            }
            if((A1 == true && A2 == false && Cin == false)||
               (A1 == false && A2 == true && Cin == false)||
               (A1 == false && A2 == false && Cin == true))
            {
                Cout = false;
                S = true;
            }
            if((A1 == false && A2 == false && Cin == false))
            {
                Cout = false;
                S = false;
            }
            if((A1 == true && A2 == true && Cin == true))
            {
                Cout = true;
                S = true;
            }
        }
        public bool BitKontrolny(Sumator a)
        {
            Cin = a.Cout;
            if (a.Cout == true)
                return true;
            else return false;
        }

        public void A1naFalsz()
        {
            A1 = false;
        }
        public void A1naPrawda()
        {
            A1 = true;
        }

        public void A2naFalsz()
        {
            A2 = false;
        }

        public void A2naPrawda()
        {
            A2 = true;
        }

        public bool C_Wartosc()
        {
            if (Cout == true)
                return true;
            else
                return false;
        }

        public bool S_Wartosc()
        {
            if (S == true)
                return true;
            else
                return false;
        }
    }

}
