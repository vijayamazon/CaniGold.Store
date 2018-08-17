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
    /// CreateACaseResponse
    /// </summary>
    [DataContract]
    public partial class CreateACaseResponse :  IEquatable<CreateACaseResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateACaseResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateACaseResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateACaseResponse" /> class.
        /// </summary>
        /// <param name="InvestigationId"> (required).</param>
        public CreateACaseResponse(int? InvestigationId = default(int?))
        {
            // to ensure "InvestigationId" is required (not null)
            if (InvestigationId == null)
            {
                throw new InvalidDataException("InvestigationId is a required property for CreateACaseResponse and cannot be null");
            }
            else
            {
                this.InvestigationId = InvestigationId;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="investigationId", EmitDefaultValue=false)]
        public int? InvestigationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateACaseResponse {\n");
            sb.Append("  InvestigationId: ").Append(InvestigationId).Append("\n");
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
            return this.Equals(obj as CreateACaseResponse);
        }

        /// <summary>
        /// Returns true if CreateACaseResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateACaseResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateACaseResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InvestigationId == other.InvestigationId ||
                    this.InvestigationId != null &&
                    this.InvestigationId.Equals(other.InvestigationId)
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
                if (this.InvestigationId != null)
                    hash = hash * 59 + this.InvestigationId.GetHashCode();
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
