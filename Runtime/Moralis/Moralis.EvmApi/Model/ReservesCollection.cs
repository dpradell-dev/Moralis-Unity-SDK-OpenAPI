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
    /// ReservesCollection
    /// </summary>
    [DataContract(Name = "reservesCollection")]
    public partial class ReservesCollection : IEquatable<ReservesCollection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReservesCollection" /> class.
        /// </summary>
        /// <param name="token0">token0.</param>
        /// <param name="token1">token1.</param>
        /// <param name="pairAddress">pairAddress.</param>
        public ReservesCollection(ReservesCollectionToken0 token0 = default(ReservesCollectionToken0), ReservesCollectionToken1 token1 = default(ReservesCollectionToken1), string pairAddress = default(string))
        {
            this.Token0 = token0;
            this.Token1 = token1;
            this.PairAddress = pairAddress;
        }

        /// <summary>
        /// Gets or Sets Token0
        /// </summary>
        [DataMember(Name = "token0", EmitDefaultValue = false)]
        public ReservesCollectionToken0 Token0 { get; set; }

        /// <summary>
        /// Gets or Sets Token1
        /// </summary>
        [DataMember(Name = "token1", EmitDefaultValue = false)]
        public ReservesCollectionToken1 Token1 { get; set; }

        /// <summary>
        /// Gets or Sets PairAddress
        /// </summary>
        [DataMember(Name = "pairAddress", EmitDefaultValue = false)]
        public string PairAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReservesCollection {\n");
            sb.Append("  Token0: ").Append(Token0).Append("\n");
            sb.Append("  Token1: ").Append(Token1).Append("\n");
            sb.Append("  PairAddress: ").Append(PairAddress).Append("\n");
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
            return this.Equals(input as ReservesCollection);
        }

        /// <summary>
        /// Returns true if ReservesCollection instances are equal
        /// </summary>
        /// <param name="input">Instance of ReservesCollection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReservesCollection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Token0 == input.Token0 ||
                    (this.Token0 != null &&
                    this.Token0.Equals(input.Token0))
                ) && 
                (
                    this.Token1 == input.Token1 ||
                    (this.Token1 != null &&
                    this.Token1.Equals(input.Token1))
                ) && 
                (
                    this.PairAddress == input.PairAddress ||
                    (this.PairAddress != null &&
                    this.PairAddress.Equals(input.PairAddress))
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
                if (this.Token0 != null)
                {
                    hashCode = (hashCode * 59) + this.Token0.GetHashCode();
                }
                if (this.Token1 != null)
                {
                    hashCode = (hashCode * 59) + this.Token1.GetHashCode();
                }
                if (this.PairAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PairAddress.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
