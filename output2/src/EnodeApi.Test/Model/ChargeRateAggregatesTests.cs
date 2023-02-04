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
    ///  Class for testing ChargeRateAggregates
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ChargeRateAggregatesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ChargeRateAggregates
        //private ChargeRateAggregates instance;

        public ChargeRateAggregatesTests()
        {
            // TODO uncomment below to create an instance of ChargeRateAggregates
            //instance = new ChargeRateAggregates();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ChargeRateAggregates
        /// </summary>
        [Fact]
        public void ChargeRateAggregatesInstanceTest()
        {
            // TODO uncomment below to test "IsType" ChargeRateAggregates
            //Assert.IsType<ChargeRateAggregates>(instance);
        }


        /// <summary>
        /// Test the property 'Min'
        /// </summary>
        [Fact]
        public void MinTest()
        {
            // TODO unit test for the property 'Min'
        }
        /// <summary>
        /// Test the property 'Max'
        /// </summary>
        [Fact]
        public void MaxTest()
        {
            // TODO unit test for the property 'Max'
        }
        /// <summary>
        /// Test the property 'Mean'
        /// </summary>
        [Fact]
        public void MeanTest()
        {
            // TODO unit test for the property 'Mean'
        }

    }

}
