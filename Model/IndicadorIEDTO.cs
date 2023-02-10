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
    /// IndicadorIEDTO
    /// </summary>
    [DataContract]
    public partial class IndicadorIEDTO :  IEquatable<IndicadorIEDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndicadorIEDTO" /> class.
        /// </summary>
        /// <param name="indicadorIE">indicadorIE.</param>
        /// <param name="descricaoIndicadorIE">descricaoIndicadorIE.</param>
        public IndicadorIEDTO(int? indicadorIE = default(int?), string descricaoIndicadorIE = default(string))
        {
            this.IndicadorIE = indicadorIE;
            this.DescricaoIndicadorIE = descricaoIndicadorIE;
        }
        
        /// <summary>
        /// Gets or Sets IndicadorIE
        /// </summary>
        [DataMember(Name="indicadorIE", EmitDefaultValue=false)]
        public int? IndicadorIE { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoIndicadorIE
        /// </summary>
        [DataMember(Name="descricaoIndicadorIE", EmitDefaultValue=false)]
        public string DescricaoIndicadorIE { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndicadorIEDTO {\n");
            sb.Append("  IndicadorIE: ").Append(IndicadorIE).Append("\n");
            sb.Append("  DescricaoIndicadorIE: ").Append(DescricaoIndicadorIE).Append("\n");
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
            return this.Equals(input as IndicadorIEDTO);
        }

        /// <summary>
        /// Returns true if IndicadorIEDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IndicadorIEDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndicadorIEDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IndicadorIE == input.IndicadorIE ||
                    (this.IndicadorIE != null &&
                    this.IndicadorIE.Equals(input.IndicadorIE))
                ) && 
                (
                    this.DescricaoIndicadorIE == input.DescricaoIndicadorIE ||
                    (this.DescricaoIndicadorIE != null &&
                    this.DescricaoIndicadorIE.Equals(input.DescricaoIndicadorIE))
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
                if (this.IndicadorIE != null)
                    hashCode = hashCode * 59 + this.IndicadorIE.GetHashCode();
                if (this.DescricaoIndicadorIE != null)
                    hashCode = hashCode * 59 + this.DescricaoIndicadorIE.GetHashCode();
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