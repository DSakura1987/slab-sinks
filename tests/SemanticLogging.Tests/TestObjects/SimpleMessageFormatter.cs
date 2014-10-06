﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System.IO;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging;
using Microsoft.Practices.EnterpriseLibrary.SemanticLogging.Formatters;

namespace FullScale180.SemanticLogging.Sinks.Tests.TestObjects
{
    internal class SimpleMessageFormatter : IEventTextFormatter
    {
        public void WriteEvent(EventEntry eventEntry, TextWriter writer)
        {
            writer.Write(eventEntry.FormattedMessage);
        }
    }
}
