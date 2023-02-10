/* 
 * Zion WMS API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SitTributariaOrigemDTO
    /// </summary>
    [DataContract]
    public partial class SitTributariaOrigemDTO :  IEquatable<SitTributariaOrigemDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitTributariaOrigemDTO" /> class.
        /// </summary>
        /// <param name="sitTributariaOrigem">sitTributariaOrigem.</param>
        public SitTributariaOrigemDTO(string sitTributariaOrigem = default(string))
        {
            this.SitTributariaOrigem = sitTributariaOrigem;
        }
        
        /// <summary>
        /// Gets or Sets SitTributariaOrigem
        /// </summary>
        [DataMember(Name="sitTributariaOrigem", EmitDefaultValue=false)]
        public string SitTributariaOrigem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SitTributariaOrigemDTO {\n");
            sb.Append("  SitTributariaOrigem: ").Append(SitTributariaOrigem).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SitTributariaOrigemDTO);
        }

        /// <summary>
        /// Returns true if SitTributariaOrigemDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SitTributariaOrigemDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SitTributariaOrigemDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SitTributariaOrigem == input.SitTributariaOrigem ||
                    (this.SitTributariaOrigem != null &&
                    this.SitTributariaOrigem.Equals(input.SitTributariaOrigem))
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
                if (this.SitTributariaOrigem != null)
                    hashCode = hashCode * 59 + this.SitTributariaOrigem.GetHashCode();
                return hashCode;
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
