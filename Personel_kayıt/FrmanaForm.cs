using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_kayıt
{
    public partial class FrmanaForm : Form
    {
        public FrmanaForm()
        {
            InitializeComponent();
        }
        SqlConnection bağlantı=new SqlConnection("Data Source=mkumru\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
        void temizle()
        {
            Txtperad.Text = "";
            TxtPersoy.Text = "";
            Txt_perid.Text = "";
            Txtmeslek.Text = "";
            MaskMaaş.Text = "";
            PerSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personelVeriTabanıDataSet.Tbl_personel);
        }

        private void BtnKAydet_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut=new SqlCommand("insert into Tbl_personel (PerAd,PerSoyad,PerŞehir,PerMaaş,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6) ",bağlantı);
            komut.Parameters.AddWithValue("@p1", Txtperad.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersoy.Text);
            komut.Parameters.AddWithValue("@p3", PerSehir.Text);
            komut.Parameters.AddWithValue("@p4", MaskMaaş.Text);
            komut.Parameters.AddWithValue("@p5", Txtmeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();
           
          

            bağlantı.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {  
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
              
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            Txt_perid.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();    
            Txtperad.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();    
            TxtPersoy.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();    
            Txtmeslek.Text = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();    
            PerSehir.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();    
            MaskMaaş.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();    
            label8.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();    
                
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked=true;
            }
            if(label8.Text == "False") {
              radioButton2.Checked=true;
            
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komutsil=new SqlCommand("Delete From Tbl_Personel where Perid=@k1",bağlantı);
            komutsil.Parameters.AddWithValue("@k1", Txt_perid.Text);
            komutsil.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("Personel Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komutgüncelle = new SqlCommand("Update Tbl_Personel Set Perad=@a1,PerSoyad=@a2,PerŞehir=@a3,Permaaş=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", bağlantı);
            komutgüncelle.Parameters.AddWithValue("@a1", Txtperad.Text);
            komutgüncelle.Parameters.AddWithValue("@a2", TxtPersoy.Text);
            komutgüncelle.Parameters.AddWithValue("@a3", PerSehir.Text);
            komutgüncelle.Parameters.AddWithValue("@a4", MaskMaaş.Text);
            komutgüncelle.Parameters.AddWithValue("@a6", Txtmeslek.Text);
            komutgüncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutgüncelle.Parameters.AddWithValue("@a7",Txt_perid.Text);    
            komutgüncelle.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("Personel güncellendi");
        }

        private void Btnİstaatistik_Click(object sender, EventArgs e)
        {
           Frmİstatistik fr=new Frmİstatistik();
            fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg=new FrmGrafikler();    
            frg.Show();
        }
    }
}
