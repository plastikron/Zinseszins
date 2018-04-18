using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPFZinsesZins
{
    class ZinsesZins : INotifyPropertyChanged
    {
        private Double a_kapital;
        private Double e_kapital;
        private Double zins;
        private Double jahre;
        private Double gewinn;
        private Double prozent;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        public double A_kapital
        {
            get
            {
                return a_kapital;
            }

            set
            {
                a_kapital = value;
            }
        }

        public double E_kapital
        {
            get
            {
                return e_kapital;
            }

            private set
            {
                e_kapital = value;
                OnPropertyChanged(new PropertyChangedEventArgs("E_kapital"));
            }
        }

        public double Zins
        {
            get
            {
                return zins;
            }

            set
            {
                zins = value;
            }
        }

        public Double Jahre
        {
            get
            {
                return jahre;
            }

            set
            {
                jahre = value;
            }
        }

        public double Gewinn
        {
            get
            {
                return gewinn;
            }

            private set
            {
                gewinn = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Gewinn"));
            }
        }

        public double Prozent
        {
            get
            {
                return prozent;
            }

            private set
            {
                prozent = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Prozent"));
            }
        }

        public ZinsesZins(Double a_kap, Double zinsfuss, Double laufzeit)
        {
            A_kapital = a_kap;
            Zins = zinsfuss;
            Jahre = laufzeit;
        }
        public ZinsesZins()
        {

        }

        public void BerechneKapital()
        {
            E_kapital = a_kapital * Math.Pow((1 + zins / 100), Jahre);
            Gewinn = E_kapital - A_kapital;
            Prozent = Gewinn / A_kapital * 100;
        }
    }
}
