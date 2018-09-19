using Animals;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AnimalTest
{
    [TestClass]
    public class DuckTest
    {
        [TestMethod]
        public void sut_has_Name_property()
        {
            typeof(Duck).Should().HaveProperty<string>("Name");
        }

        [TestMethod]
        public void constructor_sets_property_correctly()
        {
            // Arrange
            var name = $"{Guid.NewGuid()}";

            // Act
            var sut = new Duck(name);

            // Assert
            sut.Name.Should().Be(name);
        }
    }
}
