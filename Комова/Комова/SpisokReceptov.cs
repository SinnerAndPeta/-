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
using Excel = Microsoft.Office.Interop.Excel;

namespace Комова
{
    public partial class SpisokReceptov : Form
    {
        public SpisokReceptov(SqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }
        public SqlConnection con;

        private void SpisokReceptov_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MenuChef parent2 = new MenuChef(con);//Создается новая родительская форма, содержащая параметр SqlConnection con
            parent2.Show();
        }

        private void SpisokReceptov_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet7.YP_06_recept_ingridient' table. You can move, or remove it, as needed.
            this.yP_06_recept_ingridientTableAdapter.Fill(this.dataSet7.YP_06_recept_ingridient);
            // TODO: This line of code loads data into the 'dataSet6.YP_06_Bluda' table. You can move, or remove it, as needed.
            this.yP_06_BludaTableAdapter.Fill(this.dataSet6.YP_06_Bluda);
            // TODO: This line of code loads data into the 'dataSet5.YP_06_Recept' table. You can move, or remove it, as needed.
            this.yP_06_ReceptTableAdapter.Fill(this.dataSet5.YP_06_Recept);
            panel1.Hide();
            panel2.Hide();
            //подгрузка данных в комбобокс
            String quertString = @"select * from YP_06_Ingridient;"; con.Open();
            SqlCommand table = new SqlCommand(quertString, con); SqlDataReader reader = table.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[1]);//Добавляем имя в comboBox1
            }
            reader.Close(); con.Close();
            //изменение id на названия
            con.Open();
            String quertString1 = @"select YP_06_Ingridient.Nazvanie from YP_06_Ingridient, YP_06_recept_ingridient where YP_06_recept_ingridient.id_ingridienta=YP_06_Ingridient.id_ingridienta;";
            SqlCommand table1 = new SqlCommand(quertString1, con);
            SqlDataReader reader1 = table1.ExecuteReader(); int i = 0;
            while (reader1.Read())
            {
                dataGridView1[3, i].Value = Convert.ToString(reader1[0]); i++;
            }
            reader1.Close();
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            SpisokReceptov.ActiveForm.Width = 500;
            SpisokReceptov.ActiveForm.Height = 300;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
            SpisokReceptov.ActiveForm.Width = 600;
            SpisokReceptov.ActiveForm.Height = 265;
        }

        private void izmrec_Click(object sender, EventArgs e)
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

            
            string strAll1 = "update YP_06_recept_ingridient SET id_ingridienta = '" + id_ingridienta + "',ves = '" + Convert.ToInt32(dataGridView1[4, Program.rows].Value) + "' WHERE id_recept_ingridient = '" + Convert.ToInt32(dataGridView1[0, Program.rows].Value) + "'";
            SqlCommand com6 = new SqlCommand(strAll1, con);
            com6.ExecuteNonQuery();
            MessageBox.Show(string.Format("Ингридиент успешно изменен"), "Сообщение");
            con.Close();
            this.yP_06_recept_ingridientTableAdapter.Fill(this.dataSet7.YP_06_recept_ingridient);
            con.Open();
            String quertString1 = @"select YP_06_Ingridient.Nazvanie from YP_06_Ingridient, YP_06_recept_ingridient where YP_06_recept_ingridient.id_ingridienta=YP_06_Ingridient.id_ingridienta;";
            SqlCommand table1 = new SqlCommand(quertString1, con);
            SqlDataReader reader1 = table1.ExecuteReader(); int i = 0;
            while (reader1.Read())
            {
                dataGridView1[3, i].Value = Convert.ToString(reader1[0]); i++;
            }
            reader1.Close();
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.rows = dataGridView1.CurrentCell.RowIndex;
            Program.column = dataGridView1.CurrentCell.ColumnIndex;
            
        }

        private void delrec_Click(object sender, EventArgs e)
        {
            con.Open();
            string strAll1 = "Delete from YP_06_recept_ingridient where id_recept_ingridient = '" + Convert.ToInt32(dataGridView1[0, Program.rows].Value) + "'";
            SqlCommand com1 = new SqlCommand(strAll1, con);
            com1.ExecuteNonQuery();
            MessageBox.Show(string.Format("Ингридиент успешно удален"), "Сообщение");
            con.Close();
            this.yP_06_recept_ingridientTableAdapter.Fill(this.dataSet7.YP_06_recept_ingridient);
        }

        private void izmblu_Click(object sender, EventArgs e)
        {
            con.Open();
            string strAll1 = "update YP_06_Bluda SET Nazvanie = '" + Convert.ToString(dataGridView2[2, Program.rows].Value) + "', Stoimost = '" + Convert.ToString(dataGridView2[3, Program.rows].Value) + "', Ves = '" + Convert.ToString(dataGridView2[4, Program.rows].Value) + "' WHERE id_Bluda = '" + Convert.ToInt32(dataGridView2[0, Program.rows].Value) + "'";
            SqlCommand com6 = new SqlCommand(strAll1, con);
            com6.ExecuteNonQuery();
            MessageBox.Show(string.Format("Блюдо успешно изменено"), "Сообщение");
            con.Close();
            this.yP_06_BludaTableAdapter.Fill(this.dataSet6.YP_06_Bluda);
        }

        private void delblu_Click(object sender, EventArgs e)
        {
            con.Open();
            string strAll1 = "Delete from YP_06_Bluda where id_Bluda = '" + Convert.ToInt32(dataGridView2[0, Program.rows].Value) + "'";
            SqlCommand com1 = new SqlCommand(strAll1, con);
            com1.ExecuteNonQuery();
            MessageBox.Show(string.Format("Блюдо успешно удалено"), "Сообщение");
            con.Close();
            this.yP_06_BludaTableAdapter.Fill(this.dataSet6.YP_06_Bluda);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.rows = dataGridView2.CurrentCell.RowIndex;
            Program.column = dataGridView2.CurrentCell.ColumnIndex;
        }

        private void rasrec_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Файлы Excel (*.xls; *.xlsx) | *.xls;*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Рецепты с ингридиентами";
                worksheet.Cells[1, 1] = "Рецепты:";
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    if (i == 1 || i == 3) {
                    
                    }
                    else
                    {
                        worksheet.Cells[2, i] = dataGridView1[i - 1, 0].Value;
                        worksheet.Columns[i].ColumnWidth = 30;
                        worksheet.Cells[1, i].Font.Color = Color.Red;
                    }
                }
                for (int i = 1; i < dataGridView1.RowCount; i++)
                    for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    {
                        if (j < 1 )
                        {
                            worksheet.Cells[i + 2, j-1] = dataGridView1[j, i].Value;
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j] = dataGridView1[j, i].Value;
                        }
                    }
                workbook.SaveAs(saveFileDialog1.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                app.Quit();



            }
        }

        private void rasblu_Click(object sender, EventArgs e)
        {

        }
    }
}
