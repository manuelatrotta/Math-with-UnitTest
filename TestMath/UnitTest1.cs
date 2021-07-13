using NUnit.Framework;

namespace TestMath
{
    [TestFixture]
    public class MathTests
    {
        // aggiunta classe Math private e metodo setup con attibuto Setup per pulizia codice della ripetuta creazione d'istanza Math nei casi di test
        private Math _math;

        [SetUp]
        public void SetUp()
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
        // utilizzando i TestCase è possibile inserire i diversi casi tramite i parametri e il valore aspettato riducendo il codice di test in un solo metodo
        [Test]
        [TestCase(1,2,2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnGreaterThanArgument(int a, int b, int expectedResult)
        {
            //var math = new Math();

            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));


       }
     //   [Test]
     //   public void Max_SecondtArgumentGreater_ReturnSecond()
      //  {
            //var math = new Math();

       //     var result = _math.Max(1, 2);

       //     Assert.That(result, Is.EqualTo(2));

      //  }
       // [Test]
      //  public void Max_FirstAreEqualSecondArgumentGreater_ReturnAreEqual()
      //  {
            //var math = new Math();

       //     var result = _math.Max(2, 2);

       //     Assert.That(result, Is.EqualTo(2));
       // }


    }
}