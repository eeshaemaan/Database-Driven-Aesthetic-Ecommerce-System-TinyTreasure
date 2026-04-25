using WinFormsApp2;
using System.Data;
using Microsoft.Data.SqlClient;

public static class HelperFunctions
{
    public static Detail GetProductDetailPage(string productName, string image_name)
    {
        DatabaseConnection dbHelper = new DatabaseConnection();
        DataTable productData = dbHelper.GetProductDetailsFromDB(productName);
        string name;
        string price;
        string desc;

        if (productData.Rows.Count > 0)
        {
            name = productData.Rows[0]["prod_name"]?.ToString();
            price = productData.Rows[0]["price"]?.ToString();
            desc = productData.Rows[0]["prod_description"]?.ToString();

            return new Detail(name, image_name, price, desc);
        }

        name = "Unknown Product";
        price = "0";
        desc = "No Description";
        return new Detail(name, image_name, price, desc);
    }

}
