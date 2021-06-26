using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class Escenario : ObjetoGeneral, IObjeto
    {

       public Dictionary<string, IObjeto> listaObjetos;

        public Escenario(double px, double py, double pz, double escala, double teta)
        {
            this.position_x = px;
            this.position_y = py;
            this.position_z = pz;
            this.escala = escala;
            this.teta = teta;
            this.listaObjetos = new Dictionary<string, IObjeto>();

            this.listaObjetos.Add("Silla", new Chair(this.position_y, this.position_x , this.position_x , this.escala ,  this.teta ));
            this.listaObjetos.Add("Mesa", new Mesa(10, 0, 10, this.escala, this.teta));

        }

        public void Dibujar()
        {
            
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Dibujar();
            }
        }

        public void Escalar(double x, double y, double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Escalar(x , y , z);
            }
        }

        public void Rotar(double angulo, double x, double y, double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Rotar( angulo, x , y , z );
            }
        }

        public void Trasladar(double x, double y, double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                
                element.Value.Trasladar( x , y , z );
               
            }
        }

    }
}
