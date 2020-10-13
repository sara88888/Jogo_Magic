using System;
using System.Windows.Forms;
using System.Drawing;

namespace Jogo_Magic
{
    public partial class Form1 : Form
    {
        int contadorCartas = 0;

        public Form1()
        {
            InitializeComponent();
        }

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
                case 7:
                    break;
            }
        }

        private void carta1TSM_Click(object sender, EventArgs e)
        {

        }

        private void criatura1TSM_Click(object sender, EventArgs e)
        {
            //artefacto1TSM.Enabled = false;
            //encantamento1TSM.Enabled = false;
            //terreno1TSM.Enabled = false;
            //magica1TSM.Enabled = false;
            //feitico1TSM.Enabled = false;
        }

        private void elfo1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();  //retorna um form do tamanho certo para caberem 7 dentro do container
            carta1.MdiParent = this;    //estabelece o container
            this.LayoutMdi(MdiLayout.TileVertical);  //estabelece o modo de visualização
            //carta1 = CartaCriatura(carta1);   //envia o form para o método q desenha a carta criatura
            carta1 = CartaElfo(carta1);  //envia a carta para o método que desenha a carta elfo
            carta1.Show();    //apresenta a primeira carta
            contadorCartas++; //força a escolher a carta seguinte
        }


        private void terreno1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();  //retorna um form do tamanho certo para caberem 7 dentro do container
            carta1.MdiParent = this;    //estabelece o container
            this.LayoutMdi(MdiLayout.TileVertical);  //estabelece o modo de visualização
            carta1 = CartaTerreno(carta1);   //envia o form para o método q desenha a carta terreno
            carta1.Show();    //apresenta a primeira carta
            contadorCartas++; //força a escolher a carta seguinte
        }

        private Form EstaCarta()
        {
            Form carta = new Form();
            carta.WindowState = FormWindowState.Normal;
            carta.Size = new Size(210, 450);
            return carta;
        }

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
            lbl1.Size = new Size(210, 150);
            lbl1.BackColor = Color.FromName(elfo.CorCarta);
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(0, 151);
            lbl2.Size = new Size(210, 20);
            lbl2.BackColor = Color.FromName("LightSteelBlue");
            lbl2.Text = "Criatura";
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(145, 176);
            lbl3.Size = new Size(20, 20);
            lbl3.ForeColor = Color.FromName("DimGray");
            lbl3.BorderStyle = BorderStyle.FixedSingle;
            lbl3.Text = elfo.CustoGeral.ToString();
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(170, 176);
            lbl4.Size = new Size(20, 20);
            lbl4.Text = elfo.CustoTerreno.ToString();
            lbl4.BorderStyle = BorderStyle.FixedSingle;
            lbl4.ForeColor = Color.FromName(elfo.CorCarta);
            Label lbl8 = new Label();
            carta.Controls.Add(lbl8);
            lbl8.Location = new Point(2, 363);
            lbl8.Size = new Size(100, 20);
            lbl8.Text = "Ataque /";
            Label lbl5 = new Label();
            carta.Controls.Add(lbl5);
            lbl5.Location = new Point(2, 385);
            lbl5.Size = new Size(125, 20);
            lbl5.Text = "Resistência:";
            Label lbl6 = new Label();
            carta.Controls.Add(lbl6);
            lbl6.Location = new Point(145, 385);
            lbl6.Size = new Size(20,20);
            lbl6.BorderStyle = BorderStyle.FixedSingle;
            lbl6.ForeColor = Color.FromName("DimGray");
            lbl6.Text = elfo.PontosDano.ToString();
            Label lbl7 = new Label();
            carta.Controls.Add(lbl7);
            lbl7.Location = new Point(170, 385);
            lbl7.Size = new Size(20, 20);
            lbl7.BorderStyle = BorderStyle.FixedSingle;
            lbl7.ForeColor = Color.FromName("DimGray");
            lbl7.Text = elfo.PontosResist.ToString();
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
            lbl1.Size = new Size(210, 150);
            lbl1.BackColor = Color.FromName(terreno.CorCarta);
            Label lbl2 = new Label();
            carta.Controls.Add(lbl2);
            lbl2.Location = new Point(0, 151);
            lbl2.Size = new Size(210, 20);
            lbl2.BackColor = Color.FromName("LightSteelBlue");
            lbl2.Text = "Terreno";
            Label lbl3 = new Label();
            carta.Controls.Add(lbl3);
            lbl3.Location = new Point(20, 300);
            lbl3.Size = new Size(100, 20);
            lbl3.Text = "Qtt mana:";
            Label lbl4 = new Label();
            carta.Controls.Add(lbl4);
            lbl4.Location = new Point(140, 300);
            lbl4.Size = new Size(20, 20);
            lbl4.Text = terreno.QttMana.ToString();
            return carta;
        }

        //private Form CartaCriatura(Form carta)
        //{
        //    Criatura criatura = new Criatura();
        //    carta.ShowIcon = false;
        //    carta.ControlBox = false;
        //    carta.BackColor = Color.FromName(criatura.CorCustoTerreno);
        //    Label lbl1 = new Label();
        //    carta.Controls.Add(lbl1);
        //    lbl1.Location = new Point(0, 1);
        //    lbl1.Size = new Size(210, 150);
        //    lbl1.BackColor = Color.FromName(criatura.CorCarta);
        //    Label lbl2 = new Label();
        //    carta.Controls.Add(lbl2);
        //    lbl2.Location = new Point(0, 151);
        //    lbl2.Size = new Size(210, 20);
        //    lbl2.BackColor = Color.FromName("LightSteelBlue");
        //    lbl2.Text = "Criatura";
        //    Label lbl3 = new Label();
        //    carta.Controls.Add(lbl3);
        //    lbl3.Location = new Point(0, 430);
        //    lbl3.Size = new Size(150, 20);
        //    lbl3.Text = "Ataque/Resistência:";
        //    Label lbl4 = new Label();
        //    carta.Controls.Add(lbl4);
        //    lbl4.Location = new Point(160, 430);
        //    lbl4.Size = new Size(20, 20);
        //    lbl4.BorderStyle = BorderStyle.FixedSingle;
        //    lbl4.Text = criatura.PontosDano.ToString();
        //    Label lbl5 = new Label();
        //    carta.Controls.Add(lbl5);
        //    lbl5.Location = new Point(185, 430);
        //    lbl5.Size = new Size(20, 20);
        //    lbl5.Text = criatura.PontosResist.ToString();
        //    return carta;
        //}

        private void sairTSM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
