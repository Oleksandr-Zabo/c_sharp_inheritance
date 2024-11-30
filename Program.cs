namespace c_sharp_inheritance
{//lab ex-2

    public class AppConsts {
        public const string DefaultName = "No_name";
        public const string DefaultSurname = "No_surname";
        public const int DefaultAge = -1;
        public const long DefaultPassportNumber = -1;
        public const string DefaultCountry = "No_Country";
    };

    public class Visa
    {
        private string? _visaType;
        private string? _visaCountry;
        private string? _visaStartDate;
        private string? _visaEndDate;
        public string VisaType
        {
            get => _visaType ?? AppConsts.DefaultName;
            set => _visaType = value;
        }
        public string VisaCountry
        {
            get => _visaCountry ?? AppConsts.DefaultCountry;
            set => _visaCountry = value;
        }
        public string VisaStartDate
        {
            get => _visaStartDate ?? AppConsts.DefaultName;
            set => _visaStartDate = value;
        }
        public string VisaEndDate
        {
            get => _visaEndDate ?? AppConsts.DefaultName;
            set => _visaEndDate = value;
        }
        public Visa()
        {
            _visaType = null;
            _visaCountry = null;
            _visaStartDate = null;
            _visaEndDate = null;
        }
        public Visa(string visaType, string visaCountry, string visaStartDate, string visaEndDate)
        {
            VisaType = visaType;
            VisaCountry = visaCountry;
            VisaStartDate = visaStartDate;
            VisaEndDate = visaEndDate;
        }
        public override string ToString()
        {
            return $"Visa Info: \nVisa Type: {VisaType}, Visa Country: {VisaCountry}, Visa Start Date: {VisaStartDate}, Visa End Date: {VisaEndDate}";
        }
        public string getInfo()
        {
            return ToString();
        }
    };

    public class Visas : Visa {
        private Visa[] _visas;
        private int _count;
        public Visas()
        {
            _visas = new Visa[10];
            _count = 0;
        }
        public void AddVisa(Visa visa)
        {
            if (_count < 10)
            {
                _visas[_count] = visa;
                _count++;
            }
        }
        public override string ToString()
        {
            if (_count != 0) {
                string result = "Visas Info: \n";
                for (int i = 0; i < _count; i++)
                {
                    result += _visas[i].ToString() + "\n";
                }
                return result;
            }

            else{
                return "No Visas";
            }
        }
    };

    public class Passport {
        private string? _name;
        private string? _surname;
        private int? _age;
        private string? _country;

        public string Name
        {
            get => _name?? AppConsts.DefaultName;
            set => _name = value;
        }
        public string Surname
        {
            get => _surname ?? AppConsts.DefaultSurname;
            set => _surname = value;
        }
        public int Age
        {
            get => _age ?? AppConsts.DefaultAge;
            set => _age = value;
        }
        public string Country
        {
            get => _country ?? AppConsts.DefaultCountry;
            set => _country = value;
        }

        public Passport()
        {
            _name = null;
            _surname = null;
            _age = null;
            _country = null;
        }

        public Passport(string name, string surname, int age, string country)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Country = country;
        }

        public override string ToString()
        {
            return $"Passport Info: \nName: {Name}, Surname: {Surname}, Age: {Age}, Country: {Country}";
        }

        public virtual string getInfo() {
            return ToString();
        }
    };

    public class ForeignPassport : Passport
    {
        private long? _passportNumber;
        private Visas _visas;
        public long PassportNumber
        {
            get => _passportNumber ?? AppConsts.DefaultPassportNumber;
            set => _passportNumber = value;
        }
        public ForeignPassport()
        {
            _passportNumber = null;
            _visas = new Visas();
        }
        public ForeignPassport(string name, string surname, int age, string country, long passportNumber) : base(name, surname, age, country)
        {
            PassportNumber = passportNumber;
            _visas = new Visas();
        }
        public void AddVisa(Visa visa)
        {
            _visas.AddVisa(visa);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nPassport Number: {PassportNumber}\n{_visas.ToString()}";
        }
        public override string getInfo()
        {
            return ToString();
        }
    };

    internal class Program
    {
        static void Main()
        {
            Passport passport = new Passport("John", "Doe", 25, "USA");
            Console.WriteLine(passport.getInfo());
            Console.WriteLine();

            Passport foreignPassport = new ForeignPassport("John", "Doe", 25, "USA", 123456789);
            Console.WriteLine(foreignPassport.getInfo());
            Console.WriteLine();

            Visa visa1 = new Visa("Tourist", "USA", "01.01.2021", "01.07.2021");
            Visa visa2 = new Visa("Business", "USA", "01.01.2021", "01.07.2021");

            ((ForeignPassport)foreignPassport).AddVisa(visa1);
            ((ForeignPassport)foreignPassport).AddVisa(visa2);

            Console.WriteLine(foreignPassport.getInfo());
        }
    }
}
