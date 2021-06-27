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

        public Escenario()
        {
            
            this.listaObjetos = new Dictionary<string, IObjeto>();

            this.listaObjetos.Add("Silla", new Chair());
            this.listaObjetos.Add("Mesa", new Mesa());

        }

        public void Dibujar()
        {
            
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Dibujar();
            }
        }

        public void Escalar( double x , double y , double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Escalar( x  , y , z);
            }
        }

        public void Rotar(double angulo, double x, double y, double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                element.Value.Rotar( angulo, x , y , z );
            }
        }

        public void Trasladar()
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaObjetos)
            {
                
                element.Value.Trasladar( );
               
            }
        }

    }
}
