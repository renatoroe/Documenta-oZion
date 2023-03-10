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
    /// ProdutoRelacionadoDTO
    /// </summary>
    [DataContract]
    public partial class ProdutoRelacionadoDTO :  IEquatable<ProdutoRelacionadoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProdutoRelacionadoDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProdutoRelacionadoDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProdutoRelacionadoDTO" /> class.
        /// </summary>
        /// <param name="codigoEmpresa">codigoEmpresa.</param>
        /// <param name="codigoProduto">codigoProduto (required).</param>
        /// <param name="tipoUcCampo">tipoUcCampo.</param>
        /// <param name="codigoProdutoRelacionado">codigoProdutoRelacionado.</param>
        /// <param name="tipoCodigoBarra">tipoCodigoBarra.</param>
        /// <param name="usuario">usuario.</param>
        /// <param name="dataHistorico">dataHistorico.</param>
        public ProdutoRelacionadoDTO(string codigoEmpresa = default(string), string codigoProduto = default(string), string tipoUcCampo = default(string), string codigoProdutoRelacionado = default(string), TipoCodigoBarraDTO tipoCodigoBarra = default(TipoCodigoBarraDTO), string usuario = default(string), DateTime? dataHistorico = default(DateTime?))
        {
            // to ensure "codigoProduto" is required (not null)
            if (codigoProduto == null)
            {
                throw new InvalidDataException("codigoProduto is a required property for ProdutoRelacionadoDTO and cannot be null");
            }
            else
            {
                this.CodigoProduto = codigoProduto;
            }
            this.CodigoEmpresa = codigoEmpresa;
            this.TipoUcCampo = tipoUcCampo;
            this.CodigoProdutoRelacionado = codigoProdutoRelacionado;
            this.TipoCodigoBarra = tipoCodigoBarra;
            this.Usuario = usuario;
            this.DataHistorico = dataHistorico;
        }
        
        /// <summary>
        /// Gets or Sets CodigoEmpresa
        /// </summary>
        [DataMember(Name="codigoEmpresa", EmitDefaultValue=false)]
        public string CodigoEmpresa { get; set; }

        /// <summary>
        /// Gets or Sets CodigoProduto
        /// </summary>
        [DataMember(Name="codigoProduto", EmitDefaultValue=false)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Gets or Sets TipoUcCampo
        /// </summary>
        [DataMember(Name="tipoUcCampo", EmitDefaultValue=false)]
        public string TipoUcCampo { get; set; }

        /// <summary>
        /// Gets or Sets CodigoProdutoRelacionado
        /// </summary>
        [DataMember(Name="codigoProdutoRelacionado", EmitDefaultValue=false)]
        public string CodigoProdutoRelacionado { get; set; }

        /// <summary>
        /// Gets or Sets TipoCodigoBarra
        /// </summary>
        [DataMember(Name="tipoCodigoBarra", EmitDefaultValue=false)]
        public TipoCodigoBarraDTO TipoCodigoBarra { get; set; }

        /// <summary>
        /// Gets or Sets Usuario
        /// </summary>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }

        /// <summary>
        /// Gets or Sets DataHistorico
        /// </summary>
        [DataMember(Name="dataHistorico", EmitDefaultValue=false)]
        public DateTime? DataHistorico { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProdutoRelacionadoDTO {\n");
            sb.Append("  CodigoEmpresa: ").Append(CodigoEmpresa).Append("\n");
            sb.Append("  CodigoProduto: ").Append(CodigoProduto).Append("\n");
            sb.Append("  TipoUcCampo: ").Append(TipoUcCampo).Append("\n");
            sb.Append("  CodigoProdutoRelacionado: ").Append(CodigoProdutoRelacionado).Append("\n");
            sb.Append("  TipoCodigoBarra: ").Append(TipoCodigoBarra).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  DataHistorico: ").Append(DataHistorico).Append("\n");
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
            return this.Equals(input as ProdutoRelacionadoDTO);
        }

        /// <summary>
        /// Returns true if ProdutoRelacionadoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProdutoRelacionadoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProdutoRelacionadoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodigoEmpresa == input.CodigoEmpresa ||
                    (this.CodigoEmpresa != null &&
                    this.CodigoEmpresa.Equals(input.CodigoEmpresa))
                ) && 
                (
                    this.CodigoProduto == input.CodigoProduto ||
                    (this.CodigoProduto != null &&
                    this.CodigoProduto.Equals(input.CodigoProduto))
                ) && 
                (
                    this.TipoUcCampo == input.TipoUcCampo ||
                    (this.TipoUcCampo != null &&
                    this.TipoUcCampo.Equals(input.TipoUcCampo))
                ) && 
                (
                    this.CodigoProdutoRelacionado == input.CodigoProdutoRelacionado ||
                    (this.CodigoProdutoRelacionado != null &&
                    this.CodigoProdutoRelacionado.Equals(input.CodigoProdutoRelacionado))
                ) && 
                (
                    this.TipoCodigoBarra == input.TipoCodigoBarra ||
                    (this.TipoCodigoBarra != null &&
                    this.TipoCodigoBarra.Equals(input.TipoCodigoBarra))
                ) && 
                (
                    this.Usuario == input.Usuario ||
                    (this.Usuario != null &&
                    this.Usuario.Equals(input.Usuario))
                ) && 
                (
                    this.DataHistorico == input.DataHistorico ||
                    (this.DataHistorico != null &&
                    this.DataHistorico.Equals(input.DataHistorico))
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
                if (this.CodigoEmpresa != null)
                    hashCode = hashCode * 59 + this.CodigoEmpresa.GetHashCode();
                if (this.CodigoProduto != null)
                    hashCode = hashCode * 59 + this.CodigoProduto.GetHashCode();
                if (this.TipoUcCampo != null)
                    hashCode = hashCode * 59 + this.TipoUcCampo.GetHashCode();
                if (this.CodigoProdutoRelacionado != null)
                    hashCode = hashCode * 59 + this.CodigoProdutoRelacionado.GetHashCode();
                if (this.TipoCodigoBarra != null)
                    hashCode = hashCode * 59 + this.TipoCodigoBarra.GetHashCode();
                if (this.Usuario != null)
                    hashCode = hashCode * 59 + this.Usuario.GetHashCode();
                if (this.DataHistorico != null)
                    hashCode = hashCode * 59 + this.DataHistorico.GetHashCode();
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
