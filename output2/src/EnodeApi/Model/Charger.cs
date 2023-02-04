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
    /// Charger
    /// </summary>
    [DataContract(Name = "Charger")]
    public partial class Charger : IEquatable<Charger>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name = "vendor", IsRequired = true, EmitDefaultValue = true)]
        public ChargerVendor Vendor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Charger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Charger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Charger" /> class.
        /// </summary>
        /// <param name="id">Charger ID (required).</param>
        /// <param name="vendor">vendor (required).</param>
        /// <param name="lastSeen">The last time the charger was successfully communicated with (required).</param>
        /// <param name="isReachable">Whether live data from the charger is currently fetchable from Enode&#39;s perspective. This &#39;reachability&#39; may refer to reading from a cache operated by the charger&#39;s cloud service if that service has determined that its cache is valid. (required).</param>
        /// <param name="chargingLocationId">ID of the charging location the charger is currently positioned at (if any). (required).</param>
        /// <param name="chargeState">chargeState (required).</param>
        /// <param name="information">information (required).</param>
        /// <param name="capabilities">capabilities (required).</param>
        public Charger(string id = default(string), ChargerVendor vendor = default(ChargerVendor), DateTime? lastSeen = default(DateTime?), bool isReachable = default(bool), string chargingLocationId = default(string), ChargerChargeState chargeState = default(ChargerChargeState), ChargerInformation information = default(ChargerInformation), ChargerCapabilities capabilities = default(ChargerCapabilities))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Charger and cannot be null");
            }
            this.Id = id;
            this.Vendor = vendor;
            // to ensure "lastSeen" is required (not null)
            if (lastSeen == null)
            {
                throw new ArgumentNullException("lastSeen is a required property for Charger and cannot be null");
            }
            this.LastSeen = lastSeen;
            this.IsReachable = isReachable;
            // to ensure "chargingLocationId" is required (not null)
            if (chargingLocationId == null)
            {
                throw new ArgumentNullException("chargingLocationId is a required property for Charger and cannot be null");
            }
            this.ChargingLocationId = chargingLocationId;
            // to ensure "chargeState" is required (not null)
            if (chargeState == null)
            {
                throw new ArgumentNullException("chargeState is a required property for Charger and cannot be null");
            }
            this.ChargeState = chargeState;
            // to ensure "information" is required (not null)
            if (information == null)
            {
                throw new ArgumentNullException("information is a required property for Charger and cannot be null");
            }
            this.Information = information;
            // to ensure "capabilities" is required (not null)
            if (capabilities == null)
            {
                throw new ArgumentNullException("capabilities is a required property for Charger and cannot be null");
            }
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Charger ID
        /// </summary>
        /// <value>Charger ID</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The last time the charger was successfully communicated with
        /// </summary>
        /// <value>The last time the charger was successfully communicated with</value>
        [DataMember(Name = "lastSeen", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// Whether live data from the charger is currently fetchable from Enode&#39;s perspective. This &#39;reachability&#39; may refer to reading from a cache operated by the charger&#39;s cloud service if that service has determined that its cache is valid.
        /// </summary>
        /// <value>Whether live data from the charger is currently fetchable from Enode&#39;s perspective. This &#39;reachability&#39; may refer to reading from a cache operated by the charger&#39;s cloud service if that service has determined that its cache is valid.</value>
        [DataMember(Name = "isReachable", IsRequired = true, EmitDefaultValue = true)]
        public bool IsReachable { get; set; }

        /// <summary>
        /// ID of the charging location the charger is currently positioned at (if any).
        /// </summary>
        /// <value>ID of the charging location the charger is currently positioned at (if any).</value>
        [DataMember(Name = "chargingLocationId", IsRequired = true, EmitDefaultValue = true)]
        public string ChargingLocationId { get; set; }

        /// <summary>
        /// Gets or Sets ChargeState
        /// </summary>
        [DataMember(Name = "chargeState", IsRequired = true, EmitDefaultValue = true)]
        public ChargerChargeState ChargeState { get; set; }

        /// <summary>
        /// Gets or Sets Information
        /// </summary>
        [DataMember(Name = "information", IsRequired = true, EmitDefaultValue = true)]
        public ChargerInformation Information { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", IsRequired = true, EmitDefaultValue = true)]
        public ChargerCapabilities Capabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Charger {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  LastSeen: ").Append(LastSeen).Append("\n");
            sb.Append("  IsReachable: ").Append(IsReachable).Append("\n");
            sb.Append("  ChargingLocationId: ").Append(ChargingLocationId).Append("\n");
            sb.Append("  ChargeState: ").Append(ChargeState).Append("\n");
            sb.Append("  Information: ").Append(Information).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
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
            return this.Equals(input as Charger);
        }

        /// <summary>
        /// Returns true if Charger instances are equal
        /// </summary>
        /// <param name="input">Instance of Charger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Charger input)
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
                    this.LastSeen == input.LastSeen ||
                    (this.LastSeen != null &&
                    this.LastSeen.Equals(input.LastSeen))
                ) && 
                (
                    this.IsReachable == input.IsReachable ||
                    this.IsReachable.Equals(input.IsReachable)
                ) && 
                (
                    this.ChargingLocationId == input.ChargingLocationId ||
                    (this.ChargingLocationId != null &&
                    this.ChargingLocationId.Equals(input.ChargingLocationId))
                ) && 
                (
                    this.ChargeState == input.ChargeState ||
                    (this.ChargeState != null &&
                    this.ChargeState.Equals(input.ChargeState))
                ) && 
                (
                    this.Information == input.Information ||
                    (this.Information != null &&
                    this.Information.Equals(input.Information))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
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
                if (this.LastSeen != null)
                {
                    hashCode = (hashCode * 59) + this.LastSeen.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsReachable.GetHashCode();
                if (this.ChargingLocationId != null)
                {
                    hashCode = (hashCode * 59) + this.ChargingLocationId.GetHashCode();
                }
                if (this.ChargeState != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeState.GetHashCode();
                }
                if (this.Information != null)
                {
                    hashCode = (hashCode * 59) + this.Information.GetHashCode();
                }
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
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
