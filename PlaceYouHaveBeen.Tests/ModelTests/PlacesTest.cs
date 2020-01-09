using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Places.Models;

namespace Places.Tests
{
    [TestClass]
    public class PlaceTest : IDisposable
    {
        public void Dispose()
        {
            Place.ClearAll();
        }

        [TestMethod]
        public void PlaceConstructor_CreateInstanceOfPlace_Place()
        {
            Place newPlace = new Place("Tokyo", "Japan", "This is the journal of the trip to Tokyo.");
            Assert.AreEqual(typeof(Place), newPlace.GetType());
        }
    }
}