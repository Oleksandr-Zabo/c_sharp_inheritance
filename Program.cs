namespace c_sharp_inheritance
{//lab ex-1
    public abstract class AppConsts
    {
        public const string DefaultName = "No Name";
        public const string DefaultSurname = "No Surname";
        public const int DefaultAge = -1;
        public const string DefaultWork = "No Work";
    }

    public class Human
    {
        private string? _name;
        private string? _s_name;
        private int? _age;
        private string? _work;

        public string Name
        {
            get => _name ?? AppConsts.DefaultName;
            set => _name = value;
        }

        public string Surname
        {
            get => _s_name ?? AppConsts.DefaultSurname;
            set => _s_name = value;
        }

        public int Age
        {
            get => _age ?? AppConsts.DefaultAge;
            set => _age = value;
        }

        public string Work
        {
            get => _work ?? AppConsts.DefaultWork;
            set => _work = value;
        }

        public Human()
        {
            _name = null;
            _s_name = null;
            _age = null;
            _work = null;
        }

        public Human(string? name, string? surname, int? age, string? work)
        {
            _name = name;
            _s_name = surname;
            _age = age;
            _work = work;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Work: {Work}";
        }

        public virtual string GetInfo()
        {
            return ToString();
        }
    };

    public class Builder: Human
    {
        public Builder(): base()
        {
            Work = "Builder";
        }

        public Builder(string? name, string? surname, int? age) : base(name, surname, age, "Builder")
        {
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}";
        }
    }

    public class Sailor : Human
    {
        public Sailor() : base()
        {
            Work = "Sailor";
        }
        public Sailor(string? name, string? surname, int? age) : base(name, surname, age, "Sailor")
        {
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}";
        }
    }

    public class Pilot : Human
    {
        public Pilot() : base()
        {
            Work = "Pilot";
        }
        public Pilot(string? name, string? surname, int? age) : base(name, surname, age, "Pilot")
        {
        }
        public override string GetInfo()
        {
            return $"{base.GetInfo()}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            Human human = new Human();
            Console.WriteLine(human);

            Human builder = new Builder("John", "Doe", 25);
            Console.WriteLine(builder.GetInfo());

            Human sailor = new Sailor("Jack", "Sparrow", 35);
            Console.WriteLine(sailor.GetInfo());

            Human pilot = new Pilot("John", "Doe", 45);

            Console.WriteLine(pilot);

        }
    }
}
