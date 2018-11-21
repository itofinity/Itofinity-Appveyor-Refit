/* 
 * AppVeyor REST API
 *
 * AppVeyor is a hosted continuous integration service which runs on Microsoft Windows.  The AppVeyor REST API provides a RESTful way to interact with the AppVeyor service.  This includes managing projects, builds, deployments, and the teams that build them.  Additional help and discussion of the AppVeyor REST API is available at http://help.appveyor.com/discussions  This Swagger definition is an **unofficial** description of the AppVeyor REST API maintained at https://github.com/kevinoid/appveyor-swagger Please report any issues or suggestions for this Swagger definition at https://github.com/kevinoid/appveyor-swagger/issues/new  #### API Conventions  Fields which are missing from update operations (`PUT` requests) are typically reset to their default values.  So although most fields are not technically required, they should usually be specified in practice. 
 *
 * OpenAPI spec version: 0.20181117.0
 * Contact: team@appveyor.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Model;
using Itofinity.Appveyor.Refit.Client;
using System.Reflection;

namespace Itofinity.Appveyor.Refit.Test
{
    /// <summary>
    ///  Class for testing UserAccountSettings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserAccountSettingsTests
    {
        // TODO uncomment below to declare an instance variable for UserAccountSettings
        //private UserAccountSettings instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UserAccountSettings
            //instance = new UserAccountSettings();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserAccountSettings
        /// </summary>
        [Test]
        public void UserAccountSettingsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UserAccountSettings
            //Assert.IsInstanceOfType<UserAccountSettings> (instance, "variable 'instance' is a UserAccountSettings");
        }

        /// <summary>
        /// Test the property 'SuccessfulBuildNotification'
        /// </summary>
        [Test]
        public void SuccessfulBuildNotificationTest()
        {
            // TODO unit test for the property 'SuccessfulBuildNotification'
        }
        /// <summary>
        /// Test the property 'FailedBuildNotification'
        /// </summary>
        [Test]
        public void FailedBuildNotificationTest()
        {
            // TODO unit test for the property 'FailedBuildNotification'
        }
        /// <summary>
        /// Test the property 'NotifyWhenBuildStatusChangedOnly'
        /// </summary>
        [Test]
        public void NotifyWhenBuildStatusChangedOnlyTest()
        {
            // TODO unit test for the property 'NotifyWhenBuildStatusChangedOnly'
        }
        /// <summary>
        /// Test the property 'SuccessfulDeploymentNotification'
        /// </summary>
        [Test]
        public void SuccessfulDeploymentNotificationTest()
        {
            // TODO unit test for the property 'SuccessfulDeploymentNotification'
        }
        /// <summary>
        /// Test the property 'FailedDeploymentNotification'
        /// </summary>
        [Test]
        public void FailedDeploymentNotificationTest()
        {
            // TODO unit test for the property 'FailedDeploymentNotification'
        }
        /// <summary>
        /// Test the property 'NotifyWhenDeploymentStatusChangedOnly'
        /// </summary>
        [Test]
        public void NotifyWhenDeploymentStatusChangedOnlyTest()
        {
            // TODO unit test for the property 'NotifyWhenDeploymentStatusChangedOnly'
        }

    }

}
