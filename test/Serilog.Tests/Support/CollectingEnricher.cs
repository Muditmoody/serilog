﻿using System.Collections.Generic;
using System.Linq;
using Serilog.Core;
using Serilog.Events;

namespace Serilog.Tests.Support
{
    class CollectingEnricher : ILogEventEnricher
    {
        public List<LogEvent> Events { get; } = new List<LogEvent>();

        public LogEvent SingleEvent => Events.Single();

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            Events.Add(logEvent);
        }
    }
}
