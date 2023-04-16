using System.Windows.Forms;

namespace ksıasıanav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            listBox1.Items.Add(sayi);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int toplam = 0;       // toplama yapmak için bu parametre girilmelidir
            foreach (int sayi in listBox1.Items) // listedeki sayıların toplamını hesaplar (her bir sayı için yapar)
            {
                toplam += sayi;        //toplama =0 demiştik aralıktaki sayıalrı giriyorurz şimdi
            }
            double ortalama = (double)toplam / listBox1.Items.Count;
            MessageBox.Show("Sayıların Ortalaması: " +ortalama.ToString());   // + operatörü mesajı başlıkta gösteriyor


        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    double toplam = 0;
        //    for (int i = 0; i<listBox1.Items.Count; i++)
        //    {
        //        toplam += Convert.ToDouble(listBox1.Items[i]);
        //    }

        //    double ortalamavirgul = (double)toplam / listBox1.Items.Count;
        //    MessageBox.Show("VİRGÜLLÜ SAYILARINIZIN ORTLAMASI : ", ortalamavirgul.ToString());

        //        }
        //    }
    }
}
