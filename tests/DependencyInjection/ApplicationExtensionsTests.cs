// Copyright (c) 2014-2025 Sarin Na Wangkanai, All Rights Reserved.

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;

namespace Microsoft.Extensions.DependencyInjection;

public class ApplicationExtensionsTests
{
   [Fact]
   public void UseAnalytics_ThrowsInvalidOptionException_IfMakerServiceIsNotRegister()
   {
      // Arrange
      var provider = new Mock<IServiceProvider>();
      provider.Setup(s => s.GetService(typeof(ILoggerFactory)))
              .Returns(Mock.Of<ILoggerFactory>());
      var app = new Mock<IApplicationBuilder>();
      app.Setup(x => x.ApplicationServices)
         .Returns(provider.Object);

      // Act
      var exception = Assert.Throws<InvalidOperationException>(() => app.Object.UseAnalytics());

      // Assert
      Assert.Equal("AnalyticsMarkerService is not added to ConfigureServices(...)", exception.Message);
   }
}