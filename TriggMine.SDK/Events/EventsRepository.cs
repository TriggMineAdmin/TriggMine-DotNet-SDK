using System;
using System.Collections.Generic;
using TriggMine.SDK.Models;

namespace TriggMine.SDK.Events
{
    /// <summary>
    /// TriggMine API event urls
    /// </summary>
    internal static class EventsRepository
    {
        internal static string GetEventUrl(Type type)
        {
            var urlRepository = new Dictionary<Type, string>()
            {
                [typeof(CartEvent)] = "/api/events/cart",
                [typeof(HistoryEvents)] = "/api/events/history",
                [typeof(LoginEvent)] = "/api/events/prospect/login",
                [typeof(LogoutEvent)] = "/api/events/prospect/logout",
                [typeof(NavigationEvent)] = "/api/events/navigation",
                [typeof(OrderEvent)] = "/api/events/order",
                [typeof(ProspectEvent)] = "/api/events/prospect/registration",
                [typeof(PluginDiagnosticEvent)] = "/control/api/plugin/onDiagnosticInformationUpdated"
            };

            return urlRepository[type];
        }
    }
}
