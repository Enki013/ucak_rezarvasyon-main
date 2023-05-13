using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class koltuk : Form
    {
        public koltuk()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {


            Button secilenButon = (Button)sender;  // Hangi butonun tıklandığını belirlemek için sender'a cast işlemi yapılır.
            string koltukNumarasi = secilenButon.Name.Replace("button_", "");  // buton isminden numarayı çıkarmak için "button_" texti silinir.

            // Ana forma koltuk numarasını aktarma
            rezervasyon anaForm = (rezervasyon)Application.OpenForms["rezervasyon"];
            anaForm.label8.Text = koltukNumarasi;
            anaForm.ucakYolcuKapasitesi--;
            anaForm.label11.Text = anaForm.ucakYolcuKapasitesi.ToString();

            this.Close();

        }

        private void koltuk_Load(object sender, EventArgs e)
        {
            //button isimlerine göre trim yapma ve stringe çevirme
            for (int i = 1; i <= 88; i++)
            {
                Button button = (Button)Controls.Find("button_" + i.ToString(), true)[0];
                button.Click += new EventHandler(Click);
            }
        }
        private void Buton_Click(object sender, EventArgs e)
        {

        }
        private void button_52_Click(object sender, EventArgs e)
        {
        }

        private void button_87_Click(object sender, EventArgs e)
        {
        }

        private void button_86_Click(object sender, EventArgs e)
        {
        }

        private void button_85_Click(object sender, EventArgs e)
        {
        }

        private void button_84_Click(object sender, EventArgs e)
        {
        }

        private void button_83_Click(object sender, EventArgs e)
        {
        }

        private void button_82_Click(object sender, EventArgs e)
        {
        }

        private void button_81_Click(object sender, EventArgs e)
        {
        }

        private void button_80_Click(object sender, EventArgs e)
        {
        }

        private void button_79_Click(object sender, EventArgs e)
        {
        }

        private void button_78_Click(object sender, EventArgs e)
        {
        }

        private void button_77_Click(object sender, EventArgs e)
        {
        }

        private void button_76_Click(object sender, EventArgs e)
        {
        }

        private void button_75_Click(object sender, EventArgs e)
        {
        }

        private void button_74_Click(object sender, EventArgs e)
        {
        }

        private void button_73_Click(object sender, EventArgs e)
        {
        }

        private void button_72_Click(object sender, EventArgs e)
        {
        }

        private void button_71_Click(object sender, EventArgs e)
        {
        }

        private void button_70_Click(object sender, EventArgs e)
        {
        }

        private void button_69_Click(object sender, EventArgs e)
        {
        }

        private void button_68_Click(object sender, EventArgs e)
        {
        }

        private void button_67_Click(object sender, EventArgs e)
        {
        }

        private void button_66_Click(object sender, EventArgs e)
        {
        }

        private void button_65_Click(object sender, EventArgs e)
        {
        }

        private void button_64_Click(object sender, EventArgs e)
        {
        }

        private void button_63_Click(object sender, EventArgs e)
        {
        }

        private void button_62_Click(object sender, EventArgs e)
        {
        }

        private void button_61_Click(object sender, EventArgs e)
        {
        }

        private void button_60_Click(object sender, EventArgs e)
        {
        }

        private void button_59_Click(object sender, EventArgs e)
        {
        }

        private void button_58_Click(object sender, EventArgs e)
        {
        }

        private void button_57_Click(object sender, EventArgs e)
        {
        }

        private void button_56_Click(object sender, EventArgs e)
        {
        }

        private void button_55_Click(object sender, EventArgs e)
        {
        }

        private void button_54_Click(object sender, EventArgs e)
        {
        }

        private void button_53_Click(object sender, EventArgs e)
        {
        }

        private void button_88_Click(object sender, EventArgs e)
        {
        }

        private void button_51_Click(object sender, EventArgs e)
        {
        }

        private void button_50_Click(object sender, EventArgs e)
        {
        }

        private void button_49_Click(object sender, EventArgs e)
        {
        }

        private void button_48_Click(object sender, EventArgs e)
        {
        }

        private void button_47_Click(object sender, EventArgs e)
        {
        }

        private void button_46_Click(object sender, EventArgs e)
        {
        }

        private void button_45_Click(object sender, EventArgs e)
        {
        }

        private void button_44_Click(object sender, EventArgs e)
        {
        }

        private void button_43_Click(object sender, EventArgs e)
        {
        }

        private void button_42_Click(object sender, EventArgs e)
        {
        }

        private void button_41_Click(object sender, EventArgs e)
        {
        }

        private void button_40_Click(object sender, EventArgs e)
        {
        }

        private void button_39_Click(object sender, EventArgs e)
        {
        }

        private void button_38_Click(object sender, EventArgs e)
        {
        }

        private void button_37_Click(object sender, EventArgs e)
        {
        }

        private void button_36_Click(object sender, EventArgs e)
        {
        }

        private void button_35_Click(object sender, EventArgs e)
        {
        }

        private void button_34_Click(object sender, EventArgs e)
        {
        }

        private void button_33_Click(object sender, EventArgs e)
        {
        }

        private void button_32_Click(object sender, EventArgs e)
        {
        }

        private void button_31_Click(object sender, EventArgs e)
        {
        }

        private void button_30_Click(object sender, EventArgs e)
        {
        }

        private void button_29_Click(object sender, EventArgs e)
        {
        }

        private void button_28_Click(object sender, EventArgs e)
        {
        }

        private void button_27_Click(object sender, EventArgs e)
        {
        }

        private void button_26_Click(object sender, EventArgs e)
        {
        }

        private void button_25_Click(object sender, EventArgs e)
        {
        }

        private void button_24_Click(object sender, EventArgs e)
        {
        }

        private void button_23_Click(object sender, EventArgs e)
        {
        }

        private void button_22_Click(object sender, EventArgs e)
        {
        }

        private void button_21_Click(object sender, EventArgs e)
        {
        }

        private void button_20_Click(object sender, EventArgs e)
        {
        }

        private void button_19_Click(object sender, EventArgs e)
        {
        }

        private void button_18_Click(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void button_17_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void button_16_Click(object sender, EventArgs e)
        {
        }

        private void button_15_Click(object sender, EventArgs e)
        {
        }

        private void button_14_Click(object sender, EventArgs e)
        {
        }

        private void button_13_Click(object sender, EventArgs e)
        {
        }

        private void button_12_Click(object sender, EventArgs e)
        {
        }

        private void button_11_Click(object sender, EventArgs e)
        {
        }

        private void button_10_Click(object sender, EventArgs e)
        {
        }

        private void button_9_Click(object sender, EventArgs e)
        {
        }

        private void button_8_Click(object sender, EventArgs e)
        {
        }

        private void button_7_Click(object sender, EventArgs e)
        {
        }

        private void button_6_Click(object sender, EventArgs e)
        {
        }

        private void button_5_Click(object sender, EventArgs e)
        {
        }

        private void button_4_Click(object sender, EventArgs e)
        {
        }

        private void button_3_Click(object sender, EventArgs e)
        {
        }

        private void button_2_Click(object sender, EventArgs e)
        {
        }

        private void button_1_Click(object sender, EventArgs e)
        {

        }

        private void grpbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
