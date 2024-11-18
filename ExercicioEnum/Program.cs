using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enum;
using System.Globalization;
using System.Net.Http.Json;
using System.Transactions;
namespace ExercicioEnum
   
{
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Client Data: ");
        Console.WriteLine("Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Birthday: ");
        DateTime Bd = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter Order Data");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name,email,Bd);
            Order order = new Order(DateTime.Now,status,client);
                
            Console.WriteLine("How many items to this order? ");
           int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i} item data: ");
                Console.Write("Product Name: ");
                string product = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product product1 = new Product(product,price);

                Console.Write("Quantidade: ");
                int qtd = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(qtd,price,product1);
                order.Items.Add(item); 
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
} 
}

