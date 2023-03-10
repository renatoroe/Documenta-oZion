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
    /// Linha
    /// </summary>
    [DataContract]
    public partial class Linha :  IEquatable<Linha>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Linha" /> class.
        /// </summary>
        /// <param name="codigoLinha">codigoLinha.</param>
        /// <param name="descricaoLinha">descricaoLinha.</param>
        public Linha(string codigoLinha = default(string), string descricaoLinha = default(string))
        {
            this.CodigoLinha = codigoLinha;
            this.DescricaoLinha = descricaoLinha;
        }
        
        /// <summary>
        /// Gets or Sets CodigoLinha
        /// </summary>
        [DataMember(Name="codigoLinha", EmitDefaultValue=false)]
        public string CodigoLinha { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoLinha
        /// </summary>
        [DataMember(Name="descricaoLinha", EmitDefaultValue=false)]
        public string DescricaoLinha { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Linha {\n");
            sb.Append("  CodigoLinha: ").Append(CodigoLinha).Append("\n");
            sb.Append("  DescricaoLinha: ").Append(DescricaoLinha).Append("\n");
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
            return this.Equals(input as Linha);
        }

        /// <summary>
        /// Returns true if Linha instances are equal
        /// </summary>
        /// <param name="input">Instance of Linha to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Linha input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodigoLinha == input.CodigoLinha ||
                    (this.CodigoLinha != null &&
                    this.CodigoLinha.Equals(input.CodigoLinha))
                ) && 
                (
                    this.DescricaoLinha == input.DescricaoLinha ||
                    (this.DescricaoLinha != null &&
                    this.DescricaoLinha.Equals(input.DescricaoLinha))
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
                if (this.CodigoLinha != null)
                    hashCode = hashCode * 59 + this.CodigoLinha.GetHashCode();
                if (this.DescricaoLinha != null)
                    hashCode = hashCode * 59 + this.DescricaoLinha.GetHashCode();
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
