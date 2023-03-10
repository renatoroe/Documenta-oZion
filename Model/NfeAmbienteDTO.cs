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
    /// NfeAmbienteDTO
    /// </summary>
    [DataContract]
    public partial class NfeAmbienteDTO :  IEquatable<NfeAmbienteDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeAmbienteDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NfeAmbienteDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NfeAmbienteDTO" /> class.
        /// </summary>
        /// <param name="nfeAmbiente">nfeAmbiente (required).</param>
        /// <param name="descricaoAmbiente">descricaoAmbiente.</param>
        public NfeAmbienteDTO(int? nfeAmbiente = default(int?), string descricaoAmbiente = default(string))
        {
            // to ensure "nfeAmbiente" is required (not null)
            if (nfeAmbiente == null)
            {
                throw new InvalidDataException("nfeAmbiente is a required property for NfeAmbienteDTO and cannot be null");
            }
            else
            {
                this.NfeAmbiente = nfeAmbiente;
            }
            this.DescricaoAmbiente = descricaoAmbiente;
        }
        
        /// <summary>
        /// Gets or Sets NfeAmbiente
        /// </summary>
        [DataMember(Name="nfeAmbiente", EmitDefaultValue=false)]
        public int? NfeAmbiente { get; set; }

        /// <summary>
        /// Gets or Sets DescricaoAmbiente
        /// </summary>
        [DataMember(Name="descricaoAmbiente", EmitDefaultValue=false)]
        public string DescricaoAmbiente { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NfeAmbienteDTO {\n");
            sb.Append("  NfeAmbiente: ").Append(NfeAmbiente).Append("\n");
            sb.Append("  DescricaoAmbiente: ").Append(DescricaoAmbiente).Append("\n");
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
            return this.Equals(input as NfeAmbienteDTO);
        }

        /// <summary>
        /// Returns true if NfeAmbienteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of NfeAmbienteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NfeAmbienteDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NfeAmbiente == input.NfeAmbiente ||
                    (this.NfeAmbiente != null &&
                    this.NfeAmbiente.Equals(input.NfeAmbiente))
                ) && 
                (
                    this.DescricaoAmbiente == input.DescricaoAmbiente ||
                    (this.DescricaoAmbiente != null &&
                    this.DescricaoAmbiente.Equals(input.DescricaoAmbiente))
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
                if (this.NfeAmbiente != null)
                    hashCode = hashCode * 59 + this.NfeAmbiente.GetHashCode();
                if (this.DescricaoAmbiente != null)
                    hashCode = hashCode * 59 + this.DescricaoAmbiente.GetHashCode();
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
