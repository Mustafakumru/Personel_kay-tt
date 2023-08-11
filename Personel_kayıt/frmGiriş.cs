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
    public partial class frmGiriş : Form
    {
        public frmGiriş()
        {
            InitializeComponent();
        }

        private void frmGiriş_Load(object sender, EventArgs e)
        {

        }
        SqlConnection bağlantı = new SqlConnection("Data Source=mkumru\\MSSQLSERVER01;Initial Catalog=PersonelVeriTabanı;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_griş where KulanıcıAd=@p1 and Şifre=@p2", bağlantı);
            komut.Parameters.AddWithValue("@p1", KullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSıfre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                FrmanaForm form = new FrmanaForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Ve Şifre");
            }
            bağlantı.Close();
        }
    }
}
