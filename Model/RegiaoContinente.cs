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
    /// RegiaoContinente
    /// </summary>
    [DataContract]
    public partial class RegiaoContinente :  IEquatable<RegiaoContinente>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegiaoContinente" /> class.
        /// </summary>
        /// <param name="regiaoContinente">regiaoContinente.</param>
        /// <param name="descricaoregiaocontinente">descricaoregiaocontinente.</param>
        /// <param name="usuario">usuario.</param>
        /// <param name="dataatualizacao">dataatualizacao.</param>
        public RegiaoContinente(string regiaoContinente = default(string), string descricaoregiaocontinente = default(string), string usuario = default(string), DateTime? dataatualizacao = default(DateTime?))
        {
            this._RegiaoContinente = regiaoContinente;
            this.Descricaoregiaocontinente = descricaoregiaocontinente;
            this.Usuario = usuario;
            this.Dataatualizacao = dataatualizacao;
        }
        
        /// <summary>
        /// Gets or Sets _RegiaoContinente
        /// </summary>
        [DataMember(Name="regiaoContinente", EmitDefaultValue=false)]
        public string _RegiaoContinente { get; set; }

        /// <summary>
        /// Gets or Sets Descricaoregiaocontinente
        /// </summary>
        [DataMember(Name="descricaoregiaocontinente", EmitDefaultValue=false)]
        public string Descricaoregiaocontinente { get; set; }

        /// <summary>
        /// Gets or Sets Usuario
        /// </summary>
        [DataMember(Name="usuario", EmitDefaultValue=false)]
        public string Usuario { get; set; }

        /// <summary>
        /// Gets or Sets Dataatualizacao
        /// </summary>
        [DataMember(Name="dataatualizacao", EmitDefaultValue=false)]
        public DateTime? Dataatualizacao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegiaoContinente {\n");
            sb.Append("  _RegiaoContinente: ").Append(_RegiaoContinente).Append("\n");
            sb.Append("  Descricaoregiaocontinente: ").Append(Descricaoregiaocontinente).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  Dataatualizacao: ").Append(Dataatualizacao).Append("\n");
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
            return this.Equals(input as RegiaoContinente);
        }

        /// <summary>
        /// Returns true if RegiaoContinente instances are equal
        /// </summary>
        /// <param name="input">Instance of RegiaoContinente to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegiaoContinente input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._RegiaoContinente == input._RegiaoContinente ||
                    (this._RegiaoContinente != null &&
                    this._RegiaoContinente.Equals(input._RegiaoContinente))
                ) && 
                (
                    this.Descricaoregiaocontinente == input.Descricaoregiaocontinente ||
                    (this.Descricaoregiaocontinente != null &&
                    this.Descricaoregiaocontinente.Equals(input.Descricaoregiaocontinente))
                ) && 
                (
                    this.Usuario == input.Usuario ||
                    (this.Usuario != null &&
                    this.Usuario.Equals(input.Usuario))
                ) && 
                (
                    this.Dataatualizacao == input.Dataatualizacao ||
                    (this.Dataatualizacao != null &&
                    this.Dataatualizacao.Equals(input.Dataatualizacao))
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
                if (this._RegiaoContinente != null)
                    hashCode = hashCode * 59 + this._RegiaoContinente.GetHashCode();
                if (this.Descricaoregiaocontinente != null)
                    hashCode = hashCode * 59 + this.Descricaoregiaocontinente.GetHashCode();
                if (this.Usuario != null)
                    hashCode = hashCode * 59 + this.Usuario.GetHashCode();
                if (this.Dataatualizacao != null)
                    hashCode = hashCode * 59 + this.Dataatualizacao.GetHashCode();
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
            // Descricaoregiaocontinente (string) maxLength
            if(this.Descricaoregiaocontinente != null && this.Descricaoregiaocontinente.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Descricaoregiaocontinente, length must be less than 40.", new [] { "Descricaoregiaocontinente" });
            }

            // Descricaoregiaocontinente (string) minLength
            if(this.Descricaoregiaocontinente != null && this.Descricaoregiaocontinente.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Descricaoregiaocontinente, length must be greater than 0.", new [] { "Descricaoregiaocontinente" });
            }

            // Usuario (string) maxLength
            if(this.Usuario != null && this.Usuario.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Usuario, length must be less than 15.", new [] { "Usuario" });
            }

            // Usuario (string) minLength
            if(this.Usuario != null && this.Usuario.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Usuario, length must be greater than 0.", new [] { "Usuario" });
            }

            yield break;
        }
    }

}
