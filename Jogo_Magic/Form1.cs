using System;
using System.Windows.Forms;
using System.Drawing;

namespace Jogo_Magic
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// region Variáveis
        /// </summary>
        private int contadorCartas = 0;
       
        /// <summary>
        /// region Método Construtor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// region Métodos do Posicionamento
        /// </summary>
        private void baralhoTSM_Click(object sender, EventArgs e)
        {
            carta1TSM.Enabled = false;
            carta2TSM.Enabled = false;
            carta3TSM.Enabled = false;
            carta4TSM.Enabled = false;
            carta5TSM.Enabled = false;
            carta6TSM.Enabled = false;
            carta7TSM.Enabled = false;
            //força a escolher a carta sequencial para serem 7 ao todo

            switch (contadorCartas)
            {
                case 0:
                    carta1TSM.Enabled = true;
                    break;
                case 1:
                    carta2TSM.Enabled = true;
                    break;
                case 2:
                    carta3TSM.Enabled = true;
                    break;
                case 3:
                    carta4TSM.Enabled = true;
                    break;
                case 4:
                    carta5TSM.Enabled = true;
                    break;
                case 5:
                    carta6TSM.Enabled = true;
                    break;
                case 6:
                    carta7TSM.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private Form EstaCarta()
        {
            Form carta = new Form();
            carta.WindowState = FormWindowState.Normal;
            carta.Size = new Size(180, 400);
            carta.MdiParent = this;   //estabelece o container
            carta.Dock = DockStyle.Left;  //estabelece o layout lado a lado
            return carta;
        }

        /// <summary>
        /// Métodos dos Controlos
        /// </summary>
        private void elfo1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();  //retorna um form do tamanho certo para caberem 7 dentro do container
            carta1 = CartaElfo(carta1);  //envia o form para o método que desenha a carta elfo
            carta1.Show();    //apresenta a primeira carta
            contadorCartas++; //força a escolher a carta seguinte
        }

        private void guerreiro1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();
            carta1 = CartaGuerreiro(carta1);
            carta1.Show();
            contadorCartas++;
        }

        private void tritao1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();
            carta1 = CartaTritao(carta1);
            carta1.Show();
            contadorCartas++;
        }

        private void elixir1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();
            carta1 = CartaElixir(carta1);
            carta1.Show();
            contadorCartas++;
        }

        private void sorte1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();
            carta1 = CartaSorte(carta1);
            carta1.Show();
            contadorCartas++;
        }

        private void encantamento1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();
            carta1 = CartaEncantamento(carta1);
            carta1.Show();
            contadorCartas++;
        }

        private void terreno1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();  
            carta1 = CartaTerreno(carta1);  
            carta1.Show();    
            contadorCartas++; 
        }

        private void magica1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();
            carta1 = CartaMagica(carta1);
            carta1.Show();
            contadorCartas++;
        }

        private void feitico1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();
            carta1 = CartaFeitico(carta1);
            carta1.Show();
            contadorCartas++;
        }

        private void elfo2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();  
            carta2 = CartaElfo(carta2);  
            carta2.Show();    
            contadorCartas++; 
        }

        private void guerreiro2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();
            carta2 = CartaGuerreiro(carta2);
            carta2.Show();
            contadorCartas++;
        }

        private void tritao2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();
            carta2 = CartaTritao(carta2);
            carta2.Show();
            contadorCartas++;
        }

        private void elixir2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();
            carta2 = CartaElixir(carta2);
            carta2.Show();
            contadorCartas++;
        }

        private void sorte2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();
            carta2 = CartaSorte(carta2);
            carta2.Show();
            contadorCartas++;
        }

        private void encantamento2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();
            carta2 = CartaEncantamento(carta2);
            carta2.Show();
            contadorCartas++;
        }

        private void terreno2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();
            carta2 = CartaTerreno(carta2);
            carta2.Show();
            contadorCartas++;
        }

        private void magica2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();
            carta2 = CartaMagica(carta2);
            carta2.Show();
            contadorCartas++;
        }

        private void feitico2TSM_Click(object sender, EventArgs e)
        {
            Form carta2 = EstaCarta();
            carta2 = CartaFeitico(carta2);
            carta2.Show();
            contadorCartas++;
        }

        private void elfo3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaElfo(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void guerreiro3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaGuerreiro(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void tritao3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaTritao(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void elixir3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaElixir(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void sorte3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaSorte(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void encantamento3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaEncantamento(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void terreno3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaTerreno(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void magica3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaMagica(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void feitico3TSM_Click(object sender, EventArgs e)
        {
            Form carta3 = EstaCarta();
            carta3 = CartaFeitico(carta3);
            carta3.Show();
            contadorCartas++;
        }

        private void elfo4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaElfo(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void guerreiro4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaGuerreiro(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void tritao4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaTritao(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void elixir4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaElixir(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void sorte4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaSorte(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void encantamento4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaEncantamento(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void terreno4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaTerreno(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void magica4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaMagica(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void feitico4TSM_Click(object sender, EventArgs e)
        {
            Form carta4 = EstaCarta();
            carta4 = CartaFeitico(carta4);
            carta4.Show();
            contadorCartas++;
        }

        private void elfo5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaElfo(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void guerreiro5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaGuerreiro(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void tritao5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaTritao(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void elixir5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaElixir(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void sorte5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaSorte(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void encantamento5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaEncantamento(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void terreno5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaTerreno(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void magica5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaMagica(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void feitico5TSM_Click(object sender, EventArgs e)
        {
            Form carta5 = EstaCarta();
            carta5 = CartaFeitico(carta5);
            carta5.Show();
            contadorCartas++;
        }

        private void elfo6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaElfo(carta6);
            carta6.Show();
            contadorCartas++;
        }

        private void guerreiro6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaGuerreiro(carta6);
            carta6.Show();
            contadorCartas++;
        }

        private void tritao6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaTritao(carta6);
            carta6.Show();
            contadorCartas++;
        }

        private void elixir6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaElixir(carta6);
            carta6.Show();
            contadorCartas++;
        }

        private void sorte6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaSorte(carta6);
            carta6.Show();
            contadorCartas++;

        }

        private void encantamento6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaEncantamento(carta6);
            carta6.Show();
            contadorCartas++;
        }

        private void terreno6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaTerreno(carta6);
            carta6.Show();
            contadorCartas++;
        }

        private void magica6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaMagica(carta6);
            carta6.Show();
            contadorCartas++;
        }

        private void feitico6TSM_Click(object sender, EventArgs e)
        {
            Form carta6 = EstaCarta();
            carta6 = CartaFeitico(carta6);
            carta6.Show();
            contadorCartas++;
        }

        private void elfo7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaElfo(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void guerreiro7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaGuerreiro(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void tritao7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaTritao(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void elixir7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaElixir(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void sorte7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaSorte(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void encantamento7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaEncantamento(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void terreno7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaTerreno(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void magica7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaMagica(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void feitico7TSM_Click(object sender, EventArgs e)
        {
            Form carta7 = EstaCarta();
            carta7 = CartaFeitico(carta7);
            carta7.Show();
            contadorCartas++;
        }

        private void sairTSM_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// region Métodos das Classes
        /// </summary>
        private Form CartaElfo(Form carta)
        {
            Elfo elfo = new Elfo();
            carta.Text = elfo.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor = Color.FromName(elfo.CorCustoTerreno);
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 1);
            lbl1.Size = new Size(180, 100);
            lbl1.BackColor = Color.FromName(elfo.CorCarta);
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(0, 101);
            lbl2.Size = new Size(180, 20);
            lbl2.BackColor = Color.FromName("LightSteelBlue");
            lbl2.Text = elfo.TipoCarta;
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(115, 126);
            lbl3.Size = new Size(20, 20);
            lbl3.ForeColor = Color.FromName("DimGray");
            lbl3.BorderStyle = BorderStyle.FixedSingle;
            lbl3.Text = elfo.CustoGeral.ToString();
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(140, 126);
            lbl4.Size = new Size(20, 20);
            lbl4.Text = elfo.CustoTerreno.ToString();
            lbl4.BorderStyle = BorderStyle.FixedSingle;
            lbl4.ForeColor = Color.FromName(elfo.CorCarta);
            Label lbl8 = new Label();
            carta.Controls.Add(lbl8);
            lbl8.Location = new Point(2, 333);
            lbl8.Size = new Size(100, 20);
            lbl8.Text = "Ataque /";
            Label lbl5 = new Label();
            carta.Controls.Add(lbl5);
            lbl5.Location = new Point(2, 355);
            lbl5.Size = new Size(110, 20);
            lbl5.Text = "Resistência:";
            Label lbl6 = new Label();
            carta.Controls.Add(lbl6);
            lbl6.Location = new Point(115, 350);
            lbl6.Size = new Size(20,20);
            lbl6.BorderStyle = BorderStyle.FixedSingle;
            lbl6.ForeColor = Color.FromName("DimGray");
            lbl6.Text = elfo.PontosDano.ToString();
            Label lbl7 = new Label();
            carta.Controls.Add(lbl7);
            lbl7.Location = new Point(140, 350);
            lbl7.Size = new Size(20, 20);
            lbl7.BorderStyle = BorderStyle.FixedSingle;
            lbl7.ForeColor = Color.FromName("DimGray");
            lbl7.Text = elfo.PontosResist.ToString();
            return carta;
        }

        private Form CartaGuerreiro(Form carta)
        {
            Guerreiro guerreiro = new Guerreiro();
            carta.Text = guerreiro.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor = Color.FromName(guerreiro.CorCustoTerreno);
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 1);
            lbl1.Size = new Size(180, 100);
            lbl1.BackColor = Color.FromName(guerreiro.CorCarta);
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(0, 101);
            lbl2.Size = new Size(180, 20);
            lbl2.BackColor = Color.FromName("LightSteelBlue");
            lbl2.Text = guerreiro.TipoCarta;
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(115, 126);
            lbl3.Size = new Size(20, 20);
            lbl3.ForeColor = Color.FromName("DimGray");
            lbl3.BorderStyle = BorderStyle.FixedSingle;
            lbl3.Text = guerreiro.CustoGeral.ToString();
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(140, 126);
            lbl4.Size = new Size(20, 20);
            lbl4.Text = guerreiro.CustoTerreno.ToString();
            lbl4.BorderStyle = BorderStyle.FixedSingle;
            lbl4.ForeColor = Color.FromName(guerreiro.CorCarta);
            Label lbl8 = new Label();
            carta.Controls.Add(lbl8);
            lbl8.Location = new Point(2, 333);
            lbl8.Size = new Size(100, 20);
            lbl8.Text = "Ataque /";
            Label lbl5 = new Label();
            carta.Controls.Add(lbl5);
            lbl5.Location = new Point(2, 355);
            lbl5.Size = new Size(110, 20);
            lbl5.Text = "Resistência:";
            Label lbl6 = new Label();
            carta.Controls.Add(lbl6);
            lbl6.Location = new Point(115, 350);
            lbl6.Size = new Size(20, 20);
            lbl6.BorderStyle = BorderStyle.FixedSingle;
            lbl6.ForeColor = Color.FromName("DimGray");
            lbl6.Text = guerreiro.PontosDano.ToString();
            Label lbl7 = new Label();
            carta.Controls.Add(lbl7);
            lbl7.Location = new Point(140, 350);
            lbl7.Size = new Size(20, 20);
            lbl7.BorderStyle = BorderStyle.FixedSingle;
            lbl7.ForeColor = Color.FromName("DimGray");
            lbl7.Text = guerreiro.PontosResist.ToString();
            return carta;
        }

        private Form CartaTritao(Form carta)
        {
            Tritao tritao = new Tritao();
            carta.Text = tritao.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor = Color.FromName(tritao.CorCustoTerreno);
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 1);
            lbl1.Size = new Size(180, 100);
            lbl1.BackColor = Color.FromName(tritao.CorCarta);
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(0, 101);
            lbl2.Size = new Size(180, 20);
            lbl2.BackColor = Color.FromName("LightSteelBlue");
            lbl2.Text = tritao.TipoCarta;
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(115, 126);
            lbl3.Size = new Size(20, 20);
            lbl3.ForeColor = Color.FromName("DimGray");
            lbl3.BorderStyle = BorderStyle.FixedSingle;
            lbl3.Text = tritao.CustoGeral.ToString();
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(140, 126);
            lbl4.Size = new Size(20, 20);
            lbl4.Text = tritao.CustoTerreno.ToString();
            lbl4.BorderStyle = BorderStyle.FixedSingle;
            lbl4.ForeColor = Color.FromName(tritao.CorCarta);
            Label lbl8 = new Label();
            carta.Controls.Add(lbl8);
            lbl8.Location = new Point(2, 333);
            lbl8.Size = new Size(100, 20);
            lbl8.Text = "Ataque /";
            Label lbl5 = new Label();
            carta.Controls.Add(lbl5);
            lbl5.Location = new Point(2, 355);
            lbl5.Size = new Size(110, 20);
            lbl5.Text = "Resistência:";
            Label lbl6 = new Label();
            carta.Controls.Add(lbl6);
            lbl6.Location = new Point(115, 350);
            lbl6.Size = new Size(20, 20);
            lbl6.BorderStyle = BorderStyle.FixedSingle;
            lbl6.ForeColor = Color.FromName("DimGray");
            lbl6.Text = tritao.PontosDano.ToString();
            Label lbl7 = new Label();
            carta.Controls.Add(lbl7);
            lbl7.Location = new Point(140, 350);
            lbl7.Size = new Size(20, 20);
            lbl7.BorderStyle = BorderStyle.FixedSingle;
            lbl7.ForeColor = Color.FromName("DimGray");
            lbl7.Text = tritao.PontosResist.ToString();
            return carta;
        }

        private Form CartaElixir(Form carta)
        {
            Elixir elixir = new Elixir();
            carta.Text = elixir.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor = Color.FromName("LightPink");
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 101);
            lbl1.Size = new Size(180, 20);
            lbl1.BackColor = Color.FromName("LightSteelBlue");
            lbl1.Text = elixir.TipoCarta;
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(140,126);
            lbl2.Size = new Size(20, 20);
            lbl2.ForeColor = Color.FromName("DimGray");
            lbl2.BorderStyle = BorderStyle.FixedSingle;
            lbl2.Text = elixir.CustoGeral.ToString();
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(2,200);
            lbl3.Size = new Size(100,20);
            lbl3.Text = "Efeito 1:";
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(2,230);
            lbl4.Size = new Size(175,100);
            lbl4.Text = elixir.Efeito1.ToString();
            return carta;
        }

        private Form CartaSorte(Form carta)
        {
            Sorte sorte = new Sorte();
            carta.Text = sorte.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor = Color.FromName("Orange");
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 101);
            lbl1.Size = new Size(180, 20);
            lbl1.BackColor = Color.FromName("LightSteelBlue");
            lbl1.Text = sorte.TipoCarta;
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(140, 126);
            lbl2.Size = new Size(20, 20);
            lbl2.ForeColor = Color.FromName("DimGray");
            lbl2.BorderStyle = BorderStyle.FixedSingle;
            lbl2.Text = sorte.CustoGeral.ToString();
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(2, 160);
            lbl3.Size = new Size(100, 20);
            lbl3.Text = "Efeito 1:";
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(2, 190);
            lbl4.Size = new Size(170,90);
            lbl4.Text = sorte.Efeito1.ToString();
            Label lbl5 = new Label();
            carta.Controls.Add(lbl5);
            lbl5.Location = new Point(2, 290);
            lbl5.Size = new Size(100, 20);
            lbl5.Text = "Efeito 2:";
            Label lbl6 = new Label();
            carta.Controls.Add(lbl6);
            lbl6.Location = new Point(2, 320);
            lbl6.Size = new Size(170, 50);
            lbl6.Text = sorte.Efeito2.ToString();
            return carta;
        }

        private Form CartaEncantamento(Form carta)
        {
            Encantamento encantamento = new Encantamento();
            carta.Text = encantamento.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor = Color.FromName(encantamento.CorCustoTerreno);
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 1);
            lbl1.Size = new Size(180, 100);
            lbl1.BackColor = Color.FromName(encantamento.CorCarta);
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(0, 101);
            lbl2.Size = new Size(180, 20);
            lbl2.BackColor = Color.FromName("LightSteelBlue");
            lbl2.Text = encantamento.TipoCarta;
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(140, 126);
            lbl3.Size = new Size(20, 20);
            lbl3.ForeColor = Color.FromName("DimGray");
            lbl3.BorderStyle = BorderStyle.FixedSingle;
            lbl3.Text = encantamento.CustoGeral.ToString();
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(2, 160);
            lbl4.Size = new Size(100, 20);
            lbl4.Text = "Efeito 1:";
            Label lbl5 = new Label();
            carta.Controls.Add(lbl5);
            lbl5.Location = new Point(2, 190);
            lbl5.Size = new Size(175, 60);
            lbl5.Text = encantamento.Efeito1.ToString();
            Label lbl6 = new Label();
            carta.Controls.Add(lbl6);
            lbl6.Location = new Point(2, 270);
            lbl6.Size = new Size(100, 20);
            lbl6.Text = "Efeito 2:";
            Label lbl7 = new Label();
            carta.Controls.Add(lbl7);
            lbl7.Location = new Point(2, 300);
            lbl7.Size = new Size(175, 60);
            lbl7.Text = encantamento.Efeito2.ToString();
            return carta;
        }

        private Form CartaTerreno(Form carta)
        {
            Terreno terreno = new Terreno();
            carta.Text = terreno.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor= Color.FromName(terreno.CorTerreno);
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 1);
            lbl1.Size = new Size(180, 100);
            lbl1.BackColor = Color.FromName(terreno.CorCarta);
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(0, 101);
            lbl2.Size = new Size(180, 20);
            lbl2.BackColor = Color.FromName("LightSteelBlue");
            lbl2.Text = terreno.TipoCarta;
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(20, 230);
            lbl3.Size = new Size(100, 20);
            lbl3.Text = "Qtt mana:";
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(140, 230);
            lbl4.Size = new Size(20, 20);
            lbl4.Text = terreno.QttMana.ToString();
            return carta;
        }

        private Form CartaMagica(Form carta)
        {
            Magica magica = new Magica();
            carta.Text = magica.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor = Color.FromName("Plum");
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 101);
            lbl1.Size = new Size(180, 20);
            lbl1.BackColor = Color.FromName("LightSteelBlue");
            lbl1.Text = magica.TipoCarta;
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(140, 126);
            lbl2.Size = new Size(20, 20);
            lbl2.ForeColor = Color.FromName("DimGray");
            lbl2.BorderStyle = BorderStyle.FixedSingle;
            lbl2.Text = magica.CustoGeral.ToString();
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(2, 200);
            lbl3.Size = new Size(100, 20);
            lbl3.Text = "Efeito 1:";
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(2, 230);
            lbl4.Size = new Size(173, 90);
            lbl4.Text = magica.Efeito1.ToString();
            return carta;
        }

        private Form CartaFeitico(Form carta)
        {
            Feitico feitico = new Feitico();
            carta.Text = feitico.NomeCarta;
            carta.ShowIcon = false;
            carta.ControlBox = false;
            carta.BackColor = Color.FromName(feitico.CorCustoTerreno);
            Label lbl1 = new Label();
            carta.Controls.Add(lbl1);
            lbl1.Location = new Point(0, 1);
            lbl1.Size = new Size(180, 100);
            lbl1.BackColor = Color.FromName(feitico.CorCarta);
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(0, 101);
            lbl2.Size = new Size(175, 20);
            lbl2.BackColor = Color.FromName("LightSteelBlue");
            lbl2.Text = feitico.TipoCarta;
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(140, 126);
            lbl4.Size = new Size(20, 20);
            lbl4.Text = feitico.CustoTerreno.ToString();
            lbl4.BorderStyle = BorderStyle.FixedSingle;
            lbl4.ForeColor = Color.FromName(feitico.CorCarta);
            Label lbl5 = new Label();
            carta.Controls.Add(lbl5);
            lbl5.Location = new Point(2, 200);
            lbl5.Size = new Size(100, 20);
            lbl5.Text = "Efeito 1:";
            Label lbl6 = new Label();
            carta.Controls.Add(lbl6);
            lbl6.Location = new Point(1, 230);
            lbl6.Size = new Size(170, 150);
            lbl6.Text = feitico.Efeito1.ToString();
            return carta;
        }
    }
}
