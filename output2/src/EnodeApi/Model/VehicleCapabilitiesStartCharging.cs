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
    /// Support for START charging command
    /// </summary>
    [DataContract(Name = "VehicleCapabilities_startCharging")]
    public partial class VehicleCapabilitiesStartCharging : IEquatable<VehicleCapabilitiesStartCharging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleCapabilitiesStartCharging" /> class.
        /// </summary>
        /// <param name="isCapable">The entity is fully capable of providing this data or functionality. If false, support is partial or missing..</param>
        /// <param name="interventionIds">IDs of interventions the user can make to alter the availability of this capability. See [the interventions reference](/docs/connections/interventions#available-interventions) for all possible values..</param>
        public VehicleCapabilitiesStartCharging(bool isCapable = default(bool), List<string> interventionIds = default(List<string>))
        {
            this.IsCapable = isCapable;
            this.InterventionIds = interventionIds;
        }

        /// <summary>
        /// The entity is fully capable of providing this data or functionality. If false, support is partial or missing.
        /// </summary>
        /// <value>The entity is fully capable of providing this data or functionality. If false, support is partial or missing.</value>
        [DataMember(Name = "isCapable", EmitDefaultValue = true)]
        public bool IsCapable { get; set; }

        /// <summary>
        /// IDs of interventions the user can make to alter the availability of this capability. See [the interventions reference](/docs/connections/interventions#available-interventions) for all possible values.
        /// </summary>
        /// <value>IDs of interventions the user can make to alter the availability of this capability. See [the interventions reference](/docs/connections/interventions#available-interventions) for all possible values.</value>
        [DataMember(Name = "interventionIds", EmitDefaultValue = false)]
        public List<string> InterventionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VehicleCapabilitiesStartCharging {\n");
            sb.Append("  IsCapable: ").Append(IsCapable).Append("\n");
            sb.Append("  InterventionIds: ").Append(InterventionIds).Append("\n");
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
            return this.Equals(input as VehicleCapabilitiesStartCharging);
        }

        /// <summary>
        /// Returns true if VehicleCapabilitiesStartCharging instances are equal
        /// </summary>
        /// <param name="input">Instance of VehicleCapabilitiesStartCharging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleCapabilitiesStartCharging input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsCapable == input.IsCapable ||
                    this.IsCapable.Equals(input.IsCapable)
                ) && 
                (
                    this.InterventionIds == input.InterventionIds ||
                    this.InterventionIds != null &&
                    input.InterventionIds != null &&
                    this.InterventionIds.SequenceEqual(input.InterventionIds)
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
                hashCode = (hashCode * 59) + this.IsCapable.GetHashCode();
                if (this.InterventionIds != null)
                {
                    hashCode = (hashCode * 59) + this.InterventionIds.GetHashCode();
                }
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
