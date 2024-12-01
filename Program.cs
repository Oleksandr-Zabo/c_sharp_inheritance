namespace c_sharp_inheritance
{//hw- ex.3
    public class MusicalInstrument
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }

        public MusicalInstrument()
        {
            Name = "Generic musical instrument";
            Characteristics = "Generic characteristics";
        }

        public MusicalInstrument(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual string Sound()
        {
            return "Generic musical instrument sound";
        }

        public string Show()
        {
            return $"Instrument Name: {Name}";
        }

        public string Desc()
        {
            return $"Description: {Characteristics}";
        }

        public virtual string History()
        {
            return "History: Generic history of the musical instrument";
        }
    }

    public class Violin : MusicalInstrument
    {
        public Violin() : base() {
            Name = "Violin";
            Characteristics = "A small, high-pitched string instrument";
        }

        public Violin(string name, string characteristics) : base(name, characteristics) { }

        public override string Sound()
        {
            return "Violin sound";
        }

        public override string History()
        {
            return "History: The violin, also known as a fiddle, is a wooden string instrument in the violin family.";
        }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone() : base()
        {
            Name = "Trombone";
            Characteristics = "A brass instrument with a slide";
        }

        public Trombone(string name, string characteristics) : base(name, characteristics) { }

        public override string Sound()
        {
            return "Trombone sound";
        }

        public override string History()
        {
            return "History: The trombone is a brass instrument in the brass family.";
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base()
        {
            Name = "Ukulele";
            Characteristics = "A small, four-stringed instrument";
        }

        public Ukulele(string name, string characteristics) : base(name, characteristics) { }

        public override string Sound()
        {
            return "Ukulele sound";
        }

        public override string History()
        {
            return "History: The ukulele is a member of the lute family of instruments.";
        }
    }

    public class Cello : MusicalInstrument
    {
        public Cello() : base()
        {
            Name = "Cello";
            Characteristics = "A large, low-pitched string instrument";
        }

        public Cello(string name, string characteristics) : base(name, characteristics) { }

        public override string Sound()
        {
            return "Cello sound";
        }

        public override string History()
        {
            return "History: The cello is a bowed string instrument of the violin family.";
        }
    }

    internal class Program
    {
        public static void Main()
        {
            MusicalInstrument[] instruments = new MusicalInstrument[]
            {
            new Violin(),
            new Trombone("Trombone", "A brass instrument with a slide"),
            new Ukulele(),
            new Cello("Cello", "A large, low-pitched string instrument")
            };

            foreach (var instrument in instruments)
            {
                Console.WriteLine(instrument.Show());
                Console.WriteLine(instrument.Desc());
                Console.WriteLine($"Sound: {instrument.Sound()}");
                Console.WriteLine(instrument.History());
                Console.WriteLine();
            }
        }
    }


}
