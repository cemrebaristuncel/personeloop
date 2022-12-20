namespace Sınıflar
{
    class Mudur : Calisan
    {
        private double departmanKar;

        public double DepartmanKar
        {
            get { return departmanKar; }
            set { departmanKar = value; }
        }
        public override void ZamYap(double zam)
        {
            double EkstraZam = 0;
            if (DepartmanKar > 0 && DepartmanKar <= 100000)
            {
                EkstraZam = 10000;
            }
            else if (DepartmanKar > 100000)
            {
                EkstraZam = 15000;
            }
            else if (DepartmanKar < 0)
            {
                EkstraZam = -3000;
            }
            Maas += EkstraZam + zam;
        }
    }
}
