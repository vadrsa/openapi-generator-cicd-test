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
    /// Aggregate statistics for power price (&#x60;&lt;CURRENCY&gt;&#x60; per kWh), calculated as if the charging had ocurred uninterrupted without being delayed by Smart Charging
    /// </summary>
    [DataContract(Name = "NonSmartPriceAggregates")]
    public partial class NonSmartPriceAggregates : IEquatable<NonSmartPriceAggregates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonSmartPriceAggregates" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NonSmartPriceAggregates() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NonSmartPriceAggregates" /> class.
        /// </summary>
        /// <param name="min">min (required).</param>
        /// <param name="max">max (required).</param>
        /// <param name="mean">mean (required).</param>
        public NonSmartPriceAggregates(decimal min = default(decimal), decimal max = default(decimal), decimal mean = default(decimal))
        {
            this.Min = min;
            this.Max = max;
            this.Mean = mean;
        }

        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name = "min", IsRequired = true, EmitDefaultValue = true)]
        public decimal Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name = "max", IsRequired = true, EmitDefaultValue = true)]
        public decimal Max { get; set; }

        /// <summary>
        /// Gets or Sets Mean
        /// </summary>
        [DataMember(Name = "mean", IsRequired = true, EmitDefaultValue = true)]
        public decimal Mean { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NonSmartPriceAggregates {\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NonSmartPriceAggregates);
        }

        /// <summary>
        /// Returns true if NonSmartPriceAggregates instances are equal
        /// </summary>
        /// <param name="input">Instance of NonSmartPriceAggregates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonSmartPriceAggregates input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Min == input.Min ||
                    this.Min.Equals(input.Min)
                ) && 
                (
                    this.Max == input.Max ||
                    this.Max.Equals(input.Max)
                ) && 
                (
                    this.Mean == input.Mean ||
                    this.Mean.Equals(input.Mean)
                );
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
                hashCode = (hashCode * 59) + this.Min.GetHashCode();
                hashCode = (hashCode * 59) + this.Max.GetHashCode();
                hashCode = (hashCode * 59) + this.Mean.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
