namespace Bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


            label7.Text = button2.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button3.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;


           

            label8.Text = button1.Text;
            if (label7.Text == label8.Text )
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            soruno++;
            label4.Text = soruno.ToString();

            pictureBox1.Visible = false;    // BU KOD SONRAKÝ BUTONUNA TIKLAYINCA GÖRÜNME ÖZELLÐÝNÝ PASÝF YAPIYOR.
            pictureBox2.Visible = false;

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yýlýnda Ýlan Edilmiþtir ?";
                button1.Text = "1920";
                button2.Text = "1922";
                button3.Text = "1923";
                button4.Text = "1924";
                label7.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi Ýl Ege Bölgesinde Bulunmaz ?";
                button1.Text = "Ýzmir";
                button2.Text = "Çanakkale";
                button3.Text = "Manisa";
                button4.Text = "Rize";
                label7.Text = "Rize";
            }
            if (soruno ==3)
            {
                richTextBox1.Text = "Amerikada Bir Türk Çoçuðu Romaný Kime Aittir ?";
                button1.Text = "Peyami Safa";
                button2.Text = "Sait Faik";
                button3.Text = "Cemal Süreya";
                button4.Text = "Atilla Ýlhan";
                label7.Text = "Peyami Safa";
                button5.Text = "Sonuclar";
            }
            if (soruno == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Doðru :" + dogru + "\n" + "Yanlýþ :" + yanlis );
            }
        
        
        }
    }
}