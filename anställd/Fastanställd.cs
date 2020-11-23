using System;

namespace Anställd1
{
    class Fast : Anställd
    {
        private double Lön;

        public Fast(string namnet, double Lön):base(namnet)
        {
           this.Lön = Lön;
        }
        public override double BeräknaLön()
        {
            return Lön;
        }
        public override String ToString()
        {
            return "billy: " + 
                Environment.NewLine + "fastanställd" +
                Environment.NewLine + "Lön:" + BeräknaLön() +
                Environment.NewLine;
        }
        
    }
}    
