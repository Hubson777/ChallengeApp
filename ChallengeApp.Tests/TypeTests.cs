namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComparisonString()
        {
            // arrenge
            string number1 = "Hubert";
            string number2 = "Hubert";

            // act


            // assert
            Assert.AreEqual(number1, number2);

        }


        [Test]
        public void ComparisonValueType_Int()
        {
            // arrenge
            int number1 = 2;
            int number2 = 2;

            // act


            // assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void ComparisonValueType_float()
        {
            // arrenge
            float number1 = 1.2f;
            float number2 = 1.2f;

            // act


            // assert
            Assert.AreEqual(number1, number2);

        }  
    }
}
