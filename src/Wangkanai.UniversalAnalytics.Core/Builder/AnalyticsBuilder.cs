﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using Microsoft.Extensions.DependencyInjection;
using Wangkanai.UniversalAnalytics.Core.Applications;

namespace Wangkanai.UniversalAnalytics.Core.Builder
{
    public class AnalyticsBuilder : IAnalyticsBuilder
    {
        public IServiceCollection Services { get; }
        public AnalyticsManager Manager { get; }

        public AnalyticsBuilder(IServiceCollection services, AnalyticsManager manager)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (manager == null) throw new ArgumentNullException(nameof(manager));

            Services = services;
            Manager = manager;
        }        
    }
}
