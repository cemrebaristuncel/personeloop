using Sınıflar;
using System;
using System.Windows.Forms;

namespace oopornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            aciklamaLbl.Visible = false;
            if (radioButton1.Checked == true)
            {
                if (adTxt.Text != "" && maasTxt.Text != "" && sskNoTxt.Text != "" && zamTxt.Text != "")
                {
                    try
                    {
                        using (Calisan calisan = new Calisan())
                        {
                            calisan.Adi = adTxt.Text;
                            calisan.Maas = double.Parse(maasTxt.Text);
                            calisan.SskNo = double.Parse(sskNoTxt.Text);
                            calisan.ZamYap(double.Parse(zamTxt.Text));
                            listBox1.Items.Add(calisan.BilgiVer());
                        }
                    }
                    catch (Exception)
                    {
                        aciklamaLbl.Visible = true;
                        aciklamaLbl.Text = "Hatalı Giriş!";
                    }
                }
                else
                {
                    aciklamaLbl.Visible = true;
                    aciklamaLbl.Text = "Alanlar boş geçilemez!";
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (adTxt.Text != "" && maasTxt.Text != "" && sskNoTxt.Text != "" && zamTxt.Text != "" && ekstraZamTxt.Text != "")
                {
                    try
                    {
                        using (Mudur mudur = new Mudur())
                        {
                            mudur.Adi = adTxt.Text;
                            mudur.Maas = double.Parse(maasTxt.Text);
                            mudur.SskNo = double.Parse(sskNoTxt.Text);
                            mudur.DepartmanKar = double.Parse(ekstraZamTxt.Text);
                            mudur.ZamYap(double.Parse(zamTxt.Text));
                            listBox1.Items.Add(mudur.BilgiVer());
                        }
                    }
                    catch (Exception)
                    {
                        aciklamaLbl.Visible = true;
                        aciklamaLbl.Text = "Hatalı Giriş!";
                    }
                }
                else
                {
                    aciklamaLbl.Visible = true;
                    aciklamaLbl.Text = "Alanlar boş geçilemez!";
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (adTxt.Text != "" && maasTxt.Text != "" && sskNoTxt.Text != "" && zamTxt.Text != "" && ekstraZamTxt.Text != "")
                {
                    try
                    {
                        using (Satisci satisci = new Satisci())
                        {
                            satisci.Adi = adTxt.Text;
                            satisci.Maas = double.Parse(maasTxt.Text);
                            satisci.SskNo = double.Parse(sskNoTxt.Text);
                            satisci.SatisSayisi = double.Parse(ekstraZamTxt.Text);
                            satisci.ZamYap(double.Parse(zamTxt.Text));        
                            listBox1.Items.Add(satisci.BilgiVer());
                        }
                    }
                    catch (Exception)
                    {
                        aciklamaLbl.Visible = true;
                        aciklamaLbl.Text = "Hatalı Giriş!";
                    }
                }
                else
                {
                    aciklamaLbl.Visible = true;
                    aciklamaLbl.Text = "Alanlar boş geçilemez!";
                }
            }  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label5.Visible = false;
                ekstraZamTxt.Visible = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label5.Visible = true;
                label5.Text = "Departman Karı";
                ekstraZamTxt.Visible = true;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label5.Visible = true;
                label5.Text = "Satış Sayısı";
                ekstraZamTxt.Visible = true;
            }
        }
    }
}
