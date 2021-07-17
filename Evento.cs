using System;
using OpenTK.Input;

namespace ProjectXTwo
{
    public class Evento
    {
       public static void eventoLanzado( KeyboardState x , Escenario escenario ) {


            if ( x.IsKeyDown(Key.A) ) {

                escenario.AnimarEscena();


            }

          
            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.E))
            {

                escenario.Rotar(escenario.anguloRotacion, 1, 0, 0);
                //escenario.Rotar(escenario.anguloRotacion,0 , 1, 0);
                //escenario.Rotar(escenario.anguloRotacion, 0, 0, 1);

                escenario.anguloRotacion += 1.0;
                if (escenario.anguloRotacion > 360)
                {
                    escenario.anguloRotacion -= 360;
                }


            }


            if (x.IsKeyDown(Key.Plus) && x.IsKeyDown(Key.E))
            {

                escenario.escalaX = escenario.escalaX + 0.1;
                escenario.escalaY = escenario.escalaY + 0.1;
                escenario.escalaZ = escenario.escalaZ + 0.1;


                escenario.Escalar(escenario.escalaX, escenario.escalaY, escenario.escalaZ);
            }

            if (x.IsKeyDown(Key.Minus) && x.IsKeyDown(Key.E))
            {

                escenario.escalaX = escenario.escalaX - 0.1;
                escenario.escalaY = escenario.escalaY - 0.1;
                escenario.escalaZ = escenario.escalaZ - 0.1;


                escenario.Escalar(escenario.escalaX, escenario.escalaY, escenario.escalaZ);
            }


            if (x.IsKeyDown(Key.H))
            {
                escenario.position_y = escenario.position_y + 0.5;

            }

            ///////////////////////////////////////////////////////SILLA//////////////////////////////////////////////////////////////////////

            ///ESTO PARA MOVER LA SILLA SOLAMENTE (trasladar)
            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Up))
            { // hacia arriba en Y

                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.position_y = silla.position_y + 0.5;
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Down)) // hacia abajo en Y
            {

                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.position_y = silla.position_y - 0.5;
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Right))
            { // hacia derecha en X

                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.position_x = silla.position_x + 0.5;
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Left)) // hacia izquierda en X
            {

                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.position_x = silla.position_x - 0.5;
            }


            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Up) && x.IsKeyDown(Key.Z))
            { // hacia Z +

                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.position_z = silla.position_z + 0.5;
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Down) && x.IsKeyDown(Key.Z)) // hacia Z -
            {

                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.position_z = silla.position_z - 0.5;
            }

            ///ESTO ES PARA ROTAR SOLO LA SILLA
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.S))
            { //angulo positivo

                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.anguloRotacion = silla.anguloRotacion + 1.0;

            }


            ///ESTO ES PARA ESCALAR SOLO LA SILLA
            ///

            if (x.IsKeyDown(Key.E) && x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Up))
            {
                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.escalaX = silla.escalaX + 0.1;
                silla.escalaY = silla.escalaY + 0.1;
                silla.escalaZ = silla.escalaZ + 0.1;

            }

            if (x.IsKeyDown(Key.E) && x.IsKeyDown(Key.S) && x.IsKeyDown(Key.Down))
            {
                ObjetoGeneral silla = (ObjetoGeneral)escenario.listaObjetos["Silla"];
                silla.escalaX = silla.escalaX - 0.1;
                silla.escalaY = silla.escalaY - 0.1;
                silla.escalaZ = silla.escalaZ - 0.1;

            }


            /////////////////////////////////////////////////////////MESA////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ///ESTO PARA MOVER LA MEsa SOLAMENTE (trasladar)
            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Up))
            { // hacia arriba en Y

                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];
                mesa.position_y = mesa.position_y + 0.5;
            }

            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Down)) // hacia abajo en Y
            {

                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];
                mesa.position_y = mesa.position_y - 0.5;
            }

            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Right))
            { // hacia derecha en X

                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];
                mesa.position_x = mesa.position_x + 0.5;
            }

            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Left)) // hacia izquierda en X
            {

                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];
                mesa.position_x = mesa.position_x - 0.5;
            }


            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Up) && x.IsKeyDown(Key.Z))
            { // hacia Z +

                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];
                mesa.position_z = mesa.position_z + 0.5;
            }

            if (x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Down) && x.IsKeyDown(Key.Z)) // hacia Z -
            {

                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];
                mesa.position_z = mesa.position_z - 0.5;
            }

            ///ESTO ES PARA ROTAR SOLO LA MESA
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.M))
            { //angulo positivo

                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];
                mesa.anguloRotacion = mesa.anguloRotacion + 1.0;

            }


            ///ESTO ES PARA ESCALAR SOLO LA MESA
            ///

            if (x.IsKeyDown(Key.E) && x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Up))
            {
                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];

                mesa.escalaX = mesa.escalaX + 0.1;
                mesa.escalaY = mesa.escalaY + 0.1;
                mesa.escalaZ = mesa.escalaZ + 0.1;

            }

            if (x.IsKeyDown(Key.E) && x.IsKeyDown(Key.M) && x.IsKeyDown(Key.Down))
            {
                ObjetoGeneral mesa = (ObjetoGeneral)escenario.listaObjetos["Mesa"];

                mesa.escalaX = mesa.escalaX - 0.1;
                mesa.escalaY = mesa.escalaY - 0.1;
                mesa.escalaZ = mesa.escalaZ - 0.1;

            }



            ////////////////////////////////////////////////////////////////////////////////////PATA DE MESA////////////////////////////////////////////////////////////////////
            ///

            ///ESTO PARA MOVER LA MEsa SOLAMENTE una pata (trasladar)
            if (x.IsKeyDown(Key.Up) && x.IsKeyDown(Key.P))
            { // hacia arriba en Y

                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_y = primeraPata.position_y + 0.5;
            }

            if (x.IsKeyDown(Key.Down) && x.IsKeyDown(Key.P)) // hacia abajo en Y
            {

                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_y = primeraPata.position_y - 0.5;
            }

            if (x.IsKeyDown(Key.Right) && x.IsKeyDown(Key.P))
            { // hacia derecha en X

                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_x = primeraPata.position_x + 0.5;
            }

            if (x.IsKeyDown(Key.Left) && x.IsKeyDown(Key.P)) // hacia izquierda en X
            {

                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_x = primeraPata.position_x - 0.5;
            }


            if (x.IsKeyDown(Key.Up) && x.IsKeyDown(Key.Z) && x.IsKeyDown(Key.P))
            { // hacia Z +

                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_z = primeraPata.position_z + 0.5;
            }

            if (x.IsKeyDown(Key.Down) && x.IsKeyDown(Key.Z) && x.IsKeyDown(Key.P)) // hacia Z -
            {

                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.position_z = primeraPata.position_z - 0.5;
            }

            ///ESTO ES PARA ROTAR SOLO LA MESA la pata
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.P))
            { //angulo positivo

                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.anguloRotacion = primeraPata.anguloRotacion + 1.0;

            }

            if (x.IsKeyDown(Key.P) && x.IsKeyDown(Key.O))
            {
                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.escalaX = primeraPata.escalaX + 0.1;
                primeraPata.escalaY = primeraPata.escalaY + 0.1;
                primeraPata.escalaZ = primeraPata.escalaZ + 0.1;
            }

            if (x.IsKeyDown(Key.P) && x.IsKeyDown(Key.M))
            {
                Mesa mesa = (Mesa)escenario.listaObjetos["Mesa"];
                PrimeraPata primeraPata = (PrimeraPata)mesa.listaPartes["PrimeraPata"];
                primeraPata.escalaX = primeraPata.escalaX - 0.1;
                primeraPata.escalaY = primeraPata.escalaY - 0.1;
                primeraPata.escalaZ = primeraPata.escalaZ - 0.1;
            }



            ////////////////////////////////////////////////////////////////////////////////////PATA DE SILLA////////////////////////////////////////////////////////////////////
            ///

            ///ESTO PARA MOVER LA SILLA SOLAMENTE una pata (trasladar)
            if (x.IsKeyDown(Key.W) && x.IsKeyDown(Key.P))
            { // hacia arriba en Y

                Chair silla = (Chair)escenario.listaObjetos["Silla"];
                SegundaPata segundaPata = (SegundaPata)silla.listaPartes["SegundaPata"];
                segundaPata.position_y = segundaPata.position_y + 0.5;
            }

            if (x.IsKeyDown(Key.S) && x.IsKeyDown(Key.P)) // hacia abajo en Y
            {

                Chair silla = (Chair)escenario.listaObjetos["Silla"];
                SegundaPata segundaPata = (SegundaPata)silla.listaPartes["SegundaPata"];
                segundaPata.position_y = segundaPata.position_y - 0.5;
            }

            if (x.IsKeyDown(Key.D) && x.IsKeyDown(Key.P))
            { // hacia derecha en X

                Chair silla = (Chair)escenario.listaObjetos["Silla"];
                SegundaPata segundaPata = (SegundaPata)silla.listaPartes["SegundaPata"];
                segundaPata.position_x = segundaPata.position_x + 0.5;
            }

            if (x.IsKeyDown(Key.A) && x.IsKeyDown(Key.P)) // hacia izquierda en X
            {

                Chair silla = (Chair)escenario.listaObjetos["Silla"];
                SegundaPata segundaPata = (SegundaPata)silla.listaPartes["SegundaPata"];
                segundaPata.position_x = segundaPata.position_x - 0.5;
            }

            ///ESTO ES PARA ROTAR SOLO LA SILLA la pata
            ///

            if (x.IsKeyDown(Key.R) && x.IsKeyDown(Key.C))
            { //angulo positivo

                Chair silla = (Chair)escenario.listaObjetos["Silla"];
                SegundaPata segundaPata = (SegundaPata)silla.listaPartes["SegundaPata"];
                segundaPata.anguloRotacion = segundaPata.anguloRotacion + 1.0;

            }

            if (x.IsKeyDown(Key.C) && x.IsKeyDown(Key.W))
            {
                Chair silla = (Chair)escenario.listaObjetos["Silla"];
                SegundaPata segundaPata = (SegundaPata)silla.listaPartes["SegundaPata"];
                segundaPata.escalaX = segundaPata.escalaX + 0.1;
                segundaPata.escalaY = segundaPata.escalaY + 0.1;
                segundaPata.escalaZ = segundaPata.escalaZ + 0.1;
            }

            if (x.IsKeyDown(Key.C) && x.IsKeyDown(Key.X))
            {
                Chair silla = (Chair)escenario.listaObjetos["Silla"];
                SegundaPata segundaPata = (SegundaPata)silla.listaPartes["SegundaPata"];
                segundaPata.escalaX = segundaPata.escalaX - 0.1;
                segundaPata.escalaY = segundaPata.escalaY - 0.1;
                segundaPata.escalaZ = segundaPata.escalaZ - 0.1;
            }



        }

    }
}
