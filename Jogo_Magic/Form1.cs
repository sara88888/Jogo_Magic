using System;
using System.Windows.Forms;
using System.Drawing;

namespace Jogo_Magic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairTSM_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carta1TSM_Click(object sender, EventArgs e)
        {
            carta2TSM.Enabled = false;
            carta3TSM.Enabled = false;
            carta4TSM.Enabled = false;
            carta5TSM.Enabled = false;
            carta6TSM.Enabled = false;
            carta7TSM.Enabled = false;
        }
       
        private void terreno1TSM_Click(object sender, EventArgs e)
        {
            Form carta1 = EstaCarta();
            carta1.MdiParent = this;
            this.LayoutMdi(MdiLayout.TileVertical);
            carta1 = CartaTerreno(carta1);
            carta1.Show();
            carta1TSM.Enabled = false;
            carta2TSM.Enabled = true;
        }

        private Form EstaCarta()
        {
            Form carta = new Form();
            carta.WindowState = FormWindowState.Normal;
            carta.Size = new Size(210, 450);
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

        private void criatura1TSM_Click(object sender, EventArgs e)
        {

        }
    }
}
