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
    ///  Class for testing ChargeScheduleStatusIsChargingExpectedParts
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ChargeScheduleStatusIsChargingExpectedPartsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ChargeScheduleStatusIsChargingExpectedParts
        //private ChargeScheduleStatusIsChargingExpectedParts instance;

        public ChargeScheduleStatusIsChargingExpectedPartsTests()
        {
            // TODO uncomment below to create an instance of ChargeScheduleStatusIsChargingExpectedParts
            //instance = new ChargeScheduleStatusIsChargingExpectedParts();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChargeScheduleStatusIsChargingExpectedParts
        /// </summary>
        [Fact]
        public void ChargeScheduleStatusIsChargingExpectedPartsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ChargeScheduleStatusIsChargingExpectedParts
            //Assert.IsType<ChargeScheduleStatusIsChargingExpectedParts>(instance);
        }


        /// <summary>
        /// Test the property 'NeedsCharge'
        /// </summary>
        [Fact]
        public void NeedsChargeTest()
        {
            // TODO unit test for the property 'NeedsCharge'
        }
        /// <summary>
        /// Test the property 'IsPluggedIn'
        /// </summary>
        [Fact]
        public void IsPluggedInTest()
        {
            // TODO unit test for the property 'IsPluggedIn'
        }
        /// <summary>
        /// Test the property 'ShouldCharge'
        /// </summary>
        [Fact]
        public void ShouldChargeTest()
        {
            // TODO unit test for the property 'ShouldCharge'
        }

    }

}
