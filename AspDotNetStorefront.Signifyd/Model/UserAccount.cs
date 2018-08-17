// --------------------------------------------------------------------------------
// Copyright AspDotNetStorefront.com. All Rights Reserved.
// http://www.aspdotnetstorefront.com
// For details on this license please visit the product homepage at the URL above.
// THE ABOVE NOTICE MUST REMAIN INTACT. 
// --------------------------------------------------------------------------------
/* 
 * Signifyd API
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = AspDotNetStorefront.Signifyd.Client.SwaggerDateConverter;

namespace AspDotNetStorefront.Signifyd.Model
{
    /// <summary>
    /// UserAccount
    /// </summary>
    [DataContract]
    public partial class UserAccount :  IEquatable<UserAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccount" /> class.
        /// </summary>
        /// <param name="Email">The primary email address associated with the account..</param>
        /// <param name="Username">The username associated with the account. Please supply this even if it is the same as the email address..</param>
        /// <param name="Phone">The phone number associated with the account..</param>
        /// <param name="CreatedDate">&#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The date when the account was created. See the Dates section of these docs for more information about date formats..</param>
        /// <param name="AccountNumber">Your unique identifier for the account..</param>
        /// <param name="LastOrderId">The unique identifier for the last order placed by this account, prior to the current order..</param>
        /// <param name="AggregateOrderCount">The total count of orders placed by this account since it was created, including the current order..</param>
        /// <param name="AggregateOrderDollars">The total amount spent by this account since it was created, including the current order..</param>
        /// <param name="LastUpdateDate">&#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The last time a change was made to this account other than an order being placed. Examples include changing email addresses or adding a new credit card. See the Dates section of these docs for more information about date formats..</param>
        public UserAccount(string Email = default(string), string Username = default(string), string Phone = default(string), string CreatedDate = default(string), string AccountNumber = default(string), string LastOrderId = default(string), double? AggregateOrderCount = default(double?), double? AggregateOrderDollars = default(double?), string LastUpdateDate = default(string))
        {
            this.Email = Email;
            this.Username = Username;
            this.Phone = Phone;
            this.CreatedDate = CreatedDate;
            this.AccountNumber = AccountNumber;
            this.LastOrderId = LastOrderId;
            this.AggregateOrderCount = AggregateOrderCount;
            this.AggregateOrderDollars = AggregateOrderDollars;
            this.LastUpdateDate = LastUpdateDate;
        }
        
        /// <summary>
        /// The primary email address associated with the account.
        /// </summary>
        /// <value>The primary email address associated with the account.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The username associated with the account. Please supply this even if it is the same as the email address.
        /// </summary>
        /// <value>The username associated with the account. Please supply this even if it is the same as the email address.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The phone number associated with the account.
        /// </summary>
        /// <value>The phone number associated with the account.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The date when the account was created. See the Dates section of these docs for more information about date formats.
        /// </summary>
        /// <value>&#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The date when the account was created. See the Dates section of these docs for more information about date formats.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Your unique identifier for the account.
        /// </summary>
        /// <value>Your unique identifier for the account.</value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The unique identifier for the last order placed by this account, prior to the current order.
        /// </summary>
        /// <value>The unique identifier for the last order placed by this account, prior to the current order.</value>
        [DataMember(Name="lastOrderId", EmitDefaultValue=false)]
        public string LastOrderId { get; set; }

        /// <summary>
        /// The total count of orders placed by this account since it was created, including the current order.
        /// </summary>
        /// <value>The total count of orders placed by this account since it was created, including the current order.</value>
        [DataMember(Name="aggregateOrderCount", EmitDefaultValue=false)]
        public double? AggregateOrderCount { get; set; }

        /// <summary>
        /// The total amount spent by this account since it was created, including the current order.
        /// </summary>
        /// <value>The total amount spent by this account since it was created, including the current order.</value>
        [DataMember(Name="aggregateOrderDollars", EmitDefaultValue=false)]
        public double? AggregateOrderDollars { get; set; }

        /// <summary>
        /// &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The last time a change was made to this account other than an order being placed. Examples include changing email addresses or adding a new credit card. See the Dates section of these docs for more information about date formats.
        /// </summary>
        /// <value>&#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The last time a change was made to this account other than an order being placed. Examples include changing email addresses or adding a new credit card. See the Dates section of these docs for more information about date formats.</value>
        [DataMember(Name="lastUpdateDate", EmitDefaultValue=false)]
        public string LastUpdateDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccount {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  LastOrderId: ").Append(LastOrderId).Append("\n");
            sb.Append("  AggregateOrderCount: ").Append(AggregateOrderCount).Append("\n");
            sb.Append("  AggregateOrderDollars: ").Append(AggregateOrderDollars).Append("\n");
            sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UserAccount);
        }

        /// <summary>
        /// Returns true if UserAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                    this.LastOrderId == other.LastOrderId ||
                    this.LastOrderId != null &&
                    this.LastOrderId.Equals(other.LastOrderId)
                ) && 
                (
                    this.AggregateOrderCount == other.AggregateOrderCount ||
                    this.AggregateOrderCount != null &&
                    this.AggregateOrderCount.Equals(other.AggregateOrderCount)
                ) && 
                (
                    this.AggregateOrderDollars == other.AggregateOrderDollars ||
                    this.AggregateOrderDollars != null &&
                    this.AggregateOrderDollars.Equals(other.AggregateOrderDollars)
                ) && 
                (
                    this.LastUpdateDate == other.LastUpdateDate ||
                    this.LastUpdateDate != null &&
                    this.LastUpdateDate.Equals(other.LastUpdateDate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                if (this.LastOrderId != null)
                    hash = hash * 59 + this.LastOrderId.GetHashCode();
                if (this.AggregateOrderCount != null)
                    hash = hash * 59 + this.AggregateOrderCount.GetHashCode();
                if (this.AggregateOrderDollars != null)
                    hash = hash * 59 + this.AggregateOrderDollars.GetHashCode();
                if (this.LastUpdateDate != null)
                    hash = hash * 59 + this.LastUpdateDate.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
