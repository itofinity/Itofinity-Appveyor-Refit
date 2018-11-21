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
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UserApiTests
    {
        private string hostUrl = "";
        private string userAgent = "Itofinity.Appveyor.Refit.Test.UserApiTests";

        private IUserApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = RestService.For<IUserApi>(hostUrl);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserApi
            //Assert.IsInstanceOfType(typeof(UserApi), instance, "instance is a UserApi");
        }

        
        /// <summary>
        /// Test AddUser
        /// </summary>
        [Test]
        public async void AddUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserAddition body = null;
            //instance.AddUser(userAgent, body);
            
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public async void DeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //instance.DeleteUser(userAgent, userId);
            
        }
        
        /// <summary>
        /// Test GetUser
        /// </summary>
        [Test]
        public async void GetUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? userId = null;
            //var response = await instance.GetUser(userAgent, userId);
            //Assert.IsInstanceOf<UserAccountRolesResults> (response, "response is UserAccountRolesResults");
        }
        
        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Test]
        public async void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = await instance.GetUsers(userAgent);
            //Assert.IsInstanceOf<List<UserAccount>> (response, "response is List<UserAccount>");
        }
        
        /// <summary>
        /// Test UpdateUser
        /// </summary>
        [Test]
        public async void UpdateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserAccount body = null;
            //instance.UpdateUser(userAgent, body);
            
        }
        
    }

}
