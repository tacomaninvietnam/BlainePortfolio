using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExperimentBase;

namespace SimcoxBUnitTesting
{
    [TestClass]
    public class ExperimentBaseTest
    {
        #region NameTests
        [TestMethod]
        public void NameTest()
        {
            Foo foo = new Foo();
            foo.Name = "Straego";
            string actual = foo.Name;

            string expected = "Straego";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void HandleNull()
        {
            Foo foo = new Foo();
            try
            {
                foo.Name = null;
            }
            catch (ArgumentNullException)
            {

            }
        }

        [TestMethod]
        public void NullNameTest()
        {
            Foo foo = new Foo();
            foo.Name = null;

            Assert.IsNull(foo.Name);
        }

        [TestMethod]
        public void NameIsEmpty()
        {
            Foo foo = new Foo();
            Assert.AreEqual(foo.Name, "");
        } 
        #endregion

        #region RatingTests
        [TestMethod]
        public void RatingNotEqual()
        {
            Foo foo = new Foo();
            foo.Rating = 12;

            Assert.AreNotEqual(foo.Rating, 14);
        }

        [TestMethod]
        public void RatingTooHigh()
        {
            Foo foo = new Foo();
            int testRating = 2 ^ 3;

            foo.Rating = 6;
            Assert.AreNotEqual(foo.Rating, testRating);

        }

        [TestMethod]
        public void RatingNotNull()
        {
            Foo foo = new Foo();
            Assert.IsNotNull(foo.Rating);

        }

        [TestMethod]
        public void RatingNumberInput()
        {
            Foo foo = new Foo();
            foo.Rating = 098765432;
            int actual = 098765432;
            Assert.AreEqual(foo.Rating, actual);

        } 
        #endregion

        #region RegisteredTests
        [TestMethod]
        public void IsRegisteredTest()
        {
            Foo foo = new Foo();
            foo.Registered = true;

            Assert.IsTrue(foo.Registered);
        }

        [TestMethod]
        public void NotRegisteredTest()
        {
            Foo foo = new Foo();
            foo.Registered = false;

            Assert.IsFalse(foo.Registered);
        }

        [TestMethod]
        public void RegisteredDefaultFalseTest()
        {
            Foo foo = new Foo();

            Assert.IsFalse(foo.Registered);
        } 
        #endregion

        #region WhenPurchasedTests
        [TestMethod]
        public void WhenPurchasedEqulityTest()
        {
            Foo foo = new Foo();
            DateTime time = new DateTime();

            foo.WhenPurchased = time;

            Assert.AreEqual(time, foo.WhenPurchased);
        }

        [TestMethod]
        public void WhenPurchasedDataEntryTest()
        {
            Foo foo = new Foo();
            DateTime time = new DateTime(2013, 1, 10);

            foo.WhenPurchased = new DateTime(2013, 1, 10);

            Assert.AreEqual(time, foo.WhenPurchased);
        }

        [TestMethod]
        public void WhenPurchasedOutOfRangeTest()
        {
            Foo foo = new Foo();

            try
            {
                foo.WhenPurchased = new DateTime(1, 10, 2013);
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        } 
        #endregion

        [TestMethod]
        public void FooClassEqualityTest()
        {
            DateTime time = new DateTime(2013,1, 10);
            Foo foo = new Foo("bob", 16, true, time);
            Foo dog = new Foo("bob", 16, true, time);

            Assert.AreEqual(foo.Name, dog.Name);
            Assert.AreEqual(foo.Registered, dog.Registered);
            Assert.AreEqual(foo.Rating, dog.Rating);
            Assert.AreEqual(foo.WhenPurchased, dog.WhenPurchased);
            
        }

        [TestMethod]
        public void FooClassInequalityTest()
        {
            DateTime time = new DateTime(2013, 1, 10);
            DateTime time2 = new DateTime(1999, 1, 10);

            Foo foo = new Foo("bob", 16, true, time);
            Foo dog = new Foo("George", 23, false, time2);

            Assert.AreNotEqual(foo.Name, dog.Name);
            Assert.AreNotEqual(foo.Registered, dog.Registered);
            Assert.AreNotEqual(foo.Rating, dog.Rating);
            Assert.AreNotEqual(foo.WhenPurchased, dog.WhenPurchased);

        }

        [TestMethod]
        public void FooClassConstructorAndTitleCaseEqualityTest()
        {
            DateTime time = new DateTime(2013, 1, 10);
            DateTime time2 = new DateTime(2013, 1, 10);
            
            Foo foo = new Foo("bob", 16, true, time);

            Assert.AreEqual(foo.Name, "Bob");
            Assert.AreEqual(foo.Registered, true);
            Assert.AreEqual(foo.Rating, 16);
            Assert.AreEqual(foo.WhenPurchased, time2);

        }
        
        [TestMethod]
        public void ToStringTest()
        {
            DateTime time = new DateTime(2013, 1, 10);
            Foo foo = new Foo("bob", 16, true, time);
            string test = foo.ToString(); 

            Assert.AreEqual(foo.ToString(), test);
        }
    }


}
