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
    public partial class Chef : Form
    {
        public Chef(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public SqlConnection con;

        private void Chef_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.YP_06_Bluda' table. You can move, or remove it, as needed.
            this.yP_06_BludaTableAdapter.Fill(this.dataSet3.YP_06_Bluda);
            // TODO: This line of code loads data into the 'dataSet2.YP_06_recept_ingridient' table. You can move, or remove it, as needed.
            this.yP_06_recept_ingridientTableAdapter1.Fill(this.dataSet2.YP_06_recept_ingridient);

            String quertString = @"select * from YP_06_Ingridient;"; con.Open();
            SqlCommand table = new SqlCommand(quertString, con); SqlDataReader reader = table.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[1]);//Добавляем имя в comboBox1
            }
            reader.Close(); con.Close();

            dataGridView1.Hide();
            textBox1.Hide();
            comboBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            Recept.Hide();
            zavershit.Hide();
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chef.ActiveForm.Width = 460;
            Chef.ActiveForm.Height = 390;
            string CommandText1 = "SELECT id_rabotnika FROM YP_06_Rabotnik WHERE id_doljnosti = 1";
            SqlCommand myCommand1 = new SqlCommand(CommandText1, con);
            con.Open();
            myCommand1.ExecuteNonQuery();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(myCommand1);
            DataTable dt1 = new DataTable();
            dataAdapter1.Fill(dt1);
            string chef = dt1.Rows[0][0].ToString();

            string sInsSql = "Insert into YP_06_Recept(id_Chef) Values('{0}')";

            string sInsSotr = string.Format(sInsSql,chef);

            SqlCommand cmdIns = new SqlCommand(sInsSotr, con);

            cmdIns.ExecuteNonQuery();

            string CommandText2 = "SELECT top 1 id_recept FROM YP_06_Recept order by id_recept desc";
            SqlCommand myCommand2 = new SqlCommand(CommandText2, con);
            myCommand2.ExecuteNonQuery();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(myCommand2);
            DataTable dt2 = new DataTable();
            dataAdapter2.Fill(dt2);
            int recept = Int32.Parse(dt2.Rows[0][0].ToString());

            Program.id_recept = recept;

            con.Close();

            Newrecept.Hide();
            dataGridView1.Show();
            textBox1.Show();
            comboBox1.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            Recept.Show();
            zavershit.Show();

            MessageBox.Show(string.Format("Рецепт создан id рецепта: " + recept), "Сообщение");
            Program.sebestoimost = 0;
            Program.ves_bluda = 0;
        }

        private void Recept_Click(object sender, EventArgs e)
        {
            string ingr = comboBox1.Text;
            string CommandText1 = "SELECT id_ingridienta FROM YP_06_Ingridient WHERE Nazvanie = '" + ingr + "'";
            SqlCommand myCommand1 = new SqlCommand(CommandText1, con);
            con.Open();
            myCommand1.ExecuteNonQuery();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(myCommand1);
            DataTable dt1 = new DataTable();
            dataAdapter1.Fill(dt1);
            int id_ingridienta = Int32.Parse(dt1.Rows[0][0].ToString());

            string CommandText2 = "SELECT Stoimost_za_1000_ed FROM YP_06_Ingridient WHERE Nazvanie = '" + ingr + "'";
            SqlCommand myCommand2 = new SqlCommand(CommandText2, con);
            myCommand2.ExecuteNonQuery();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(myCommand2);
            DataTable dt2 = new DataTable();
            dataAdapter2.Fill(dt2);
            int stoimost_ingridienta = Int32.Parse(dt2.Rows[0][0].ToString());

            string sInsSql = "Insert into YP_06_recept_ingridient(id_recept,id_ingridienta,ves) Values('{0}', '{1}', '{2}')";

            int ves = Int32.Parse(textBox1.Text);

                string sInsSotr = string.Format(sInsSql, Program.id_recept,id_ingridienta,ves);

                SqlCommand cmdIns = new SqlCommand(sInsSotr, con);

                cmdIns.ExecuteNonQuery();

                MessageBox.Show(string.Format("Ингридиент добавлен"), "Сообщение");

                con.Close();

            // TODO: This line of code loads data into the 'dataSet3.YP_06_Bluda' table. You can move, or remove it, as needed.
            this.yP_06_BludaTableAdapter.Fill(this.dataSet3.YP_06_Bluda);
            // TODO: This line of code loads data into the 'dataSet2.YP_06_recept_ingridient' table. You can move, or remove it, as needed.
            this.yP_06_recept_ingridientTableAdapter1.Fill(this.dataSet2.YP_06_recept_ingridient);

            int ves_ing = Int32.Parse(textBox1.Text);
            int za_kg = 1000 / ves_ing;
            int sebest_ing = stoimost_ingridienta / za_kg;
            Program.sebestoimost = Program.sebestoimost + sebest_ing;
            Program.ves_bluda = Program.ves_bluda + ves_ing;

        }

        private void Chef_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MenuChef parent2 = new MenuChef(con);//Создается новая родительская форма, содержащая параметр SqlConnection con
            parent2.Show();
        }

        private void zavershit_Click(object sender, EventArgs e)
        {
            Newrecept.Hide();
            dataGridView1.Hide();
            textBox1.Hide();
            comboBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            Recept.Hide();
            zavershit.Hide();
            panel1.Show();
            Chef.ActiveForm.Width = 520;
            Chef.ActiveForm.Height = 350;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chef.ActiveForm.Width = 460;
            Chef.ActiveForm.Height = 390;
            Newrecept.Hide();
            dataGridView1.Show();
            textBox1.Show();
            comboBox1.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            Recept.Show();
            zavershit.Show();
            panel1.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            con.Open();

            string sInsSql = "Insert into YP_06_Bluda(id_recepta,Nazvanie,Stoimost,Ves) Values('{0}', '{1}', '{2}','{3}')";

            string sInsSotr = string.Format(sInsSql, Program.id_recept,textBox2.Text ,Program.sebestoimost * 2.5, Program.ves_bluda);

            SqlCommand cmdIns = new SqlCommand(sInsSotr, con);

            cmdIns.ExecuteNonQuery();

            MessageBox.Show(string.Format("Блюдо Создано"), "Сообщение");

            con.Close();

            // TODO: This line of code loads data into the 'dataSet3.YP_06_Bluda' table. You can move, or remove it, as needed.
            this.yP_06_BludaTableAdapter.Fill(this.dataSet3.YP_06_Bluda);
            // TODO: This line of code loads data into the 'dataSet2.YP_06_recept_ingridient' table. You can move, or remove it, as needed.
            this.yP_06_recept_ingridientTableAdapter1.Fill(this.dataSet2.YP_06_recept_ingridient);
        }
    }
}
