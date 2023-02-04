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
using System.Reflection;

namespace EnodeApi.Model
{
    /// <summary>
    /// A Schedule that applies to the combination of a certain Charging Location and a linked asset (Vehicle/Charger/HVAC). Read the guide to [Using Schedules](/docs/scheduling).
    /// </summary>
    [JsonConverter(typeof(PartialScheduleJsonConverter))]
    [DataContract(Name = "PartialSchedule")]
    public partial class PartialSchedule : AbstractOpenAPISchema, IEquatable<PartialSchedule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSchedule" /> class
        /// with the <see cref="PartialChargeSchedule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PartialChargeSchedule.</param>
        public PartialSchedule(PartialChargeSchedule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialSchedule" /> class
        /// with the <see cref="PartialTemperatureSchedule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PartialTemperatureSchedule.</param>
        public PartialSchedule(PartialTemperatureSchedule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(PartialChargeSchedule))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PartialTemperatureSchedule))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: PartialChargeSchedule, PartialTemperatureSchedule");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `PartialChargeSchedule`. If the actual instance is not `PartialChargeSchedule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PartialChargeSchedule</returns>
        public PartialChargeSchedule GetPartialChargeSchedule()
        {
            return (PartialChargeSchedule)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PartialTemperatureSchedule`. If the actual instance is not `PartialTemperatureSchedule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PartialTemperatureSchedule</returns>
        public PartialTemperatureSchedule GetPartialTemperatureSchedule()
        {
            return (PartialTemperatureSchedule)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartialSchedule {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, PartialSchedule.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PartialSchedule
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PartialSchedule</returns>
        public static PartialSchedule FromJson(string jsonString)
        {
            PartialSchedule newPartialSchedule = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPartialSchedule;
            }

            try
            {
                newPartialSchedule = new PartialSchedule(JsonConvert.DeserializeObject<PartialChargeSchedule>(jsonString, PartialSchedule.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPartialSchedule;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PartialChargeSchedule: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newPartialSchedule = new PartialSchedule(JsonConvert.DeserializeObject<PartialTemperatureSchedule>(jsonString, PartialSchedule.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newPartialSchedule;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PartialTemperatureSchedule: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartialSchedule);
        }

        /// <summary>
        /// Returns true if PartialSchedule instances are equal
        /// </summary>
        /// <param name="input">Instance of PartialSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartialSchedule input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for PartialSchedule
    /// </summary>
    public class PartialScheduleJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PartialSchedule).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return PartialSchedule.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
