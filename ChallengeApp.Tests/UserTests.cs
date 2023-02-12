
namespace ChallengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectThreeScore_ShouldReturnCorrectResult()
        {
            // arrange 
            var user = new User("Adam", "asdaas324");
            user.AddScore(5);
            user.AddScore(6);
            user.AddNegativeScore(7);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(4, result);
            
        }
    }
}