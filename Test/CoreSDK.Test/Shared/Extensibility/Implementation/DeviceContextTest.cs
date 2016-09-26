﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation
{
    using System.Collections.Generic;
    using System.Reflection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Assert = Xunit.Assert;

    [TestClass]
    public class DeviceContextTest
    {
        [TestMethod]
        public void ClassIsPublicToAllowInstantiationInSdkAndUserCode()
        {
            Assert.True(typeof(DeviceContext).GetTypeInfo().IsPublic);
        }
        
        [TestMethod]
        public void TypeIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            Assert.Null(context.Type);
        }

        [TestMethod]
        public void TypeCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            context.Type = "test value";
            Assert.Equal("test value", context.Type);
        }

        [TestMethod]
        public void IdIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            Assert.Null(context.Id);
        }

        [TestMethod]
        public void IdCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            context.Id = "test value";
            Assert.Equal("test value", context.Id);
        }

        [TestMethod]
        public void OperatingSystemIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            Assert.Null(context.OperatingSystem);
        }

        [TestMethod]
        public void OperatingSystemCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            context.OperatingSystem = "test value";
            Assert.Equal("test value", context.OperatingSystem);
        }

        [TestMethod]
        public void OemNameIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            Assert.Null(context.OemName);
        }

        [TestMethod]
        public void OemNameCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            context.OemName = "test value";
            Assert.Equal("test value", context.OemName);
        }

        [TestMethod]
        public void DeviceModelIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            Assert.Null(context.Model);
        }

        [TestMethod]
        public void DeviceModelCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
            context.Model = "test value";
            Assert.Equal("test value", context.Model);
        }

        [TestMethod]
        public void NetworkTypeIsNullByDefaultToPreventUnnecessaryTransmissionOfDefaultValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
#pragma warning disable 618
            Assert.Null(context.NetworkType);
#pragma warning restore 618
        }

        [TestMethod]
        public void NetworkTypeCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
#pragma warning disable 618
            context.NetworkType = "42";
            Assert.Equal("42", context.NetworkType);
#pragma warning restore 618
        }

        [TestMethod]
        public void ScreenResolutionIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
#pragma warning disable 618
            Assert.Null(context.ScreenResolution);
#pragma warning restore 618
        }

        [TestMethod]
        public void ScreenResolutionCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
#pragma warning disable 618
            context.ScreenResolution = "test value";
            Assert.Equal("test value", context.ScreenResolution);
#pragma warning restore 618
        }

        [TestMethod]
        public void LanguageIsNullByDefaultToAvoidSendingItToEndpointUnnecessarily()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
#pragma warning disable 618
            Assert.Null(context.Language);
#pragma warning restore 618
        }

        [TestMethod]
        public void LanguageCanBeChangedByUserToSpecifyACustomValue()
        {
            var context = new DeviceContext(new Dictionary<string, string>(), new Dictionary<string, string>());
#pragma warning disable 618
            context.Language = "test value";
            Assert.Equal("test value", context.Language);
#pragma warning restore 618
        }
    }
}
