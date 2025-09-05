namespace Ejemplotrl
{
    public class Nuevaclass
    {
        public double b { get; set; }
        public double h { get; set; }
        public Nuevaclass() { }
        public Nuevaclass(double b, double h) { this.b = b; this.h = h; }
        public double Area() { return (b * h) / 2; }
        public double Perimetro() { return b + h + Math.Sqrt(b * b + h * h); }
        public void CambiarValores(double b, double h) { this.b = b; this.h = h; }
    }
}