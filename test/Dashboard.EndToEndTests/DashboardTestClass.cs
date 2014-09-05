﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Dashboard.EndToEndTests.DomAbstractions;
using Xunit;

namespace Dashboard.EndToEndTests
{
    public class DashboardTestClass<T> : IUseFixture<T>
        where T : DashboardTestFixture, new ()
    {
        protected WebJobsDashboard Dashboard { get; private set; }

        public virtual void SetFixture(T data)
        {
            Dashboard = data.CreateDashboard();
        }
    }
}
