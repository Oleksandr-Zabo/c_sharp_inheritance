namespace c_sharp_inheritance
{//lab ex-3

    public class AppConst
    {
        public const string DefaultName = "No Name";
        public const int DefaultAge = -1;
        public const string DefaultColor = "No Color";
        public const string DefaultType = "No Type";
    }

    public class Animal {
        private string? _name;
        private int? _age;
        private string? _color;
        private string? _type;

        public string Name
        {
            get => _name ?? AppConst.DefaultName;
            set => _name = value;
        }
        public int Age
        {
            get => _age ?? AppConst.DefaultAge;
            set => _age = value;
        }
        public string Color
        {
            get => _color ?? AppConst.DefaultColor;
            set => _color = value;
        }
        public string Type
        {
            get => _type ?? AppConst.DefaultType;
            set => _type = value;
        }

        public Animal() {
            _name = null;
            _age = null;
            _color = null;
            _type = null;
        }

        public Animal(string? name, int? age, string? color, string? type)
        {
            _name = name;
            _age = age;
            _color = color;
            _type = type;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Color: {Color}, Type: {Type}";
        }

        public virtual string getSound()
        {
            return "No Sound";
        }
    };

    public class Tiger: Animal {
        private string _sound = "Roar";
        public Tiger():base()
        {
        }
        public Tiger(int? age, string? color, string? type): base("Tiger", age, color, type)
        {
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Sound: {_sound}";
        }

        public override string getSound()
        {
            return _sound;
        }
    };

    public class Crocodale : Animal {
        private string _sound = "Grunt";
        public Crocodale() : base()
        {
        }
        public Crocodale(int? age, string? color, string? type) : base("Crocodale", age, color, type)
        {
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Sound: {_sound}";
        }
        public override string getSound()
        {
            return _sound;
        }
    };

    public class Kengaroo : Animal
    {
        private string _sound = "Chortle";
        public Kengaroo() : base()
        {
        }
        public Kengaroo(int? age, string? color, string? type) : base("Kengaroo", age, color, type)
        {
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Sound: {_sound}";
        }
        public override string getSound()
        {
            return _sound;
        }
    };

    internal class Program
    {
        static void Main()
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Tiger(5, "Orange", "Wild");
            animals[1] = new Crocodale(10, "Green", "Wild");
            animals[2] = new Kengaroo(7, "Brown", "Wild");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine($"Sound: {animal.getSound()}");
                Console.WriteLine();
            }
        }
    }
}
