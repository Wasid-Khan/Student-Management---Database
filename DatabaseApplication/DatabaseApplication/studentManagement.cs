using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace DatabaseApplication
{
    public partial class studentManagement : Form
    {
        public string fname, lname, city, state, country, nationality;

        private void bt_addNewRecord_Click(object sender, EventArgs e)
        {
            addData();
            getData();
        }

        public void clearData()
        {
            this.tb_Fn.Text = "";
            this.tb_Ln.Text = "";
            this.tb_City.Text = "";
            this.tb_Country.Text = "";
            this.tb_State.Text = "";
            this.tb_Nationality.Text = "";
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void bt_Update_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;

            //Creating connection object.
            SqlConnection connection = new SqlConnection(connectionString);

            //Creating command object
            SqlCommand command = new SqlCommand();

            //Assigning connection obj to connection property of command obj
            command.Connection = connection;

            //Getting values from text boxes
            String fname = this.tb_Fn.Text;
            string lname = this.tb_Ln.Text;
            string city = this.tb_City.Text;
            string state = this.tb_State.Text;
            string country = this.tb_Country.Text;
            string nationality = this.tb_Nationality.Text;

            //Assigning query to commandText property of command obj
            command.CommandText = "UPDATE student SET FirstName=@FirstName, LastName=@LastName, City=@City, State=@State, Country=@Country, Nationality=@Nationality WHERE FirstName=@FirstName";

            command.Parameters.AddWithValue("@FirstName", fname);
            command.Parameters.AddWithValue("@LastName", lname);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@State", state);
            command.Parameters.AddWithValue("@Country", country);
            command.Parameters.AddWithValue("@Nationality", nationality);
            //Opening connection
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Updated Record Successfully !");
            this.listBox1.Items.Clear();
            clearData();
            getData();

        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;

            //Creating connection object.
            SqlConnection connection = new SqlConnection(connectionString);

            //Creating command object
            SqlCommand command = new SqlCommand();

            //Assigning connection obj to connection property of command obj
            command.Connection = connection;

            //Getting values from text boxes
            String fname = this.tb_Fn.Text;

            //Assigning query to commandText property of command obj
            command.CommandText = "DELETE from student WHERE FirstName=@FirstName";

            command.Parameters.AddWithValue("@FirstName", fname);
            //Opening connection
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Deleted Record Successfully !");
            this.listBox1.Items.Clear();
            clearData();
            getData();

        }

        private void bt_DeleteFromListBoxView_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex == -1)
                MessageBox.Show("Select the record to remove !");
            if (this.listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        public string fname2, lname2, city2, state2, country2, nationality2;
        public studentManagement()
        {
            InitializeComponent();
        }
        public void getData() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;

            //creating connection object
            SqlConnection connection = new SqlConnection(connectionString);

            //creatign command object
            SqlCommand command = new SqlCommand();

            //Assigning connection object to connection property of command object
            command.Connection = connection;

            //Assigning Query to commandText property of command object 
            command.CommandText = "Select * from Students";

            //opening connection
            connection.Open();

            //executing query using command object and assigning it to datareader object
            SqlDataReader datareader1 = command.ExecuteReader();

            //reading records one by one by using read method of datareader object
            while (datareader1.Read())
            {
                //accessing all the data using datareader
                fname = (string)datareader1["FirstName"];
                lname = (string)datareader1["LastName"];
                city = (string)datareader1["City"];
                state = (string)datareader1["State"];
                country = (string)datareader1["Country"];
                nationality = (string)datareader1["Nationality"];

                this.listBox1.Items.Add(fname + ", " + lname + ", " + city + ", " + state + ", " + country + ", " + nationality);
            }
            //closing datareader object
            datareader1.Close();
            //closing connection close
            connection.Close();

        }
        public void addData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;

            //creating connection object
            SqlConnection connection = new SqlConnection(connectionString);

            //creating command object
            SqlCommand command = new SqlCommand();

            //assigning connection object to connection property of command obj
            command.Connection = connection;

            //getting values from text boxes
            fname2 = this.tb_Fn.Text;
            lname2 = this.tb_Ln.Text;
            city2 = this.tb_City.Text;
            state2 = this.tb_State.Text;
            country2 = this.tb_Country.Text;
            nationality2 = this.tb_Nationality.Text;

            //Assigning query to commandText property of command obj
            command.CommandText = "INSERT INTO Students(FirstName, LastName, City, State, Country, Nationality)" +
                                "Values (@FirstName, @LastName, @City, @State, @Country, @Nationality)";



            command.Parameters.AddWithValue("@FirstName", fname2);
            command.Parameters.AddWithValue("@LastName", lname2);
            command.Parameters.AddWithValue("@City", city2);
            command.Parameters.AddWithValue("@State", state2);
            command.Parameters.AddWithValue("@Country", country2);
            command.Parameters.AddWithValue("@Nationality", nationality2);
            //Opening connection
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Inserted Record Successfully !");
            this.listBox1.Items.Clear();
            getData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
