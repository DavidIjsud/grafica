using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;
namespace ProjectXTwo
{
    public class Chair : ObjetoGeneral, IObjeto
    {
        Dictionary<string, IObjeto> listaPartes;

       
       

        public Chair( double px , double py, double pz , double escala , double teta )
        {
            this.position_x = px;
            this.position_y = py;
            this.position_z = pz;
            this.escala = escala;
            this.teta = teta;

            fillElementsOfChair();

        }

        private void fillElementsOfChair()
        {

            this.listaPartes = new Dictionary<string, IObjeto>();
            this.listaPartes.Add("Espaldar", new Espaldar(this.position_x, this.position_y, this.position_z, this.escala, this.teta));
            this.listaPartes.Add("Apoyador", new ApoyadorPoto(this.position_x, this.position_y, this.position_z, this.escala, this.teta));
            this.listaPartes.Add("PrimeraPata", new PrimeraPata(this.position_x, this.position_y, this.position_z, this.escala, this.teta));
            this.listaPartes.Add("SegundaPata", new SegundaPata(this.position_x, this.position_y, this.position_z, this.escala, this.teta));
            this.listaPartes.Add("TerceraPata", new TerceraPata(this.position_x, this.position_y, this.position_z, this.escala, this.teta));
            this.listaPartes.Add("CuartaPata", new CuartaPata(this.position_x, this.position_y, this.position_z, this.escala, this.teta));
        }

        public void Dibujar()
        {

            foreach (KeyValuePair<string, IObjeto> element in this.listaPartes)
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

       


       

        
    }
}
