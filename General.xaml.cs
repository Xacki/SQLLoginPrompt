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
    /// Логика взаимодействия для General.xaml
    /// </summary>
    public partial class General : Window
    {
        DataBase _data = new DataBase();
        int idUser;

        public General(int id)
        {
            InitializeComponent();
            RefreshDataGrid(postsGrid,id);
            
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
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
        enum RowState
        {
            Add,
            Remove,
            Create,
            Edit
        }

        private void RefreshDataGrid(DataGrid dg,int id)
        {
            
            SqlCommand createCommand = new SqlCommand($"SELECT header,text,date FROM posts WHERE owner={id}", _data.GetSqlConnection());
            
            _data.OpenConnection();
            createCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(createCommand);
            DataTable dataTable = new DataTable("Posts");
            dataAdapter.Fill(dataTable);
            dg.ItemsSource = dataTable.DefaultView;
            
            _data.CloseConnection();

        }

        private void postsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gd = (DataGrid)sender;
            DataRowView rowSelected = gd.SelectedItem as DataRowView;
            if (rowSelected != null)
            {
                header_txt.Text = rowSelected["header"].ToString();
                text_txt.Text = rowSelected["text"].ToString();
                date_txt.Text = rowSelected["date"].ToString();
            }
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
