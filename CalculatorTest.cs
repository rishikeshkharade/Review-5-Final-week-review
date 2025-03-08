using Review_5__Final_week_Review_;
namespace CalculatorTest
{
    public class Tests
    {
        private Calculator calcultor;
        
        [SetUp]
        public void Setup()
        {
            calcultor = new Calculator();
        }

        [Test]
        public void Add()
        {
            double a = 5;
            double b = 3;
            double expected = 8;

            double actual = calcultor.Add(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract()
        {
            double a = 5;
            double b = 3;
            double expected = 2;

            double actual = calcultor.Subtract(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_Negative_Integers()
        {
            double a = 5;
            double b = -3;
            double expected = 8;

            double actual = calcultor.Subtract(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Subtract_From_Itself()
        {
            double a = 5;
            double expected = 0;

            double actual = calcultor.Subtract(a, a);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply()
        {
            double a = 5;
            double b = 3;
            double expected = 15;

            double actual = calcultor.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_By_Zero()
        {
            double a = 5;
            double b = 0;
            double expected = 0;

            double actual = calcultor.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_By_One_Negative_Integgers()
        {
            double a = 5;
            double b = -3;
            double expected = -15;

            double actual = calcultor.Multiply(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Multiply_Both_Negative_Integgers()
        {
            double a = -5;
            double b = -10;
            double expected = 50;

            double actual = calcultor.Multiply(a, b);
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_By_Zero()
        {
            double a = 5;
            double b = 0;

            Assert.Throws<DivideByZeroException>(() => calcultor.Divide(a, b));
        }

        [Test]
        public void Divide_By_One()
        {
            double a = 5;
            double b = 1;
            double expected = 5;

            double actual = calcultor.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide()
        {
            double a = 5;
            double b = 10;

            double expected = 0.5;

            double actual = calcultor.Divide(a, b);

            Assert.AreEqual(expected, actual);

        }

        [Test]

        public void Divide_Negative_Numbers()
        {

            double a = -5;
            double b = -10;

            double expected = 0.5;

            double actual = calcultor.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }



    }
}