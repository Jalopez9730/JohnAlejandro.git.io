using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioASP
{
    public partial class Loggin : Form
    {
        String _User = "JOHN";
        String _Password = "123456";


        public Loggin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Loggin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == _User && txtPass.Text == _Password)
            {
                LblAlarm.Visible = false;
                frmMenu menu = new frmMenu();
                menu.ShowDialog();
            }
            else
            {
                LblAlarm.Visible = true;
            }
        }

        private void Loggin_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
