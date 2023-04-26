using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestRoomNumber
{
    public class Tests
    {
        [TestFixture]
        internal class Test
        {
            [Test]
            public void NumberOfSets_122_2()
            {
                var roomNumber = 122;

                int result = RoomNumber.numberOfSets(roomNumber);
                Assert.That(result, Is.EqualTo(2));
            }

            [Test]
            public void NumberOfSets_9999_2()
            {
                var roomNumber = 9999;

                int result = RoomNumber.numberOfSets(roomNumber);
                Assert.That(result, Is.EqualTo(2));
            }

            [Test]
            public void NumberOfSets_12635_1()
            {
                var roomNumber = 12635;

                int result = RoomNumber.numberOfSets(roomNumber);
                Assert.That(result, Is.EqualTo(1));
            }

            [Test]
            public void NumberOfSets_888888_6()
            {
                var roomNumber = 888888;

                int result = RoomNumber.numberOfSets(roomNumber);
                Assert.That(result, Is.EqualTo(6));
            }

            [Test]
            public void NumberOfSets_96_1()
            {
                var roomNumber = 96;

                int result = RoomNumber.numberOfSets(roomNumber);
                Assert.That(result, Is.EqualTo(1));
            }

            [Test]
            public void NumberOfSets_999999_3()
            {
                var roomNumber = 999999;

                int result = RoomNumber.numberOfSets(roomNumber);
                Assert.That(result, Is.EqualTo(3));
            }

            [Test]
            public void NumberOfSets_1000000_6()
            {
                var roomNumber = 1000000;

                int result = RoomNumber.numberOfSets(roomNumber);
                Assert.That(result, Is.EqualTo(6));
            }

            [Test]
            public void NumberOfSets_1000001_Exception()
            {
                var roomNumber = 1000001;

                var exception = Assert.Throws<ArgumentException>(() => RoomNumber.numberOfSets(roomNumber));

                Assert.That($"Please provide number in range from {RoomNumber.LowerLimit} to {RoomNumber.UpperLimit}.", Is.EqualTo(exception.Message));
            }
        }
    }
}