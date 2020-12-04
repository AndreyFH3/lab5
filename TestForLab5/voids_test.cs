using NUnit.Framework;
using lab5;
using System;

namespace TestForLab5
{
    public class Tests
    {
        voids cls = new voids();

        [Test]
        public void santiPolo()
        {
            string result = cls.DtoS(1);
            Assert.AreEqual(result, "2,54 сантиметров");
        }
        [Test]
        public void santiOtri()
        {
            var exception = Assert.Throws<ArgumentException>(() => cls.DtoS(-1));
            Assert.AreEqual(exception.Message, "Число должно быть не отрицательным");
            Assert.DoesNotThrow(() => cls.DtoS(1));
        }
        [Test]
        public void SantiMax()
        {
            var exception = Assert.Throws<ArgumentException>(() => cls.DtoS(double.MaxValue));
            Assert.AreEqual(exception.Message, "Число должно быть не отрицательным");
            Assert.DoesNotThrow(() => cls.DtoS(1));
        }
        [Test]
        public void nechetnost()
        {
            string result = cls.chetnost(1);
            Assert.AreEqual(result, "число нечетное");
        }
        [Test]
        public void chet()
        {
            string result = cls.chetnost(2);
            Assert.AreEqual(result, "число четное");
        }
        [Test]
        public void biggest_nub()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string result = cls.biggestnum(arr);
            Assert.AreEqual(result, "9");
        }
        [Test]
        public void biggest_nub_min()
        {
            int[] arr = { int.MinValue };
            string result = cls.biggestnum(arr);
            Assert.AreEqual(result, "-1");
        }
        [Test]
        public void biggest_nub_eps()
        {
            int[] arr = { };
            var exception = Assert.Throws<ArgumentException>(() => cls.biggestnum(arr));
            Assert.That(exception.Message, Is.EqualTo("массив должен быть длиннее нуля"));
            int[] warr = {1,32, 2};
            Assert.DoesNotThrow(() => cls.biggestnum(warr));
        }
        [Test]
        public void ostatok()
        {
            double result = cls.ost(2, 1);
            Assert.AreEqual(result, 0);
        }
        [Test]
        public void ostatokbol()
        {
            var exception = Assert.Throws<ArgumentException>(() => cls.ost(2, 0));
            Assert.That(exception.Message, Is.EqualTo("Делитель должен быть >= 0"));
            Assert.DoesNotThrow(() => cls.ost(2, 1));
        }
    }
}