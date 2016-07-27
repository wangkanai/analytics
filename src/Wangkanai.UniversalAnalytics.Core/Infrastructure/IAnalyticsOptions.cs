﻿// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The MIT License (MIT). See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wangkanai.UniversalAnalytics.Infrastructure
{
    public interface IAnalyticsOptions
    {
        IEnumerable<IAnalyticsOptionsExtension> Extensions { get; }
        T FindExtension<T>() where T : class, IAnalyticsOptionsExtension;
    }
}
