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
    /// The target state to apply when no rules are active.
    /// </summary>
    [DataContract(Name = "PartialTemperatureSchedule_defaultTargetState")]
    public partial class PartialTemperatureScheduleDefaultTargetState : IEquatable<PartialTemperatureScheduleDefaultTargetState>, IValidatableObject
    {
        /// <summary>
        /// The duration the setpoints and mode are expected to be held. If &#x60;SCHEDULED&#x60;, the device is being controlled by an OEM schedule configured on the device. When targeting a &#x60;SCHEDLUED&#x60; holdType, no other properties should be specified. If &#x60;PERMANENT&#x60;, at least the mode must be specified.
        /// </summary>
        /// <value>The duration the setpoints and mode are expected to be held. If &#x60;SCHEDULED&#x60;, the device is being controlled by an OEM schedule configured on the device. When targeting a &#x60;SCHEDLUED&#x60; holdType, no other properties should be specified. If &#x60;PERMANENT&#x60;, at least the mode must be specified.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HoldTypeEnum
        {
            /// <summary>
            /// Enum PERMANENT for value: PERMANENT
            /// </summary>
            [EnumMember(Value = "PERMANENT")]
            PERMANENT = 1,

            /// <summary>
            /// Enum SCHEDULED for value: SCHEDULED
            /// </summary>
            [EnumMember(Value = "SCHEDULED")]
            SCHEDULED = 2

        }


        /// <summary>
        /// The duration the setpoints and mode are expected to be held. If &#x60;SCHEDULED&#x60;, the device is being controlled by an OEM schedule configured on the device. When targeting a &#x60;SCHEDLUED&#x60; holdType, no other properties should be specified. If &#x60;PERMANENT&#x60;, at least the mode must be specified.
        /// </summary>
        /// <value>The duration the setpoints and mode are expected to be held. If &#x60;SCHEDULED&#x60;, the device is being controlled by an OEM schedule configured on the device. When targeting a &#x60;SCHEDLUED&#x60; holdType, no other properties should be specified. If &#x60;PERMANENT&#x60;, at least the mode must be specified.</value>
        [DataMember(Name = "holdType", IsRequired = true, EmitDefaultValue = true)]
        public HoldTypeEnum HoldType { get; set; }
        /// <summary>
        /// Desired mode. HVAC units may specify a list of &#x60;capableModes&#x60; under capabilities. No setpoints are accepted in the &#x60;OFF&#x60; state. When specifying &#x60;HEAT&#x60; or &#x60;COOL&#x60;, the associated setpoint must be specified. Additionally, when targeting the &#x60;AUTO&#x60; state, both setpoints must be specified.
        /// </summary>
        /// <value>Desired mode. HVAC units may specify a list of &#x60;capableModes&#x60; under capabilities. No setpoints are accepted in the &#x60;OFF&#x60; state. When specifying &#x60;HEAT&#x60; or &#x60;COOL&#x60;, the associated setpoint must be specified. Additionally, when targeting the &#x60;AUTO&#x60; state, both setpoints must be specified.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            [EnumMember(Value = "AUTO")]
            AUTO = 1,

            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            [EnumMember(Value = "OFF")]
            OFF = 2,

            /// <summary>
            /// Enum HEAT for value: HEAT
            /// </summary>
            [EnumMember(Value = "HEAT")]
            HEAT = 3,

            /// <summary>
            /// Enum COOL for value: COOL
            /// </summary>
            [EnumMember(Value = "COOL")]
            COOL = 4

        }


        /// <summary>
        /// Desired mode. HVAC units may specify a list of &#x60;capableModes&#x60; under capabilities. No setpoints are accepted in the &#x60;OFF&#x60; state. When specifying &#x60;HEAT&#x60; or &#x60;COOL&#x60;, the associated setpoint must be specified. Additionally, when targeting the &#x60;AUTO&#x60; state, both setpoints must be specified.
        /// </summary>
        /// <value>Desired mode. HVAC units may specify a list of &#x60;capableModes&#x60; under capabilities. No setpoints are accepted in the &#x60;OFF&#x60; state. When specifying &#x60;HEAT&#x60; or &#x60;COOL&#x60;, the associated setpoint must be specified. Additionally, when targeting the &#x60;AUTO&#x60; state, both setpoints must be specified.</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTemperatureScheduleDefaultTargetState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartialTemperatureScheduleDefaultTargetState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartialTemperatureScheduleDefaultTargetState" /> class.
        /// </summary>
        /// <param name="holdType">The duration the setpoints and mode are expected to be held. If &#x60;SCHEDULED&#x60;, the device is being controlled by an OEM schedule configured on the device. When targeting a &#x60;SCHEDLUED&#x60; holdType, no other properties should be specified. If &#x60;PERMANENT&#x60;, at least the mode must be specified. (required).</param>
        /// <param name="mode">Desired mode. HVAC units may specify a list of &#x60;capableModes&#x60; under capabilities. No setpoints are accepted in the &#x60;OFF&#x60; state. When specifying &#x60;HEAT&#x60; or &#x60;COOL&#x60;, the associated setpoint must be specified. Additionally, when targeting the &#x60;AUTO&#x60; state, both setpoints must be specified..</param>
        /// <param name="heatSetpoint">Desired heat setpoint, required when &#x60;mode&#x60; is &#x60;HEAT&#x60; or &#x60;AUTO&#x60;..</param>
        /// <param name="coolSetpoint">Desired cool setpoint, required when &#x60;mode&#x60; is &#x60;COOL&#x60; or &#x60;AUTO&#x60;. If both setpoints are specified, &#x60;coolSetpoint&#x60; must be larger than &#x60;heatSetpoint&#x60;..</param>
        public PartialTemperatureScheduleDefaultTargetState(HoldTypeEnum holdType = default(HoldTypeEnum), ModeEnum? mode = default(ModeEnum?), decimal heatSetpoint = default(decimal), decimal coolSetpoint = default(decimal))
        {
            this.HoldType = holdType;
            this.Mode = mode;
            this.HeatSetpoint = heatSetpoint;
            this.CoolSetpoint = coolSetpoint;
        }

        /// <summary>
        /// Desired heat setpoint, required when &#x60;mode&#x60; is &#x60;HEAT&#x60; or &#x60;AUTO&#x60;.
        /// </summary>
        /// <value>Desired heat setpoint, required when &#x60;mode&#x60; is &#x60;HEAT&#x60; or &#x60;AUTO&#x60;.</value>
        [DataMember(Name = "heatSetpoint", EmitDefaultValue = false)]
        public decimal HeatSetpoint { get; set; }

        /// <summary>
        /// Desired cool setpoint, required when &#x60;mode&#x60; is &#x60;COOL&#x60; or &#x60;AUTO&#x60;. If both setpoints are specified, &#x60;coolSetpoint&#x60; must be larger than &#x60;heatSetpoint&#x60;.
        /// </summary>
        /// <value>Desired cool setpoint, required when &#x60;mode&#x60; is &#x60;COOL&#x60; or &#x60;AUTO&#x60;. If both setpoints are specified, &#x60;coolSetpoint&#x60; must be larger than &#x60;heatSetpoint&#x60;.</value>
        [DataMember(Name = "coolSetpoint", EmitDefaultValue = false)]
        public decimal CoolSetpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartialTemperatureScheduleDefaultTargetState {\n");
            sb.Append("  HoldType: ").Append(HoldType).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  HeatSetpoint: ").Append(HeatSetpoint).Append("\n");
            sb.Append("  CoolSetpoint: ").Append(CoolSetpoint).Append("\n");
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
            return this.Equals(input as PartialTemperatureScheduleDefaultTargetState);
        }

        /// <summary>
        /// Returns true if PartialTemperatureScheduleDefaultTargetState instances are equal
        /// </summary>
        /// <param name="input">Instance of PartialTemperatureScheduleDefaultTargetState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartialTemperatureScheduleDefaultTargetState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HoldType == input.HoldType ||
                    this.HoldType.Equals(input.HoldType)
                ) && 
                (
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.HeatSetpoint == input.HeatSetpoint ||
                    this.HeatSetpoint.Equals(input.HeatSetpoint)
                ) && 
                (
                    this.CoolSetpoint == input.CoolSetpoint ||
                    this.CoolSetpoint.Equals(input.CoolSetpoint)
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
                hashCode = (hashCode * 59) + this.HoldType.GetHashCode();
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                hashCode = (hashCode * 59) + this.HeatSetpoint.GetHashCode();
                hashCode = (hashCode * 59) + this.CoolSetpoint.GetHashCode();
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
