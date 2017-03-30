using System;
using System.Net;
using NUnit.Framework;
using TriggMine.SDK.Events;
using TriggMine.SDK.Models;
using static System.Configuration.ConfigurationSettings;

namespace TriggMine.SDK.Tests.Events
{
    [TestFixture]
    public class EventTests
    {
        private readonly string _apiKey = AppSettings["ApiKey"]; //Your ApiKey > https://client.triggmine.com.ua/login > Settings > Integration
        private readonly string _apiUrl = AppSettings["ApiUrl"];
        private readonly FakeObjects _fakeObjects = new FakeObjects();
        private readonly TriggmineApi _triggmineApi;
        public EventTests()
        {
            _triggmineApi = new TriggmineApi(_apiKey, new Uri(_apiUrl));
        }

        [Test]
        public void Send_Registration_Event_Success()
        {
            //Arrange
            var fakeProspect = _fakeObjects.GetProspectEvent();

            //Act
            var result = _triggmineApi.SendEvent(fakeProspect);
            var resultAsync = _triggmineApi.SendEventAsync(fakeProspect);
            var staticResult = TriggmineApi.SendEvent(fakeProspect, _apiKey, new Uri(_apiUrl));

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, result.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, staticResult.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, resultAsync.Result.StatusCode);
        }

        [Test]
        public void Send_Cart_Event_Success()
        {
            //Arrange
            var fakeCart = _fakeObjects.GetCartEvent();

            //Act
            var result = _triggmineApi.SendEvent(fakeCart);
            var resultAsync = _triggmineApi.SendEventAsync(fakeCart);
            var staticResult = TriggmineApi.SendEvent(fakeCart, _apiKey, new Uri(_apiUrl));

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, result.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, staticResult.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, resultAsync.Result.StatusCode);
        }

        [Test]
        public void Send_History_Event_Success()
        {
            //Arrange
            var fakeHistory = _fakeObjects.GetHistoryEvent();

            //Act
            var result = _triggmineApi.SendEvent(fakeHistory);
            var resultAsync = _triggmineApi.SendEventAsync(fakeHistory);
            var staticResult = TriggmineApi.SendEvent(fakeHistory, _apiKey, new Uri(_apiUrl));

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, staticResult.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, resultAsync.Result.StatusCode);
        }

        [Test]
        public void Send_Login_Event()
        {
            //Arrange
            var fakeLogin = _fakeObjects.GetLoginEvent();

            //Act
            var result = _triggmineApi.SendEvent(fakeLogin);
            var resultAsync = _triggmineApi.SendEventAsync(fakeLogin);
            var staticResult = TriggmineApi.SendEvent(fakeLogin, _apiKey, new Uri(_apiUrl));

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, staticResult.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, resultAsync.Result.StatusCode);
        }

        [Test]
        public void Send_Logout_Event_Success()
        {
            //Arrange
            var fakeLogout = _fakeObjects.GetLogoutEvent();

            //Act
            var result = _triggmineApi.SendEvent(fakeLogout);
            var resultAsync = _triggmineApi.SendEventAsync(fakeLogout);
            var staticResult = TriggmineApi.SendEvent(fakeLogout, _apiKey, new Uri(_apiUrl));

            //Assert
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, staticResult.StatusCode);
            Assert.AreEqual(HttpStatusCode.OK, resultAsync.Result.StatusCode);
        }

        [Test]
        public void Send_Navigation_Event_Success()
        {
            //Arrange
            var fakeNavigation = _fakeObjects.GetNavigationEvent();

            //Act
            var result = _triggmineApi.SendEvent(fakeNavigation);
            var resultAsync = _triggmineApi.SendEventAsync(fakeNavigation);
            var staticResult = TriggmineApi.SendEvent(fakeNavigation, _apiKey, new Uri(_apiUrl));

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, result.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, staticResult.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, resultAsync.Result.StatusCode);
        }

        [Test]
        public void Send_Order_Event_Success()
        {
            //Arrange
            var fakeOrder = _fakeObjects.GetOrderEvent();

            //Act
            var result = _triggmineApi.SendEvent(fakeOrder);
            var resultAsync = _triggmineApi.SendEventAsync(fakeOrder);
            var staticResult = TriggmineApi.SendEvent(fakeOrder, _apiKey, new Uri(_apiUrl));

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, result.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, staticResult.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, resultAsync.Result.StatusCode);
        }

        [Test]
        public void Send_Plug_Diagnostic_Event_Success()
        {
            //Arrange
            var fakePlugDiagnostic = _fakeObjects.GetPluginDiagnosticEvent();

            //Act
            var result = _triggmineApi.SendEvent(fakePlugDiagnostic);
            var resultAsync = _triggmineApi.SendEventAsync(fakePlugDiagnostic);
            var staticResult = TriggmineApi.SendEvent(fakePlugDiagnostic, _apiKey, new Uri(_apiUrl));

            //Assert
            Assert.AreEqual(HttpStatusCode.Created, result.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, staticResult.StatusCode);
            Assert.AreEqual(HttpStatusCode.Created, resultAsync.Result.StatusCode);
        }

    }
}
