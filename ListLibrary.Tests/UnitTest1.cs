using NUnit.Framework;
using System;
using USQLCSharpProject1;
using USQLCSharpProject1.Properties;

namespace ListLibrary.Tests
{
    [TestFixture]
    public class CustomListTests
    {
        private CustomList<int> _list;

        [SetUp]
        public void Setup()
        {
            _list = new CustomList<int>();
        }

        [Test]
        public void Add_ShouldAddElement()
        {
            _list.Add(5);
            Assert.AreEqual(1, _list.Count);
        }

        [Test]
        public void Remove_ShouldRemoveElement()
        {
            _list.Add(10);
            bool removed = _list.Remove(10);
            Assert.IsTrue(removed);
            Assert.AreEqual(0, _list.Count);
        }

        [Test]
        public void Contains_ShouldReturnTrueIfExists()
        {
            _list.Add(20);
            Assert.IsTrue(_list.Contains(20));
        }

        [Test]
        public void Get_ShouldReturnCorrectElement()
        {
            _list.Add(30);
            Assert.AreEqual(30, _list.Get(0));
        }

        [Test]
        public void Get_ShouldThrowExceptionIfIndexOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _list.Get(0));
        }

        [Test]
        public void Clear_ShouldRemoveAllElements()
        {
            _list.Add(40);
            _list.Clear();
            Assert.AreEqual(0, _list.Count);
        }
    }
}