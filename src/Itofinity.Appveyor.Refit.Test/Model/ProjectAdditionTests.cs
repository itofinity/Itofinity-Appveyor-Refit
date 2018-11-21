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
    ///  Class for testing ProjectAddition
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProjectAdditionTests
    {
        // TODO uncomment below to declare an instance variable for ProjectAddition
        //private ProjectAddition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ProjectAddition
            //instance = new ProjectAddition();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectAddition
        /// </summary>
        [Test]
        public void ProjectAdditionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ProjectAddition
            //Assert.IsInstanceOfType<ProjectAddition> (instance, "variable 'instance' is a ProjectAddition");
        }

        /// <summary>
        /// Test the property 'RepositoryProvider'
        /// </summary>
        [Test]
        public void RepositoryProviderTest()
        {
            // TODO unit test for the property 'RepositoryProvider'
        }
        /// <summary>
        /// Test the property 'RepositoryName'
        /// </summary>
        [Test]
        public void RepositoryNameTest()
        {
            // TODO unit test for the property 'RepositoryName'
        }
        /// <summary>
        /// Test the property 'RepositoryAuthentication'
        /// </summary>
        [Test]
        public void RepositoryAuthenticationTest()
        {
            // TODO unit test for the property 'RepositoryAuthentication'
        }
        /// <summary>
        /// Test the property 'RepositoryUsername'
        /// </summary>
        [Test]
        public void RepositoryUsernameTest()
        {
            // TODO unit test for the property 'RepositoryUsername'
        }
        /// <summary>
        /// Test the property 'RepositoryPassword'
        /// </summary>
        [Test]
        public void RepositoryPasswordTest()
        {
            // TODO unit test for the property 'RepositoryPassword'
        }

    }

}
