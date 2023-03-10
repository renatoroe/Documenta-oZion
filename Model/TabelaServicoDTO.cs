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
    /// TabelaServicoDTO
    /// </summary>
    [DataContract]
    public partial class TabelaServicoDTO :  IEquatable<TabelaServicoDTO>, IValidatableObject
    {
        /// <summary>
        /// Defines EstadoTabelaServico
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EstadoTabelaServicoEnum
        {
            
            /// <summary>
            /// Enum PENDENTE for value: PENDENTE
            /// </summary>
            [EnumMember(Value = "PENDENTE")]
            PENDENTE = 1,
            
            /// <summary>
            /// Enum CONFIRMADO for value: CONFIRMADO
            /// </summary>
            [EnumMember(Value = "CONFIRMADO")]
            CONFIRMADO = 2,
            
            /// <summary>
            /// Enum CANCELADO for value: CANCELADO
            /// </summary>
            [EnumMember(Value = "CANCELADO")]
            CANCELADO = 3
        }

        /// <summary>
        /// Gets or Sets EstadoTabelaServico
        /// </summary>
        [DataMember(Name="estadoTabelaServico", EmitDefaultValue=false)]
        public EstadoTabelaServicoEnum? EstadoTabelaServico { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TabelaServicoDTO" /> class.
        /// </summary>
        /// <param name="codigoEmpresa">codigoEmpresa.</param>
        /// <param name="tabelaServico">tabelaServico.</param>
        /// <param name="descricaoTabelaServico">descricaoTabelaServico.</param>
        /// <param name="estadoTabelaServico">estadoTabelaServico.</param>
        public TabelaServicoDTO(string codigoEmpresa = default(string), long? tabelaServico = default(long?), string descricaoTabelaServico = default(string), EstadoTabelaServicoEnum? estadoTabelaServico = default(EstadoTabelaServicoEnum?))
        {
            this.CodigoEmpresa = codigoEmpresa;
            this.TabelaServico = tabelaServico;
            this.DescricaoTabelaServico = descricaoTabelaServico;
            this.EstadoTabelaServico = estadoTabelaServico;
        }
        
        /// <summary>
        /// Gets or Sets CodigoEmpresa
        /// </summary>
        [DataMember(Name="codigoEmpresa", EmitDefaultValue=false)]
        public string CodigoEmpresa { get; set; }

        /// <summary>
        /// Gets or Sets TabelaServico
        /// </summary>
        [DataMember(Name="tabelaServico", EmitDefaultValue=false)]
        public long? TabelaServico { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoTabelaServico
        /// </summary>
        [DataMember(Name="descricaoTabelaServico", EmitDefaultValue=false)]
        public string DescricaoTabelaServico { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TabelaServicoDTO {\n");
            sb.Append("  CodigoEmpresa: ").Append(CodigoEmpresa).Append("\n");
            sb.Append("  TabelaServico: ").Append(TabelaServico).Append("\n");
            sb.Append("  DescricaoTabelaServico: ").Append(DescricaoTabelaServico).Append("\n");
            sb.Append("  EstadoTabelaServico: ").Append(EstadoTabelaServico).Append("\n");
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
            return this.Equals(input as TabelaServicoDTO);
        }

        /// <summary>
        /// Returns true if TabelaServicoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TabelaServicoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TabelaServicoDTO input)
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
                    this.TabelaServico == input.TabelaServico ||
                    (this.TabelaServico != null &&
                    this.TabelaServico.Equals(input.TabelaServico))
                ) && 
                (
                    this.DescricaoTabelaServico == input.DescricaoTabelaServico ||
                    (this.DescricaoTabelaServico != null &&
                    this.DescricaoTabelaServico.Equals(input.DescricaoTabelaServico))
                ) && 
                (
                    this.EstadoTabelaServico == input.EstadoTabelaServico ||
                    (this.EstadoTabelaServico != null &&
                    this.EstadoTabelaServico.Equals(input.EstadoTabelaServico))
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
                if (this.TabelaServico != null)
                    hashCode = hashCode * 59 + this.TabelaServico.GetHashCode();
                if (this.DescricaoTabelaServico != null)
                    hashCode = hashCode * 59 + this.DescricaoTabelaServico.GetHashCode();
                if (this.EstadoTabelaServico != null)
                    hashCode = hashCode * 59 + this.EstadoTabelaServico.GetHashCode();
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
