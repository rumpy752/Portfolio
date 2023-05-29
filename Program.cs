/*
 *      date: 2023-04-17
 *      author: Jaime Rump
 *      filename: Program.cs
 */

namespace MyApp
{
    public class Person
    {
        // variables declared to hold person values
        protected string name { get; set; }
        protected long number { get; set; }
        protected string address { get; set; }

        // Main method/entry of program. Creates instances of each class and calls their ToString() method. 
        static void Main(string[] args)
        {
            Person person = new Person();
            Customer person2 = new Customer();
            PreferredCustomer person3 = new PreferredCustomer();
            Console.WriteLine(person.ToString() + person2.ToString() + person3.ToString());
        }

        // Constructor for person class 
        public Person()
        {
            name = "Jaime Rump";
            number = 7782150307;
            address = "752 Petterson Rd, West Kelowna, BC, Canada";
        }

        // Displays properties of person class to console
        public override string ToString()
        {
            return $"Name: {name} \nNumber: {number} \nAddress: {address} \n";
        }
    }
 
    public class Customer : Person
    {
        // Variables declared to hold customer values
        protected int CustomerId { get; set; }
        protected Boolean MailingList { get; set; }
        Random random = new Random();

        // Constructor for customer class
        public Customer()
        {
            CustomerId = random.Next(100000, 999999);
            MailingList = true;
        }

        // Displays properties of customer class to console
        public override string ToString()
        {
            return $"Customer ID: {CustomerId} \nAccepts mailing: {MailingList}\n";
        }
    }

    public class PreferredCustomer : Customer
    {
        // Variables declared to hold preferred customer values
        protected int purchaseAmount { get; set; }
        protected double customerDiscount { get; set; }
        protected string level { get; set; }

        // Constructor for preferredcustomer class
        public PreferredCustomer()
        {
            purchaseAmount = 1450;
            level = "0%";
            customerDiscount = CalculateDiscount();
        }

        // Method calculates appropriate discount level 
        public double CalculateDiscount()
        {
            if (purchaseAmount >= 500 && purchaseAmount < 1000)
            {
                level = "5%";
                return purchaseAmount * 0.05; // 10% discount for purchases over $1000
            }
            else if (purchaseAmount >= 1000 && purchaseAmount < 1500)
            {
                level = "6%";
                return purchaseAmount * 0.06;
            }
            else if (purchaseAmount >= 1500 && purchaseAmount < 2000)
            {
                level = "7%";
                return purchaseAmount * 0.07;
            }
            else if (purchaseAmount >= 2000)
            {
                level = "10%";
                return purchaseAmount * 0.10;
            }
            else
            {
                return 0;
            }
        }

        // Displays properties of preferred customer class to console
        public override string ToString()
        {
            return $"Purchase amount: {purchaseAmount.ToString("C")}\nDiscount level: {level}\nDiscount amount on purchase: {customerDiscount.ToString("C")}";
        }
    }
}