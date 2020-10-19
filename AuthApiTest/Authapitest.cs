using AutApi;
using AutApi.Controllers;
using DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Models;
using Moq;
using NUnit.Framework;
using System;

namespace AuthApiTest
{
    public class Authapitest
    {
        private Mock<IRepository<Authen>> _user;
        private Mock<IConfiguration> _config;
        private Mock<IAuthRepo> _auth1;
        private AuthApiController _controller;

        [SetUp]
        public void Setup()
        {
            _config = new Mock<IConfiguration>();
            _user = new Mock<IRepository<Authen>>();
            _auth1 = new Mock<IAuthRepo>();
            _controller = new AuthApiController(_config.Object, _user.Object, _auth1.Object);
        }

        [Test]
        public void Login_WhenCalled_ReturnsOk()
        {
            Authen user = new Authen()
            {
                Id = 1,
                Username = "Anuj",
                Password = "1234"
            };
            _auth1.Setup(r => r.AuthenticateUser(It.IsAny<Authen>())).Returns(user);
            _auth1.Setup(r => r.GenerateJSONWebToken()).Returns("Token");

            var result = _controller.Login(user);

            Assert.That(result, Is.InstanceOf<OkObjectResult>());
        }

        [Test]
        public void Login_WhenCalled_ReturnsUnAuthorized()
        {
            Authen user = new Authen()
            {
                Id = 1,
                Username = "Mansi",
                Password = "1234"
            };
            _auth1.Setup(r => r.AuthenticateUser(It.IsAny<Authen>())).Returns(() => null);
            _auth1.Setup(r => r.GenerateJSONWebToken()).Returns("Token");

            var result = _controller.Login(user);

            Assert.That(result, Is.InstanceOf<UnauthorizedResult>());
        }
    }
}