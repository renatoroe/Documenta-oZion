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
    /// ProdutoRevisaoComponenteDTO
    /// </summary>
    [DataContract]
    public partial class ProdutoRevisaoComponenteDTO :  IEquatable<ProdutoRevisaoComponenteDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProdutoRevisaoComponenteDTO" /> class.
        /// </summary>
        /// <param name="codigoEmpresa">codigoEmpresa.</param>
        /// <param name="codigoProduto">codigoProduto.</param>
        /// <param name="numeroRevisao">numeroRevisao.</param>
        /// <param name="sequenciaComponente">sequenciaComponente.</param>
        /// <param name="codigoEmpresaComponente">codigoEmpresaComponente.</param>
        /// <param name="codigoProdutoComponente">codigoProdutoComponente.</param>
        /// <param name="tipoUcComponente">tipoUcComponente.</param>
        /// <param name="fatorTipoUcComponente">fatorTipoUcComponente.</param>
        /// <param name="quantidadeUtilizada">quantidadeUtilizada.</param>
        /// <param name="baixarEstoqueAutomatico">baixarEstoqueAutomatico.</param>
        /// <param name="classeProduto">classeProduto.</param>
        /// <param name="usuario">usuario.</param>
        /// <param name="dataAtualizacao">dataAtualizacao.</param>
        /// <param name="produtoRevisao">produtoRevisao.</param>
        public ProdutoRevisaoComponenteDTO(string codigoEmpresa = default(string), string codigoProduto = default(string), string numeroRevisao = default(string), long? sequenciaComponente = default(long?), string codigoEmpresaComponente = default(string), string codigoProdutoComponente = default(string), string tipoUcComponente = default(string), decimal? fatorTipoUcComponente = default(decimal?), decimal? quantidadeUtilizada = default(decimal?), bool? baixarEstoqueAutomatico = default(bool?), string classeProduto = default(string), string usuario = default(string), DateTime? dataAtualizacao = default(DateTime?), ProdutoRevisaoDTO produtoRevisao = default(ProdutoRevisaoDTO))
        {
            this.CodigoEmpresa = codigoEmpresa;
            this.CodigoProduto = codigoProduto;
            this.NumeroRevisao = numeroRevisao;
            this.SequenciaComponente = sequenciaComponente;
            this.CodigoEmpresaComponente = codigoEmpresaComponente;
            this.CodigoProdutoComponente = codigoProdutoComponente;
            this.TipoUcComponente = tipoUcComponente;
            this.FatorTipoUcComponente = fatorTipoUcComponente;
            this.QuantidadeUtilizada = quantidadeUtilizada;
            this.BaixarEstoqueAutomatico = baixarEstoqueAutomatico;
            this.ClasseProduto = classeProduto;
            this.Usuario = usuario;
            this.DataAtualizacao = dataAtualizacao;
            this.ProdutoRevisao = produtoRevisao;
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
        /// Gets or Sets NumeroRevisao
        /// </summary>
        [DataMember(Name="numeroRevisao", EmitDefaultValue=false)]
        public string NumeroRevisao { get; set; }

        /// <summary>
        /// Gets or Sets SequenciaComponente
        /// </summary>
        [DataMember(Name="sequenciaComponente", EmitDefaultValue=false)]
        public long? SequenciaComponente { get; set; }

        /// <summary>
        /// Gets or Sets CodigoEmpresaComponente
        /// </summary>
        [DataMember(Name="codigoEmpresaComponente", EmitDefaultValue=false)]
        public string CodigoEmpresaComponente { get; set; }

        /// <summary>
        /// Gets or Sets CodigoProdutoComponente
        /// </summary>
        [DataMember(Name="codigoProdutoComponente", EmitDefaultValue=false)]
        public string CodigoProdutoComponente { get; set; }

        /// <summary>
        /// Gets or Sets TipoUcComponente
        /// </summary>
        [DataMember(Name="tipoUcComponente", EmitDefaultValue=false)]
        public string TipoUcComponente { get; set; }

        /// <summary>
        /// Gets or Sets FatorTipoUcComponente
        /// </summary>
        [DataMember(Name="fatorTipoUcComponente", EmitDefaultValue=false)]
        public decimal? FatorTipoUcComponente { get; set; }

        /// <summary>
        /// Gets or Sets QuantidadeUtilizada
        /// </summary>
        [DataMember(Name="quantidadeUtilizada", EmitDefaultValue=false)]
        public decimal? QuantidadeUtilizada { get; set; }

        /// <summary>
        /// Gets or Sets BaixarEstoqueAutomatico
        /// </summary>
        [DataMember(Name="baixarEstoqueAutomatico", EmitDefaultValue=false)]
        public bool? BaixarEstoqueAutomatico { get; set; }

        /// <summary>
        /// Gets or Sets ClasseProduto
        /// </summary>
        [DataMember(Name="classeProduto", EmitDefaultValue=false)]
        public string ClasseProduto { get; set; }

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
        /// Gets or Sets ProdutoRevisao
        /// </summary>
        [DataMember(Name="produtoRevisao", EmitDefaultValue=false)]
        public ProdutoRevisaoDTO ProdutoRevisao { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProdutoRevisaoComponenteDTO {\n");
            sb.Append("  CodigoEmpresa: ").Append(CodigoEmpresa).Append("\n");
            sb.Append("  CodigoProduto: ").Append(CodigoProduto).Append("\n");
            sb.Append("  NumeroRevisao: ").Append(NumeroRevisao).Append("\n");
            sb.Append("  SequenciaComponente: ").Append(SequenciaComponente).Append("\n");
            sb.Append("  CodigoEmpresaComponente: ").Append(CodigoEmpresaComponente).Append("\n");
            sb.Append("  CodigoProdutoComponente: ").Append(CodigoProdutoComponente).Append("\n");
            sb.Append("  TipoUcComponente: ").Append(TipoUcComponente).Append("\n");
            sb.Append("  FatorTipoUcComponente: ").Append(FatorTipoUcComponente).Append("\n");
            sb.Append("  QuantidadeUtilizada: ").Append(QuantidadeUtilizada).Append("\n");
            sb.Append("  BaixarEstoqueAutomatico: ").Append(BaixarEstoqueAutomatico).Append("\n");
            sb.Append("  ClasseProduto: ").Append(ClasseProduto).Append("\n");
            sb.Append("  Usuario: ").Append(Usuario).Append("\n");
            sb.Append("  DataAtualizacao: ").Append(DataAtualizacao).Append("\n");
            sb.Append("  ProdutoRevisao: ").Append(ProdutoRevisao).Append("\n");
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
            return this.Equals(input as ProdutoRevisaoComponenteDTO);
        }

        /// <summary>
        /// Returns true if ProdutoRevisaoComponenteDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProdutoRevisaoComponenteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProdutoRevisaoComponenteDTO input)
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
                    this.NumeroRevisao == input.NumeroRevisao ||
                    (this.NumeroRevisao != null &&
                    this.NumeroRevisao.Equals(input.NumeroRevisao))
                ) && 
                (
                    this.SequenciaComponente == input.SequenciaComponente ||
                    (this.SequenciaComponente != null &&
                    this.SequenciaComponente.Equals(input.SequenciaComponente))
                ) && 
                (
                    this.CodigoEmpresaComponente == input.CodigoEmpresaComponente ||
                    (this.CodigoEmpresaComponente != null &&
                    this.CodigoEmpresaComponente.Equals(input.CodigoEmpresaComponente))
                ) && 
                (
                    this.CodigoProdutoComponente == input.CodigoProdutoComponente ||
                    (this.CodigoProdutoComponente != null &&
                    this.CodigoProdutoComponente.Equals(input.CodigoProdutoComponente))
                ) && 
                (
                    this.TipoUcComponente == input.TipoUcComponente ||
                    (this.TipoUcComponente != null &&
                    this.TipoUcComponente.Equals(input.TipoUcComponente))
                ) && 
                (
                    this.FatorTipoUcComponente == input.FatorTipoUcComponente ||
                    (this.FatorTipoUcComponente != null &&
                    this.FatorTipoUcComponente.Equals(input.FatorTipoUcComponente))
                ) && 
                (
                    this.QuantidadeUtilizada == input.QuantidadeUtilizada ||
                    (this.QuantidadeUtilizada != null &&
                    this.QuantidadeUtilizada.Equals(input.QuantidadeUtilizada))
                ) && 
                (
                    this.BaixarEstoqueAutomatico == input.BaixarEstoqueAutomatico ||
                    (this.BaixarEstoqueAutomatico != null &&
                    this.BaixarEstoqueAutomatico.Equals(input.BaixarEstoqueAutomatico))
                ) && 
                (
                    this.ClasseProduto == input.ClasseProduto ||
                    (this.ClasseProduto != null &&
                    this.ClasseProduto.Equals(input.ClasseProduto))
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
                    this.ProdutoRevisao == input.ProdutoRevisao ||
                    (this.ProdutoRevisao != null &&
                    this.ProdutoRevisao.Equals(input.ProdutoRevisao))
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
                if (this.NumeroRevisao != null)
                    hashCode = hashCode * 59 + this.NumeroRevisao.GetHashCode();
                if (this.SequenciaComponente != null)
                    hashCode = hashCode * 59 + this.SequenciaComponente.GetHashCode();
                if (this.CodigoEmpresaComponente != null)
                    hashCode = hashCode * 59 + this.CodigoEmpresaComponente.GetHashCode();
                if (this.CodigoProdutoComponente != null)
                    hashCode = hashCode * 59 + this.CodigoProdutoComponente.GetHashCode();
                if (this.TipoUcComponente != null)
                    hashCode = hashCode * 59 + this.TipoUcComponente.GetHashCode();
                if (this.FatorTipoUcComponente != null)
                    hashCode = hashCode * 59 + this.FatorTipoUcComponente.GetHashCode();
                if (this.QuantidadeUtilizada != null)
                    hashCode = hashCode * 59 + this.QuantidadeUtilizada.GetHashCode();
                if (this.BaixarEstoqueAutomatico != null)
                    hashCode = hashCode * 59 + this.BaixarEstoqueAutomatico.GetHashCode();
                if (this.ClasseProduto != null)
                    hashCode = hashCode * 59 + this.ClasseProduto.GetHashCode();
                if (this.Usuario != null)
                    hashCode = hashCode * 59 + this.Usuario.GetHashCode();
                if (this.DataAtualizacao != null)
                    hashCode = hashCode * 59 + this.DataAtualizacao.GetHashCode();
                if (this.ProdutoRevisao != null)
                    hashCode = hashCode * 59 + this.ProdutoRevisao.GetHashCode();
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
