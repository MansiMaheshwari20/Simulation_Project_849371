using CarRental.Controllers;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace NunitCarRentalTest
{
    public class Tests
    {
        private Mock<IRepository<RentalCar>> _menu;
        private CarsRentalController _controller;

        [SetUp]
        public void Setup()
        {
            _menu = new Mock<IRepository<RentalCar>>();
            _controller = new CarsRentalController(_menu.Object);
        }

        [Test]
        public void Get_WhenCalled_ReturnsListOfMenuItems()
        {

            _menu.Setup(repo => repo.GetAll()).Returns(new List<RentalCar> {new RentalCar()
                {
                    Idclient = 1,
                    Nameclient = "Mansi",
                    Address = "Dehradun",
                    Adhar = "234365",
                    CarId = 1,
                } });

            var result = _controller.Get();


            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public void Post_WhenCalled_ReturnsOk()
        {

            _menu.Setup(repo => repo.Add(It.IsAny<RentalCar>())).Verifiable();

            var result = _controller.Post(new RentalCar { });


            //Assert.AreEqual(200,result.StatusCode);
            Assert.That(result, Is.TypeOf<OkResult>());
        }
    }
}
