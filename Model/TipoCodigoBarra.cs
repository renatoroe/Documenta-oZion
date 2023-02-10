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
    /// TipoCodigoBarra
    /// </summary>
    [DataContract]
    public partial class TipoCodigoBarra :  IEquatable<TipoCodigoBarra>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoCodigoBarra" /> class.
        /// </summary>
        /// <param name="tipoCodBarra">tipoCodBarra.</param>
        /// <param name="usuario">usuario.</param>
        /// <param name="dataAtualizacao">dataAtualizacao.</param>
        /// <param name="descTipoCodigoBarra">descTipoCodigoBarra.</param>
        /// <param name="ativo">ativo.</param>
        public TipoCodigoBarra(string tipoCodBarra = default(string), string usuario = default(string), DateTime? dataAtualizacao = default(DateTime?), string descTipoCodigoBarra = default(string), bool? ativo = default(bool?))
        {
            this.TipoCodBarra = tipoCodBarra;
            this.Usuario = usuario;
            this.DataAtualizacao = dataAtualizacao;
            this.DescTipoCodigoBarra = descTipoCodigoBarra;
            this.Ativo = ativo;
        }
        
        /// <summary>
        /// Gets or Sets TipoCodBarra
        /// </summary>
        [DataMember(Name="tipoCodBarra", EmitDefaultValue=false)]
        public string TipoCodBarra { get; set; }

        /// <summary>
        /// Gets or Sets Usuario
        /// </summary>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }

        /// <summary>
        /// Gets or Sets DataAtualizacao
        /// </summary>
        [DataMember(Name="dataAtualizacao", EmitDefaultValue=false)]
        public DateTime? DataAtualizacao { get; set; }

        /// <summary>
        /// Gets or Sets DescTipoCodigoBarra
        /// </summary>
        [DataMember(Name="descTipoCodigoBarra", EmitDefaultValue=false)]
        public string DescTipoCodigoBarra { get; set; }

        /// <summary>
        /// Gets or Sets Ativo
        /// </summary>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoCodigoBarra {\n");
            sb.Append("  TipoCodBarra: ").Append(TipoCodBarra).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  DataAtualizacao: ").Append(DataAtualizacao).Append("\n");
            sb.Append("  DescTipoCodigoBarra: ").Append(DescTipoCodigoBarra).Append("\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
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
            return this.Equals(input as TipoCodigoBarra);
        }

        /// <summary>
        /// Returns true if TipoCodigoBarra instances are equal
        /// </summary>
        /// <param name="input">Instance of TipoCodigoBarra to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoCodigoBarra input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TipoCodBarra == input.TipoCodBarra ||
                    (this.TipoCodBarra != null &&
                    this.TipoCodBarra.Equals(input.TipoCodBarra))
                ) && 
                (
                    this.Usuario == input.Usuario ||
                    (this.Usuario != null &&
                    this.Usuario.Equals(input.Usuario))
                ) && 
                (
                    this.DataAtualizacao == input.DataAtualizacao ||
                    (this.DataAtualizacao != null &&
                    this.DataAtualizacao.Equals(input.DataAtualizacao))
                ) && 
                (
                    this.DescTipoCodigoBarra == input.DescTipoCodigoBarra ||
                    (this.DescTipoCodigoBarra != null &&
                    this.DescTipoCodigoBarra.Equals(input.DescTipoCodigoBarra))
                ) && 
                (
                    this.Ativo == input.Ativo ||
                    (this.Ativo != null &&
                    this.Ativo.Equals(input.Ativo))
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
                if (this.TipoCodBarra != null)
                    hashCode = hashCode * 59 + this.TipoCodBarra.GetHashCode();
                if (this.Usuario != null)
                    hashCode = hashCode * 59 + this.Usuario.GetHashCode();
                if (this.DataAtualizacao != null)
                    hashCode = hashCode * 59 + this.DataAtualizacao.GetHashCode();
                if (this.DescTipoCodigoBarra != null)
                    hashCode = hashCode * 59 + this.DescTipoCodigoBarra.GetHashCode();
                if (this.Ativo != null)
                    hashCode = hashCode * 59 + this.Ativo.GetHashCode();
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
