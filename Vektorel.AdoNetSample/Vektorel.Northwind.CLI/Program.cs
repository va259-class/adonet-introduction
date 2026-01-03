using Microsoft.Data.SqlClient;

namespace Vektorel.Northwind.CLI;

class Program
{
    public static void Main(string[] args)
    {
        GetProducts(1);
    }

    private static void GetProducts(int page)
    {
        var connectionString = "Server=127.0.0.1,10001;Database=Northwind;User ID=sa;Password=1q2w3e4R!;TrustServerCertificate=True";
        var connection = new SqlConnection(connectionString);
        connection.Open();
        var query = @"select ProductName, UnitPrice, UnitsInStock
                      from Products
                      order by ProductName
                      offset 0 rows
                      fetch next 10 rows only";
        var command = new SqlCommand(query, connection);
        var reader = command.ExecuteReader();

        while (reader.Read())
        {
            var product = new Product();
            //product.Name = reader.GetString(1);
            //product.UnitPrice = reader.GetDecimal(2);
            //product.Stock = reader.GetInt32(3);

            product.Name = reader["ProductName"].ToString();
            product.UnitPrice = Convert.ToDecimal(reader["UnitPrice"]);
            product.Stock = Convert.ToInt32(reader["UnitsInStock"]);

            Console.WriteLine($"{product.Name} - {product.UnitPrice} - {product.Stock}");
        }
        //using yazılmadığı için manuel kapatıldı.
        connection.Close();
    }

    private static void GetCategories()
    {
        var connectionString = "Server=127.0.0.1,10001;Database=Northwind;User ID=sa;Password=1q2w3e4R!;TrustServerCertificate=True";
        using var connection = new SqlConnection(connectionString);
        connection.Open();
        var query = "select CategoryName, Description from Categories";
        var command = new SqlCommand(query, connection);
        var reader = command.ExecuteReader();

        //Başlık için alan ayrıldı. 20 karakter Kategori, 60 karakter Açıklama
        Console.WriteLine("{0, -20}{1, -60}", "Category", "Description");
        Console.WriteLine(new string('-', 80));

        //string.Format("{0} ile {1} ormanda yürüken, Saat {2} sularında {0} gülmeye başladı", "Can", "Cem", DateTime.Now);
        while (reader.Read())
        {
            var category = new Category();
            category.Name = reader["CategoryName"].ToString();
            category.Description = reader["Description"].ToString();

            Console.WriteLine("{0, -20}{1, -60}", category.Name, category.Description);
        }
    }
}

class Category
{
    public string Name { get; set; }
    public string Description { get; set; }
}

class Product
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public int Stock { get; set; }
}