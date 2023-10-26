using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sample_Ex1
{
    public partial class Sample_Ex1 : Form
    {
        SqlDataAdapter da_Khoa;
        SqlConnection cnn;
        public Sample_Ex1()
        {
            InitializeComponent();
        }

        private void Sample_Ex1_Load(object sender, EventArgs e)
        {

        }
        void LoadDuLieuKhoa()
        {

            string strsel = "SELECT * FROM Lop";
            da_Khoa = new SqlDataAdapter(strsel, cnn);
            da_Khoa.Fill(ds_QLSV, "Lop");
            
        }
        
    }
}
