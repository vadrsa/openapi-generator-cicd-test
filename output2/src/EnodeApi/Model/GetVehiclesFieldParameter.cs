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
    /// GetVehiclesFieldParameter
    /// </summary>
    [JsonConverter(typeof(GetVehiclesFieldParameterJsonConverter))]
    [DataContract(Name = "getVehicles_field_parameter")]
    public partial class GetVehiclesFieldParameter : AbstractOpenAPISchema, IEquatable<GetVehiclesFieldParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVehiclesFieldParameter" /> class
        /// with the <see cref="List{String}" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of List&lt;string&gt;.</param>
        public GetVehiclesFieldParameter(List<string> actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.") ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVehiclesFieldParameter" /> class
        /// with the <see cref="GetVehiclesFieldParameterOneOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of GetVehiclesFieldParameterOneOf.</param>
        public GetVehiclesFieldParameter(GetVehiclesFieldParameterOneOf actualInstance)
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
                if (value.GetType() == typeof(GetVehiclesFieldParameterOneOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(List<string>))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: GetVehiclesFieldParameterOneOf, List<string>");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `List&lt;string&gt;`. If the actual instance is not `List&lt;string&gt;`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of List&lt;string&gt;</returns>
        public List<string> GetList()
        {
            return (List<string>)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `GetVehiclesFieldParameterOneOf`. If the actual instance is not `GetVehiclesFieldParameterOneOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of GetVehiclesFieldParameterOneOf</returns>
        public GetVehiclesFieldParameterOneOf GetGetVehiclesFieldParameterOneOf()
        {
            return (GetVehiclesFieldParameterOneOf)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetVehiclesFieldParameter {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, GetVehiclesFieldParameter.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of GetVehiclesFieldParameter
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of GetVehiclesFieldParameter</returns>
        public static GetVehiclesFieldParameter FromJson(string jsonString)
        {
            GetVehiclesFieldParameter newGetVehiclesFieldParameter = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newGetVehiclesFieldParameter;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(GetVehiclesFieldParameterOneOf).GetProperty("AdditionalProperties") == null)
                {
                    newGetVehiclesFieldParameter = new GetVehiclesFieldParameter(JsonConvert.DeserializeObject<GetVehiclesFieldParameterOneOf>(jsonString, GetVehiclesFieldParameter.SerializerSettings));
                }
                else
                {
                    newGetVehiclesFieldParameter = new GetVehiclesFieldParameter(JsonConvert.DeserializeObject<GetVehiclesFieldParameterOneOf>(jsonString, GetVehiclesFieldParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("GetVehiclesFieldParameterOneOf");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into GetVehiclesFieldParameterOneOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(List<string>).GetProperty("AdditionalProperties") == null)
                {
                    newGetVehiclesFieldParameter = new GetVehiclesFieldParameter(JsonConvert.DeserializeObject<List<string>>(jsonString, GetVehiclesFieldParameter.SerializerSettings));
                }
                else
                {
                    newGetVehiclesFieldParameter = new GetVehiclesFieldParameter(JsonConvert.DeserializeObject<List<string>>(jsonString, GetVehiclesFieldParameter.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("List<string>");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into List<string>: {1}", jsonString, exception.ToString()));
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
            return newGetVehiclesFieldParameter;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetVehiclesFieldParameter);
        }

        /// <summary>
        /// Returns true if GetVehiclesFieldParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of GetVehiclesFieldParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetVehiclesFieldParameter input)
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
    /// Custom JSON converter for GetVehiclesFieldParameter
    /// </summary>
    public class GetVehiclesFieldParameterJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(GetVehiclesFieldParameter).GetMethod("ToJson").Invoke(value, null)));
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
                return GetVehiclesFieldParameter.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
