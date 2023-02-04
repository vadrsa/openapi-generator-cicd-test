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
    /// GetHealthChargerVendors200ResponseInner
    /// </summary>
    [DataContract(Name = "getHealthChargerVendors_200_response_inner")]
    public partial class GetHealthChargerVendors200ResponseInner : IEquatable<GetHealthChargerVendors200ResponseInner>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name = "vendor", EmitDefaultValue = false)]
        public ChargerVendor? Vendor { get; set; }
        /// <summary>
        /// Ready-state of the Vendor. Currently always &#x60;READY&#x60;.
        /// </summary>
        /// <value>Ready-state of the Vendor. Currently always &#x60;READY&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum READY for value: READY
            /// </summary>
            [EnumMember(Value = "READY")]
            READY = 1,

            /// <summary>
            /// Enum ELEVATEDERRORRATE for value: ELEVATED_ERROR_RATE
            /// </summary>
            [EnumMember(Value = "ELEVATED_ERROR_RATE")]
            ELEVATEDERRORRATE = 2,

            /// <summary>
            /// Enum OUTAGE for value: OUTAGE
            /// </summary>
            [EnumMember(Value = "OUTAGE")]
            OUTAGE = 3

        }


        /// <summary>
        /// Ready-state of the Vendor. Currently always &#x60;READY&#x60;.
        /// </summary>
        /// <value>Ready-state of the Vendor. Currently always &#x60;READY&#x60;.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHealthChargerVendors200ResponseInner" /> class.
        /// </summary>
        /// <param name="vendor">vendor.</param>
        /// <param name="displayName">A formatted and properly cased vendor brand name, suitable for reading by humans..</param>
        /// <param name="portalName">The name of the first party service or app that the user normally logs into..</param>
        /// <param name="status">Ready-state of the Vendor. Currently always &#x60;READY&#x60;..</param>
        public GetHealthChargerVendors200ResponseInner(ChargerVendor? vendor = default(ChargerVendor?), string displayName = default(string), string portalName = default(string), StatusEnum? status = default(StatusEnum?))
        {
            this.Vendor = vendor;
            this.DisplayName = displayName;
            this.PortalName = portalName;
            this.Status = status;
        }

        /// <summary>
        /// A formatted and properly cased vendor brand name, suitable for reading by humans.
        /// </summary>
        /// <value>A formatted and properly cased vendor brand name, suitable for reading by humans.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The name of the first party service or app that the user normally logs into.
        /// </summary>
        /// <value>The name of the first party service or app that the user normally logs into.</value>
        [DataMember(Name = "portalName", EmitDefaultValue = false)]
        public string PortalName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetHealthChargerVendors200ResponseInner {\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PortalName: ").Append(PortalName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as GetHealthChargerVendors200ResponseInner);
        }

        /// <summary>
        /// Returns true if GetHealthChargerVendors200ResponseInner instances are equal
        /// </summary>
        /// <param name="input">Instance of GetHealthChargerVendors200ResponseInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetHealthChargerVendors200ResponseInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Vendor == input.Vendor ||
                    this.Vendor.Equals(input.Vendor)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.PortalName == input.PortalName ||
                    (this.PortalName != null &&
                    this.PortalName.Equals(input.PortalName))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.PortalName != null)
                {
                    hashCode = (hashCode * 59) + this.PortalName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
