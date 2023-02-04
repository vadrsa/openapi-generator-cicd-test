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
    ///  Class for testing HEAT
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class HEATTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for HEAT
        //private HEAT instance;

        public HEATTests()
        {
            // TODO uncomment below to create an instance of HEAT
            //instance = new HEAT();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of HEAT
        /// </summary>
        [Fact]
        public void HEATInstanceTest()
        {
            // TODO uncomment below to test "IsType" HEAT
            //Assert.IsType<HEAT>(instance);
        }


        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Fact]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }
        /// <summary>
        /// Test the property 'HeatSetpoint'
        /// </summary>
        [Fact]
        public void HeatSetpointTest()
        {
            // TODO unit test for the property 'HeatSetpoint'
        }

    }

}
