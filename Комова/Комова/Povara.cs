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
    public partial class Povara : Form
    {
        public Povara(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public SqlConnection con;

        private void Menu_Chefa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet4.YP_06_Rabotnik' table. You can move, or remove it, as needed.
            this.yP_06_RabotnikTableAdapter.Fill(this.dataSet4.YP_06_Rabotnik);

        }

        private void Povara_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MenuChef parent2 = new MenuChef(con);//Создается новая родительская форма, содержащая параметр SqlConnection con
            parent2.Show();
        }

        private void c_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(dataGridView1[0, Program.rows].Value) >= 0)
            {
                MessageBox.Show("Вы выбрали существующего повара!");
            }
            else
            {
                if (Convert.ToString(dataGridView1[2, Program.rows].Value) != "" && Convert.ToString(dataGridView1[3, Program.rows].Value) != "" && Convert.ToString(dataGridView1[5, Program.rows].Value) != "" && Convert.ToString(dataGridView1[6, Program.rows].Value) != "")
                {
                    con.Open();
                    string sInsSql = "Insert into YP_06_Rabotnik(id_doljnosti,Familiya,Ima,Otchestvo,Login,Password) Values('{0}', '{1}', '{2}', '{3}','{4}','{5}')";
                    // Считываем данные с формы 
                    int d = 2;
                    string f = Convert.ToString(dataGridView1[2, Program.rows].Value);
                    string im = Convert.ToString(dataGridView1[3, Program.rows].Value);
                    string o = Convert.ToString(dataGridView1[4, Program.rows].Value);
                    string l = Convert.ToString(dataGridView1[5, Program.rows].Value);
                    string p = Convert.ToString(dataGridView1[6, Program.rows].Value);


                    string sInsSotr = string.Format(sInsSql, d, f, im, o, l, p);

                    SqlCommand cmdIns = new SqlCommand(sInsSotr, con);

                    cmdIns.ExecuteNonQuery();

                    MessageBox.Show(string.Format("Повар успешно добавлен"), "Сообщение");
                    con.Close();
                    this.yP_06_RabotnikTableAdapter.Fill(this.dataSet4.YP_06_Rabotnik);
                }
                else {
                    MessageBox.Show("Не все поля заполнены!");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.rows = dataGridView1.CurrentCell.RowIndex;
            Program.column = dataGridView1.CurrentCell.ColumnIndex;
        }

        private void Izmenit_Click(object sender, EventArgs e)
        {
            con.Open();
            string strAll1 = "update YP_06_Rabotnik SET Familiya = '" + Convert.ToString(dataGridView1[2, Program.rows].Value) + "', Ima = '" + Convert.ToString(dataGridView1[3, Program.rows].Value) + "', Otchestvo = '" + Convert.ToString(dataGridView1[4, Program.rows].Value) + "',Login ='" + Convert.ToString(dataGridView1[5, Program.rows].Value) + "',Password = '" + Convert.ToString(dataGridView1[6, Program.rows].Value) + "' WHERE id_rabotnika = '" + Convert.ToInt32(dataGridView1[0, Program.rows].Value) + "'";
            SqlCommand com6 = new SqlCommand(strAll1, con);
            com6.ExecuteNonQuery();
            MessageBox.Show(string.Format("Повар успешно изменен"), "Сообщение");
            con.Close();
            this.yP_06_RabotnikTableAdapter.Fill(this.dataSet4.YP_06_Rabotnik);

        }

        private void Ud_Click(object sender, EventArgs e)
        {
            con.Open();
            string strAll1 = "Delete from YP_06_Rabotnik where id_rabotnika = '" + Convert.ToInt32(dataGridView1[0, Program.rows].Value) + "'";
            SqlCommand com1 = new SqlCommand(strAll1, con);
            com1.ExecuteNonQuery();
            MessageBox.Show(string.Format("Повар успешно удален"), "Сообщение");
            con.Close();
            this.yP_06_RabotnikTableAdapter.Fill(this.dataSet4.YP_06_Rabotnik);
        }
    }
}
