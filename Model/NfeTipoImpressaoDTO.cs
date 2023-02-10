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
    /// NfeTipoImpressaoDTO
    /// </summary>
    [DataContract]
    public partial class NfeTipoImpressaoDTO :  IEquatable<NfeTipoImpressaoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeTipoImpressaoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeTipoImpressaoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeTipoImpressaoDTO" /> class.
        /// </summary>
        /// <param name="nfeTipoImpressao">nfeTipoImpressao (required).</param>
        /// <param name="descricaoTipoImpressao">descricaoTipoImpressao.</param>
        public NfeTipoImpressaoDTO(int? nfeTipoImpressao = default(int?), string descricaoTipoImpressao = default(string))
        {
            // to ensure "nfeTipoImpressao" is required (not null)
            if (nfeTipoImpressao == null)
            {
                throw new InvalidDataException("nfeTipoImpressao is a required property for NfeTipoImpressaoDTO and cannot be null");
            }
            else
            {
                this.NfeTipoImpressao = nfeTipoImpressao;
            }
            this.DescricaoTipoImpressao = descricaoTipoImpressao;
        }
        
        /// <summary>
        /// Gets or Sets NfeTipoImpressao
        /// </summary>
        [DataMember(Name="nfeTipoImpressao", EmitDefaultValue=false)]
        public int? NfeTipoImpressao { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoTipoImpressao
        /// </summary>
        [DataMember(Name="descricaoTipoImpressao", EmitDefaultValue=false)]
        public string DescricaoTipoImpressao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NfeTipoImpressaoDTO {\n");
            sb.Append("  NfeTipoImpressao: ").Append(NfeTipoImpressao).Append("\n");
            sb.Append("  DescricaoTipoImpressao: ").Append(DescricaoTipoImpressao).Append("\n");
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
            return this.Equals(input as NfeTipoImpressaoDTO);
        }

        /// <summary>
        /// Returns true if NfeTipoImpressaoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeTipoImpressaoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeTipoImpressaoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NfeTipoImpressao == input.NfeTipoImpressao ||
                    (this.NfeTipoImpressao != null &&
                    this.NfeTipoImpressao.Equals(input.NfeTipoImpressao))
                ) && 
                (
                    this.DescricaoTipoImpressao == input.DescricaoTipoImpressao ||
                    (this.DescricaoTipoImpressao != null &&
                    this.DescricaoTipoImpressao.Equals(input.DescricaoTipoImpressao))
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
                if (this.NfeTipoImpressao != null)
                    hashCode = hashCode * 59 + this.NfeTipoImpressao.GetHashCode();
                if (this.DescricaoTipoImpressao != null)
                    hashCode = hashCode * 59 + this.DescricaoTipoImpressao.GetHashCode();
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
