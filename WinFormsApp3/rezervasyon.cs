using System;

namespace WinFormsApp3
{
    public partial class rezervasyon : Form
    {
        public int ucakYolcuKapasitesi = 88;
        Dictionary<string, List<string>> countriesCities = new Dictionary<string, List<string>>()
        {
            {"Turkey", new List<string>{"Istanbul", "Ankara", "Izmir"}},
            {"USA", new List<string>{"New York", "Los Angeles", "Chicago"}},
            {"Germany", new List<string>{"Berlin", "Munich", "Hamburg"}},
        };

        Dictionary<string, List<string>> citiesAirports = new Dictionary<string, List<string>>()
        {
            {"Istanbul", new List<string>{"Istanbul Airport", "Sabiha Gökçen Airport"}},
            {"Ankara", new List<string>{"Esenboga Airport"}},
            {"Izmir", new List<string>{"Adnan Menderes Airport"}},
            {"New York", new List<string>{"John F. Kennedy Airport", "LaGuardia Airport"}},
            {"Los Angeles", new List<string>{"Los Angeles International Airport"}},
            {"Chicago", new List<string>{"O'Hare International Airport", "Chicago Midway International Airport"}},
            {"Berlin", new List<string>{"Berlin Tegel Airport", "Berlin Schönefeld Airport"}},
            {"Munich", new List<string>{"Munich Airport"}},
            {"Hamburg", new List<string>{"Hamburg Airport"}},
        };

        Dictionary<string, bool> airportStatus = new Dictionary<string, bool>()
        {
            {"Istanbul Airport", true},
            {"Sabiha Gökçen Airport", false},
            {"Esenboga Airport", true},
            {"Adnan Menderes Airport", false},
            {"John F. Kennedy Airport", true},
            {"LaGuardia Airport", false},
            {"Los Angeles International Airport", true},
            {"O'Hare International Airport", false},
            {"Chicago Midway International Airport", true},
            {"Berlin Tegel Airport", false},
            {"Berlin Schönefeld Airport", true},
            {"Munich Airport", true},
            {"Hamburg Airport", false},
        };




        public rezervasyon()
        {

            InitializeComponent();

            cbCountry.Items.AddRange(new object[] { "Turkey", "USA", "Germany" });
            cbCountry2.Items.AddRange(new object[] { "Turkey", "USA", "Germany" });

            //yeni ucak modelleri
            ucak ucak1 = new ucak();
            ucak1.model = "Boeing 737";
            ucak1.yolcuKapasitesi = 162;
            ucak1.seriNo = "abcd123456789";
            ucak1.bakımTarihi = "5/10/23";

            ucak ucak2 = new ucak();
            ucak2.model = "AIRBUS A330";
            ucak2.yolcuKapasitesi = 268;
            ucak2.bakımTarihi = "1/10/23";
            ucak2.seriNo = "73248758235abcd";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label11.Text = ucakYolcuKapasitesi.ToString();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // diğer comboboxları temizle ve false yap
            cbCity.Items.Clear();
            cbCity.Enabled = false;
            cbAirport.Items.Clear();
            cbAirport.Enabled = false;
            lblAirportStatus.Text = "";

            // şehirleri ülkelere göre comboboxlara doldurma
            if (cbCountry.SelectedItem != null)
            {
                cbCity.Items.AddRange(countriesCities[cbCountry.SelectedItem.ToString()].ToArray());
                cbCity.Enabled = true;
            }
        }

        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // havaalanları combobox temizlik ve false yapma
            cbAirport.Items.Clear();
            cbAirport.Enabled = false;
            lblAirportStatus.Text = "";

            // havaalanlarını şehirlere göre doldurma
            if (cbCity.SelectedItem != null)
            {
                cbAirport.Items.AddRange(citiesAirports[cbCity.SelectedItem.ToString()].ToArray());
                cbAirport.Enabled = true;
            }
        }

        private void cmbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            // havaalanlarının durumunu gösterme
            if (cbAirport.SelectedItem != null)
            {
                bool status = airportStatus[cbAirport.SelectedItem.ToString()];
                lblAirportStatus.Text = status ? "Açık" : "Kapalı";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblAirportStatus.Text == "Kapalı")
            {
                MessageBox.Show("Lütfen açık Havaalanı seçiniz");

            }
            else if (string.IsNullOrEmpty(ad.Text) || string.IsNullOrEmpty(soyad.Text))
            {
                MessageBox.Show("Ad Soyad giriniz.");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen cinsiyet giriniz.");
            }
            else if (label8.Text == "Seçilmedi")
            {
                MessageBox.Show("Lütfen koltuk seçiniz.");
            }
            else if (string.IsNullOrEmpty(cbCountry.Text) && string.IsNullOrEmpty(cbCity.Text) && string.IsNullOrEmpty(cbAirport.Text))
            {
                MessageBox.Show("Lütfen rota seçiniz.");
            }
            else if (cbCity.Text == cbCity2.Text || cbAirport.Text == cbAirport2.Text)
            {
                MessageBox.Show("Aynı şehire uçuş yapamazsınız");
            }
            else if (string.IsNullOrEmpty(cbCountry2.Text) && string.IsNullOrEmpty(cbCity2.Text) && string.IsNullOrEmpty(cbAirport2.Text))
            {
                MessageBox.Show("Lütfen rota seçiniz.");
            }
            else
            {

                listBox1.Items.Add("Ad: " + ad.Text + " Soyad: " + soyad.Text + " Cinsiyet: " + comboBox1.Text + " Engelli: " + (engelli.Checked ? "evet" : "hayır ") + " Yaşlı: " + (yasli.Checked ? "evet" : "hayır ") + " Tarih: " + dateTimePicker1.Text + " Rota: " + cbCountry.Text + "  " + cbAirport.Text + " - " + cbCountry2.Text + " " + cbAirport2.Text + " " + "uçuşu " + label11.Text + " boş koltuk");
            }



        }
        private void myForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // form kapanınca butonu aktif etme
            button2.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // birden fazla form acılmaması icin butonu kapatma
            button2.Enabled = false;

            var myForm = new koltuk();
            myForm.FormClosing += myForm_FormClosing;
            myForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCountry2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCity2.Items.Clear();
            cbCity2.Enabled = false;
            cbAirport2.Items.Clear();
            cbAirport2.Enabled = false;
            lblAirportStatus2.Text = "";

            // şehirleri ülkelere göre comboboxlara doldurma
            if (cbCountry2.SelectedItem != null)
            {
                cbCity2.Items.AddRange(countriesCities[cbCountry2.SelectedItem.ToString()].ToArray());
                cbCity2.Enabled = true;
            }
        }

        private void cbAirport2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAirport2.SelectedItem != null)
            {
                bool status = airportStatus[cbAirport2.SelectedItem.ToString()];
                lblAirportStatus2.Text = status ? "Açık" : "Kapalı";
            }
        }

        private void cbCity2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // havaalanları combobox temizlik ve false yapma
            cbAirport2.Items.Clear();
            cbAirport2.Enabled = false;
            lblAirportStatus2.Text = "";

            // havaalanlarını şehirlere göre doldurma
            if (cbCity2.SelectedItem != null)
            {
                cbAirport2.Items.AddRange(citiesAirports[cbCity2.SelectedItem.ToString()].ToArray());
                cbAirport2.Enabled = true;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}