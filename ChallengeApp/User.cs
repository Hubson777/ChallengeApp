
namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();

        public User(string login) // konstruktor
        {
            this.Login = login;
        }

        public User(string login, string password) // konstruktor
        {
            this.Login = login;
            this.Password = password;
        }

        public string Login { get; private set; }
        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number) // metoda
        {
            this.score.Add(number);
        }

        public void AddNegativeScore(int number) // metoda
        {
            this.score.Add(-number);
        }
    }
}
