using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class Escenario : ObjetoGeneral, IObjeto
    {

        Dictionary<string, IObjeto> listaObjetos;

        public Escenario(double px, double py, double pz, double escala, double teta)
        {
            this.position_x = px;
            this.position_y = py;
            this.position_z = pz;
            this.escala = escala;
            this.teta = teta;
            this.listaObjetos = new Dictionary<string, IObjeto>();

            this.listaObjetos.Add("Silla", new Chair(4.0, 10.0, 10.0, 1.0, 1.0));
        }

        public void Dibujar()
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Dibujar();
            }
        }

        public void Escalar()
        {
           
        }

        public void Rotar()
        {
            
        }

        public void Trasladar()
        {
            
        }


        //  pintarEscenario(100);

      







    }
}
