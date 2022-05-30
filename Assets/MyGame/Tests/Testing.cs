using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Testing
    {
        public int minIntRand=1;
        public int maxIntRand=10;
        // A Test behaves as an ordinary method
        [Test]
        public void TestingSimplePasses()
        {
            int firstTrueNumber = Random.Range(minIntRand, maxIntRand);
            int secondTrueNumber = Random.Range(minIntRand, maxIntRand);
            GlobalRandomNumber.firstTrueNumber = firstTrueNumber;
            GlobalRandomNumber.secondTrueNumber = secondTrueNumber;
            // Use the Assert class to test conditions
        }

    
        [Test]
        public void FirstNumberFalse()

        {

            int randFalseFirst1 = Random.Range(minIntRand, maxIntRand);
            int randFalseSecond1 = Random.Range(minIntRand, maxIntRand);

            GlobalRandomNumber.falseFirstObject = randFalseFirst1 * randFalseSecond1;
            Assert.AreEqual(true, GlobalRandomNumber.falseFirstObject <= maxIntRand * maxIntRand && GlobalRandomNumber.falseFirstObject >= minIntRand * minIntRand);
            // Use the Assert class to test conditions
        }
        [Test]
        public void SecondNumberFalse ()
        {
            int randFalseFirst2 = Random.Range(minIntRand, maxIntRand);
            int randFalseSecond2 = Random.Range(minIntRand, maxIntRand);
            GlobalRandomNumber.falseSecondObject = randFalseFirst2 * randFalseSecond2;
            Assert.AreEqual(true, GlobalRandomNumber.falseSecondObject <= maxIntRand * maxIntRand && GlobalRandomNumber.falseSecondObject >= minIntRand * minIntRand);
            // Use the Assert class to test conditions
        }
        [Test]
        public void TrueNumberFirst()
        {
            int firstTrueNumber = Random.Range(minIntRand, maxIntRand);

            Assert.AreEqual(true, firstTrueNumber >= minIntRand && firstTrueNumber <= maxIntRand);
            // Use the Assert class to test conditions
        }
        [Test]
        public void TrueNumberSecond()
        {
            int secondTrueNumber = Random.Range(minIntRand, maxIntRand);
            Assert.AreEqual(true, secondTrueNumber >= minIntRand && secondTrueNumber <= maxIntRand);
            // Use the Assert class to test conditions
        }
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestingWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
