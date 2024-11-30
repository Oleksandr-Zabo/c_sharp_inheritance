namespace c_sharp_inheritance
{//hw- ex. 1

    class Money
    {
        private int wholePart;
        private int fractionalPart;

        public int WholePart
        {
            get { return wholePart; }
            set { wholePart = value; }
        }

        public int FractionalPart
        {
            get { return fractionalPart; }
            set
            {
                wholePart += value / 100;
                fractionalPart = value % 100;
            }
        }

        public Money(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }

        public void SetValues(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }

        public string Display()
        {
            return $"{WholePart}.{FractionalPart:D2}";
        }
    }

    class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void ReducePrice(int wholePart, int fractionalPart)
        {
            int totalFractionalPart = Price.WholePart * 100 + Price.FractionalPart;
            int reductionFractionalPart = wholePart * 100 + fractionalPart;

            int newTotalFractionalPart = totalFractionalPart - reductionFractionalPart;

            Price.WholePart = newTotalFractionalPart / 100;
            Price.FractionalPart = newTotalFractionalPart % 100;
        }

        public string Display()
        {
            return $"{Name} : {Price.Display()}";
        }
    }


    internal class Program
    {
        static void Main()
        {
            Money money = new Money(10, 150); // 10.150 should become 11.50
            Console.WriteLine(money.Display());

            Product product = new Product("Example Product", new Money(20, 175)); // 20.175 should become 21.75
            Console.WriteLine(product.Display());

            product.ReducePrice(5, 25); // Reduce by 5.25
            Console.WriteLine(product.Display());
        }
    }
}
