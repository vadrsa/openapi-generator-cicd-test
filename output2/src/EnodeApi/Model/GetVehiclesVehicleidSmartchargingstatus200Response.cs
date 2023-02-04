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
    /// GetVehiclesVehicleidSmartchargingstatus200Response
    /// </summary>
    [DataContract(Name = "getVehiclesVehicleidSmartchargingstatus_200_response")]
    public partial class GetVehiclesVehicleidSmartchargingstatus200Response : IEquatable<GetVehiclesVehicleidSmartchargingstatus200Response>, IValidatableObject
    {
        /// <summary>
        /// An enum value that describes the current SmartCharging state of the vehicle. Every vehicle is in exactly one state, at all times
        /// </summary>
        /// <value>An enum value that describes the current SmartCharging state of the vehicle. Every vehicle is in exactly one state, at all times</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 1,

            /// <summary>
            /// Enum CONSIDERING for value: CONSIDERING
            /// </summary>
            [EnumMember(Value = "CONSIDERING")]
            CONSIDERING = 2,

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 3,

            /// <summary>
            /// Enum PLANEXECUTINGSTOPPING for value: PLAN:EXECUTING:STOPPING
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:STOPPING")]
            PLANEXECUTINGSTOPPING = 4,

            /// <summary>
            /// Enum PLANEXECUTINGSTOPFAILED for value: PLAN:EXECUTING:STOP_FAILED
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:STOP_FAILED")]
            PLANEXECUTINGSTOPFAILED = 5,

            /// <summary>
            /// Enum PLANEXECUTINGSTOPPED for value: PLAN:EXECUTING:STOPPED
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:STOPPED")]
            PLANEXECUTINGSTOPPED = 6,

            /// <summary>
            /// Enum PLANEXECUTINGSTOPPEDAWAITINGPRICES for value: PLAN:EXECUTING:STOPPED:AWAITING_PRICES
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:STOPPED:AWAITING_PRICES")]
            PLANEXECUTINGSTOPPEDAWAITINGPRICES = 7,

            /// <summary>
            /// Enum PLANEXECUTINGSTARTING for value: PLAN:EXECUTING:STARTING
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:STARTING")]
            PLANEXECUTINGSTARTING = 8,

            /// <summary>
            /// Enum PLANEXECUTINGSTARTFAILED for value: PLAN:EXECUTING:START_FAILED
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:START_FAILED")]
            PLANEXECUTINGSTARTFAILED = 9,

            /// <summary>
            /// Enum PLANEXECUTINGSTARTED for value: PLAN:EXECUTING:STARTED
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:STARTED")]
            PLANEXECUTINGSTARTED = 10,

            /// <summary>
            /// Enum PLANEXECUTINGCHARGEINTERRUPTED for value: PLAN:EXECUTING:CHARGE_INTERRUPTED
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:CHARGE_INTERRUPTED")]
            PLANEXECUTINGCHARGEINTERRUPTED = 11,

            /// <summary>
            /// Enum PLANEXECUTINGOVERRIDDEN for value: PLAN:EXECUTING:OVERRIDDEN
            /// </summary>
            [EnumMember(Value = "PLAN:EXECUTING:OVERRIDDEN")]
            PLANEXECUTINGOVERRIDDEN = 12,

            /// <summary>
            /// Enum PLANENDEDFINISHED for value: PLAN:ENDED:FINISHED
            /// </summary>
            [EnumMember(Value = "PLAN:ENDED:FINISHED")]
            PLANENDEDFINISHED = 13,

            /// <summary>
            /// Enum PLANENDEDUNPLUGGED for value: PLAN:ENDED:UNPLUGGED
            /// </summary>
            [EnumMember(Value = "PLAN:ENDED:UNPLUGGED")]
            PLANENDEDUNPLUGGED = 14,

            /// <summary>
            /// Enum PLANENDEDFAILED for value: PLAN:ENDED:FAILED
            /// </summary>
            [EnumMember(Value = "PLAN:ENDED:FAILED")]
            PLANENDEDFAILED = 15,

            /// <summary>
            /// Enum PLANENDEDDISABLED for value: PLAN:ENDED:DISABLED
            /// </summary>
            [EnumMember(Value = "PLAN:ENDED:DISABLED")]
            PLANENDEDDISABLED = 16,

            /// <summary>
            /// Enum PLANENDEDDEADLINECHANGED for value: PLAN:ENDED:DEADLINE_CHANGED
            /// </summary>
            [EnumMember(Value = "PLAN:ENDED:DEADLINE_CHANGED")]
            PLANENDEDDEADLINECHANGED = 17

        }


        /// <summary>
        /// An enum value that describes the current SmartCharging state of the vehicle. Every vehicle is in exactly one state, at all times
        /// </summary>
        /// <value>An enum value that describes the current SmartCharging state of the vehicle. Every vehicle is in exactly one state, at all times</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVehiclesVehicleidSmartchargingstatus200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetVehiclesVehicleidSmartchargingstatus200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetVehiclesVehicleidSmartchargingstatus200Response" /> class.
        /// </summary>
        /// <param name="updatedAt">Time at which the SmartChargingStatus object was recalculated, whether or not any values actually changed (required).</param>
        /// <param name="vehicleId">Vehicle ID (required).</param>
        /// <param name="userId">User ID (required).</param>
        /// <param name="vendor">Vendor of the Vehicle (required).</param>
        /// <param name="state">An enum value that describes the current SmartCharging state of the vehicle. Every vehicle is in exactly one state, at all times (required).</param>
        /// <param name="stateChangedAt">Time at which the the &#39;state&#39; property transitioned to its current value (required).</param>
        /// <param name="consideration">consideration (required).</param>
        /// <param name="plan">plan (required).</param>
        /// <param name="smartOverride">smartOverride (required).</param>
        public GetVehiclesVehicleidSmartchargingstatus200Response(DateTime updatedAt = default(DateTime), string vehicleId = default(string), string userId = default(string), string vendor = default(string), StateEnum state = default(StateEnum), DateTime stateChangedAt = default(DateTime), VehicleSmartChargingStatusConsideration consideration = default(VehicleSmartChargingStatusConsideration), VehicleSmartChargingStatusPlan plan = default(VehicleSmartChargingStatusPlan), SmartOverrideStatus smartOverride = default(SmartOverrideStatus))
        {
            this.UpdatedAt = updatedAt;
            // to ensure "vehicleId" is required (not null)
            if (vehicleId == null)
            {
                throw new ArgumentNullException("vehicleId is a required property for GetVehiclesVehicleidSmartchargingstatus200Response and cannot be null");
            }
            this.VehicleId = vehicleId;
            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new ArgumentNullException("userId is a required property for GetVehiclesVehicleidSmartchargingstatus200Response and cannot be null");
            }
            this.UserId = userId;
            // to ensure "vendor" is required (not null)
            if (vendor == null)
            {
                throw new ArgumentNullException("vendor is a required property for GetVehiclesVehicleidSmartchargingstatus200Response and cannot be null");
            }
            this.Vendor = vendor;
            this.State = state;
            this.StateChangedAt = stateChangedAt;
            // to ensure "consideration" is required (not null)
            if (consideration == null)
            {
                throw new ArgumentNullException("consideration is a required property for GetVehiclesVehicleidSmartchargingstatus200Response and cannot be null");
            }
            this.Consideration = consideration;
            // to ensure "plan" is required (not null)
            if (plan == null)
            {
                throw new ArgumentNullException("plan is a required property for GetVehiclesVehicleidSmartchargingstatus200Response and cannot be null");
            }
            this.Plan = plan;
            // to ensure "smartOverride" is required (not null)
            if (smartOverride == null)
            {
                throw new ArgumentNullException("smartOverride is a required property for GetVehiclesVehicleidSmartchargingstatus200Response and cannot be null");
            }
            this.SmartOverride = smartOverride;
        }

        /// <summary>
        /// Time at which the SmartChargingStatus object was recalculated, whether or not any values actually changed
        /// </summary>
        /// <value>Time at which the SmartChargingStatus object was recalculated, whether or not any values actually changed</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Vehicle ID
        /// </summary>
        /// <value>Vehicle ID</value>
        [DataMember(Name = "vehicleId", IsRequired = true, EmitDefaultValue = true)]
        public string VehicleId { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Vendor of the Vehicle
        /// </summary>
        /// <value>Vendor of the Vehicle</value>
        [DataMember(Name = "vendor", IsRequired = true, EmitDefaultValue = true)]
        public string Vendor { get; set; }

        /// <summary>
        /// Time at which the the &#39;state&#39; property transitioned to its current value
        /// </summary>
        /// <value>Time at which the the &#39;state&#39; property transitioned to its current value</value>
        [DataMember(Name = "stateChangedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime StateChangedAt { get; set; }

        /// <summary>
        /// Gets or Sets Consideration
        /// </summary>
        [DataMember(Name = "consideration", IsRequired = true, EmitDefaultValue = true)]
        public VehicleSmartChargingStatusConsideration Consideration { get; set; }

        /// <summary>
        /// Gets or Sets Plan
        /// </summary>
        [DataMember(Name = "plan", IsRequired = true, EmitDefaultValue = true)]
        public VehicleSmartChargingStatusPlan Plan { get; set; }

        /// <summary>
        /// Gets or Sets SmartOverride
        /// </summary>
        [DataMember(Name = "smartOverride", IsRequired = true, EmitDefaultValue = true)]
        public SmartOverrideStatus SmartOverride { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetVehiclesVehicleidSmartchargingstatus200Response {\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  StateChangedAt: ").Append(StateChangedAt).Append("\n");
            sb.Append("  Consideration: ").Append(Consideration).Append("\n");
            sb.Append("  Plan: ").Append(Plan).Append("\n");
            sb.Append("  SmartOverride: ").Append(SmartOverride).Append("\n");
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
            return this.Equals(input as GetVehiclesVehicleidSmartchargingstatus200Response);
        }

        /// <summary>
        /// Returns true if GetVehiclesVehicleidSmartchargingstatus200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetVehiclesVehicleidSmartchargingstatus200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetVehiclesVehicleidSmartchargingstatus200Response input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.VehicleId == input.VehicleId ||
                    (this.VehicleId != null &&
                    this.VehicleId.Equals(input.VehicleId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Vendor == input.Vendor ||
                    (this.Vendor != null &&
                    this.Vendor.Equals(input.Vendor))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.StateChangedAt == input.StateChangedAt ||
                    (this.StateChangedAt != null &&
                    this.StateChangedAt.Equals(input.StateChangedAt))
                ) && 
                (
                    this.Consideration == input.Consideration ||
                    (this.Consideration != null &&
                    this.Consideration.Equals(input.Consideration))
                ) && 
                (
                    this.Plan == input.Plan ||
                    (this.Plan != null &&
                    this.Plan.Equals(input.Plan))
                ) && 
                (
                    this.SmartOverride == input.SmartOverride ||
                    (this.SmartOverride != null &&
                    this.SmartOverride.Equals(input.SmartOverride))
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
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.VehicleId != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.Vendor != null)
                {
                    hashCode = (hashCode * 59) + this.Vendor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.State.GetHashCode();
                if (this.StateChangedAt != null)
                {
                    hashCode = (hashCode * 59) + this.StateChangedAt.GetHashCode();
                }
                if (this.Consideration != null)
                {
                    hashCode = (hashCode * 59) + this.Consideration.GetHashCode();
                }
                if (this.Plan != null)
                {
                    hashCode = (hashCode * 59) + this.Plan.GetHashCode();
                }
                if (this.SmartOverride != null)
                {
                    hashCode = (hashCode * 59) + this.SmartOverride.GetHashCode();
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
