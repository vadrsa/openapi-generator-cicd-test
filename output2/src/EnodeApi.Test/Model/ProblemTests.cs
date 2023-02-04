/*
 * Enode API
 *
 * The Enode API is designed to make smart charging applications easy to develop. We provide an abstraction layer that reduces the complexity when extracting vehicle data and sending commands to vehicles from a variety of manufacturers.  The API has a RESTful architecture and utilizes OAuth2 authorization. 
 *
 * The version of the OpenAPI document: 1.17.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using EnodeApi.Api;
using EnodeApi.Model;
using EnodeApi.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace EnodeApi.Test.Model
{
    /// <summary>
    ///  Class for testing Problem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ProblemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Problem
        //private Problem instance;

        public ProblemTests()
        {
            // TODO uncomment below to create an instance of Problem
            //instance = new Problem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Problem
        /// </summary>
        [Fact]
        public void ProblemInstanceTest()
        {
            // TODO uncomment below to test "IsType" Problem
            //Assert.IsType<Problem>(instance);
        }


        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Detail'
        /// </summary>
        [Fact]
        public void DetailTest()
        {
            // TODO unit test for the property 'Detail'
        }

    }

}
