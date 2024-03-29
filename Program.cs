using static Prog_OOP_Midterm_Part1.Database;
using static Prog_OOP_Midterm_Part1.Database.MyDatabase;

namespace Prog_OOP_Midterm_Part1

    //Manjula Rajan
{
    internal class Program
    {
        static void Main()
        {
            {
               
                // Access the static property to get the data
                //List<string> dataList = MyDatabase.Data;

                // Display the data from the static class
                //foreach (string item in dataList)
                //{
                // Console.WriteLine(item);
                //}




                //Product product = new Product("T-shirt ", 19.99, "Medium", "Red", "", "");

                //product.DisplayProductInformation();


                // Testing Clothing
                Clothing tShirt = new Clothing("T-shirt", 19.99, "Medium", "Red");
                //tShirt.DisplayProductInfo();

                //Testing Electronics
                 Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
                 //smartphone.DisplayProductInfo();

                // Testing Groceries
                Groceries banana = new Groceries("Banana", 0.99, "2024-02-10");
                //banana.DisplayProductInfo();

                List<Product> productList = new List<Product>();
                productList.Add(tShirt);
                productList.Add(smartphone);
                productList.Add(banana);

                foreach (Product product in productList)
                {

                    product.DisplayProductInfo();
                }



            }

        } 
        

    }
    
}
