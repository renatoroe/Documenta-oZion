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
    /// CategoriaDTO
    /// </summary>
    [DataContract]
    public partial class CategoriaDTO :  IEquatable<CategoriaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriaDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CategoriaDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriaDTO" /> class.
        /// </summary>
        /// <param name="codigoCategoria">Código da Categoria, caso não exista será cadastrada (required).</param>
        /// <param name="descricaoCategoria">Descrição da Categoria (required).</param>
        public CategoriaDTO(string codigoCategoria = default(string), string descricaoCategoria = default(string))
        {
            // to ensure "codigoCategoria" is required (not null)
            if (codigoCategoria == null)
            {
                throw new InvalidDataException("codigoCategoria is a required property for CategoriaDTO and cannot be null");
            }
            else
            {
                this.CodigoCategoria = codigoCategoria;
            }
            // to ensure "descricaoCategoria" is required (not null)
            if (descricaoCategoria == null)
            {
                throw new InvalidDataException("descricaoCategoria is a required property for CategoriaDTO and cannot be null");
            }
            else
            {
                this.DescricaoCategoria = descricaoCategoria;
            }
        }
        
        /// <summary>
        /// Código da Categoria, caso não exista será cadastrada
        /// </summary>
        /// <value>Código da Categoria, caso não exista será cadastrada</value>
        [DataMember(Name="codigoCategoria", EmitDefaultValue=false)]
        public string CodigoCategoria { get; set; }

        /// <summary>
        /// Descrição da Categoria
        /// </summary>
        /// <value>Descrição da Categoria</value>
        [DataMember(Name="descricaoCategoria", EmitDefaultValue=false)]
        public string DescricaoCategoria { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoriaDTO {\n");
            sb.Append("  CodigoCategoria: ").Append(CodigoCategoria).Append("\n");
            sb.Append("  DescricaoCategoria: ").Append(DescricaoCategoria).Append("\n");
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
            return this.Equals(input as CategoriaDTO);
        }

        /// <summary>
        /// Returns true if CategoriaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoriaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoriaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodigoCategoria == input.CodigoCategoria ||
                    (this.CodigoCategoria != null &&
                    this.CodigoCategoria.Equals(input.CodigoCategoria))
                ) && 
                (
                    this.DescricaoCategoria == input.DescricaoCategoria ||
                    (this.DescricaoCategoria != null &&
                    this.DescricaoCategoria.Equals(input.DescricaoCategoria))
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
                if (this.CodigoCategoria != null)
                    hashCode = hashCode * 59 + this.CodigoCategoria.GetHashCode();
                if (this.DescricaoCategoria != null)
                    hashCode = hashCode * 59 + this.DescricaoCategoria.GetHashCode();
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
            // CodigoCategoria (string) maxLength
            if(this.CodigoCategoria != null && this.CodigoCategoria.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodigoCategoria, length must be less than 25.", new [] { "CodigoCategoria" });
            }

            // CodigoCategoria (string) minLength
            if(this.CodigoCategoria != null && this.CodigoCategoria.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodigoCategoria, length must be greater than 1.", new [] { "CodigoCategoria" });
            }

            // DescricaoCategoria (string) maxLength
            if(this.DescricaoCategoria != null && this.DescricaoCategoria.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DescricaoCategoria, length must be less than 100.", new [] { "DescricaoCategoria" });
            }

            // DescricaoCategoria (string) minLength
            if(this.DescricaoCategoria != null && this.DescricaoCategoria.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DescricaoCategoria, length must be greater than 1.", new [] { "DescricaoCategoria" });
            }

            yield break;
        }
    }

}