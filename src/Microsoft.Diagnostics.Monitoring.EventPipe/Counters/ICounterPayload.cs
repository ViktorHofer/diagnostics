﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Diagnostics.Monitoring.EventPipe
{
    public enum CounterType
    {
        //Same as average or mean
        Metric,

        //Same as sum
        Rate
    }

    public interface ICounterPayload
    {
        string Name { get; }

        double Value { get; }

        CounterType CounterType { get; }

        string Provider { get; }

        string DisplayName { get; }

        string Unit { get; }

        DateTime Timestamp { get; }

        float Interval { get; }

        IReadOnlyDictionary<string, string> Metadata { get; }

        public EventType EventType { get; set; }
    }
}
