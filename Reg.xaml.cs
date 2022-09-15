using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;


namespace SQLLoginPrompt
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Reg : Window
    {
        DataBase _data = new DataBase();

        public Reg()
        {
            InitializeComponent();
        }
        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtMinimaze(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private bool ValidationPass()
        {
            var pass = passFrm.Password;
            var pass1 = repeatPassFrm.Password;

            if (pass == pass1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
        private bool checkUserReg()
        {
            SqlCommand sqlCommand = new SqlCommand($"SELECT id,login,pass FROM users WHERE login='{loginFrm.Text}'", _data.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void BtRegistrer(object sender, RoutedEventArgs e)
        {
            if (ValidationPass())
            {
                if (checkUserReg())
                {

                    SqlCommand command = new SqlCommand($"INSERT INTO dbo.users(login,pass) VALUES('{loginFrm.Text}','{passFrm.Password}')",_data.GetSqlConnection());

                    _data.OpenConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан");
                    }
                    Login frmLogin = new Login();
                    frmLogin.Show();
                    Close();

                    _data.CloseConnection();


                }
                else
                {
                    MessageBox.Show("Логин занят");
                }
            }
            else
            {
                MessageBox.Show("Чот с паролем");
            }
        }


        private void labelAut(object sender, MouseButtonEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            Close();
        }


    }
}
