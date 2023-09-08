﻿using BindOpen.Kernel.Processing;
using NUnit.Framework;

namespace BindOpen.Kernel.Hosting.Loggers
{
    /// <summary>
    /// 
    /// </summary>
    [TestFixture]
    public class LoggersTests
    {
        /// <summary>
        /// 
        /// </summary>
        [OneTimeSetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void DefaultConfigurationTest()
        {
            var appHost = BdoHosting.NewHost(
                //options => options
                //.SetLogger(BdoLogging.NewLogger<Logger>)
                );
            appHost.Start();

            Assert.That(appHost.State == ProcessExecutionState.Pending, "Application host not load failed");
        }
    }
}