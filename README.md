## Analytics: Dive Deep into Your Website's Performance with .NET 9

[![NuGet Version](https://img.shields.io/nuget/v/wangkanai.analytics)](https://www.nuget.org/packages/wangkanai.analytics)
[![NuGet Pre Release](https://img.shields.io/nuget/vpre/wangkanai.analytics)](https://www.nuget.org/packages/wangkanai.analytics)

[![.NET](https://github.com/wangkanai/analytics/actions/workflows/dotnet.yml/badge.svg)](https://github.com/wangkanai/analytics/actions/workflows/dotnet.yml)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=wangkanai_analytics&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=wangkanai_analytics)

[![Open Collective](https://img.shields.io/badge/open%20collective-support%20me-3385FF.svg)](https://opencollective.com/wangkanai)
[![Patreon](https://img.shields.io/badge/patreon-support%20me-d9643a.svg)](https://www.patreon.com/wangkanai)
[![GitHub](https://img.shields.io/github/license/wangkanai/analytics)](https://github.com/wangkanai/analytics/blob/main/LICENSE)

Welcome to `Analytics`, a dynamic .NET 9 library that does more than just track your website's visitors.
It unravels the story behind your traffic, providing insightful statistics that empower you to make data-driven decisions.

In the digital age, understanding your website's performance is more than a luxury - it's a necessity.
`Analytics` delivers on this requirement, offering a comprehensive suite of tracking features.
From session duration and pages per session to bounce rate and traffic source, `Analytics` tracks it all, turning raw data into valuable insights.

But `Analytics` is more than just a data tracker.
It's a compass guiding you through the vast ocean of website metrics, helping you understand your audience better.
Whether you're gauging the success of a marketing campaign or optimizing your website's user experience,
`Analytics` gives you the information you need, when you need it.

The heart of `Analytics` lies in its community of developers.
We believe in the transformative power of data, and we're committed to making website analytics accessible to all .NET developers.
Whether you're a seasoned data analyst or a developer just dipping your toes into website analytics, Analytics is designed with you in mind.

## Features

- **Real-time Analytics**: Track user interactions in real-time
- **Session Management**: Monitor session duration and user engagement
- **Page View Tracking**: Detailed page view analytics with referrer information
- **User Journey Mapping**: Understand how users navigate through your site
- **Traffic Source Analysis**: Identify where your visitors are coming from
- **Performance Metrics**: Bounce rate, conversion tracking, and more
- **Privacy-First**: Built with privacy considerations and GDPR compliance in mind
- **.NET 9 Optimized**: Built for the latest .NET framework with modern C# features

## Quick Start

### Installation

Install the Analytics package from NuGet:

```bash
dotnet add package Wangkanai.Analytics
```

### Basic Setup

1. **Add Analytics services** in your `Program.cs`:

```csharp
using Wangkanai.Analytics;

var builder = WebApplication.CreateBuilder(args);

// Add Analytics services
builder.Services.AddAnalytics();

var app = builder.Build();

// Use Analytics middleware
app.UseAnalytics();

app.MapControllers();
app.Run();
```

2. **Configure options** (optional):

```csharp
builder.Services.AddAnalytics(options =>
{
    options.TrackPageViews = true;
    options.TrackUserSessions = true;
    options.EnableRealTimeTracking = true;
    // Additional configuration options
});
```

### Advanced Usage

For detailed usage examples, configuration options, and advanced scenarios, please see our [Installation Guide](INSTALL.md).

## Documentation

- [Installation Guide](INSTALL.md) - Comprehensive setup and configuration guide
- [API Reference](https://docs.wangkanai.com/analytics) - Complete API documentation
- [Examples](https://github.com/wangkanai/analytics/tree/main/samples) - Sample applications and use cases
- [Migration Guide](docs/migration.md) - Upgrading from previous versions

## Requirements

- **.NET 9.0** or later
- **ASP.NET Core 9.0** or later
- Compatible with all .NET 9 supported platforms

## Dependencies

- `Wangkanai.Detection` - For device and browser detection capabilities
- `Microsoft.AspNetCore.App` - ASP.NET Core framework reference

## Contributing

We welcome contributions! Here's how you can help:

1. **Report Issues**: Found a bug or have a feature request? [Open an issue](https://github.com/wangkanai/analytics/issues)
2. **Submit PRs**: Have a fix or improvement? Submit a pull request
3. **Documentation**: Help improve our documentation and examples
4. **Testing**: Help test new features and report compatibility issues

Please read our [Contributing Guidelines](CONTRIBUTING.md) for more information.

## Support

If you find this project useful, please consider:

- ⭐ **Starring the repository** to show your support
- 💰 **Sponsoring the project** through [GitHub Sponsors](https://github.com/sponsors/wangkanai)
- 🗣️ **Spreading the word** about Analytics in the .NET community

## Community

- [GitHub Discussions](https://github.com/wangkanai/analytics/discussions) - Ask questions, share ideas
- [Discord Server](https://discord.gg/wangkanai) - Real-time community chat
- [Stack Overflow](https://stackoverflow.com/questions/tagged/wangkanai-analytics) - Technical questions

## License

This project is licensed under the [Apache License 2.0](LICENSE) - see the LICENSE file for details.

## Acknowledgments

Special thanks to all contributors and the .NET community for making this project possible.

---

**Analytics** is part of the [Wangkanai](https://github.com/wangkanai) ecosystem of .NET libraries designed to make web development more efficient and data-driven.