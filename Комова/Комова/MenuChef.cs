using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Комова
{
    public partial class MenuChef : Form
    {
        public MenuChef(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public SqlConnection con;

        private void Vhod_Click(object sender, EventArgs e)
        {
            Povara parent = new Povara(con);
            parent.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chef parent = new Chef(con);
            parent.Show();
            this.Hide();
        }

        private void MenuChef_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Avtorizcia parent2 = new Avtorizcia();
            parent2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpisokReceptov parent2 = new SpisokReceptov(con);
            parent2.Show();
        }
    }
}
