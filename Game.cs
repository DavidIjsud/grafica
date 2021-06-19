using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace ProjectXTwo
{
    public class  Game : GameWindow
    {

      

        Escenario escenario;

        double angulo;

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) {

            this.escenario = new Escenario(0.0, 0.0, 0.0, 0.0, 0.0);
            this.Run(1.0/60.0);

        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
            GL.Enable( EnableCap.DepthTest );
            base.OnLoad(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Matrix4 matrix = Matrix4.Perspective(45.0f, Width / Height, 1.0f,100.0f);
            GL.LoadMatrix( ref matrix );
  

            GL.MatrixMode(MatrixMode.Modelview);

            base.OnResize(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );


            GL.Translate(-5.0, 0.0, -20.0);

            GL.PushMatrix();

            
            
            this.escenario.Rotar(angulo , 1.0, 0.0, 0.0);
            this.escenario.Escalar(1, 1, 1);

            this.escenario.Dibujar();

            GL.PopMatrix();

            Context.SwapBuffers();

            this.angulo += 1.0;
            if (this.angulo == 360)
            {
                this.angulo -= 360;
            }

            base.OnRenderFrame(e);
        }

    }
}
