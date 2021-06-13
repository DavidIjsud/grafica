﻿using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class CuartaPata : ObjetoGeneral , IObjeto
    {

        public CuartaPata(double px, double py, double pz, double escala, double teta)
        {
            this.position_x = px;
            this.position_y = py;
            this.position_z = pz;
            this.escala = escala;
            this.teta = teta;
        }

        public void Dibujar()
        {
            /////segunda pata

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //parte superior

            GL.Vertex3(3 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(3 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0, 5, 0);

            //parte trasera
            GL.Vertex3(3 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(3 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //lateral derecho
            GL.Vertex3(1 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //lateral izquierda
            GL.Vertex3(3 + (this.position_x), -2 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(3 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(3 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(3 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(1.0, 1.0, 1.0); //blanco

            //parte abajo

            GL.Vertex3(3 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));
            GL.Vertex3(3 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), 1 + (this.position_z));

            GL.End();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(0.0, 5, 0);

            //parte frontal
            GL.Vertex3(3 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(3 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), 1 + (this.position_y), 0 + (this.position_z));
            GL.Vertex3(1 + (this.position_x), -2 + (this.position_y), 0 + (this.position_z));

            GL.End();

        }

        public void Escalar()
        {
            throw new NotImplementedException();
        }

        public void Rotar()
        {
            throw new NotImplementedException();
        }

        public void Trasladar()
        {
            throw new NotImplementedException();
        }
    }
}
