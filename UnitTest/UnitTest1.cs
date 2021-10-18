using ConsoleApp9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OtrMinutes()
        {
            int min = -50;
            Time a = new Time(0, min);
            Assert.AreEqual(a.Minutes, 0);
        }
        [TestMethod]
        public void HoursSv()
        {
            int h = 2;
            Time a = new Time(h, 0);
            Assert.AreEqual(a.Hours, h);
        }
        [TestMethod]
        public void HoursSvOtr()
        {
            int h = -4;
            Time a = new Time(h, 0);
            Assert.AreEqual(a.Hours, 0);
        }
        [TestMethod]
        public void Perevod()
        {
            Time a = new Time(0, 120);
            Time expected = new Time(2, 0);
            Assert.AreEqual(a, expected);
        }
        [TestMethod]
        public void Inc()
        {
            Time a = new Time(1, 0);
            Time b = new Time(1, 1);
            Assert.AreEqual(++a, b);
        }
        [TestMethod]
        public void Dec()
        {
            Time a = new Time(1, 0);
            Time b = new Time(0, 59);
            Assert.AreEqual(--a, b);
        }
        [TestMethod]
        public void DecNul()
        {
            Time a = new Time(0, 0);
            Assert.AreEqual(--a, a);
        }
        [TestMethod]
        public void PribMin()
        {
            Time a = new Time(1, 0);
            Time b = new Time(1, 20);
            a.AddTime1(20);
            Assert.AreEqual(a, b);
        }
        [TestMethod]
        public void SlojObj()
        {
            Time a = new Time(1, 40);
            Time b = new Time(1, 30);
            Time c = new Time(3, 10);
            Time d = a + b;
            Assert.AreEqual(c, d);
        }
        [TestMethod]
        public void VychObj()
        {
            Time a = new Time(1, 40);
            Time b = new Time(1, 30);
            Time c = new Time(0, 10);
            Time d = a - b;
            Assert.AreEqual(c, d);
        }
        [TestMethod]
        public void VychObjOtr()
        {
            Time a = new Time(2, 40);
            Time b = new Time(1, 30);
            Time c = new Time(0, 10);
            Time n = new Time();
            Time d = b - a;
            Assert.AreEqual(d, n);
        }
        [TestMethod]
        public void Okruglenie()
        {
            Time a = new Time(1, 40);
            int res = 1;
            int srav = (int)(a);
            Assert.AreEqual(res, srav);
        }
        [TestMethod]
        public void ProverkaNeNul()
        {
            Time a = new Time(1, 40);
            bool res = a;
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void ProverkaNul()
        {
            Time a = new Time(0, 0);
            bool res = a;
            Assert.IsFalse(res);
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Dlina()
        {
            int q = 3;
            TimeArray a = new TimeArray(q);
            int b = a.Length;
            Assert.AreEqual(b, q);
        }
        [TestMethod]
        public void Rand()
        {
            TimeArray q = new TimeArray(5);
            Assert.AreEqual(q.Length, 5);
        }
        [TestMethod]
        public void NoParams()
        {
            TimeArray q = new TimeArray();
            Time a = new Time();
            Assert.AreEqual(q[0], a);
        }
        [TestMethod]
        public void Vruch()
        {
            Time a = new Time();
            Time b = new Time(1, 0);
            Time c = new Time(1, 50);
            Time[] mas = new Time[] { a, b, c };
            TimeArray q = new TimeArray(3, mas);
            Assert.AreEqual(q[0], a);
        }
        [TestMethod]
        public void Index()
        {
            Time a = new Time();
            Time b = new Time(1, 0);
            Time c = new Time(1, 50);
            Time[] mas = new Time[] { a, b, c };
            TimeArray q = new TimeArray(3, mas);
            Time d = new Time(2, 0);
            q[0] = new Time(2, 0);
            Assert.AreEqual(q[0], d);
        }
        [TestMethod]
        public void IndexNeSozd()
        {
            Time a = new Time();
            Time b = new Time(1, 0);
            Time c = new Time(1, 50);
            Time[] mas = new Time[] { a, b, c };
            TimeArray q = new TimeArray(3, mas);
            Time d = q[7];
            Assert.AreEqual(d, a);
        }
        [TestMethod]
        public void Perenos()
        {
            Time a = new Time();
            Time b = new Time(1, 0);
            Time c = new Time(1, 50);
            Time[] mas = new Time[] { a, b, c };
            TimeArray q = new TimeArray(mas);
            Assert.AreEqual(q[0], a);
        }
        [TestClass]
        public class TestUnit3
        {
            [TestMethod]
            public void PribMinProg()
            {
                Time a = new Time();
                Time b = new Time(0, 50);
                a = Program.AddTime(ref a, 50);
                Assert.AreEqual(a, b);
            }

        }
    }
}
