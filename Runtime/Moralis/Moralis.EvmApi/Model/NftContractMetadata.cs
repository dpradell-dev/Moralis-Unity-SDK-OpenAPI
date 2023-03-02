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
    /// NftContractMetadata
    /// </summary>
    [DataContract(Name = "nftContractMetadata")]
    public partial class NftContractMetadata : IEquatable<NftContractMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NftContractMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NftContractMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NftContractMetadata" /> class.
        /// </summary>
        /// <param name="tokenAddress">The address of the token contract (required).</param>
        /// <param name="name">The name of the token contract (required).</param>
        /// <param name="syncedAt">Timestamp of when the contract was last synced with the node.</param>
        /// <param name="symbol">The symbol of the NFT contract (required).</param>
        /// <param name="contractType">The type of NFT contract (required).</param>
        public NftContractMetadata(string tokenAddress = default(string), string name = default(string), string syncedAt = default(string), string symbol = default(string), string contractType = default(string))
        {
            // to ensure "tokenAddress" is required (not null)
            if (tokenAddress == null)
            {
                throw new ArgumentNullException("tokenAddress is a required property for NftContractMetadata and cannot be null");
            }
            this.TokenAddress = tokenAddress;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for NftContractMetadata and cannot be null");
            }
            this.Name = name;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for NftContractMetadata and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "contractType" is required (not null)
            if (contractType == null)
            {
                throw new ArgumentNullException("contractType is a required property for NftContractMetadata and cannot be null");
            }
            this.ContractType = contractType;
            this.SyncedAt = syncedAt;
        }

        /// <summary>
        /// The address of the token contract
        /// </summary>
        /// <value>The address of the token contract</value>
        [DataMember(Name = "token_address", IsRequired = true, EmitDefaultValue = true)]
        public string TokenAddress { get; set; }

        /// <summary>
        /// The name of the token contract
        /// </summary>
        /// <value>The name of the token contract</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Timestamp of when the contract was last synced with the node
        /// </summary>
        /// <value>Timestamp of when the contract was last synced with the node</value>
        [DataMember(Name = "synced_at", EmitDefaultValue = false)]
        public string SyncedAt { get; set; }

        /// <summary>
        /// The symbol of the NFT contract
        /// </summary>
        /// <value>The symbol of the NFT contract</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// The type of NFT contract
        /// </summary>
        /// <value>The type of NFT contract</value>
        [DataMember(Name = "contract_type", IsRequired = true, EmitDefaultValue = true)]
        public string ContractType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NftContractMetadata {\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SyncedAt: ").Append(SyncedAt).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
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
            return this.Equals(input as NftContractMetadata);
        }

        /// <summary>
        /// Returns true if NftContractMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of NftContractMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NftContractMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TokenAddress == input.TokenAddress ||
                    (this.TokenAddress != null &&
                    this.TokenAddress.Equals(input.TokenAddress))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SyncedAt == input.SyncedAt ||
                    (this.SyncedAt != null &&
                    this.SyncedAt.Equals(input.SyncedAt))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
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
                if (this.TokenAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAddress.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SyncedAt != null)
                {
                    hashCode = (hashCode * 59) + this.SyncedAt.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.ContractType != null)
                {
                    hashCode = (hashCode * 59) + this.ContractType.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
