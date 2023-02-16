namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void TestForMinStats()
        {
            // arrange
            var employee = new Employee("Hubert", "Głoś");

            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(9);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min); 

        }
        [Test]
        public void TestForMaxStats()
        {
            // arrange
            var employee = new Employee("Hubert", "Głoś");

            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(9);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(9, statistics.Max);

        }
        [Test]
        public void TestForAverageStats()
        {
            // arrange
            var employee = new Employee("Hubert", "Głoś");

            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(2);
            employee.AddGrade(9);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(5.6f, statistics.Average);

        }
    }
}
