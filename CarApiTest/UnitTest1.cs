using CarApi.Controllers;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CarApiTest
{
    public class Tests
    {
        private Mock<IRepository<Car>> _menu;
        private CarsApiController _controller;

        [SetUp]
        public void Setup()
        {
            _menu = new Mock<IRepository<Car>>();
            _controller = new CarsApiController(_menu.Object);
        }

        [Test]
        public void Get_WhenCalled_ReturnsListOfMenuItems()
        {

            _menu.Setup(repo => repo.GetAll()).Returns(new List<Car> {new Car()
                {
                    Id = 1,
                    Name = "HaundaCity",
                    Color = "Black",
                    Speed = 180,
                    Engine = "Diesel",
                    CartypeId = 3,
                    Available = 4
                } });

            var result = _controller.Get();


            Assert.That(result.Count, Is.EqualTo(1));
        }

        
    }
}
