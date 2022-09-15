using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace SQLLoginPrompt
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>

    public partial class Login : Window
    {
        DataBase _data = new DataBase();

        public Login()
        {
            InitializeComponent();
        }

        private void BtClose(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void BtMinimaze(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtEnter(object sender, RoutedEventArgs e)
        {
            string login = loginFrm.Text;
            string pass = passFrm.Password;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            SqlCommand sqlCommand = new SqlCommand($"SELECT id,login,pass FROM users WHERE login='{login}' and pass='{pass}'", _data.GetSqlConnection());

            adapter.SelectCommand = sqlCommand;

            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {

                int id = -1;
                foreach (DataRow myRow in table.Rows)
                {
                    id = Convert.ToInt32(myRow["id"]);
                }
                General gr = new General(id);
                
                gr.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }



        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Reg frmReg = new Reg();
            frmReg.Show();
            this.Close();
        }
    }
}
