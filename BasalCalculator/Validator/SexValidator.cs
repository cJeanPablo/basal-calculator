using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasalCalculator.Validator
{
    public class SexValidator
    {
        public char sex { get; set; }

        public bool ValidarSexo(char sex)
        {
            if (sex != 'm' &&
                sex != 'M' &&
                sex != 'f' &&
                sex != 'F')
            {
                return false;
            }
            else { return true; }

        }

        public bool ValidarSexoMasculino(char sex)
        {
            if (sex != 'm' &&
                sex != 'M')
            {
                return false;
            }
            else { return true; }
        }

        public bool ValidarSexoFeminino(char sex)
        {
            if (sex != 'f' &&
                sex != 'F')
            {
                return false;
            }
            else { return true; }
        }

    }
}
