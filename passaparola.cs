using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class passaparola : Form
    {
        public passaparola()
        {
            InitializeComponent();
        }
        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btntry_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms[0] == this)//Uygulamanin main form'u
            {
                //uygulamanin ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                Application.Restart();
            }
            else
            {
                passaparola f = new passaparola();
                f.Show();
                this.Close();
            }
        }

        private void txtCevap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCevap.Enabled = false;
                switch (soruNo)
                {
                    case 1:
                        if (txtCevap.Text.ToLower() == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (txtCevap.Text.ToLower() == "beyaz")
                        {
                            button2.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (txtCevap.Text.ToLower() == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (txtCevap.Text.ToLower() == "denizli")
                        {
                            button4.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (txtCevap.Text.ToLower() == "element")
                        {
                            button5.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (txtCevap.Text.ToLower() == "flüt")
                        {
                            button6.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (txtCevap.Text.ToLower() == "galya")
                        {
                            button7.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (txtCevap.Text.ToLower() == "halı")
                        {
                            button8.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (txtCevap.Text.ToLower() == "ırak")
                        {
                            button9.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (txtCevap.Text.ToLower() == "kasa")
                        {
                            button10.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (txtCevap.Text.ToLower() == "lale")
                        {
                            button11.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (txtCevap.Text.ToLower() == "mars")
                        {
                            button12.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (txtCevap.Text.ToLower() == "nal")
                        {
                            button13.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (txtCevap.Text.ToLower() == "olay")
                        {
                            button14.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (txtCevap.Text.ToLower() == "pil")
                        {
                            button15.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (txtCevap.Text.ToLower() == "rıhtım")
                        {
                            button16.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (txtCevap.Text.ToLower() == "salise")
                        {
                            button17.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (txtCevap.Text.ToLower() == "tersane")
                        {
                            button18.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (txtCevap.Text.ToLower() == "uganda")
                        {
                            button19.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (txtCevap.Text.ToLower() == "varis")
                        {
                            button20.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (txtCevap.Text.ToLower() == "yaprak")
                        {
                            button21.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (txtCevap.Text.ToLower() == "zerde")
                        {
                            button22.BackColor = Color.Green;
                            btnHarff.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            btnHarff.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            txtCevap.Focus();
            txtCevap.Enabled = true;
            btnBasla.Text = "Sonraki Soru";
            txtCevap.Clear();

            soruNo++;
            this.Text = soruNo.ToString() + ". Soru";



            if (soruNo == 22)
            {
                btnBasla.Enabled = false;
                btnBasla.Visible = false;
                btntry.Visible = true;
            }
            switch (soruNo)
            {
                // System.Threading.Thread.Sleep(1000);
                case 1:
                    richTextBox1.Text = "Ülkemizin Güney Kısmındaki Bölgenin Adı ?"; //AKDENİZ
                    btnHarff.Text = "A";
                    button1.BackColor = Color.Yellow;
                    break;
                case 2:
                    richTextBox1.Text = "Karanın Zıttı?"; //BEYAZ
                    btnHarff.Text = "B";
                    button2.BackColor = Color.Yellow;
                    break;
                case 3:
                    richTextBox1.Text = "Müslümanların Kutsal Günü ?";//CUMA
                    btnHarff.Text = "C";
                    button3.BackColor = Color.Yellow;
                    break;
                case 4:
                    richTextBox1.Text = "Horozuyla Ünlü Şehrimiz ?";//DENİZLİ
                    btnHarff.Text = "D";
                    button4.BackColor = Color.Yellow;
                    break;
                case 5:
                    richTextBox1.Text = "Maddenin Tek Atomdan Oluşan Hali ?"; //ELEMENT
                    btnHarff.Text = "E";
                    button5.BackColor = Color.Yellow;
                    break;
                case 6:
                    richTextBox1.Text = "Üflemeli Bir Çalgı ?";// FLÜT
                    btnHarff.Text = "F";
                    button6.BackColor = Color.Yellow;
                    break;
                case 7:
                    richTextBox1.Text = "Macaristanda Küçük Bir Nehir ?"; //GALYA
                    btnHarff.Text = "G";
                    button7.BackColor = Color.Yellow;
                    break;
                case 8:
                    richTextBox1.Text = "Genellikle Yün veya İplikten Yapılan Sergi ?"; //halı
                    btnHarff.Text = "H";
                    button8.BackColor = Color.Yellow;
                    break;
                case 9:
                    richTextBox1.Text = "Yakın Olmayan ?"; //ırak
                    btnHarff.Text = "I";
                    button9.BackColor = Color.Yellow;
                    break;
                case 10:
                    richTextBox1.Text = "Değerli Eşya vb. Şeyleri Saklamak İçin Kullanılan Güvenli Kutu ?"; //kasa
                    btnHarff.Text = "K";
                    button10.BackColor = Color.Yellow;
                    break;
                case 11:
                    richTextBox1.Text = "Osmanlıda Bir Dönem Ünlü Olan Çiçek ?"; //lale
                    btnHarff.Text = "L";
                    button11.BackColor = Color.Yellow;
                    break;
                case 12:
                    richTextBox1.Text = "Uzaylı Denilince Akla Gelen İlk Gezegen ?"; //mars
                    btnHarff.Text = "M";
                    button12.BackColor = Color.Yellow;
                    break;
                case 13:
                    richTextBox1.Text = "Atın Ayakkabısı ?"; //NAL
                    btnHarff.Text = "N";
                    button13.BackColor = Color.Yellow;
                    break;
                case 14:
                    richTextBox1.Text = "ilgiyi Çeken ve Çekebilecek Olan Her Türlü Eylem ?"; //OLAY
                    btnHarff.Text = "O";
                    button14.BackColor = Color.Yellow;
                    break;
                case 15:
                    richTextBox1.Text = "Küçük Cihazların Elektrik İhtiyacını Karşıladığı İletken Metal ?"; //Pil
                    btnHarff.Text = "P";
                    button15.BackColor = Color.Yellow;
                    break;
                case 16:
                    richTextBox1.Text = "Deniz Taşıtlarının İndirme Bindirme Yapmaları, Yük Alıp Vermeleri İçin Yapılmış Yer ?"; //RIHTIM
                    btnHarff.Text = "R";
                    button16.BackColor = Color.Yellow;
                    break;
                case 17:
                    richTextBox1.Text = "Dakikanın 6000'de 1'i ?";//Salise
                    btnHarff.Text = "S";
                    button17.BackColor = Color.Yellow;
                    break;
                case 18:
                    richTextBox1.Text = "Gemi Yapılan Yer ?";//Tersane
                    btnHarff.Text = "T";
                    button18.BackColor = Color.Yellow;
                    break;
                case 19:
                    richTextBox1.Text = "Başkenti KAMPALA Olan Ülke ?";//Uganda
                    btnHarff.Text = "U";
                    button19.BackColor = Color.Yellow;
                    break;
                case 20:
                    richTextBox1.Text = "Toplardamarların Deri Altında Mavi Renkte, Genişlemiş ve Kıvrımlar Yapmış Olarak Görülmesi ?";//Varis
                    btnHarff.Text = "V";
                    button20.BackColor = Color.Yellow;
                    break;
                case 21:
                    richTextBox1.Text = "Bitkilerin Solunum Organı ?";//Yaprak
                    btnHarff.Text = "Y";
                    button21.BackColor = Color.Yellow;
                    break;
                case 22:
                    richTextBox1.Text = "Safranla Renk ve Koku Verilen, Şekerli, Bir Çeşit Pirinç Peltesi. ?";//Zerde
                    btnHarff.Text = "Z";
                    button22.BackColor = Color.Yellow;
                    break;
            }

        }
    }
}
