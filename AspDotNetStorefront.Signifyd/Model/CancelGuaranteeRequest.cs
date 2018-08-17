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
    /// CancelGuaranteeRequest
    /// </summary>
    [DataContract]
    public partial class CancelGuaranteeRequest :  IEquatable<CancelGuaranteeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelGuaranteeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancelGuaranteeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelGuaranteeRequest" /> class.
        /// </summary>
        /// <param name="GuaranteeDisposition"> (required).</param>
        public CancelGuaranteeRequest(string GuaranteeDisposition = default(string))
        {
            // to ensure "GuaranteeDisposition" is required (not null)
            if (GuaranteeDisposition == null)
            {
                throw new InvalidDataException("GuaranteeDisposition is a required property for CancelGuaranteeRequest and cannot be null");
            }
            else
            {
                this.GuaranteeDisposition = GuaranteeDisposition;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="guaranteeDisposition", EmitDefaultValue=false)]
        public string GuaranteeDisposition { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelGuaranteeRequest {\n");
            sb.Append("  GuaranteeDisposition: ").Append(GuaranteeDisposition).Append("\n");
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
            return this.Equals(obj as CancelGuaranteeRequest);
        }

        /// <summary>
        /// Returns true if CancelGuaranteeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of CancelGuaranteeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelGuaranteeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.GuaranteeDisposition == other.GuaranteeDisposition ||
                    this.GuaranteeDisposition != null &&
                    this.GuaranteeDisposition.Equals(other.GuaranteeDisposition)
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
                if (this.GuaranteeDisposition != null)
                    hash = hash * 59 + this.GuaranteeDisposition.GetHashCode();
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
