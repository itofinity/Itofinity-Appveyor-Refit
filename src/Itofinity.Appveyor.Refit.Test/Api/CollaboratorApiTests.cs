/* 
 * AppVeyor REST API
 *
 * AppVeyor is a hosted continuous integration service which runs on Microsoft Windows.  The AppVeyor REST API provides a RESTful way to interact with the AppVeyor service.  This includes managing projects, builds, deployments, and the teams that build them.  Additional help and discussion of the AppVeyor REST API is available at http://help.appveyor.com/discussions  This Swagger definition is an **unofficial** description of the AppVeyor REST API maintained at https://github.com/kevinoid/appveyor-swagger Please report any issues or suggestions for this Swagger definition at https://github.com/kevinoid/appveyor-swagger/issues/new  #### API Conventions  Fields which are missing from update operations (`PUT` requests) are typically reset to their default values.  So although most fields are not technically required, they should usually be specified in practice. 
 *
 * OpenAPI spec version: 0.20181117.0
 * Contact: team@appveyor.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using Refit;

using Itofinity.Appveyor.Refit.Client;
using Itofinity.Appveyor.Refit.Api;
using Itofinity.Appveyor.Refit.Model;

namespace Itofinity.Appveyor.Refit.Test
{
    /// <summary>
    ///  Class for testing CollaboratorApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CollaboratorApiTests
    {
        private string hostUrl = "";
        private string userAgent = "Itofinity.Appveyor.Refit.Test.CollaboratorApiTests";

        private ICollaboratorApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = RestService.For<ICollaboratorApi>(hostUrl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CollaboratorApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CollaboratorApi
            //Assert.IsInstanceOfType(typeof(CollaboratorApi), instance, "instance is a CollaboratorApi");
        }

        
        /// <summary>
        /// Test AddCollaborator
        /// </summary>
        [Test]
        public async void AddCollaboratorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CollaboratorAddition body = null;
            //instance.AddCollaborator(userAgent, body);
            
        }
        
        /// <summary>
        /// Test DeleteCollaborator
        /// </summary>
        [Test]
        public async void DeleteCollaboratorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //instance.DeleteCollaborator(userAgent, userId);
            
        }
        
        /// <summary>
        /// Test GetCollaborator
        /// </summary>
        [Test]
        public async void GetCollaboratorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = await instance.GetCollaborator(userAgent, userId);
            //Assert.IsInstanceOf<UserAccountRolesResults> (response, "response is UserAccountRolesResults");
        }
        
        /// <summary>
        /// Test GetCollaborators
        /// </summary>
        [Test]
        public async void GetCollaboratorsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = await instance.GetCollaborators(userAgent);
            //Assert.IsInstanceOf<List<UserAccount>> (response, "response is List<UserAccount>");
        }
        
        /// <summary>
        /// Test UpdateCollaborator
        /// </summary>
        [Test]
        public async void UpdateCollaboratorTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CollaboratorUpdate body = null;
            //instance.UpdateCollaborator(userAgent, body);
            
        }
        
    }

}
