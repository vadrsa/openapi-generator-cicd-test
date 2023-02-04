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
    /// [Smart Charging](/docs/smart-charging/introduction) configuration properties. Configured via the [Update Smart Charging Policy](/api/reference#updateVehicleSmartChargingPolicy) endpoint.
    /// </summary>
    [DataContract(Name = "VehicleSmartChargingPolicy")]
    public partial class VehicleSmartChargingPolicy : IEquatable<VehicleSmartChargingPolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleSmartChargingPolicy" /> class.
        /// </summary>
        /// <param name="isEnabled">When enabled, this vehicle&#39;s charging status may be controlled by [Smart Charging](/docs/smart-charging/introduction).</param>
        /// <param name="deadline">The hour-minute deadline for fully charging the vehicle. Smart charging does not work without setting a deadline. If a timezone is set on the charging location at which the smart charging ocurrs, the deadline is interpreted in that timezone, otherwise UTC is used..</param>
        /// <param name="minimumChargeLimit">Immediately charge without regard for energy prices until the vehicle reaches this minimum limit. The &#x60;hasChargeAboveThreshold&#x60; Smart Charge consideration uses this value. Defaults to zero..</param>
        public VehicleSmartChargingPolicy(bool? isEnabled = default(bool?), string deadline = default(string), decimal minimumChargeLimit = default(decimal))
        {
            this.IsEnabled = isEnabled;
            this.Deadline = deadline;
            this.MinimumChargeLimit = minimumChargeLimit;
        }

        /// <summary>
        /// When enabled, this vehicle&#39;s charging status may be controlled by [Smart Charging](/docs/smart-charging/introduction)
        /// </summary>
        /// <value>When enabled, this vehicle&#39;s charging status may be controlled by [Smart Charging](/docs/smart-charging/introduction)</value>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// The hour-minute deadline for fully charging the vehicle. Smart charging does not work without setting a deadline. If a timezone is set on the charging location at which the smart charging ocurrs, the deadline is interpreted in that timezone, otherwise UTC is used.
        /// </summary>
        /// <value>The hour-minute deadline for fully charging the vehicle. Smart charging does not work without setting a deadline. If a timezone is set on the charging location at which the smart charging ocurrs, the deadline is interpreted in that timezone, otherwise UTC is used.</value>
        [DataMember(Name = "deadline", EmitDefaultValue = true)]
        public string Deadline { get; set; }

        /// <summary>
        /// Immediately charge without regard for energy prices until the vehicle reaches this minimum limit. The &#x60;hasChargeAboveThreshold&#x60; Smart Charge consideration uses this value. Defaults to zero.
        /// </summary>
        /// <value>Immediately charge without regard for energy prices until the vehicle reaches this minimum limit. The &#x60;hasChargeAboveThreshold&#x60; Smart Charge consideration uses this value. Defaults to zero.</value>
        [DataMember(Name = "minimumChargeLimit", EmitDefaultValue = false)]
        public decimal MinimumChargeLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VehicleSmartChargingPolicy {\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Deadline: ").Append(Deadline).Append("\n");
            sb.Append("  MinimumChargeLimit: ").Append(MinimumChargeLimit).Append("\n");
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
            return this.Equals(input as VehicleSmartChargingPolicy);
        }

        /// <summary>
        /// Returns true if VehicleSmartChargingPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of VehicleSmartChargingPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleSmartChargingPolicy input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsEnabled == input.IsEnabled ||
                    (this.IsEnabled != null &&
                    this.IsEnabled.Equals(input.IsEnabled))
                ) && 
                (
                    this.Deadline == input.Deadline ||
                    (this.Deadline != null &&
                    this.Deadline.Equals(input.Deadline))
                ) && 
                (
                    this.MinimumChargeLimit == input.MinimumChargeLimit ||
                    this.MinimumChargeLimit.Equals(input.MinimumChargeLimit)
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
                if (this.IsEnabled != null)
                {
                    hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                }
                if (this.Deadline != null)
                {
                    hashCode = (hashCode * 59) + this.Deadline.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinimumChargeLimit.GetHashCode();
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
            // Deadline (string) pattern
            Regex regexDeadline = new Regex(@"\\d{2}:\\d{2}", RegexOptions.CultureInvariant);
            if (false == regexDeadline.Match(this.Deadline).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Deadline, must match a pattern of " + regexDeadline, new [] { "Deadline" });
            }

            // MinimumChargeLimit (decimal) maximum
            if (this.MinimumChargeLimit > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinimumChargeLimit, must be a value less than or equal to 100.", new [] { "MinimumChargeLimit" });
            }

            // MinimumChargeLimit (decimal) minimum
            if (this.MinimumChargeLimit < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinimumChargeLimit, must be a value greater than or equal to 0.", new [] { "MinimumChargeLimit" });
            }

            yield break;
        }
    }

}
