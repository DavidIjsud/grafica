using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectXTwo.Animacion
{
    public class ControlAnimador
    {



        public ControlAnimador()
        {

        }

        public static void animar(Animacion animacion) {

           

            switch (animacion.Objeto) {
                case nameof(Objetos.Silla):

                    Chair silla = (Chair)animacion.escenario.listaObjetos["Silla"];
                    _ = animarAccionesAsync(silla, animacion.Acciones);

                    break;

                case nameof(Objetos.Mesa):
                    Mesa mesa = (Mesa)animacion.escenario.listaObjetos["Mesa"];
                    _ = animarAccionesAsync(mesa, animacion.Acciones);
                    break;

            }

        }

        private static async Task animarAccionesAsync (ObjetoGeneral o, List<Accione> listaAcciones){

            foreach (Accione a in listaAcciones) {
               await animarAccion( o , a );
            }

        }

        private static async Task animarAccion( ObjetoGeneral o , Accione accione ) {

            switch (accione.Accion) {
                case nameof(Acciones.TrasladarEnXMas):
                    await Task.Run(() => {
                        MoverObjetoEnXMas(o, accione.Tiempo);
                    });
                    break;
                case nameof(Acciones.TrasladarEnYMas):
                    await Task.Run(() => {
                        MoverObjetoEnYMas(o, accione.Tiempo);
                    });
                    break;
                case nameof(Acciones.Rotar):
                    await Task.Run(() => {
                        RotarObjeto(o, accione.Tiempo);
                    } );
                    break;

                case nameof(Acciones.Escalar):
                    await Task.Run(() => {
                        EscalarObjeto(o, accione.Tiempo);
                    });
                    break;
                case nameof(Acciones.EscalarMenos):
                    await Task.Run(() => {
                        EscalarObjetoMenos(o, accione.Tiempo);
                    });
                    break;
            }

        }


        private static void EscalarObjetoMenos(ObjetoGeneral objetoGeneral, int tiempo)
        {

            int contador = 0;
            while (true)
            {

                objetoGeneral.escalaX -= 0.02;
                objetoGeneral.escalaY -= 0.02;
                objetoGeneral.escalaZ -= 0.02;
                Thread.Sleep(90);

                contador += 100;

                if (contador > tiempo)
                {

                    break;
                }

            }

        }


        private static void EscalarObjeto( ObjetoGeneral objetoGeneral, int tiempo ){

            int contador = 0;
            while (true)
            {

                objetoGeneral.escalaX += 0.02;
                objetoGeneral.escalaY += 0.02;
                objetoGeneral.escalaZ += 0.02;
                Thread.Sleep(90);

                contador += 100;

                if (contador > tiempo)
                {

                    break;
                }

            }

        }

        private static void RotarObjeto(ObjetoGeneral objetoConcreto, int tiempo) {
            int contador = 0;
            while (true)
            {

                objetoConcreto.anguloRotacion += 1.0;
                Thread.Sleep(90);

                contador += 100;

                if (contador > tiempo)
                {

                    break;
                }

            }
        }

        private static void MoverObjetoEnYMas(ObjetoGeneral objetoConcreto, int tiempo)
        {
            int contador = 0;
            while (true)
            {

                objetoConcreto.position_y += 0.05;

                Thread.Sleep(100);

                contador += 100;

                if (contador > tiempo)
                {

                    return;
                }


            }

        }


        private static void MoverObjetoEnXMas(ObjetoGeneral objetoConcreto , int tiempo) {
            int contador = 0;
            while (true) {

                objetoConcreto.position_x += 0.05;
                
                Thread.Sleep(100);

                contador += 100;

                if ( contador > tiempo ) {

                    return;
                }

               
            }

        }



    }
}
