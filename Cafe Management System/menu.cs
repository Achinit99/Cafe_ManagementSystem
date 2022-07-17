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

namespace Cafe_Management_System
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();

            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if(cmb_category.Text == "Coffee")
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                string sqlQry = "insert into coffee values(" + txt_code.Text + ",'" + txt_name.Text + "'," + txt_price.Text + ")";

                SqlCommand cmd = new SqlCommand(sqlQry, connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("data sent!!");

                connection.Close();
            }
            else if (cmb_category.Text == "Milk Shake")
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                string sqlQry = "insert into milkshake values(" + txt_code.Text + ",'" + txt_name.Text + "'," + txt_price.Text + ")";

                SqlCommand cmd = new SqlCommand(sqlQry, connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("data sent!!");

                connection.Close();
            }
            else if (cmb_category.Text == "Desert")
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                string sqlQry = "insert into desert values(" + txt_code.Text + ",'" + txt_name.Text + "'," + txt_price.Text + ")";

                SqlCommand cmd = new SqlCommand(sqlQry, connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("data sent!!");

                connection.Close();
            }
            else if (cmb_category.Text == "Hot Drink")
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                string sqlQry = "insert into hotdrink values(" + txt_code.Text + ",'" + txt_name.Text + "'," + txt_price.Text + ")";

                SqlCommand cmd = new SqlCommand(sqlQry, connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("data sent!!");

                connection.Close();
            }
            else if (cmb_category.Text == "Ice Drink")
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Documents\black_cafe.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                string sqlQry = "insert into icedrink values(" + txt_code.Text + ",'" + txt_name.Text + "'," + txt_price.Text + ")";

                SqlCommand cmd = new SqlCommand(sqlQry, connection);

                cmd.ExecuteNonQuery();

                MessageBox.Show("data sent!!");

                connection.Close();
            }



        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Person1 p1 = new Person1();
            p1.Show();
            this.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
