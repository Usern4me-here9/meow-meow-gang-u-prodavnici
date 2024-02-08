using System.ComponentModel;

namespace meow_meow_gang_u_prodavnici
{
    public partial class Form1 : Form
    {
        static int broj_proizvoda;
        static Proizvod[] proizvodi = new Proizvod[1000];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] proizvod_iz_fajla;

            listaProizvoda.Items.Clear();

            try
            {
                StreamReader Citac = new StreamReader("Baza_Podataka.mmgupsf");
                do
                {
                    proizvod_iz_fajla = Citac.ReadLine().Split(',');
                    proizvodi[broj_proizvoda] = new Proizvod(proizvod_iz_fajla[0], proizvod_iz_fajla[1], proizvod_iz_fajla[2]);
                    listaProizvoda.Items.Add(proizvodi[broj_proizvoda].LS_box());
                    broj_proizvoda++;
                }
                while (!Citac.EndOfStream);

                Citac.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Array.Resize(ref proizvodi,broj_proizvoda);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tekst_pretraga;

            listaProizvoda.Items.Clear();

            if (textBox1.Text == string.Empty || (!upc_pretraga.Checked && !ime_pretraga.Checked && !cena_pretraga.Checked))
            {
                for (int i = 0; i < broj_proizvoda; i++)
                {
                    listaProizvoda.Items.Add(proizvodi[i].LS_box());
                }
                return;
            }

            tekst_pretraga = textBox1.Text.ToLower();

            for (int i = 0; i < broj_proizvoda; i++)
            {
                if (upc_pretraga.Checked && proizvodi[i].UPC.StartsWith(tekst_pretraga))
                {
                    listaProizvoda.Items.Add(proizvodi[i].LS_box());
                    goto nop;
                }

                if (ime_pretraga.Checked && proizvodi[i].IME.StartsWith(tekst_pretraga))
                {
                    listaProizvoda.Items.Add(proizvodi[i].LS_box());
                    goto nop;
                }

                if (cena_pretraga.Checked && proizvodi[i].CENA.StartsWith(tekst_pretraga))
                {
                    listaProizvoda.Items.Add(proizvodi[i].LS_box());
                    goto nop;
                }
            nop: System.Threading.Thread.Sleep(1);

            }


        }

        private void upc_pretraga_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void ime_pretraga_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void cena_pretraga_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            upc_pretraga.Checked = false;
            ime_pretraga.Checked = false;
            cena_pretraga.Checked = false;
        }

        private void sortiraj_Click(object sender, EventArgs e)
        {
            listaProizvoda.Items.Clear();

            if (rastuce_radio.Checked)
            {
                Array.Sort(proizvodi);
            }
            else if (opadajuce_radio.Checked)
            {
                Array.Sort(proizvodi);
                Array.Reverse(proizvodi);
            }

            for (int i = 0; i < broj_proizvoda; i++)
            {
                listaProizvoda.Items.Add(proizvodi[i].LS_box());
            }
        }
    }
}