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
    /// Inverter
    /// </summary>
    [DataContract(Name = "Inverter")]
    public partial class Inverter : IEquatable<Inverter>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name = "vendor", IsRequired = true, EmitDefaultValue = true)]
        public InverterVendor Vendor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Inverter" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Inverter() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Inverter" /> class.
        /// </summary>
        /// <param name="vendor">vendor (required).</param>
        /// <param name="chargingLocationId">ID of the charging location the solar inverter is currently positioned at (if any)..</param>
        /// <param name="productionState">productionState (required).</param>
        /// <param name="information">information (required).</param>
        /// <param name="location">location (required).</param>
        public Inverter(InverterVendor vendor = default(InverterVendor), string chargingLocationId = default(string), InverterProductionState productionState = default(InverterProductionState), InverterInformation information = default(InverterInformation), InverterLocation location = default(InverterLocation))
        {
            this.Vendor = vendor;
            // to ensure "productionState" is required (not null)
            if (productionState == null)
            {
                throw new ArgumentNullException("productionState is a required property for Inverter and cannot be null");
            }
            this.ProductionState = productionState;
            // to ensure "information" is required (not null)
            if (information == null)
            {
                throw new ArgumentNullException("information is a required property for Inverter and cannot be null");
            }
            this.Information = information;
            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new ArgumentNullException("location is a required property for Inverter and cannot be null");
            }
            this.Location = location;
            this.ChargingLocationId = chargingLocationId;
        }

        /// <summary>
        /// Solar inverter ID
        /// </summary>
        /// <value>Solar inverter ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// ID of the charging location the solar inverter is currently positioned at (if any).
        /// </summary>
        /// <value>ID of the charging location the solar inverter is currently positioned at (if any).</value>
        [DataMember(Name = "chargingLocationId", EmitDefaultValue = true)]
        public string ChargingLocationId { get; set; }

        /// <summary>
        /// The last time the solar inverter was successfully communicated with
        /// </summary>
        /// <value>The last time the solar inverter was successfully communicated with</value>
        [DataMember(Name = "lastSeen", IsRequired = true, EmitDefaultValue = true)]
        public DateTime LastSeen { get; private set; }

        /// <summary>
        /// Returns false as LastSeen should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastSeen()
        {
            return false;
        }
        /// <summary>
        /// Whether live data from the solar inverter is currently fetchable from Enode&#39;s perspective. This &#39;reachability&#39; may refer to reading from a cache operated by the solar inverter&#39;s cloud service if that service has determined that its cache is valid.
        /// </summary>
        /// <value>Whether live data from the solar inverter is currently fetchable from Enode&#39;s perspective. This &#39;reachability&#39; may refer to reading from a cache operated by the solar inverter&#39;s cloud service if that service has determined that its cache is valid.</value>
        [DataMember(Name = "isReachable", IsRequired = true, EmitDefaultValue = true)]
        public bool IsReachable { get; private set; }

        /// <summary>
        /// Returns false as IsReachable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsReachable()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ProductionState
        /// </summary>
        [DataMember(Name = "productionState", IsRequired = true, EmitDefaultValue = true)]
        public InverterProductionState ProductionState { get; set; }

        /// <summary>
        /// Gets or Sets Information
        /// </summary>
        [DataMember(Name = "information", IsRequired = true, EmitDefaultValue = true)]
        public InverterInformation Information { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = true)]
        public InverterLocation Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Inverter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  ChargingLocationId: ").Append(ChargingLocationId).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
            sb.Append("  IsReachable: ").Append(IsReachable).Append("\n");
            sb.Append("  ProductionState: ").Append(ProductionState).Append("\n");
            sb.Append("  Information: ").Append(Information).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as Inverter);
        }

        /// <summary>
        /// Returns true if Inverter instances are equal
        /// </summary>
        /// <param name="input">Instance of Inverter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Inverter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    this.Vendor.Equals(input.Vendor)
                ) && 
                (
                    this.ChargingLocationId == input.ChargingLocationId ||
                    (this.ChargingLocationId != null &&
                    this.ChargingLocationId.Equals(input.ChargingLocationId))
                ) && 
                (
                    this.LastSeen == input.LastSeen ||
                    (this.LastSeen != null &&
                    this.LastSeen.Equals(input.LastSeen))
                ) && 
                (
                    this.IsReachable == input.IsReachable ||
                    this.IsReachable.Equals(input.IsReachable)
                ) && 
                (
                    this.ProductionState == input.ProductionState ||
                    (this.ProductionState != null &&
                    this.ProductionState.Equals(input.ProductionState))
                ) && 
                (
                    this.Information == input.Information ||
                    (this.Information != null &&
                    this.Information.Equals(input.Information))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
                if (this.ChargingLocationId != null)
                {
                    hashCode = (hashCode * 59) + this.ChargingLocationId.GetHashCode();
                }
                if (this.LastSeen != null)
                {
                    hashCode = (hashCode * 59) + this.LastSeen.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsReachable.GetHashCode();
                if (this.ProductionState != null)
                {
                    hashCode = (hashCode * 59) + this.ProductionState.GetHashCode();
                }
                if (this.Information != null)
                {
                    hashCode = (hashCode * 59) + this.Information.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
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
