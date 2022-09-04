using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaCobrona
{
    internal class Jogo
    {
        //Enums keyboard;
        public Keys Direction { get; set; }
        public Keys Arrow { get; set; }

        private Timer Tempo { get; set; }

        private Label Pontos { get; set; }

        private Panel PnTela { get; set; }

        private int pontos = 0;

        private Comida Comida;

        private Cobrona Cobrona;

        private Bitmap offScreenBitmap; //Pixels size panel;
        private Graphics bitmapGraph; //Spawn panel white;
        private Graphics ScreenGraph;

        public Jogo(ref Timer timer, ref Label label, ref Panel panel) //Constructor game;
        {
            PnTela = panel;
            Tempo = timer;
            Pontos = label;
            offScreenBitmap = new Bitmap(428, 428); //Windows size init;
            Cobrona = new Cobrona(); //new = instaciando as classes;
            Comida = new Comida();
            Direction = Keys.Left;
            Arrow = Direction;
        }

        public void StartGame()
        {
            Cobrona.Reset();
            Comida.CreateFood();
            Direction = Keys.Left;
            bitmapGraph = Graphics.FromImage(offScreenBitmap);
            ScreenGraph = PnTela.CreateGraphics(); //Render window; Screen receiv CreatGraph;
            Tempo.Enabled = true; //Start timer;

        }

        public void Tick()
        {
            //Check moviment snake and block otter moviments;
            if (((Arrow == Keys.Left) && (Direction != Keys.Right)) ||
            ((Arrow == Keys.Right) && (Direction != Keys.Left)) ||
            ((Arrow == Keys.Up) && (Direction != Keys.Down)) ||
            ((Arrow == Keys.Down) && (Direction != Keys.Up)))
            {
                Direction = Arrow;
            }
            switch (Direction)
            {  //Moviment snake;
                case Keys.Left:
                    Cobrona.Left();
                    break;
                case Keys.Right:
                    Cobrona.Right();
                    break;
                case Keys.Up:
                    Cobrona.Up(); 
                    break;
                case Keys.Down:
                    Cobrona.Down(); 
                    break;
            }

            bitmapGraph.Clear(Color.White); //Clear Snake and Food;

            bitmapGraph.DrawImage(Properties.Resources.macagame, (Comida.Location.X * 15), (Comida.Location.Y * 15),15,15); //Positon and size food;
            bool gameOver = false;

            for(int i = 0; i < Cobrona.Length; i++) //Only get value to private set;
            {
                if(i == 0)
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#000000")), (Cobrona.Location[i].X * 15), (Cobrona.Location[i].Y * 15), 15, 15); //Snake Head
                } else
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#123456")), (Cobrona.Location[i].X * 15), (Cobrona.Location[i].Y * 15), 15, 15);// Snake Body;
                }

                if ((Cobrona.Location[i] == Cobrona.Location[0]) && (i > 0)) //Check colision snake;
                {
                    gameOver = true;
                }
            }
            ScreenGraph.DrawImage(offScreenBitmap, 0, 0);
            CheckCollision();
            if (gameOver)
            {
                GameOver(); //Method game over;
            }
        }

        public void CheckCollision()
        {
            if (Cobrona.Location[0] == Comida.Location)//Check food colision
            {
                Cobrona.Eat(); //Check snake eat;
                Comida.CreateFood(); //Create new food;
                pontos += 1; //Value to add pontos;
                Pontos.Text = "PONTOS: " + pontos; //Increment pontos
            }
        }

        public void GameOver()
        {
            Tempo.Enabled = false; //Reset timer
            bitmapGraph.Dispose(); //Clean memory graph;
            ScreenGraph.Dispose(); //Use Dispose in screen and bitmap;
            Pontos.Text = "PONTOS: 0";
            pontos = 0;
            MessageBox.Show("Burrão EM"); //Message box
        }


    }
}
