
namespace ChallengeApp
{
    public class Employee
    {
        private List<int> points= new List<int>();
        public Employee(string name, string surname, int age, int points) //konstruktor
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; } // pola
        public string Surname { get;private set; }
        public int Age { get; private set;}

        public int Sum
        {
            get
            {
                return this.points.Sum();
            }
        }
        public string emplData
        {
            get
            {
                return string.Join(" ", this.Name, this.Surname) + " (" + this.Age + ")";
            }
        }
        public void Addpoint(int point) // metody
        {
            this.points.Add(point);
        }
    }
}
