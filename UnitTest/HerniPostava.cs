using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class HerniPostava
    {
        private string jmeno;
        public string Jmeno {
            get { return jmeno; }
            set
            {
                if (value.Length > 10) throw new Exception("NameLength");
                this.jmeno = value;
            }
        }
        
        public int Level { get; protected set; }
        
        public double X { get; private set; }
        public double Y { get; private set; }

        public virtual void ZmenaPozice(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return string.Format("Jmeno {0};Level {1};X {2};Y {3}",jmeno,Level,X,Y);
        }

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
            X = 0;
            Y = 0;
            Level = 1;
        }
    }
}
