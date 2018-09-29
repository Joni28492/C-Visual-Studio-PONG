using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG
{
    public partial class Form1 : Form
    {
        private int paradas = 0;
        private int velocidad = 15;
        private int nivel = 1;
        private bool direccionArriba;
        private bool direccionIzq;
        private int puntUno = 0;
        private int puntDos = 0;
        Random r = new Random(DateTime.Now.Millisecond);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            //movimiento de pala con teclas 
            switch (e.KeyCode)
            {
                //el movimiento lo hago de esta manera para cuando 
                //el nivel aumente no llegue al punto de no puedo 
                //alcanzar la pelota
                case Keys.Up:


                    if (pbPala.Top <= panel1.Top)
                        pbPala.Top = panel1.Top; //no se salga por arriba
                    else
                        pbPala.Top -= 2*velocidad;
                    break;

                case Keys.Down:

                    if (pbPala.Bottom >= panel1.Bottom)
                    {
                        pbPala.Top = panel1.Height - pbPala.Height;//no se sale por abajo
                    }
                    else
                        pbPala.Top += 2 * velocidad;
                    break;
            }









        }

        private void Form1_Load(object sender, EventArgs e)
        {

            nuevaPelota();
        }
            
        //funcion nuevaPelota
        private void nuevaPelota()
        {
            //pelota se posiciona aleatoriamente de la mitad hacia la derecha 
     
            pbPelota.Left = r.Next(panel1.Width / 2, panel1.Width - pbPelota.Width);
            pbPelota.Top = r.Next(0, panel1.Height);

            if (pbPelota.Left / 2 == 0)
                direccionArriba = true;
            else
                direccionArriba = false;
           
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //direccion vertical 
            if (direccionArriba)
                pbPelota.Top -= velocidad;
            else
                pbPelota.Top += velocidad;
            if (pbPelota.Top <= panel1.Top)
                direccionArriba = false;
            else if (pbPelota.Bottom >= panel1.Bottom)
                direccionArriba = true;



            //direccion horizontal 
            if (direccionIzq)
                pbPelota.Left -= velocidad;
            else
                pbPelota.Left += velocidad;



            





            //choque panel derecha
            if (pbPelota.Right >= panel1.Right)
            {
                puntUno++;
                pbPelota.Left = panel1.Width / 2;
                direccionIzq = true;
                lblNivel.Text = "marca jugador 1";
            }
            //chocar con pared izquierda 
            else if (pbPelota.Left <= panel1.Left) {
                puntDos++;
                pbPelota.Left = panel1.Width / 2;
                direccionIzq = false; 
                lblNivel.Text = "marca jugador 2";
            }

            //colision en pala izquierda
            else if (
                // llega a la altura de la pal y vuelve
                pbPelota.Left <= pbPala.Right
                //para el margen superior y coge tambien los 3/4 de la pelota para cuando no choeque entera
                && pbPelota.Top > pbPala.Top - (3 * pbPelota.Height) / 4
                //para el margen inferior
                && pbPelota.Bottom < ((pbPala.Top + pbPala.Height) + (3 * pbPelota.Height) / 4)
                )
            {
                direccionIzq = false;
                paradas++;
                if (paradas % 10 == 0)
                {
                    velocidad += 5;
                    nivel++;
                }

               
            }

            //colision en pala derecha
            else if(
                //llega a la altura de la pala y vuelve 
                pbPelota.Right>= pbPalaDos.Left
                //para el margen superior
                && pbPelota.Top > pbPalaDos.Top - (3 * pbPelota.Height) / 4
                //para el margen inferior
                && pbPelota.Bottom < ((pbPalaDos.Top + pbPalaDos.Height) + (3 * pbPelota.Height) / 4)
                )
            {
                direccionIzq = true;
                paradas++;

                if (paradas % 10 == 0)
                {
                    velocidad += 5;
                    nivel++;
                }

            }



            //velocidad mayor o igual que el ancho de la pala
            if (velocidad >= pbPala.Width)
            {
                //hacemos la pelota mas pequeña 
                pbPelota.Width -= (velocidad - pbPala.Width);
                pbPelota.Height -= (velocidad - pbPala.Width);

                //hacemos que no se haga mas pequeña de 5x5 para que no desaparezca 
                if (pbPelota.Height <= 5)
                {
                    pbPelota.Height = 5;
                    pbPelota.Width = 5;

                }
            }


            //inteligencia artificial de la pala 
            //captura la diferencia que hay entre la pelota y la mitad de la pala
            //y se intenta ajustar a la misma
            //se vuelve un poco loco cuando hay mucha distancia 

            if(pbPelota.Top < pbPalaDos.Top)
            {

                pbPalaDos.Top -= ((pbPelota.Top + pbPelota.Height) - (pbPalaDos.Height / 2));
                //no salirse por arriba
                if (pbPalaDos.Top <= panel1.Top)
                    pbPalaDos.Top = panel1.Top;
                
            }

            else if(pbPelota.Top > pbPalaDos.Top + pbPalaDos.Height)
            {

                pbPalaDos.Top = pbPelota.Top - (pbPalaDos.Top - pbPalaDos.Height / 2);
                if (pbPalaDos.Bottom >= panel1.Bottom)
                {

                    pbPalaDos.Top = (panel1.Top + panel1.Height) - pbPalaDos.Height;
                }


            }
         

            lblNivel.Text = "<<" + puntUno + " - " + puntDos + ">>";


        }
    }
}
