using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {

        public string jogador_atual = "O";

        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Zerar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         //Teste
        public string Inverterjogador()
        {
            if(jogador_atual == "O")
            {
                return "X";
            }
            else
            {
                return "O";
            }
            return "O";
        }

        public void Zerar()
        {
            button10.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            jogador_atual = "O";
        }

        public void Ganhar ()
        {
            MessageBox.Show("O Jogador " + jogador_atual + " ganhou");
            Zerar();
        }

        public bool Verificar(string jogador_at)
        {
            if (button10.Text == jogador_at && button5.Text == jogador_at && button8.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (button1.Text == jogador_at && button4.Text == jogador_at && button7.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (button2.Text == jogador_at && button3.Text == jogador_at && button6.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (button10.Text == jogador_at && button1.Text == jogador_at && button2.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (button5.Text == jogador_at && button4.Text == jogador_at && button3.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (button8.Text == jogador_at && button7.Text == jogador_at && button6.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (button10.Text == jogador_at && button4.Text == jogador_at && button6.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (button2.Text == jogador_at && button4.Text == jogador_at && button8.Text == jogador_at)
            {
                Ganhar();
                return true;
            }

            label1.Text = "Jogador Atual:" + jogador_atual;
            jogador_atual = Inverterjogador();
            
            return false;
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "")
            {
                button10.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "")
            {
                button1.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "")
            {
                button2.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(button4.Text == "")
            {
                button4.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "")
            {
                button3.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = jogador_atual;
                Verificar(jogador_atual);
            }
        }


    }
}
