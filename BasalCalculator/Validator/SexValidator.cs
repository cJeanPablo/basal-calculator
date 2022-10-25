namespace BasalCalculator.Validator
{
    public class SexValidator
    {
        public string sex { get; set; }

        public bool ValidarSexo(string sex)
        {
            if (sex != "m" &&
                sex != "M" &&
                sex != "f" &&
                sex != "F")
            {
                return false;
            }
            else { return true; }

        }

        public bool ValidarSexoMasculino(string sex)
        {
            if (sex != "m" &&
                sex != "M")
            {
                return false;
            }
            else { return true; }
        }

        public bool ValidarSexoFeminino(string sex)
        {
            if (sex != "f" &&
                sex != "F")
            {
                return false;
            }
            else { return true; }
        }

        
    }
}
