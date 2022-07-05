using SimplePrograms;
using SimplePrograms.Implementations;
using SimplePrograms.Interfaces;
using SimplePrograms.Models;

string[] options = new string[] { 
    "Calculator", "Sorting", "Times Table", "Fibonacci", "Billing"
};

for (int i = 0; i < options.Length; i++)
{
    Console.WriteLine($"{i + 1}. {options[i]}");
}

do
{    
    Console.Write("Select the option:");
    int option = Convert.ToInt32(Console.ReadLine());

    if (option > options.Length)
    {
        Console.WriteLine("Please select the correct option");
        continue;
    }        

    Console.WriteLine("You have Selected:" + options[Convert.ToInt32(option) - 1]);

    switch (option)
    {
        case 1:
            {
                Console.WriteLine("Calculator Options ");
                Console.WriteLine("Add => A");
                Console.WriteLine("Subtract => S");
                Console.WriteLine("Multiply => M");
                Console.WriteLine("Divide => D");
                Console.WriteLine("Exit => E");
                Console.Write("\n Select an option : ");
                var keyOption = Console.ReadKey().Key;

                ICalculator calculator = new Calculator();

                do
                {
                    if (keyOption != ConsoleKey.E)
                    {
                        Console.Write("\n Enter the input value a: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the input value b: ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        int? calculatorResult = null;

                        switch (keyOption)
                        {
                            case ConsoleKey.A:
                                calculatorResult = calculator.Add(a, b);
                                break;
                            case ConsoleKey.S:
                                calculatorResult = calculator.Subtract(a, b);
                                break;
                            case ConsoleKey.M:
                                calculatorResult = calculator.Multiply(a, b);
                                break;
                            case ConsoleKey.D:
                                calculatorResult = calculator.Divide(a, b);
                                break;
                            default:
                                Console.Write("Invalid Options ");
                                break;
                        }

                        Console.WriteLine($"Result = {calculatorResult}");
                    }

                    Console.Write("\n Select an option : ");
                    keyOption = Console.ReadKey().Key;

                } while (keyOption != ConsoleKey.E);
            }
            break;
        case 2:
            
            Console.WriteLine("Input Numbers:");
            int length = 5;
            int[] vs = new int[length];
            for (int i = 0; i < length; i++)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                vs[i] = val;
            }

            ISorting sorting = new Sorting();
            int[] result = sorting.GetOrderedNumbers(vs);

            Console.WriteLine("Sorted Numbers:");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(result[i]);
            }
            break;
        case 3:

            Console.Write("Please enter the table number to be printed: ");
            int tableNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the times limit to be printed: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            ITimesTable timesTable = new TimesTable();
            string[] output = timesTable.GetTable(tableNo, limit);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            break;
        case 4:
            {
                Console.Write("Please enter the length of the fibonacci series to be printed: ");

                IFibonacci fibonacci = new Fibonacci();

                foreach (var item in fibonacci.GenerateSeries(Convert.ToInt32(Console.ReadLine())))
                {
                    Console.WriteLine(item);
                }
            }
            break;
        case 5:
            {
                var products = new List<Product>()
                {
                    new Product() { Id = 1, Name = "Apple", Category = "Fruits", Price = 1.20M },
                    new Product() { Id = 2, Name = "Grapes", Category = "Fruits", Price = 2.50M },
                    new Product() { Id = 3, Name = "Potato", Category = "Vegetable", Price = 2.00M },
                    new Product() { Id = 4, Name = "Beans", Category = "Vegetable", Price = 2.80M },
                    new Product() { Id = 5, Name = "Strawberry", Category = "Fruits", Price = 2.99M }
                };

                Console.WriteLine("Items in Store");
                foreach (var item in products)
                {
                    Console.WriteLine($"{item.Id} : {item.Name} - {item.Price} EUR");
                }

                Console.Write("Please select the item Id to add to cart: ");
                List<Product> itemsInCart = new List<Product>();

                do
                {
                    int itemId = Convert.ToInt32(Console.ReadLine());
                    itemsInCart.Add(products.FirstOrDefault(i => i.Id == itemId));
                    Console.Write("Do you wish to continue? enter Yes => 'Y' or No 'N': ");

                    var isContinue = Convert.ToChar(Console.ReadLine());

                    if (isContinue.Equals('Y'))
                    {
                        Console.Write("Please select another item Id to add to cart: ");
                        continue;
                    }                        
                    else
                        break;

                } while (true);

                IBillingService billingService = new BillingService();
                decimal totalAmount = billingService.Calcualte(itemsInCart);

                Console.WriteLine($"Total amount to Pay : {totalAmount.ToString()}");
            }
            break;

        default:
            break;
    }
} while (true);







