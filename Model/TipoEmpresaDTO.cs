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
    /// TipoEmpresaDTO
    /// </summary>
    [DataContract]
    public partial class TipoEmpresaDTO :  IEquatable<TipoEmpresaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoEmpresaDTO" /> class.
        /// </summary>
        /// <param name="tipoEmpresa">tipoEmpresa.</param>
        /// <param name="descricaoTipoEmpresa">descricaoTipoEmpresa.</param>
        public TipoEmpresaDTO(long? tipoEmpresa = default(long?), string descricaoTipoEmpresa = default(string))
        {
            this.TipoEmpresa = tipoEmpresa;
            this.DescricaoTipoEmpresa = descricaoTipoEmpresa;
        }
        
        /// <summary>
        /// Gets or Sets TipoEmpresa
        /// </summary>
        [DataMember(Name="tipoEmpresa", EmitDefaultValue=false)]
        public long? TipoEmpresa { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoTipoEmpresa
        /// </summary>
        [DataMember(Name="descricaoTipoEmpresa", EmitDefaultValue=false)]
        public string DescricaoTipoEmpresa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TipoEmpresaDTO {\n");
            sb.Append("  TipoEmpresa: ").Append(TipoEmpresa).Append("\n");
            sb.Append("  DescricaoTipoEmpresa: ").Append(DescricaoTipoEmpresa).Append("\n");
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
            return this.Equals(input as TipoEmpresaDTO);
        }

        /// <summary>
        /// Returns true if TipoEmpresaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TipoEmpresaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TipoEmpresaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TipoEmpresa == input.TipoEmpresa ||
                    (this.TipoEmpresa != null &&
                    this.TipoEmpresa.Equals(input.TipoEmpresa))
                ) && 
                (
                    this.DescricaoTipoEmpresa == input.DescricaoTipoEmpresa ||
                    (this.DescricaoTipoEmpresa != null &&
                    this.DescricaoTipoEmpresa.Equals(input.DescricaoTipoEmpresa))
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
                if (this.TipoEmpresa != null)
                    hashCode = hashCode * 59 + this.TipoEmpresa.GetHashCode();
                if (this.DescricaoTipoEmpresa != null)
                    hashCode = hashCode * 59 + this.DescricaoTipoEmpresa.GetHashCode();
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
