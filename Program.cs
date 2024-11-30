namespace c_sharp_inheritance
{//hw- ex.2
    class Device
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }

        public Device(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual string Sound()
        {
            return "Generic device sound";
        }

        public string Show()
        {
            return $"Device Name: {Name}";
        }

        public string Desc()
        {
            return $"Description: {Characteristics}";
        }
    }

    class Kettle : Device
    {
        public Kettle(string name, string characteristics) : base(name, characteristics) { }

        public override string Sound()
        {
            return "Whistle sound";
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string characteristics) : base(name, characteristics) { }

        public override string Sound()
        {
            return "Beep sound";
        }
    }

    class Car : Device
    {
        public Car(string name, string characteristics) : base(name, characteristics) { }

        public override string Sound()
        {
            return "Engine sound";
        }
    }

    class Steamboat : Device
    {
        public Steamboat(string name, string characteristics) : base(name, characteristics) { }

        public override string Sound()
        {
            return "Horn sound";
        }
    }


    internal class Program
    {
        static void Main()
        {
            Device[] devices = new Device[]
        {
            new Kettle("Electric Kettle", "Boils water quickly"),
            new Microwave("Microwave Oven", "Heats food efficiently"),
            new Car("Sedan", "Comfortable family car"),
            new Steamboat("River Steamboat", "Used for river transport")
        };

            foreach (var device in devices)
            {
                Console.WriteLine(device.Show());
                Console.WriteLine(device.Desc());
                Console.WriteLine($"Sound: {device.Sound()}");
                Console.WriteLine();
            }
        }
    }
}
