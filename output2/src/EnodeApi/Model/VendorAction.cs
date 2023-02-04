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
    /// VendorAction
    /// </summary>
    [DataContract(Name = "VendorAction")]
    public partial class VendorAction : IEquatable<VendorAction>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TargetType
        /// </summary>
        [DataMember(Name = "targetType", EmitDefaultValue = false)]
        public VendorType? TargetType { get; set; }

        /// <summary>
        /// Gets or Sets Kind
        /// </summary>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public ChargingAction? Kind { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VendorAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorAction" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="targetId">targetId.</param>
        /// <param name="targetType">targetType.</param>
        /// <param name="kind">kind.</param>
        /// <param name="target">target.</param>
        /// <param name="targetState">targetState.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="completedAt">ISO8601 UTC timestamp at which the action transitioned to a non-pending state. If this value is set, then we are no longer sending commands to the chargeable. (required).</param>
        /// <param name="state">state (required).</param>
        public VendorAction(string id = default(string), string targetId = default(string), VendorType? targetType = default(VendorType?), ChargingAction? kind = default(ChargingAction?), VendorActionTarget target = default(VendorActionTarget), VendorActionTargetState targetState = default(VendorActionTargetState), string createdAt = default(string), string updatedAt = default(string), string completedAt = default(string), VendorActionState state = default(VendorActionState))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for VendorAction and cannot be null");
            }
            this.Id = id;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for VendorAction and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new ArgumentNullException("updatedAt is a required property for VendorAction and cannot be null");
            }
            this.UpdatedAt = updatedAt;
            // to ensure "completedAt" is required (not null)
            if (completedAt == null)
            {
                throw new ArgumentNullException("completedAt is a required property for VendorAction and cannot be null");
            }
            this.CompletedAt = completedAt;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for VendorAction and cannot be null");
            }
            this.State = state;
            this.TargetId = targetId;
            this.TargetType = targetType;
            this.Kind = kind;
            this.Target = target;
            this.TargetState = targetState;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TargetId
        /// </summary>
        [DataMember(Name = "targetId", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = false)]
        public VendorActionTarget Target { get; set; }

        /// <summary>
        /// Gets or Sets TargetState
        /// </summary>
        [DataMember(Name = "targetState", EmitDefaultValue = false)]
        public VendorActionTargetState TargetState { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// ISO8601 UTC timestamp at which the action transitioned to a non-pending state. If this value is set, then we are no longer sending commands to the chargeable.
        /// </summary>
        /// <value>ISO8601 UTC timestamp at which the action transitioned to a non-pending state. If this value is set, then we are no longer sending commands to the chargeable.</value>
        [DataMember(Name = "completedAt", IsRequired = true, EmitDefaultValue = true)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public VendorActionState State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VendorAction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  TargetState: ").Append(TargetState).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as VendorAction);
        }

        /// <summary>
        /// Returns true if VendorAction instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorAction input)
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
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    this.TargetType.Equals(input.TargetType)
                ) && 
                (
                    this.Kind == input.Kind ||
                    this.Kind.Equals(input.Kind)
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.TargetState == input.TargetState ||
                    (this.TargetState != null &&
                    this.TargetState.Equals(input.TargetState))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
                hashCode = (hashCode * 59) + this.Kind.GetHashCode();
                if (this.Target != null)
                {
                    hashCode = (hashCode * 59) + this.Target.GetHashCode();
                }
                if (this.TargetState != null)
                {
                    hashCode = (hashCode * 59) + this.TargetState.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.CompletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedAt.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
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
