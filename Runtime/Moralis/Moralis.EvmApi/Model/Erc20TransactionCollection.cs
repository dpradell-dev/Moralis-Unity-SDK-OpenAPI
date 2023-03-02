/*
 * EVM API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using FileParameter = Moralis.EvmApi.Client.FileParameter;
using OpenAPIDateConverter = Moralis.EvmApi.Client.OpenAPIDateConverter;

namespace Moralis.EvmApi.Model
{
    /// <summary>
    /// Erc20TransactionCollection
    /// </summary>
    [DataContract(Name = "erc20TransactionCollection")]
    public partial class Erc20TransactionCollection : IEquatable<Erc20TransactionCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Erc20TransactionCollection" /> class.
        /// </summary>
        /// <param name="total">The total number of matches for this query.</param>
        /// <param name="page">The current page of the result.</param>
        /// <param name="pageSize">The number of results per page.</param>
        /// <param name="result">result.</param>
        public Erc20TransactionCollection(int total = default(int), int page = default(int), int pageSize = default(int), List<Erc20Transaction> result = default(List<Erc20Transaction>))
        {
            this.Total = total;
            this.Page = page;
            this.PageSize = pageSize;
            this.Result = result;
        }

        /// <summary>
        /// The total number of matches for this query
        /// </summary>
        /// <value>The total number of matches for this query</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// The current page of the result
        /// </summary>
        /// <value>The current page of the result</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// The number of results per page
        /// </summary>
        /// <value>The number of results per page</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public List<Erc20Transaction> Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Erc20TransactionCollection {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Erc20TransactionCollection);
        }

        /// <summary>
        /// Returns true if Erc20TransactionCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of Erc20TransactionCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Erc20TransactionCollection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Result == input.Result ||
                    this.Result != null &&
                    input.Result != null &&
                    this.Result.SequenceEqual(input.Result)
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
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
