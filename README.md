# Student-Management---Database
A Database connectivity concept implementation in C#.

Here's a README file for the Student Management System application, emphasizing the database concepts in C#:

---

# Student Management System

## Project Overview

The **Student Management System** is a Windows Forms application developed using C#. This application provides basic CRUD (Create, Read, Update, Delete) operations to manage student records. The system connects to a SQL Server database to store and retrieve data, ensuring persistent storage and efficient data handling.

## Features

- **CRUD Operations**: Add, read, update, and delete student records in the database.
- **Search Functionality**: Retrieve student records and display them in a list box.
- **Clear Data**: Clear the input fields to allow easy data entry.

## System Requirements

- **C# Programming Language**
- **Visual Studio IDE**
- **SQL Server Database**

## Database Integration

The application uses ADO.NET to connect to a SQL Server database. The connection string is stored in the `App.config` file and retrieved using the `ConfigurationManager`. The following operations are performed using SQL commands:

- **Insert**: Adds new student records to the database.
- **Update**: Updates existing student records.
- **Delete**: Deletes student records from the database.
- **Select**: Retrieves student records to display in the list box.

## Code Overview

### Database Connection

The connection string is stored in the `App.config` file:

```xml
<connectionStrings>
    <add name="cAString" connectionString="your_connection_string_here" />
</connectionStrings>
```

### Adding a Record

The `addData` method inserts a new record into the `Students` table:

```csharp
public void addData()
{
    string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
    SqlConnection connection = new SqlConnection(connectionString);
    SqlCommand command = new SqlCommand
    {
        Connection = connection,
        CommandText = "INSERT INTO Students(FirstName, LastName, City, State, Country, Nationality)" +
                      "VALUES (@FirstName, @LastName, @City, @State, @Country, @Nationality)"
    };

    command.Parameters.AddWithValue("@FirstName", fname2);
    command.Parameters.AddWithValue("@LastName", lname2);
    command.Parameters.AddWithValue("@City", city2);
    command.Parameters.AddWithValue("@State", state2);
    command.Parameters.AddWithValue("@Country", country2);
    command.Parameters.AddWithValue("@Nationality", nationality2);

    connection.Open();
    command.ExecuteNonQuery();
    connection.Close();
    MessageBox.Show("Inserted Record Successfully!");
    this.listBox1.Items.Clear();
    getData();
}
```

### Updating a Record

The `bt_Update_Click` method updates an existing record:

```csharp
private void bt_Update_Click(object sender, EventArgs e)
{
    string connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
    SqlConnection connection = new SqlConnection(connectionString);
    SqlCommand command = new SqlCommand
    {
        Connection = connection,
        CommandText = "UPDATE student SET FirstName=@FirstName, LastName=@LastName, City=@City, State=@State, Country=@Country, Nationality=@Nationality WHERE FirstName=@FirstName"
    };

    command.Parameters.AddWithValue("@FirstName", fname);
    command.Parameters.AddWithValue("@LastName", lname);
    command.Parameters.AddWithValue("@City", city);
    command.Parameters.AddWithValue("@State", state);
    command.Parameters.AddWithValue("@Country", country);
    command.Parameters.AddWithValue("@Nationality", nationality);

    connection.Open();
    command.ExecuteNonQuery();
    connection.Close();
    MessageBox.Show("Updated Record Successfully!");
    this.listBox1.Items.Clear();
    clearData();
    getData();
}
```

### Deleting a Record

The `bt_Delete_Click` method deletes a record from the database:

```csharp
private void bt_Delete_Click(object sender, EventArgs e)
{
    string connectionString = ConfigurationManager.ConnectionStrings["caString"].ConnectionString;
    SqlConnection connection = new SqlConnection(connectionString);
    SqlCommand command = new SqlCommand
    {
        Connection = connection,
        CommandText = "DELETE from student WHERE FirstName=@FirstName"
    };

    command.Parameters.AddWithValue("@FirstName", fname);
    connection.Open();
    command.ExecuteNonQuery();
    connection.Close();
    MessageBox.Show("Deleted Record Successfully!");
    this.listBox1.Items.Clear();
    clearData();
    getData();
}
```

### Retrieving Data

The `getData` method retrieves all records from the `Students` table and displays them in the list box:

```csharp
public void getData()
{
    string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
    SqlConnection connection = new SqlConnection(connectionString);
    SqlCommand command = new SqlCommand
    {
        Connection = connection,
        CommandText = "Select * from Students"
    };

    connection.Open();
    SqlDataReader datareader1 = command.ExecuteReader();
    while (datareader1.Read())
    {
        fname = (string)datareader1["FirstName"];
        lname = (string)datareader1["LastName"];
        city = (string)datareader1["City"];
        state = (string)datareader1["State"];
        country = (string)datareader1["Country"];
        nationality = (string)datareader1["Nationality"];

        this.listBox1.Items.Add($"{fname}, {lname}, {city}, {state}, {country}, {nationality}");
    }
    datareader1.Close();
    connection.Close();
}
```

## Conclusion

The **Student Management System** demonstrates the use of ADO.NET for database operations in a C# Windows Forms application. It provides a user-friendly interface to perform CRUD operations and manage student records efficiently. This project highlights the integration of C# with SQL Server, showcasing the practical application of database concepts in C#.

---

Feel free to customize this README file further according to your project's specific requirements.
