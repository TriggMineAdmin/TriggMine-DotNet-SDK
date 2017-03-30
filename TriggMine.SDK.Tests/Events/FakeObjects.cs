using System;
using TriggMine.SDK.Models;

namespace TriggMine.SDK.Tests.Events
{
    /// <summary>
    /// Source for fake testing objects
    /// </summary>
    internal class FakeObjects
    {
        private static int GetRandomInt() => new Random().Next();
        private static double GetRandomDouble() => new Random().NextDouble();
        internal ProductEvent GetProductEvent()
            => new ProductEvent()
            {
                ProductCategories = new[] {Guid.NewGuid().ToString(), Guid.NewGuid().ToString()},
                ProductDescription = Guid.NewGuid().ToString(),
                ProductId = Guid.NewGuid().ToString(),
                ProductImage = Guid.NewGuid().ToString(),
                ProductName = Guid.NewGuid().ToString(),
                ProductPrice = GetRandomDouble(),
                ProductQty = GetRandomInt(),
                ProductSku = Guid.NewGuid().ToString(),
                ProductTotalVal = Guid.NewGuid().ToString(),
                ProductUrl = Guid.NewGuid().ToString()
            };

        internal ProspectEvent GetProspectEvent() 
            => new ProspectEvent()
            {
                DeviceId = Guid.NewGuid().ToString(),
                SecondaryDeviceId = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                FirstName = Guid.NewGuid().ToString(),
                LastName = Guid.NewGuid().ToString(),
                Email = Guid.NewGuid().ToString(),
                RegistrationDate = DateTime.Now
            };

        internal CartEvent GeCartEvent()
            => new CartEvent()
            {
                Customer = GetProspectEvent(),
                OrderId = Guid.NewGuid().ToString(),
                PriceTotal = GetRandomDouble(),
                QtyTotal = GetRandomInt(),
                Products = new [] { GetProductEvent() }
            };

        internal LoginEvent GetLoginEvent()
            => new LoginEvent()
            {
                DeviceId = Guid.NewGuid().ToString(),
                SecondaryDeviceId = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                FirstName = Guid.NewGuid().ToString(),
                LastName = Guid.NewGuid().ToString(),
                Email = Guid.NewGuid().ToString(),
                RegistrationDate = DateTime.Now
            };

        internal LogoutEvent GetLogoutEvent()
            => new LogoutEvent()
            {
                DeviceId = Guid.NewGuid().ToString(),
                SecondaryDeviceId = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                FirstName = Guid.NewGuid().ToString(),
                LastName = Guid.NewGuid().ToString(),
                Email = Guid.NewGuid().ToString(),
                RegistrationDate = DateTime.Now
            };

        internal NavigationEvent GetNavigationEvent()
            => new NavigationEvent()
            {
                Products = new[] {GetProductEvent(), GetProductEvent()},
                Customer = GetProspectEvent(),
                UserAgent = Guid.NewGuid().ToString()
            };

        internal OrderEvent GetOrderEvent()
            => new OrderEvent()
            {
                Products = new[] {GetProductEvent(), GetProductEvent()},
                Customer = GetProspectEvent(),
                QtyTotal = GetRandomInt(),
                PriceTotal = GetRandomDouble(),
                OrderId = Guid.NewGuid().ToString(),
                DateCreated = DateTime.Now,
                OrderStatus = Guid.NewGuid().ToString()
            };

        internal PluginDiagnosticEvent GetPluginDiagnosticEvent()
            => new PluginDiagnosticEvent()
            {
                Status = 1,
                DateCreated = DateTime.Now,
                Description = Guid.NewGuid().ToString(),
                DiagnosticType = "InstallPlugin"
            };

        internal HistoryEvents GetHistoryEvent()
            => new HistoryEvents()
            {
                HistoryOrders = new[]
                {
                    new HistoryEvent()
                    {
                        Products = new[] {GetProductEvent(), GetProductEvent()},
                        QtyTotal = GetRandomInt(),
                        DateCreated = DateTime.Now.ToString(),
                        OrderId = Guid.NewGuid().ToString(),
                        PriceTotal = GetRandomDouble(),
                        Status = Guid.NewGuid().ToString(),
                        Prospect = new CustomerEvent()
                        {
                            RegistrationDate = DateTime.Now,
                            Email = Guid.NewGuid().ToString(),
                            FirstName = Guid.NewGuid().ToString(),
                            LastName = Guid.NewGuid().ToString(),
                            CustomerId = Guid.NewGuid().ToString(),
                            LastLoginDate = DateTime.Now
                        }
                    }
                }
            };

        internal CartEvent GetCartEvent()
            => new CartEvent()
            {
                Products = new[] {GetProductEvent(), GetProductEvent()},
                QtyTotal = GetRandomInt(),
                PriceTotal = GetRandomDouble(),
                OrderId = Guid.NewGuid().ToString(),
                Customer = GetProspectEvent()
            };
    }
}
