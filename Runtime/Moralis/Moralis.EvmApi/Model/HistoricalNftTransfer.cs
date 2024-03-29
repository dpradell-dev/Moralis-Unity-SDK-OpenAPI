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
    /// HistoricalNftTransfer
    /// </summary>
    [DataContract(Name = "historicalNftTransfer")]
    public partial class HistoricalNftTransfer : IEquatable<HistoricalNftTransfer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalNftTransfer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HistoricalNftTransfer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalNftTransfer" /> class.
        /// </summary>
        /// <param name="transactionHash">The transaction hash (required).</param>
        /// <param name="address">The address of the token (required).</param>
        /// <param name="blockTimestamp">The block timestamp (required).</param>
        /// <param name="blockNumber">The block number (required).</param>
        /// <param name="blockHash">The block hash (required).</param>
        /// <param name="toAddress">The recipient (required).</param>
        /// <param name="fromAddress">The sender (required).</param>
        /// <param name="tokenIds">The token ids of the tokens that were transferred (required).</param>
        /// <param name="amounts">The amounts that were transferred (required).</param>
        /// <param name="contractType">They contract type of the transfer (required).</param>
        public HistoricalNftTransfer(string transactionHash = default(string), string address = default(string), string blockTimestamp = default(string), string blockNumber = default(string), string blockHash = default(string), string toAddress = default(string), string fromAddress = default(string), List<string> tokenIds = default(List<string>), List<string> amounts = default(List<string>), string contractType = default(string))
        {
            // to ensure "transactionHash" is required (not null)
            if (transactionHash == null)
            {
                throw new ArgumentNullException("transactionHash is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.TransactionHash = transactionHash;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.Address = address;
            // to ensure "blockTimestamp" is required (not null)
            if (blockTimestamp == null)
            {
                throw new ArgumentNullException("blockTimestamp is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.BlockTimestamp = blockTimestamp;
            // to ensure "blockNumber" is required (not null)
            if (blockNumber == null)
            {
                throw new ArgumentNullException("blockNumber is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.BlockNumber = blockNumber;
            // to ensure "blockHash" is required (not null)
            if (blockHash == null)
            {
                throw new ArgumentNullException("blockHash is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.BlockHash = blockHash;
            // to ensure "toAddress" is required (not null)
            if (toAddress == null)
            {
                throw new ArgumentNullException("toAddress is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.ToAddress = toAddress;
            // to ensure "fromAddress" is required (not null)
            if (fromAddress == null)
            {
                throw new ArgumentNullException("fromAddress is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.FromAddress = fromAddress;
            // to ensure "tokenIds" is required (not null)
            if (tokenIds == null)
            {
                throw new ArgumentNullException("tokenIds is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.TokenIds = tokenIds;
            // to ensure "amounts" is required (not null)
            if (amounts == null)
            {
                throw new ArgumentNullException("amounts is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.Amounts = amounts;
            // to ensure "contractType" is required (not null)
            if (contractType == null)
            {
                throw new ArgumentNullException("contractType is a required property for HistoricalNftTransfer and cannot be null");
            }
            this.ContractType = contractType;
        }

        /// <summary>
        /// The transaction hash
        /// </summary>
        /// <value>The transaction hash</value>
        [DataMember(Name = "transaction_hash", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionHash { get; set; }

        /// <summary>
        /// The address of the token
        /// </summary>
        /// <value>The address of the token</value>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The block timestamp
        /// </summary>
        /// <value>The block timestamp</value>
        [DataMember(Name = "block_timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string BlockTimestamp { get; set; }

        /// <summary>
        /// The block number
        /// </summary>
        /// <value>The block number</value>
        [DataMember(Name = "block_number", IsRequired = true, EmitDefaultValue = true)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// The block hash
        /// </summary>
        /// <value>The block hash</value>
        [DataMember(Name = "block_hash", IsRequired = true, EmitDefaultValue = true)]
        public string BlockHash { get; set; }

        /// <summary>
        /// The recipient
        /// </summary>
        /// <value>The recipient</value>
        [DataMember(Name = "to_address", IsRequired = true, EmitDefaultValue = true)]
        public string ToAddress { get; set; }

        /// <summary>
        /// The sender
        /// </summary>
        /// <value>The sender</value>
        [DataMember(Name = "from_address", IsRequired = true, EmitDefaultValue = true)]
        public string FromAddress { get; set; }

        /// <summary>
        /// The token ids of the tokens that were transferred
        /// </summary>
        /// <value>The token ids of the tokens that were transferred</value>
        [DataMember(Name = "token_ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> TokenIds { get; set; }

        /// <summary>
        /// The amounts that were transferred
        /// </summary>
        /// <value>The amounts that were transferred</value>
        [DataMember(Name = "amounts", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Amounts { get; set; }

        /// <summary>
        /// They contract type of the transfer
        /// </summary>
        /// <value>They contract type of the transfer</value>
        [DataMember(Name = "contract_type", IsRequired = true, EmitDefaultValue = true)]
        public string ContractType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HistoricalNftTransfer {\n");
            sb.Append("  TransactionHash: ").Append(TransactionHash).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BlockTimestamp: ").Append(BlockTimestamp).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  TokenIds: ").Append(TokenIds).Append("\n");
            sb.Append("  Amounts: ").Append(Amounts).Append("\n");
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
            return this.Equals(input as HistoricalNftTransfer);
        }

        /// <summary>
        /// Returns true if HistoricalNftTransfer instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricalNftTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricalNftTransfer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionHash == input.TransactionHash ||
                    (this.TransactionHash != null &&
                    this.TransactionHash.Equals(input.TransactionHash))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BlockTimestamp == input.BlockTimestamp ||
                    (this.BlockTimestamp != null &&
                    this.BlockTimestamp.Equals(input.BlockTimestamp))
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    (this.BlockNumber != null &&
                    this.BlockNumber.Equals(input.BlockNumber))
                ) && 
                (
                    this.BlockHash == input.BlockHash ||
                    (this.BlockHash != null &&
                    this.BlockHash.Equals(input.BlockHash))
                ) && 
                (
                    this.ToAddress == input.ToAddress ||
                    (this.ToAddress != null &&
                    this.ToAddress.Equals(input.ToAddress))
                ) && 
                (
                    this.FromAddress == input.FromAddress ||
                    (this.FromAddress != null &&
                    this.FromAddress.Equals(input.FromAddress))
                ) && 
                (
                    this.TokenIds == input.TokenIds ||
                    this.TokenIds != null &&
                    input.TokenIds != null &&
                    this.TokenIds.SequenceEqual(input.TokenIds)
                ) && 
                (
                    this.Amounts == input.Amounts ||
                    this.Amounts != null &&
                    input.Amounts != null &&
                    this.Amounts.SequenceEqual(input.Amounts)
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
                if (this.TransactionHash != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionHash.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.BlockTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.BlockTimestamp.GetHashCode();
                }
                if (this.BlockNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BlockNumber.GetHashCode();
                }
                if (this.BlockHash != null)
                {
                    hashCode = (hashCode * 59) + this.BlockHash.GetHashCode();
                }
                if (this.ToAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ToAddress.GetHashCode();
                }
                if (this.FromAddress != null)
                {
                    hashCode = (hashCode * 59) + this.FromAddress.GetHashCode();
                }
                if (this.TokenIds != null)
                {
                    hashCode = (hashCode * 59) + this.TokenIds.GetHashCode();
                }
                if (this.Amounts != null)
                {
                    hashCode = (hashCode * 59) + this.Amounts.GetHashCode();
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
