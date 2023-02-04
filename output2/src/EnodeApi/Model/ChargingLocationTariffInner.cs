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
    /// ChargingLocationTariffInner
    /// </summary>
    [DataContract(Name = "ChargingLocationTariff_inner")]
    public partial class ChargingLocationTariffInner : IEquatable<ChargingLocationTariffInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargingLocationTariffInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChargingLocationTariffInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargingLocationTariffInner" /> class.
        /// </summary>
        /// <param name="weekday">Weekday to apply the named tariff. A weekday starts with 0 for Monday, and ends with 6 for Sunday. If not specified, named tariff is applied for entire week.</param>
        /// <param name="fromHourMinute">Interval from time (inclusive, UTC) (required).</param>
        /// <param name="toHourMinute">Interval to time (exclusive, UTC) (required).</param>
        /// <param name="tariffId">Energy Provider Tariff ID (required).</param>
        /// <param name="tariffName">Rate name (required).</param>
        public ChargingLocationTariffInner(decimal weekday = default(decimal), string fromHourMinute = default(string), string toHourMinute = default(string), string tariffId = default(string), string tariffName = default(string))
        {
            // to ensure "fromHourMinute" is required (not null)
            if (fromHourMinute == null)
            {
                throw new ArgumentNullException("fromHourMinute is a required property for ChargingLocationTariffInner and cannot be null");
            }
            this.FromHourMinute = fromHourMinute;
            // to ensure "toHourMinute" is required (not null)
            if (toHourMinute == null)
            {
                throw new ArgumentNullException("toHourMinute is a required property for ChargingLocationTariffInner and cannot be null");
            }
            this.ToHourMinute = toHourMinute;
            // to ensure "tariffId" is required (not null)
            if (tariffId == null)
            {
                throw new ArgumentNullException("tariffId is a required property for ChargingLocationTariffInner and cannot be null");
            }
            this.TariffId = tariffId;
            // to ensure "tariffName" is required (not null)
            if (tariffName == null)
            {
                throw new ArgumentNullException("tariffName is a required property for ChargingLocationTariffInner and cannot be null");
            }
            this.TariffName = tariffName;
            this.Weekday = weekday;
        }

        /// <summary>
        /// Weekday to apply the named tariff. A weekday starts with 0 for Monday, and ends with 6 for Sunday. If not specified, named tariff is applied for entire week
        /// </summary>
        /// <value>Weekday to apply the named tariff. A weekday starts with 0 for Monday, and ends with 6 for Sunday. If not specified, named tariff is applied for entire week</value>
        [DataMember(Name = "weekday", EmitDefaultValue = false)]
        public decimal Weekday { get; set; }

        /// <summary>
        /// Interval from time (inclusive, UTC)
        /// </summary>
        /// <value>Interval from time (inclusive, UTC)</value>
        [DataMember(Name = "fromHourMinute", IsRequired = true, EmitDefaultValue = true)]
        public string FromHourMinute { get; set; }

        /// <summary>
        /// Interval to time (exclusive, UTC)
        /// </summary>
        /// <value>Interval to time (exclusive, UTC)</value>
        [DataMember(Name = "toHourMinute", IsRequired = true, EmitDefaultValue = true)]
        public string ToHourMinute { get; set; }

        /// <summary>
        /// Energy Provider Tariff ID
        /// </summary>
        /// <value>Energy Provider Tariff ID</value>
        [DataMember(Name = "tariffId", IsRequired = true, EmitDefaultValue = true)]
        public string TariffId { get; set; }

        /// <summary>
        /// Rate name
        /// </summary>
        /// <value>Rate name</value>
        [DataMember(Name = "tariffName", IsRequired = true, EmitDefaultValue = true)]
        public string TariffName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargingLocationTariffInner {\n");
            sb.Append("  Weekday: ").Append(Weekday).Append("\n");
            sb.Append("  FromHourMinute: ").Append(FromHourMinute).Append("\n");
            sb.Append("  ToHourMinute: ").Append(ToHourMinute).Append("\n");
            sb.Append("  TariffId: ").Append(TariffId).Append("\n");
            sb.Append("  TariffName: ").Append(TariffName).Append("\n");
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
            return this.Equals(input as ChargingLocationTariffInner);
        }

        /// <summary>
        /// Returns true if ChargingLocationTariffInner instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargingLocationTariffInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargingLocationTariffInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Weekday == input.Weekday ||
                    this.Weekday.Equals(input.Weekday)
                ) && 
                (
                    this.FromHourMinute == input.FromHourMinute ||
                    (this.FromHourMinute != null &&
                    this.FromHourMinute.Equals(input.FromHourMinute))
                ) && 
                (
                    this.ToHourMinute == input.ToHourMinute ||
                    (this.ToHourMinute != null &&
                    this.ToHourMinute.Equals(input.ToHourMinute))
                ) && 
                (
                    this.TariffId == input.TariffId ||
                    (this.TariffId != null &&
                    this.TariffId.Equals(input.TariffId))
                ) && 
                (
                    this.TariffName == input.TariffName ||
                    (this.TariffName != null &&
                    this.TariffName.Equals(input.TariffName))
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
                hashCode = (hashCode * 59) + this.Weekday.GetHashCode();
                if (this.FromHourMinute != null)
                {
                    hashCode = (hashCode * 59) + this.FromHourMinute.GetHashCode();
                }
                if (this.ToHourMinute != null)
                {
                    hashCode = (hashCode * 59) + this.ToHourMinute.GetHashCode();
                }
                if (this.TariffId != null)
                {
                    hashCode = (hashCode * 59) + this.TariffId.GetHashCode();
                }
                if (this.TariffName != null)
                {
                    hashCode = (hashCode * 59) + this.TariffName.GetHashCode();
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
