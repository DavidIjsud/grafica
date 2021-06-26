using System;
using System.Collections.Generic;
namespace ProjectXTwo
{
    public class Mesa : ObjetoGeneral, IObjeto
    {

        public Dictionary<string, IObjeto> listaPartes;

        public Mesa(double px, double py, double pz, double escala, double teta)
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

        public void Escalar(double x, double y, double z)
        {
            foreach (KeyValuePair<string, IObjeto> element in this.listaPartes)
            {
                element.Value.Escalar(x, y, z);
            }
        }

        public void Rotar(double angulo, double x, double y, double z)
        {
            foreach (KeyValuePair<String, IObjeto> elemento in this.listaPartes)
            {

                elemento.Value.Rotar(angulo, x, y, z);

            }
        }

        public void Trasladar(double x, double y, double z)
        {
            foreach (KeyValuePair<String, IObjeto> elemento in this.listaPartes)
            {

                elemento.Value.Trasladar(x, y, z);

            }
        }
    }
}
