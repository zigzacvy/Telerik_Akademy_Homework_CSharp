using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    public class ClientTypes : Bank
    {
        public bool isIndividual { get; set; }
        public bool isCompagny { get; set; }

        public ClientTypes(string inputName, double inputBalance, double inputRate, bool inputIsInd)
            : base(inputName, inputBalance, inputRate)
        {
            if (inputIsInd == true)
            {
                this.isIndividual = true;
                this.isCompagny = false;
            }
            else
            {
                this.isIndividual = false;
                this.isCompagny = true;
            }
        }
    }
}
