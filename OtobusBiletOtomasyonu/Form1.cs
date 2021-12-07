using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(CmbOtobus.Text)
            {
                case "Travego":KoltukDoldur(8, false);
                    break;

                case "Setra": KoltukDoldur(12,true);
                    break;

                case "Neoplan":KoltukDoldur(10, false);
                    break;

            }

            void KoltukDoldur(int sira , bool arkaBeslimi)
            {
                yavaslat:
                foreach(Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if(btn.Text == "Kaydet")
                        {
                            continue;
                        }else
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }
                    }
                }
                int koltukNo=1;
                for(int i = 0; i < sira; i++)
                {
                    for(int j = 0; j < 5; j++)
                    {
                        if(arkaBeslimi == true)
                        {
                            if (i != sira - 1 && j == 2)
                            {
                                continue;
                            }
                        } else
                        {
                            if (j == 2)
                                continue;
                        }
                      
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 10 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.Controls.Add(koltuk);
                    }
                }
            }
        }
        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CmbOtobus.SelectedIndex ==-1 || CmbNereye.SelectedIndex == -1 || CmbNereden.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce gerekli alanları doldurunuz!!", "Hata" ,MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return;
            }
            KayıtFormu kf = new KayıtFormu();
            DialogResult sonuc = kf.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = String.Format("{0} {1}" , kf.TxtIsım.Text , kf.TxtSoyisim.Text);
                lvi.SubItems.Add(kf.MskdTelefon.Text);
                if (kf.RdbErkek.Checked)
                {
                    lvi.SubItems.Add("Erkek");
                    tiklanan.BackColor = Color.Blue;
                }
                if(kf.RdbKadin.Checked)
                {
                    lvi.SubItems.Add("Kadın");
                    tiklanan.BackColor = Color.Pink;
                }
                lvi.SubItems.Add(CmbNereden.Text);
                lvi.SubItems.Add(CmbNereye.Text);
                lvi.SubItems.Add(tiklanan.Text);
                lvi.SubItems.Add(DtpTarih.Text);
                lvi.SubItems.Add(NudFiyat.Value.ToString());
                listView1.Items.Add(lvi);
            }
        }
    }
}
