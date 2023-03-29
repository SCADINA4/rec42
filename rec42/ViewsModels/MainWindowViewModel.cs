using rec42.ViewsModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace rec42.ViewsModels
{
    public class MainWindowViewModel : ViewModel
    {
        private double power;
        private double step;

        public double Power
        {
            get { return power; }
            set { Set(ref power, value); } 
        }
        public double Step
        {
            get { return step; }    
            set { Set(ref step, value); }   
        }
        public double Pow(double a, int n)
        {
            if (n == 1)
                return a;
            return Step = a * Pow(a, n - 1); 

        }
    }
}
