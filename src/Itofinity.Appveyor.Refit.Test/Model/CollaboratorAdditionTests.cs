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
    ///  Class for testing CollaboratorAddition
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CollaboratorAdditionTests
    {
        // TODO uncomment below to declare an instance variable for CollaboratorAddition
        //private CollaboratorAddition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CollaboratorAddition
            //instance = new CollaboratorAddition();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CollaboratorAddition
        /// </summary>
        [Test]
        public void CollaboratorAdditionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CollaboratorAddition
            //Assert.IsInstanceOfType<CollaboratorAddition> (instance, "variable 'instance' is a CollaboratorAddition");
        }

        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'RoleId'
        /// </summary>
        [Test]
        public void RoleIdTest()
        {
            // TODO unit test for the property 'RoleId'
        }

    }

}
