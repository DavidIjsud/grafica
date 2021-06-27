using System;
namespace ProjectXTwo
{
    public interface IObjeto
    {

        public  void Dibujar();
        public  void Rotar( double angulo , double x , double y , double z );
        public  void Escalar(double x, double y, double z);
        public  void Trasladar( );

    }
}
