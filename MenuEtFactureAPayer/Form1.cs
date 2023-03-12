namespace MenuEtFactureAPayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1200;
            panel2.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LvMenu.Items.Clear();
            if (clb_Chaude.CheckedItems.Count != 0 || clb_Jus.CheckedItems.Count != 0 || clb_Patessrier.CheckedItems.Count != 0)
            {
                if (MessageBox.Show("Voulez vraiment confirmer votre demande", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Width = 1800;
                    panel2.Visible = true;
                    foreach (var i in clb_Chaude.CheckedItems)
                        LvMenu.Items.Add(i.ToString());

                    foreach (var i in clb_Patessrier.CheckedItems)
                        LvMenu.Items.Add(i.ToString());

                    foreach (var i in clb_Jus.CheckedItems)
                        LvMenu.Items.Add(i.ToString());

                }
            }
            else
            {
                MessageBox.Show("Veillez Choisir votre menu s'il vous plait","Info",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); ;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Width = 1200;
            panel2.Visible = false;
            LvMenu.Items.Clear();

            for (int i = 0; i < clb_Chaude.Items.Count; i++)
                clb_Chaude.SetItemChecked(i, false);

            for (int i = 0; i < clb_Jus.Items.Count; i++)
                clb_Jus.SetItemChecked(i, false);

            for (int i = 0; i < clb_Patessrier.Items.Count; i++)
                clb_Patessrier.SetItemChecked(i, false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Msg;
            if (rb_Cheque.Checked)
                Msg = "Cheque";
            else if (rb_Espece.Checked)
                Msg = "Espece";
            else Msg = "Carte Visa";

            if (MessageBox.Show($"Merci de choisir {Msg} Comme mode de paiment, Voulez vous Completer le paiement", "Paiement", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                MessageBox.Show("Merci le paiement est réussi","Paiement",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Le paiement n'est pas réussi", "Paiement", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
    }
}