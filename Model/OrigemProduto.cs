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
    /// OrigemProduto
    /// </summary>
    [DataContract]
    public partial class OrigemProduto :  IEquatable<OrigemProduto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrigemProduto" /> class.
        /// </summary>
        /// <param name="origemProduto">origemProduto.</param>
        /// <param name="descricaoOrigemProduto">descricaoOrigemProduto.</param>
        public OrigemProduto(string origemProduto = default(string), string descricaoOrigemProduto = default(string))
        {
            this._OrigemProduto = origemProduto;
            this.DescricaoOrigemProduto = descricaoOrigemProduto;
        }
        
        /// <summary>
        /// Gets or Sets _OrigemProduto
        /// </summary>
        [DataMember(Name="origemProduto", EmitDefaultValue=false)]
        public string _OrigemProduto { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoOrigemProduto
        /// </summary>
        [DataMember(Name="descricaoOrigemProduto", EmitDefaultValue=false)]
        public string DescricaoOrigemProduto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrigemProduto {\n");
            sb.Append("  _OrigemProduto: ").Append(_OrigemProduto).Append("\n");
            sb.Append("  DescricaoOrigemProduto: ").Append(DescricaoOrigemProduto).Append("\n");
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
            return this.Equals(input as OrigemProduto);
        }

        /// <summary>
        /// Returns true if OrigemProduto instances are equal
        /// </summary>
        /// <param name="input">Instance of OrigemProduto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrigemProduto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._OrigemProduto == input._OrigemProduto ||
                    (this._OrigemProduto != null &&
                    this._OrigemProduto.Equals(input._OrigemProduto))
                ) && 
                (
                    this.DescricaoOrigemProduto == input.DescricaoOrigemProduto ||
                    (this.DescricaoOrigemProduto != null &&
                    this.DescricaoOrigemProduto.Equals(input.DescricaoOrigemProduto))
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
                if (this._OrigemProduto != null)
                    hashCode = hashCode * 59 + this._OrigemProduto.GetHashCode();
                if (this.DescricaoOrigemProduto != null)
                    hashCode = hashCode * 59 + this.DescricaoOrigemProduto.GetHashCode();
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
