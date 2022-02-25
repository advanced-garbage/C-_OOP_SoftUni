namespace AnimalFarm.Models
{
    public class Chicken
    {
        public const int MinAge = 0;
        public const int MaxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            internal set
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                        throw new System.ArgumentException();
                    this.name = value;
                }
                catch (System.ArgumentException)
                {
                    System.Console.WriteLine("Name cannot be empty.");
                    System.Environment.Exit(0);
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                try
                {
                    if (value >= 0 && value <= 15)
                        this.age = value;
                    else
                        throw new System.ArgumentException();
                }
                catch (System.ArgumentException)
                {
                    System.Console.WriteLine("Age should be between 0 and 15.");
                    System.Environment.Exit(0);
                }
            }
        }

        public double ProductPerDay
        {
			get
			{				
				return this.CalculateProductPerDay();
			}
        }

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
