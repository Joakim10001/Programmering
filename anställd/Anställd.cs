using System;

namespace Anställd1
{
    class Anställd
    {
        private String namn;

     
        
        public Anställd(String namn)
        {
            this.namn = namn;

        }
        public virtual double BeräknaLön()
        {
            return 0;

        }
        public override String ToString()
        {
            return namn;
        }
        
    }
}