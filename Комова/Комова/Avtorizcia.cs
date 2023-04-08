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
    public partial class Avtorizcia : Form
    {
        public Avtorizcia()
        {
            InitializeComponent();
        }

        private void Vhod_Click(object sender, EventArgs e)
        {
            String ConnectString = "Integrated Security=false;User Id=user131_db;Password=user131;Initial Catalog=user131_db;server= stud-mssql.sttec.yar.ru,38325";
            //Объявление новой переменной типа SqlConection
            SqlConnection con = new SqlConnection(ConnectString);
            Exception error = null;//Переменная, представляющая ошибки, появляющиеся во время выполнения приложения
            try
            {
                con.Open(); //Открытие подключения
            }
            catch (Exception ex) //При возникновении неполадок при подключении появится сообщение с информацией об ошибке
            {
                error = ex;//Переменная error запоминает конкретную ошибку
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (error == null)//Если переменная не изменилась, то ошибок при подключении не было и соединение с БД Установлено
                {

                    string CommandText = "SELECT TOP 1 Count(*) FROM YP_06_Rabotnik WHERE Login = '" + login.Text + "' and Password = '" + password.Text + "'";
                    SqlCommand myCommand = new SqlCommand(CommandText, con);
                    myCommand.ExecuteNonQuery();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(myCommand);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        string CommandText1 = "SELECT id_doljnosti FROM YP_06_Rabotnik WHERE Login = '" + login.Text + "' and Password = '" + password.Text + "'";
                        SqlCommand myCommand1 = new SqlCommand(CommandText1, con);
                        myCommand1.ExecuteNonQuery();
                        SqlDataAdapter dataAdapter1 = new SqlDataAdapter(myCommand1);
                        DataTable dt1 = new DataTable();
                        dataAdapter1.Fill(dt1);
                        int yroven = Int32.Parse(dt1.Rows[0][0].ToString());
                        if (yroven == 1)
                        {

                            string CommandText2 = "SELECT Familiya,Ima,Otchestvo FROM YP_06_Rabotnik WHERE id_doljnosti = 1";
                            SqlCommand myCommand2 = new SqlCommand(CommandText2, con);
                            myCommand2.ExecuteNonQuery();
                            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(myCommand2);
                            DataTable dt2 = new DataTable();
                            dataAdapter2.Fill(dt2);
                            string familiya = dt2.Rows[0][0].ToString();
                            string Ima = dt2.Rows[0][1].ToString();
                            string otchestvo = dt2.Rows[0][2].ToString();

                            MessageBox.Show("Здравствуйте,"+ " " + familiya + " " + Ima + " " + otchestvo + "!");
                            this.Hide();
                            con.Close();//Соединение закрывается
                            MenuChef parent = new MenuChef(con); //Создается новая родительская форма, содержащая параметр SqlConnection con
                            parent.Show();//Открывается новая родительская форма
                        }
                        else if (yroven == 3)
                        {
                            string CommandText2 = "SELECT Familiya,Ima,Otchestvo FROM YP_06_Rabotnik WHERE Login = '" + login.Text + "' and Password = '" + password.Text + "'";
                            SqlCommand myCommand2 = new SqlCommand(CommandText2, con);
                            myCommand2.ExecuteNonQuery();
                            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(myCommand2);
                            DataTable dt2 = new DataTable();
                            dataAdapter2.Fill(dt2);
                            string familiya = dt2.Rows[0][0].ToString();
                            string Ima = dt2.Rows[0][1].ToString();
                            string otchestvo = dt2.Rows[0][2].ToString();

                            MessageBox.Show("Здравствуйте," + " " + familiya + " " + Ima + " " + otchestvo + "!");
                            this.Hide();
                            con.Close();//Соединение закрывается
                            Povar parent2 = new Povar(con);//Создается новая родительская форма, содержащая параметр SqlConnection con
                            parent2.Show();//Открывается новая родительская форма
                        }

                        else if (yroven == 2)
                        {
                            string CommandText2 = "SELECT Familiya,Ima,Otchestvo FROM YP_06_Rabotnik WHERE Login = '"+ login.Text +"' and Password = '" + password.Text +"'";
                            SqlCommand myCommand2 = new SqlCommand(CommandText2, con);
                            myCommand2.ExecuteNonQuery();
                            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(myCommand2);
                            DataTable dt2 = new DataTable();
                            dataAdapter2.Fill(dt2);
                            string familiya = dt2.Rows[0][0].ToString();
                            string Ima = dt2.Rows[0][1].ToString();
                            string otchestvo = dt2.Rows[0][2].ToString();

                            MessageBox.Show("Здравствуйте," +" "+ familiya + " " + Ima + " " + otchestvo + "!");
                            this.Hide();
                            con.Close();//Соединение закрывается
                            Oficiant parent2 = new Oficiant(con);//Создается новая родительская форма, содержащая параметр SqlConnection con
                            parent2.Show();//Открывается новая родительская форма
                        }

                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль!");
                    }
                }

            }

        }

        private void Avtorizcia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
