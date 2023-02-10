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
    /// Iata
    /// </summary>
    [DataContract]
    public partial class Iata :  IEquatable<Iata>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Iata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Iata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Iata" /> class.
        /// </summary>
        /// <param name="codigoIata">codigoIata (required).</param>
        /// <param name="descricaoIata">descricaoIata.</param>
        /// <param name="municipioIata">municipioIata.</param>
        /// <param name="territorioIata">territorioIata.</param>
        /// <param name="paisIata">paisIata.</param>
        /// <param name="complementoIata">complementoIata.</param>
        /// <param name="usuario">usuario.</param>
        /// <param name="dataatualizacao">dataatualizacao.</param>
        public Iata(string codigoIata = default(string), string descricaoIata = default(string), string municipioIata = default(string), string territorioIata = default(string), string paisIata = default(string), string complementoIata = default(string), string usuario = default(string), DateTime? dataatualizacao = default(DateTime?))
        {
            // to ensure "codigoIata" is required (not null)
            if (codigoIata == null)
            {
                throw new InvalidDataException("codigoIata is a required property for Iata and cannot be null");
            }
            else
            {
                this.CodigoIata = codigoIata;
            }
            this.DescricaoIata = descricaoIata;
            this.MunicipioIata = municipioIata;
            this.TerritorioIata = territorioIata;
            this.PaisIata = paisIata;
            this.ComplementoIata = complementoIata;
            this.Usuario = usuario;
            this.Dataatualizacao = dataatualizacao;
        }
        
        /// <summary>
        /// Gets or Sets CodigoIata
        /// </summary>
        [DataMember(Name="codigoIata", EmitDefaultValue=false)]
        public string CodigoIata { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoIata
        /// </summary>
        [DataMember(Name="descricaoIata", EmitDefaultValue=false)]
        public string DescricaoIata { get; set; }

        /// <summary>
        /// Gets or Sets MunicipioIata
        /// </summary>
        [DataMember(Name="municipioIata", EmitDefaultValue=false)]
        public string MunicipioIata { get; set; }

        /// <summary>
        /// Gets or Sets TerritorioIata
        /// </summary>
        [DataMember(Name="territorioIata", EmitDefaultValue=false)]
        public string TerritorioIata { get; set; }

        /// <summary>
        /// Gets or Sets PaisIata
        /// </summary>
        [DataMember(Name="paisIata", EmitDefaultValue=false)]
        public string PaisIata { get; set; }

        /// <summary>
        /// Gets or Sets ComplementoIata
        /// </summary>
        [DataMember(Name="complementoIata", EmitDefaultValue=false)]
        public string ComplementoIata { get; set; }

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
            sb.Append("class Iata {\n");
            sb.Append("  CodigoIata: ").Append(CodigoIata).Append("\n");
            sb.Append("  DescricaoIata: ").Append(DescricaoIata).Append("\n");
            sb.Append("  MunicipioIata: ").Append(MunicipioIata).Append("\n");
            sb.Append("  TerritorioIata: ").Append(TerritorioIata).Append("\n");
            sb.Append("  PaisIata: ").Append(PaisIata).Append("\n");
            sb.Append("  ComplementoIata: ").Append(ComplementoIata).Append("\n");
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
            return this.Equals(input as Iata);
        }

        /// <summary>
        /// Returns true if Iata instances are equal
        /// </summary>
        /// <param name="input">Instance of Iata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Iata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CodigoIata == input.CodigoIata ||
                    (this.CodigoIata != null &&
                    this.CodigoIata.Equals(input.CodigoIata))
                ) && 
                (
                    this.DescricaoIata == input.DescricaoIata ||
                    (this.DescricaoIata != null &&
                    this.DescricaoIata.Equals(input.DescricaoIata))
                ) && 
                (
                    this.MunicipioIata == input.MunicipioIata ||
                    (this.MunicipioIata != null &&
                    this.MunicipioIata.Equals(input.MunicipioIata))
                ) && 
                (
                    this.TerritorioIata == input.TerritorioIata ||
                    (this.TerritorioIata != null &&
                    this.TerritorioIata.Equals(input.TerritorioIata))
                ) && 
                (
                    this.PaisIata == input.PaisIata ||
                    (this.PaisIata != null &&
                    this.PaisIata.Equals(input.PaisIata))
                ) && 
                (
                    this.ComplementoIata == input.ComplementoIata ||
                    (this.ComplementoIata != null &&
                    this.ComplementoIata.Equals(input.ComplementoIata))
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
                if (this.CodigoIata != null)
                    hashCode = hashCode * 59 + this.CodigoIata.GetHashCode();
                if (this.DescricaoIata != null)
                    hashCode = hashCode * 59 + this.DescricaoIata.GetHashCode();
                if (this.MunicipioIata != null)
                    hashCode = hashCode * 59 + this.MunicipioIata.GetHashCode();
                if (this.TerritorioIata != null)
                    hashCode = hashCode * 59 + this.TerritorioIata.GetHashCode();
                if (this.PaisIata != null)
                    hashCode = hashCode * 59 + this.PaisIata.GetHashCode();
                if (this.ComplementoIata != null)
                    hashCode = hashCode * 59 + this.ComplementoIata.GetHashCode();
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
            // DescricaoIata (string) maxLength
            if(this.DescricaoIata != null && this.DescricaoIata.Length > 120)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DescricaoIata, length must be less than 120.", new [] { "DescricaoIata" });
            }

            // DescricaoIata (string) minLength
            if(this.DescricaoIata != null && this.DescricaoIata.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DescricaoIata, length must be greater than 0.", new [] { "DescricaoIata" });
            }

            // MunicipioIata (string) maxLength
            if(this.MunicipioIata != null && this.MunicipioIata.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MunicipioIata, length must be less than 50.", new [] { "MunicipioIata" });
            }

            // MunicipioIata (string) minLength
            if(this.MunicipioIata != null && this.MunicipioIata.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MunicipioIata, length must be greater than 0.", new [] { "MunicipioIata" });
            }

            // TerritorioIata (string) maxLength
            if(this.TerritorioIata != null && this.TerritorioIata.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerritorioIata, length must be less than 50.", new [] { "TerritorioIata" });
            }

            // TerritorioIata (string) minLength
            if(this.TerritorioIata != null && this.TerritorioIata.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerritorioIata, length must be greater than 0.", new [] { "TerritorioIata" });
            }

            // PaisIata (string) maxLength
            if(this.PaisIata != null && this.PaisIata.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaisIata, length must be less than 50.", new [] { "PaisIata" });
            }

            // PaisIata (string) minLength
            if(this.PaisIata != null && this.PaisIata.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaisIata, length must be greater than 0.", new [] { "PaisIata" });
            }

            // ComplementoIata (string) maxLength
            if(this.ComplementoIata != null && this.ComplementoIata.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ComplementoIata, length must be less than 80.", new [] { "ComplementoIata" });
            }

            // ComplementoIata (string) minLength
            if(this.ComplementoIata != null && this.ComplementoIata.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ComplementoIata, length must be greater than 0.", new [] { "ComplementoIata" });
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
