namespace Sınıflar
{
    class Satisci : Calisan
    {
        private double satisSayisi;

        public double SatisSayisi
        {
            get { return satisSayisi; }
            set { satisSayisi = value; }
        }
        public override void ZamYap(double zam)
        {
            double EkstraZam = 0;
            if (SatisSayisi > 0 && SatisSayisi <= 1000)
            {
                EkstraZam = 1000;
            }
            else if (SatisSayisi < 100)
            {
                EkstraZam = 1500;
            }
            else if (SatisSayisi < 0)
            {
                EkstraZam = -300;
            }
            Maas += EkstraZam + zam;
        }
        public override string BilgiVer()
        {
            return base.BilgiVer() + " / " + this.SatisSayisi;
        }
    }
}
