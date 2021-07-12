using NUnit.Framework;

namespace TestMath
{
    [TestFixture]
    public class MathTests
    {   
        // aggiunta classe Math private e metodo setup con attibuto Setup per pulizia codice della ripetuta creazione d'istanza Math nei casi di test
        private Math _math;

        public void Setup()
        {
            _math = new Math();
        }


        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // parte 1 disporre le variabili 
            //var math = new Math();
            // il test passa se 1+2 == 3 
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));

        }

        [Test]
        public void Max_FirstArgumentGreater_ReturnFirst()
        {
            //var math = new Math();

            var result = _math.Max(2, 1);

            Assert.That(result, Is.EqualTo(2));

           
        }
        [Test]
        public void Max_SecondtArgumentGreater_ReturnSecond()
        {
            //var math = new Math();

            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));

        }
        [Test]
        public void Max_FirstAreEqualSecondArgumentGreater_ReturnAreEqual()
        {
            //var math = new Math();

            var result = _math.Max(2, 2);

            Assert.That(result, Is.EqualTo(2));
        }


    }
}