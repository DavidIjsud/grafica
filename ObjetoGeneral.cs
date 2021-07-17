using System;
namespace ProjectXTwo
{
    public abstract class ObjetoGeneral : IObjeto
    {
        public double position_x = 0.0;
        public double position_y = 0.0;  //-3 
        public double position_z = 0.0;  //-20
        public double escalaX = 0.8;
        public double escalaY = 0.8;
        public double escalaZ = 0.8;
        public  double teta;
        public double rotationX;
        public double rotationY;
        public double rotationZ;
        public double anguloRotacion;

        public abstract void Dibujar();
        public abstract void Escalar(double x, double y, double z);
        public abstract void Rotar(double angulo, double x, double y, double z);
        public abstract void Trasladar();
    }
}
