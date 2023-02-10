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
    /// EstabelecimentoDTO
    /// </summary>
    [DataContract]
    public partial class EstabelecimentoDTO :  IEquatable<EstabelecimentoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EstabelecimentoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EstabelecimentoDTO" /> class.
        /// </summary>
        /// <param name="codigoEstabelecimento">codigoEstabelecimento (required).</param>
        /// <param name="nomeEstabelecimento">nomeEstabelecimento.</param>
        /// <param name="cpfEstabelecimento">cpfEstabelecimento.</param>
        /// <param name="ufEstabelecimento">ufEstabelecimento.</param>
        /// <param name="nomeResumido">nomeResumido.</param>
        /// <param name="enderecoEstabelecimento">enderecoEstabelecimento.</param>
        /// <param name="numeroEndereco">numeroEndereco.</param>
        /// <param name="bairroEstabelecimento">bairroEstabelecimento.</param>
        /// <param name="fone1Estabelecimento">fone1Estabelecimento.</param>
        /// <param name="fone2Estabelecimento">fone2Estabelecimento.</param>
        public EstabelecimentoDTO(long? codigoEstabelecimento = default(long?), string nomeEstabelecimento = default(string), string cpfEstabelecimento = default(string), string ufEstabelecimento = default(string), string nomeResumido = default(string), string enderecoEstabelecimento = default(string), string numeroEndereco = default(string), string bairroEstabelecimento = default(string), string fone1Estabelecimento = default(string), string fone2Estabelecimento = default(string))
        {
            // to ensure "codigoEstabelecimento" is required (not null)
            if (codigoEstabelecimento == null)
            {
                throw new InvalidDataException("codigoEstabelecimento is a required property for EstabelecimentoDTO and cannot be null");
            }
            else
            {
                this.CodigoEstabelecimento = codigoEstabelecimento;
            }
            this.NomeEstabelecimento = nomeEstabelecimento;
            this.CpfEstabelecimento = cpfEstabelecimento;
            this.UfEstabelecimento = ufEstabelecimento;
            this.NomeResumido = nomeResumido;
            this.EnderecoEstabelecimento = enderecoEstabelecimento;
            this.NumeroEndereco = numeroEndereco;
            this.BairroEstabelecimento = bairroEstabelecimento;
            this.Fone1Estabelecimento = fone1Estabelecimento;
            this.Fone2Estabelecimento = fone2Estabelecimento;
        }
        
        /// <summary>
        /// Gets or Sets CodigoEstabelecimento
        /// </summary>
        [DataMember(Name="codigoEstabelecimento", EmitDefaultValue=false)]
        public long? CodigoEstabelecimento { get; set; }

        /// <summary>
        /// Gets or Sets NomeEstabelecimento
        /// </summary>
        [DataMember(Name="nomeEstabelecimento", EmitDefaultValue=false)]
        public string NomeEstabelecimento { get; set; }

        /// <summary>
        /// Gets or Sets CpfEstabelecimento
        /// </summary>
        [DataMember(Name="cpfEstabelecimento", EmitDefaultValue=false)]
        public string CpfEstabelecimento { get; set; }

        /// <summary>
        /// Gets or Sets UfEstabelecimento
        /// </summary>
        [DataMember(Name="ufEstabelecimento", EmitDefaultValue=false)]
        public string UfEstabelecimento { get; set; }

        /// <summary>
        /// Gets or Sets NomeResumido
        /// </summary>
        [DataMember(Name="nomeResumido", EmitDefaultValue=false)]
        public string NomeResumido { get; set; }

        /// <summary>
        /// Gets or Sets EnderecoEstabelecimento
        /// </summary>
        [DataMember(Name="enderecoEstabelecimento", EmitDefaultValue=false)]
        public string EnderecoEstabelecimento { get; set; }

        /// <summary>
        /// Gets or Sets NumeroEndereco
        /// </summary>
        [DataMember(Name="numeroEndereco", EmitDefaultValue=false)]
        public string NumeroEndereco { get; set; }

        /// <summary>
        /// Gets or Sets BairroEstabelecimento
        /// </summary>
        [DataMember(Name="bairroEstabelecimento", EmitDefaultValue=false)]
        public string BairroEstabelecimento { get; set; }

        /// <summary>
        /// Gets or Sets Fone1Estabelecimento
        /// </summary>
        [DataMember(Name="fone1Estabelecimento", EmitDefaultValue=false)]
        public string Fone1Estabelecimento { get; set; }

        /// <summary>
        /// Gets or Sets Fone2Estabelecimento
        /// </summary>
        [DataMember(Name="fone2Estabelecimento", EmitDefaultValue=false)]
        public string Fone2Estabelecimento { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstabelecimentoDTO {\n");
            sb.Append("  CodigoEstabelecimento: ").Append(CodigoEstabelecimento).Append("\n");
            sb.Append("  NomeEstabelecimento: ").Append(NomeEstabelecimento).Append("\n");
            sb.Append("  CpfEstabelecimento: ").Append(CpfEstabelecimento).Append("\n");
            sb.Append("  UfEstabelecimento: ").Append(UfEstabelecimento).Append("\n");
            sb.Append("  NomeResumido: ").Append(NomeResumido).Append("\n");
            sb.Append("  EnderecoEstabelecimento: ").Append(EnderecoEstabelecimento).Append("\n");
            sb.Append("  NumeroEndereco: ").Append(NumeroEndereco).Append("\n");
            sb.Append("  BairroEstabelecimento: ").Append(BairroEstabelecimento).Append("\n");
            sb.Append("  Fone1Estabelecimento: ").Append(Fone1Estabelecimento).Append("\n");
            sb.Append("  Fone2Estabelecimento: ").Append(Fone2Estabelecimento).Append("\n");
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
            return this.Equals(input as EstabelecimentoDTO);
        }

        /// <summary>
        /// Returns true if EstabelecimentoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EstabelecimentoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EstabelecimentoDTO input)
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
                    this.NomeEstabelecimento == input.NomeEstabelecimento ||
                    (this.NomeEstabelecimento != null &&
                    this.NomeEstabelecimento.Equals(input.NomeEstabelecimento))
                ) && 
                (
                    this.CpfEstabelecimento == input.CpfEstabelecimento ||
                    (this.CpfEstabelecimento != null &&
                    this.CpfEstabelecimento.Equals(input.CpfEstabelecimento))
                ) && 
                (
                    this.UfEstabelecimento == input.UfEstabelecimento ||
                    (this.UfEstabelecimento != null &&
                    this.UfEstabelecimento.Equals(input.UfEstabelecimento))
                ) && 
                (
                    this.NomeResumido == input.NomeResumido ||
                    (this.NomeResumido != null &&
                    this.NomeResumido.Equals(input.NomeResumido))
                ) && 
                (
                    this.EnderecoEstabelecimento == input.EnderecoEstabelecimento ||
                    (this.EnderecoEstabelecimento != null &&
                    this.EnderecoEstabelecimento.Equals(input.EnderecoEstabelecimento))
                ) && 
                (
                    this.NumeroEndereco == input.NumeroEndereco ||
                    (this.NumeroEndereco != null &&
                    this.NumeroEndereco.Equals(input.NumeroEndereco))
                ) && 
                (
                    this.BairroEstabelecimento == input.BairroEstabelecimento ||
                    (this.BairroEstabelecimento != null &&
                    this.BairroEstabelecimento.Equals(input.BairroEstabelecimento))
                ) && 
                (
                    this.Fone1Estabelecimento == input.Fone1Estabelecimento ||
                    (this.Fone1Estabelecimento != null &&
                    this.Fone1Estabelecimento.Equals(input.Fone1Estabelecimento))
                ) && 
                (
                    this.Fone2Estabelecimento == input.Fone2Estabelecimento ||
                    (this.Fone2Estabelecimento != null &&
                    this.Fone2Estabelecimento.Equals(input.Fone2Estabelecimento))
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
                if (this.NomeEstabelecimento != null)
                    hashCode = hashCode * 59 + this.NomeEstabelecimento.GetHashCode();
                if (this.CpfEstabelecimento != null)
                    hashCode = hashCode * 59 + this.CpfEstabelecimento.GetHashCode();
                if (this.UfEstabelecimento != null)
                    hashCode = hashCode * 59 + this.UfEstabelecimento.GetHashCode();
                if (this.NomeResumido != null)
                    hashCode = hashCode * 59 + this.NomeResumido.GetHashCode();
                if (this.EnderecoEstabelecimento != null)
                    hashCode = hashCode * 59 + this.EnderecoEstabelecimento.GetHashCode();
                if (this.NumeroEndereco != null)
                    hashCode = hashCode * 59 + this.NumeroEndereco.GetHashCode();
                if (this.BairroEstabelecimento != null)
                    hashCode = hashCode * 59 + this.BairroEstabelecimento.GetHashCode();
                if (this.Fone1Estabelecimento != null)
                    hashCode = hashCode * 59 + this.Fone1Estabelecimento.GetHashCode();
                if (this.Fone2Estabelecimento != null)
                    hashCode = hashCode * 59 + this.Fone2Estabelecimento.GetHashCode();
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
