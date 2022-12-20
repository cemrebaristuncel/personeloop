using System;

namespace Sınıflar
{
    class Calisan : IDisposable
    {
        private double sskNo;
        public double SskNo
        {
            get { return sskNo; }
            set { sskNo = value; }
        }

        private string adi;
        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }


        protected double maas;

        public double Maas
        {
            get { return maas; }
            set { maas = value; }
        }

        public virtual void ZamYap(double zam)
        {
            Maas += zam;
        }

        public virtual string BilgiVer()
        {
            return this.SskNo + " / " + this.Adi + " / " + this.Maas;
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
