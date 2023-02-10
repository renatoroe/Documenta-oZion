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
    /// DocumentoProdutoSerieDTO
    /// </summary>
    [DataContract]
    public partial class DocumentoProdutoSerieDTO :  IEquatable<DocumentoProdutoSerieDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoProdutoSerieDTO" /> class.
        /// </summary>
        /// <param name="codigoEstabelecimento">codigoEstabelecimento.</param>
        /// <param name="tipoDocumento">tipoDocumento.</param>
        /// <param name="serieDocumento">serieDocumento.</param>
        /// <param name="numeroDocumento">numeroDocumento.</param>
        /// <param name="lotes">lotes.</param>
        public DocumentoProdutoSerieDTO(long? codigoEstabelecimento = default(long?), string tipoDocumento = default(string), string serieDocumento = default(string), string numeroDocumento = default(string), List<LoteProdutoSerieDTO> lotes = default(List<LoteProdutoSerieDTO>))
        {
            this.CodigoEstabelecimento = codigoEstabelecimento;
            this.TipoDocumento = tipoDocumento;
            this.SerieDocumento = serieDocumento;
            this.NumeroDocumento = numeroDocumento;
            this.Lotes = lotes;
        }
        
        /// <summary>
        /// Gets or Sets CodigoEstabelecimento
        /// </summary>
        [DataMember(Name="codigoEstabelecimento", EmitDefaultValue=false)]
        public long? CodigoEstabelecimento { get; set; }

        /// <summary>
        /// Gets or Sets TipoDocumento
        /// </summary>
        [DataMember(Name="tipoDocumento", EmitDefaultValue=false)]
        public string TipoDocumento { get; set; }

        /// <summary>
        /// Gets or Sets SerieDocumento
        /// </summary>
        [DataMember(Name="serieDocumento", EmitDefaultValue=false)]
        public string SerieDocumento { get; set; }

        /// <summary>
        /// Gets or Sets NumeroDocumento
        /// </summary>
        [DataMember(Name="numeroDocumento", EmitDefaultValue=false)]
        public string NumeroDocumento { get; set; }

        /// <summary>
        /// Gets or Sets Lotes
        /// </summary>
        [DataMember(Name="lotes", EmitDefaultValue=false)]
        public List<LoteProdutoSerieDTO> Lotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentoProdutoSerieDTO {\n");
            sb.Append("  CodigoEstabelecimento: ").Append(CodigoEstabelecimento).Append("\n");
            sb.Append("  TipoDocumento: ").Append(TipoDocumento).Append("\n");
            sb.Append("  SerieDocumento: ").Append(SerieDocumento).Append("\n");
            sb.Append("  NumeroDocumento: ").Append(NumeroDocumento).Append("\n");
            sb.Append("  Lotes: ").Append(Lotes).Append("\n");
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
            return this.Equals(input as DocumentoProdutoSerieDTO);
        }

        /// <summary>
        /// Returns true if DocumentoProdutoSerieDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentoProdutoSerieDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentoProdutoSerieDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodigoEstabelecimento == input.CodigoEstabelecimento ||
                    (this.CodigoEstabelecimento != null &&
                    this.CodigoEstabelecimento.Equals(input.CodigoEstabelecimento))
                ) && 
                (
                    this.TipoDocumento == input.TipoDocumento ||
                    (this.TipoDocumento != null &&
                    this.TipoDocumento.Equals(input.TipoDocumento))
                ) && 
                (
                    this.SerieDocumento == input.SerieDocumento ||
                    (this.SerieDocumento != null &&
                    this.SerieDocumento.Equals(input.SerieDocumento))
                ) && 
                (
                    this.NumeroDocumento == input.NumeroDocumento ||
                    (this.NumeroDocumento != null &&
                    this.NumeroDocumento.Equals(input.NumeroDocumento))
                ) && 
                (
                    this.Lotes == input.Lotes ||
                    this.Lotes != null &&
                    this.Lotes.SequenceEqual(input.Lotes)
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
                if (this.CodigoEstabelecimento != null)
                    hashCode = hashCode * 59 + this.CodigoEstabelecimento.GetHashCode();
                if (this.TipoDocumento != null)
                    hashCode = hashCode * 59 + this.TipoDocumento.GetHashCode();
                if (this.SerieDocumento != null)
                    hashCode = hashCode * 59 + this.SerieDocumento.GetHashCode();
                if (this.NumeroDocumento != null)
                    hashCode = hashCode * 59 + this.NumeroDocumento.GetHashCode();
                if (this.Lotes != null)
                    hashCode = hashCode * 59 + this.Lotes.GetHashCode();
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
