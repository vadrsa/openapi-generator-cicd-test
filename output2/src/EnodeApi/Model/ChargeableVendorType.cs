/*
 * Enode API
 *
 * The Enode API is designed to make smart charging applications easy to develop. We provide an abstraction layer that reduces the complexity when extracting vehicle data and sending commands to vehicles from a variety of manufacturers.  The API has a RESTful architecture and utilizes OAuth2 authorization. 
 *
 * The version of the OpenAPI document: 1.17.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EnodeApi.Client.OpenAPIDateConverter;

namespace EnodeApi.Model
{
    /// <summary>
    /// Defines ChargeableVendorType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargeableVendorType
    {
        /// <summary>
        /// Enum Vehicle for value: vehicle
        /// </summary>
        [EnumMember(Value = "vehicle")]
        Vehicle = 1,

        /// <summary>
        /// Enum Charger for value: charger
        /// </summary>
        [EnumMember(Value = "charger")]
        Charger = 2

    }

}
