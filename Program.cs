namespace c_sharp_inheritance
{//hw ex-4

    public abstract class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Work { get; set; }

        public Worker() {
            Name = "No name";
            Age = -1;
            Work = "No work";
        }

        public Worker(string name, int age, string work)
        {
            Name = name;
            Age = age;
            Work = work;
        }

        public abstract void Print();
    }

    public class President : Worker
    {
        public President() : base() {
            Work = "President";
        }

        public President(string name, int age) : base(name, age, "President") { }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Work: {Work}");
        }
    }

    public class Security : Worker
    {
        public Security() : base()
        {
            Work = "Security";
        }

        public Security(string name, int age) : base(name, age, "Security") { }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Work: {Work}");
        }
    }

    public class Manager : Worker
    {
        public Manager() : base()
        {
            Work = "Manager";
        }

        public Manager(string name, int age) : base(name, age, "Manager") { }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Work: {Work}");
        }
    }

    public class Engineer : Worker
    {
        public Engineer() : base()
        {
            Work = "Engineer";
        }

        public Engineer(string name, int age) : base(name, age, "Engineer") { }

        public override void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Work: {Work}");
        }
    }

    class Program
    {
        static void Main()
        {
            Worker[] workers = new Worker[]
            {
                new President("Alice", 50),
                new Security(),
                new Manager("Charlie", 40),
                new Engineer("Dave", 30)
            };

            foreach (var worker in workers)
            {
                worker.Print();
            }
        }
    }
}
