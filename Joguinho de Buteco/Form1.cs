using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joguinho_de_Buteco
{
    public partial class Form1 : Form
    {
        enum Opcoes {Pedra, Papel, Tesoura};
        enum Resultado {Jogador, Cpu, Empate}
        Opcoes jogador = new Opcoes();
        Opcoes cpu = new Opcoes();
        Random rdm = new Random();
        Resultado ganhador = new Resultado();
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoPedra_Click(object sender, EventArgs e) //evento
        {
            jogador = Opcoes.Pedra;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();


        }

        private void botaoPapel_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Papel;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();

        }

        private void botaoTesoura_Click(object sender, EventArgs e)
        {
            jogador = Opcoes.Tesoura;
            EscolhaJogador();
            EscolhaCpu();
            VerificarGanhador();

        }

        void EscolhaJogador()
        {
            switch(jogador)
            {
                case Opcoes.Pedra:
                    ImgEscolhaJogador.BackgroundImage = Image.FromFile("d:/pedra.png");
                    break;
                case Opcoes.Papel:
                    ImgEscolhaJogador.BackgroundImage = Image.FromFile("d:/papel.png");
                    break;
                case Opcoes.Tesoura:
                    ImgEscolhaJogador.BackgroundImage = Image.FromFile("d:/tesoura.png");
                    break;

            }
        }

        void EscolhaCpu()
        {
            int numero = rdm.Next(1, 4);

            if(numero == 1)
            {
                cpu = Opcoes.Pedra;
                ImgEscolhaCpu.BackgroundImage = Image.FromFile("d:/pedra.png");
            }
            else if(numero == 2)
            {
                cpu = Opcoes.Papel;
                ImgEscolhaCpu.BackgroundImage = Image.FromFile("d:/papel.png");
            }
            else if(numero == 3)
            {
                cpu = Opcoes.Tesoura;
                ImgEscolhaCpu.BackgroundImage = Image.FromFile("d:/tesoura.png");
            }
        }
        void VerificarGanhador()
        {
            switch(jogador)
            {
                case Opcoes.Pedra:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.Empate;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.Cpu;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.Jogador;
                    break;

                case Opcoes.Papel:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.Jogador;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.Empate;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.Cpu;
                    break;

                case Opcoes.Tesoura:
                    if (cpu == Opcoes.Pedra)
                        ganhador = Resultado.Cpu;
                    else if (cpu == Opcoes.Papel)
                        ganhador = Resultado.Jogador;
                    else if (cpu == Opcoes.Tesoura)
                        ganhador = Resultado.Empate;
                    break;
            }
            if(ganhador == Resultado.Jogador)
            {
                grupoPlacar.BackColor = Color.Green;
                placarJogador.Text = (int.Parse(placarJogador.Text) + 1).ToString();
            }
            else if (ganhador == Resultado.Cpu)
            {
                grupoPlacar.BackColor = Color.Red;
                placarCpu.Text = (int.Parse(placarCpu.Text) + 1).ToString();
            }
            else
            {
                grupoPlacar.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
