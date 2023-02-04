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
    ///  Class for testing PermanentHoldTargetState
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PermanentHoldTargetStateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PermanentHoldTargetState
        //private PermanentHoldTargetState instance;

        public PermanentHoldTargetStateTests()
        {
            // TODO uncomment below to create an instance of PermanentHoldTargetState
            //instance = new PermanentHoldTargetState();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PermanentHoldTargetState
        /// </summary>
        [Fact]
        public void PermanentHoldTargetStateInstanceTest()
        {
            // TODO uncomment below to test "IsType" PermanentHoldTargetState
            //Assert.IsType<PermanentHoldTargetState>(instance);
        }


        /// <summary>
        /// Test the property 'HoldType'
        /// </summary>
        [Fact]
        public void HoldTypeTest()
        {
            // TODO unit test for the property 'HoldType'
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
        /// <summary>
        /// Test the property 'CoolSetpoint'
        /// </summary>
        [Fact]
        public void CoolSetpointTest()
        {
            // TODO unit test for the property 'CoolSetpoint'
        }

    }

}
