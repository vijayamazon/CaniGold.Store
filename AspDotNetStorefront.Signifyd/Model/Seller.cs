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
    /// Seller
    /// </summary>
    [DataContract]
    public partial class Seller :  IEquatable<Seller>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Seller" /> class.
        /// </summary>
        /// <param name="Name">The business name of the seller..</param>
        /// <param name="Email">The primary email address associated with the seller..</param>
        /// <param name="Username">The unique username associated with the seller. This will likely be whatever they use to login to your site. Please supply this even if it is the same as the email address..</param>
        /// <param name="AccountNumber">.</param>
        /// <param name="Phone">The phone number associated with the seller..</param>
        /// <param name="Domain">The domain of the seller..</param>
        /// <param name="CreatedDate">&#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The date when the seller account was created on your site..</param>
        /// <param name="AggregateOrderCount">The total count of orders sold by this seller since it was created, including the current order..</param>
        /// <param name="AggregateOrderDollars">The total amount sold by this seller since it was created, including the current order..</param>
        /// <param name="LastUpdateDate">&#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The last time a change was made to this seller (e.g. changed email)..</param>
        /// <param name="OnboardingIpAddress">The IP address of the device used when this seller account was created..</param>
        /// <param name="OnboardingEmail">The email address associated with this seller account when it was created..</param>
        /// <param name="Tags">A list of attributes or short descriptors associated with the seller account, formatted as a string of comma-separated values. Example: tag1, tag2, tag3..</param>
        /// <param name="ShipFromAddress">ShipFromAddress.</param>
        /// <param name="CorporateAddress">CorporateAddress.</param>
        public Seller(string Name = default(string), string Email = default(string), string Username = default(string), string AccountNumber = default(string), string Phone = default(string), string Domain = default(string), string CreatedDate = default(string), double? AggregateOrderCount = default(double?), double? AggregateOrderDollars = default(double?), string LastUpdateDate = default(string), string OnboardingIpAddress = default(string), string OnboardingEmail = default(string), List<string> Tags = default(List<string>), Address ShipFromAddress = default(Address), Address CorporateAddress = default(Address))
        {
            this.Name = Name;
            this.Email = Email;
            this.Username = Username;
            this.AccountNumber = AccountNumber;
            this.Phone = Phone;
            this.Domain = Domain;
            this.CreatedDate = CreatedDate;
            this.AggregateOrderCount = AggregateOrderCount;
            this.AggregateOrderDollars = AggregateOrderDollars;
            this.LastUpdateDate = LastUpdateDate;
            this.OnboardingIpAddress = OnboardingIpAddress;
            this.OnboardingEmail = OnboardingEmail;
            this.Tags = Tags;
            this.ShipFromAddress = ShipFromAddress;
            this.CorporateAddress = CorporateAddress;
        }
        
        /// <summary>
        /// The business name of the seller.
        /// </summary>
        /// <value>The business name of the seller.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The primary email address associated with the seller.
        /// </summary>
        /// <value>The primary email address associated with the seller.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The unique username associated with the seller. This will likely be whatever they use to login to your site. Please supply this even if it is the same as the email address.
        /// </summary>
        /// <value>The unique username associated with the seller. This will likely be whatever they use to login to your site. Please supply this even if it is the same as the email address.</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// The phone number associated with the seller.
        /// </summary>
        /// <value>The phone number associated with the seller.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The domain of the seller.
        /// </summary>
        /// <value>The domain of the seller.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The date when the seller account was created on your site.
        /// </summary>
        /// <value>&#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The date when the seller account was created on your site.</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// The total count of orders sold by this seller since it was created, including the current order.
        /// </summary>
        /// <value>The total count of orders sold by this seller since it was created, including the current order.</value>
        [DataMember(Name="aggregateOrderCount", EmitDefaultValue=false)]
        public double? AggregateOrderCount { get; set; }

        /// <summary>
        /// The total amount sold by this seller since it was created, including the current order.
        /// </summary>
        /// <value>The total amount sold by this seller since it was created, including the current order.</value>
        [DataMember(Name="aggregateOrderDollars", EmitDefaultValue=false)]
        public double? AggregateOrderDollars { get; set; }

        /// <summary>
        /// &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The last time a change was made to this seller (e.g. changed email).
        /// </summary>
        /// <value>&#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ssZ&#x60; The last time a change was made to this seller (e.g. changed email).</value>
        [DataMember(Name="lastUpdateDate", EmitDefaultValue=false)]
        public string LastUpdateDate { get; set; }

        /// <summary>
        /// The IP address of the device used when this seller account was created.
        /// </summary>
        /// <value>The IP address of the device used when this seller account was created.</value>
        [DataMember(Name="onboardingIpAddress", EmitDefaultValue=false)]
        public string OnboardingIpAddress { get; set; }

        /// <summary>
        /// The email address associated with this seller account when it was created.
        /// </summary>
        /// <value>The email address associated with this seller account when it was created.</value>
        [DataMember(Name="onboardingEmail", EmitDefaultValue=false)]
        public string OnboardingEmail { get; set; }

        /// <summary>
        /// A list of attributes or short descriptors associated with the seller account, formatted as a string of comma-separated values. Example: tag1, tag2, tag3.
        /// </summary>
        /// <value>A list of attributes or short descriptors associated with the seller account, formatted as a string of comma-separated values. Example: tag1, tag2, tag3.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ShipFromAddress
        /// </summary>
        [DataMember(Name="shipFromAddress", EmitDefaultValue=false)]
        public Address ShipFromAddress { get; set; }

        /// <summary>
        /// Gets or Sets CorporateAddress
        /// </summary>
        [DataMember(Name="corporateAddress", EmitDefaultValue=false)]
        public Address CorporateAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Seller {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  AggregateOrderCount: ").Append(AggregateOrderCount).Append("\n");
            sb.Append("  AggregateOrderDollars: ").Append(AggregateOrderDollars).Append("\n");
            sb.Append("  LastUpdateDate: ").Append(LastUpdateDate).Append("\n");
            sb.Append("  OnboardingIpAddress: ").Append(OnboardingIpAddress).Append("\n");
            sb.Append("  OnboardingEmail: ").Append(OnboardingEmail).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ShipFromAddress: ").Append(ShipFromAddress).Append("\n");
            sb.Append("  CorporateAddress: ").Append(CorporateAddress).Append("\n");
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
            return this.Equals(obj as Seller);
        }

        /// <summary>
        /// Returns true if Seller instances are equal
        /// </summary>
        /// <param name="other">Instance of Seller to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Seller other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
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
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
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
                ) && 
                (
                    this.OnboardingIpAddress == other.OnboardingIpAddress ||
                    this.OnboardingIpAddress != null &&
                    this.OnboardingIpAddress.Equals(other.OnboardingIpAddress)
                ) && 
                (
                    this.OnboardingEmail == other.OnboardingEmail ||
                    this.OnboardingEmail != null &&
                    this.OnboardingEmail.Equals(other.OnboardingEmail)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.ShipFromAddress == other.ShipFromAddress ||
                    this.ShipFromAddress != null &&
                    this.ShipFromAddress.Equals(other.ShipFromAddress)
                ) && 
                (
                    this.CorporateAddress == other.CorporateAddress ||
                    this.CorporateAddress != null &&
                    this.CorporateAddress.Equals(other.CorporateAddress)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.AggregateOrderCount != null)
                    hash = hash * 59 + this.AggregateOrderCount.GetHashCode();
                if (this.AggregateOrderDollars != null)
                    hash = hash * 59 + this.AggregateOrderDollars.GetHashCode();
                if (this.LastUpdateDate != null)
                    hash = hash * 59 + this.LastUpdateDate.GetHashCode();
                if (this.OnboardingIpAddress != null)
                    hash = hash * 59 + this.OnboardingIpAddress.GetHashCode();
                if (this.OnboardingEmail != null)
                    hash = hash * 59 + this.OnboardingEmail.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.ShipFromAddress != null)
                    hash = hash * 59 + this.ShipFromAddress.GetHashCode();
                if (this.CorporateAddress != null)
                    hash = hash * 59 + this.CorporateAddress.GetHashCode();
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
