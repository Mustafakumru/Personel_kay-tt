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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        SqlConnection bağlantı = new SqlConnection("Data Source=mkumru\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {

            //Toplam Personel Sayısı
            bağlantı.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", bağlantı);
            SqlDataReader dr1=komut1.ExecuteReader();
            while(dr1.Read())
            {
                LblPersayı.Text = dr1[0].ToString();
            }
            bağlantı.Close();
            //Evli Personel Sayısı 
            bağlantı.Open();
         
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where perDurum=1", bağlantı);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliper.Text = dr2[0].ToString();
            }
            bağlantı.Close();
            //bekar Personel Sayısı
            bağlantı.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where perDurum=0", bağlantı);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
               LblBekarPer.Text = dr3[0].ToString();    
            }
            bağlantı.Close() ;  
            // Şehir Sayıs
            bağlantı.Open() ;
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerŞehir)) From Tbl_Personel", bağlantı);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSahir.Text = dr4[0].ToString();
            }
            bağlantı.Close();
            //Toplam Maaş 
            bağlantı.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(perMaaş) From Tbl_Personel", bağlantı);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblMaas.Text = dr5[0].ToString();   
            }
            bağlantı.Close();
            //Ortalama Maaş
            bağlantı.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(perMaaş) From Tbl_Personel", bağlantı);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                Lblortalama.Text = dr6[0].ToString();   
            }
            bağlantı.Close();

        }
      
    }
}
