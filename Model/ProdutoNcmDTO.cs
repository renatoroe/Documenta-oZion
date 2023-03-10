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
    /// ProdutoNcmDTO
    /// </summary>
    [DataContract]
    public partial class ProdutoNcmDTO :  IEquatable<ProdutoNcmDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProdutoNcmDTO" /> class.
        /// </summary>
        /// <param name="codigoNcm">codigoNcm.</param>
        /// <param name="descricaoNcm">descricaoNcm.</param>
        public ProdutoNcmDTO(string codigoNcm = default(string), string descricaoNcm = default(string))
        {
            this.CodigoNcm = codigoNcm;
            this.DescricaoNcm = descricaoNcm;
        }
        
        /// <summary>
        /// Gets or Sets CodigoNcm
        /// </summary>
        [DataMember(Name="codigoNcm", EmitDefaultValue=false)]
        public string CodigoNcm { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoNcm
        /// </summary>
        [DataMember(Name="descricaoNcm", EmitDefaultValue=false)]
        public string DescricaoNcm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProdutoNcmDTO {\n");
            sb.Append("  CodigoNcm: ").Append(CodigoNcm).Append("\n");
            sb.Append("  DescricaoNcm: ").Append(DescricaoNcm).Append("\n");
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
            return this.Equals(input as ProdutoNcmDTO);
        }

        /// <summary>
        /// Returns true if ProdutoNcmDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProdutoNcmDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProdutoNcmDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodigoNcm == input.CodigoNcm ||
                    (this.CodigoNcm != null &&
                    this.CodigoNcm.Equals(input.CodigoNcm))
                ) && 
                (
                    this.DescricaoNcm == input.DescricaoNcm ||
                    (this.DescricaoNcm != null &&
                    this.DescricaoNcm.Equals(input.DescricaoNcm))
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
                if (this.CodigoNcm != null)
                    hashCode = hashCode * 59 + this.CodigoNcm.GetHashCode();
                if (this.DescricaoNcm != null)
                    hashCode = hashCode * 59 + this.DescricaoNcm.GetHashCode();
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
