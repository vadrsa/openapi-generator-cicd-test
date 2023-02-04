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
    /// PermanentHoldTargetState
    /// </summary>
    [JsonConverter(typeof(PermanentHoldTargetStateJsonConverter))]
    [DataContract(Name = "PermanentHoldTargetState")]
    public partial class PermanentHoldTargetState : AbstractOpenAPISchema, IEquatable<PermanentHoldTargetState>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PermanentHoldTargetState" /> class
        /// with the <see cref="OFF1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OFF1.</param>
        public PermanentHoldTargetState(OFF1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermanentHoldTargetState" /> class
        /// with the <see cref="AUTO1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AUTO1.</param>
        public PermanentHoldTargetState(AUTO1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermanentHoldTargetState" /> class
        /// with the <see cref="HEAT1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of HEAT1.</param>
        public PermanentHoldTargetState(HEAT1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermanentHoldTargetState" /> class
        /// with the <see cref="COOL1" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of COOL1.</param>
        public PermanentHoldTargetState(COOL1 actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
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
                if (value.GetType() == typeof(AUTO1))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(COOL1))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(HEAT1))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OFF1))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AUTO1, COOL1, HEAT1, OFF1");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `OFF1`. If the actual instance is not `OFF1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OFF1</returns>
        public OFF1 GetOFF1()
        {
            return (OFF1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AUTO1`. If the actual instance is not `AUTO1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AUTO1</returns>
        public AUTO1 GetAUTO1()
        {
            return (AUTO1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `HEAT1`. If the actual instance is not `HEAT1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of HEAT1</returns>
        public HEAT1 GetHEAT1()
        {
            return (HEAT1)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `COOL1`. If the actual instance is not `COOL1`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of COOL1</returns>
        public COOL1 GetCOOL1()
        {
            return (COOL1)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermanentHoldTargetState {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, PermanentHoldTargetState.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PermanentHoldTargetState
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PermanentHoldTargetState</returns>
        public static PermanentHoldTargetState FromJson(string jsonString)
        {
            PermanentHoldTargetState newPermanentHoldTargetState = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPermanentHoldTargetState;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AUTO1).GetProperty("AdditionalProperties") == null)
                {
                    newPermanentHoldTargetState = new PermanentHoldTargetState(JsonConvert.DeserializeObject<AUTO1>(jsonString, PermanentHoldTargetState.SerializerSettings));
                }
                else
                {
                    newPermanentHoldTargetState = new PermanentHoldTargetState(JsonConvert.DeserializeObject<AUTO1>(jsonString, PermanentHoldTargetState.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("AUTO1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AUTO1: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(COOL1).GetProperty("AdditionalProperties") == null)
                {
                    newPermanentHoldTargetState = new PermanentHoldTargetState(JsonConvert.DeserializeObject<COOL1>(jsonString, PermanentHoldTargetState.SerializerSettings));
                }
                else
                {
                    newPermanentHoldTargetState = new PermanentHoldTargetState(JsonConvert.DeserializeObject<COOL1>(jsonString, PermanentHoldTargetState.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("COOL1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into COOL1: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(HEAT1).GetProperty("AdditionalProperties") == null)
                {
                    newPermanentHoldTargetState = new PermanentHoldTargetState(JsonConvert.DeserializeObject<HEAT1>(jsonString, PermanentHoldTargetState.SerializerSettings));
                }
                else
                {
                    newPermanentHoldTargetState = new PermanentHoldTargetState(JsonConvert.DeserializeObject<HEAT1>(jsonString, PermanentHoldTargetState.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("HEAT1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into HEAT1: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OFF1).GetProperty("AdditionalProperties") == null)
                {
                    newPermanentHoldTargetState = new PermanentHoldTargetState(JsonConvert.DeserializeObject<OFF1>(jsonString, PermanentHoldTargetState.SerializerSettings));
                }
                else
                {
                    newPermanentHoldTargetState = new PermanentHoldTargetState(JsonConvert.DeserializeObject<OFF1>(jsonString, PermanentHoldTargetState.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("OFF1");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OFF1: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newPermanentHoldTargetState;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermanentHoldTargetState);
        }

        /// <summary>
        /// Returns true if PermanentHoldTargetState instances are equal
        /// </summary>
        /// <param name="input">Instance of PermanentHoldTargetState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermanentHoldTargetState input)
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
    /// Custom JSON converter for PermanentHoldTargetState
    /// </summary>
    public class PermanentHoldTargetStateJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PermanentHoldTargetState).GetMethod("ToJson").Invoke(value, null)));
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
                return PermanentHoldTargetState.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
