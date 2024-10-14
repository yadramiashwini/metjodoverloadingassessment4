namespace metjodoverloadingassessment4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Display options to the user
            Console.WriteLine("1. Price Without Discount");
            Console.WriteLine("2. Price With Discount");
            Console.Write("Enter the choice: ");
            int choice = int.Parse(Console.ReadLine());

            // Variables to hold price and quantity
            double price;
            int quantity;

            // Get the price and quantity from the user
            Console.Write("Enter the price: ");
            price = double.Parse(Console.ReadLine());

            Console.Write("Enter the quantity: ");
            quantity = int.Parse(Console.ReadLine());

            // Calculate and display the total price based on the user's choice
            if (choice == 1)
            {
                double totalPriceWithoutDiscount = CalculateTotalPriceWithoutDiscount(price, quantity);
                Console.WriteLine($"Total price without discount: {totalPriceWithoutDiscount}");
            }
            else if (choice == 2)
            {
                Console.Write("Enter the discount percentage: ");
                double discountPercentage = double.Parse(Console.ReadLine());
                double totalPriceWithDiscount = CalculateTotalPriceWithDiscount(price, quantity, discountPercentage);
                Console.WriteLine($"Total price with discount: {totalPriceWithDiscount}");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        // Method to calculate total price without discount
        public static double CalculateTotalPriceWithoutDiscount(double price, int quantity)
        {
            return price * quantity;
        }

        // Method to calculate total price with discount
        public static double CalculateTotalPriceWithDiscount(double price, int quantity, double discountPercentage)
        {
            double totalPrice = price * quantity;
            double discountAmount = totalPrice * (discountPercentage / 100);
            return totalPrice - discountAmount;
        }
    }

}
