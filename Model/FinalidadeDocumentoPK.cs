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
    /// FinalidadeDocumentoPK
    /// </summary>
    [DataContract]
    public partial class FinalidadeDocumentoPK :  IEquatable<FinalidadeDocumentoPK>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinalidadeDocumentoPK" /> class.
        /// </summary>
        /// <param name="tipoDocumentoFiscal">tipoDocumentoFiscal.</param>
        /// <param name="codigoFinalidade">codigoFinalidade.</param>
        public FinalidadeDocumentoPK(TipoDocumentoFiscal tipoDocumentoFiscal = default(TipoDocumentoFiscal), int? codigoFinalidade = default(int?))
        {
            this.TipoDocumentoFiscal = tipoDocumentoFiscal;
            this.CodigoFinalidade = codigoFinalidade;
        }
        
        /// <summary>
        /// Gets or Sets TipoDocumentoFiscal
        /// </summary>
        [DataMember(Name="tipoDocumentoFiscal", EmitDefaultValue=false)]
        public TipoDocumentoFiscal TipoDocumentoFiscal { get; set; }

        /// <summary>
        /// Gets or Sets CodigoFinalidade
        /// </summary>
        [DataMember(Name="codigoFinalidade", EmitDefaultValue=false)]
        public int? CodigoFinalidade { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FinalidadeDocumentoPK {\n");
            sb.Append("  TipoDocumentoFiscal: ").Append(TipoDocumentoFiscal).Append("\n");
            sb.Append("  CodigoFinalidade: ").Append(CodigoFinalidade).Append("\n");
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
            return this.Equals(input as FinalidadeDocumentoPK);
        }

        /// <summary>
        /// Returns true if FinalidadeDocumentoPK instances are equal
        /// </summary>
        /// <param name="input">Instance of FinalidadeDocumentoPK to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FinalidadeDocumentoPK input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TipoDocumentoFiscal == input.TipoDocumentoFiscal ||
                    (this.TipoDocumentoFiscal != null &&
                    this.TipoDocumentoFiscal.Equals(input.TipoDocumentoFiscal))
                ) && 
                (
                    this.CodigoFinalidade == input.CodigoFinalidade ||
                    (this.CodigoFinalidade != null &&
                    this.CodigoFinalidade.Equals(input.CodigoFinalidade))
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
                if (this.TipoDocumentoFiscal != null)
                    hashCode = hashCode * 59 + this.TipoDocumentoFiscal.GetHashCode();
                if (this.CodigoFinalidade != null)
                    hashCode = hashCode * 59 + this.CodigoFinalidade.GetHashCode();
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