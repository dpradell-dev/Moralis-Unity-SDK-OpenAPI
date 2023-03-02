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
    /// Transaction
    /// </summary>
    [DataContract(Name = "transaction")]
    public partial class Transaction : IEquatable<Transaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Transaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class.
        /// </summary>
        /// <param name="hash">The hash of the transaction (required).</param>
        /// <param name="nonce">The nonce of the transaction (required).</param>
        /// <param name="transactionIndex">The transaction index (required).</param>
        /// <param name="fromAddress">The sender (required).</param>
        /// <param name="toAddress">The recipient (required).</param>
        /// <param name="value">The value that was transferred (in wei) (required).</param>
        /// <param name="gas">The gas of the transaction (required).</param>
        /// <param name="gasPrice">The gas price (required).</param>
        /// <param name="input">The input (required).</param>
        /// <param name="receiptCumulativeGasUsed">The receipt cumulative gas used (required).</param>
        /// <param name="receiptGasUsed">The receipt gas used (required).</param>
        /// <param name="receiptContractAddress">The receipt contract address (required).</param>
        /// <param name="receiptRoot">The receipt root (required).</param>
        /// <param name="receiptStatus">The receipt status (required).</param>
        /// <param name="blockTimestamp">The block timestamp (required).</param>
        /// <param name="blockNumber">The block number (required).</param>
        /// <param name="blockHash">The block hash (required).</param>
        public Transaction(string hash = default(string), string nonce = default(string), string transactionIndex = default(string), string fromAddress = default(string), string toAddress = default(string), string value = default(string), string gas = default(string), string gasPrice = default(string), string input = default(string), string receiptCumulativeGasUsed = default(string), string receiptGasUsed = default(string), string receiptContractAddress = default(string), string receiptRoot = default(string), string receiptStatus = default(string), string blockTimestamp = default(string), string blockNumber = default(string), string blockHash = default(string))
        {
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new ArgumentNullException("hash is a required property for Transaction and cannot be null");
            }
            this.Hash = hash;
            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new ArgumentNullException("nonce is a required property for Transaction and cannot be null");
            }
            this.Nonce = nonce;
            // to ensure "transactionIndex" is required (not null)
            if (transactionIndex == null)
            {
                throw new ArgumentNullException("transactionIndex is a required property for Transaction and cannot be null");
            }
            this.TransactionIndex = transactionIndex;
            // to ensure "fromAddress" is required (not null)
            if (fromAddress == null)
            {
                throw new ArgumentNullException("fromAddress is a required property for Transaction and cannot be null");
            }
            this.FromAddress = fromAddress;
            // to ensure "toAddress" is required (not null)
            if (toAddress == null)
            {
                throw new ArgumentNullException("toAddress is a required property for Transaction and cannot be null");
            }
            this.ToAddress = toAddress;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for Transaction and cannot be null");
            }
            this.Value = value;
            // to ensure "gas" is required (not null)
            if (gas == null)
            {
                throw new ArgumentNullException("gas is a required property for Transaction and cannot be null");
            }
            this.Gas = gas;
            // to ensure "gasPrice" is required (not null)
            if (gasPrice == null)
            {
                throw new ArgumentNullException("gasPrice is a required property for Transaction and cannot be null");
            }
            this.GasPrice = gasPrice;
            // to ensure "input" is required (not null)
            if (input == null)
            {
                throw new ArgumentNullException("input is a required property for Transaction and cannot be null");
            }
            this.Input = input;
            // to ensure "receiptCumulativeGasUsed" is required (not null)
            if (receiptCumulativeGasUsed == null)
            {
                throw new ArgumentNullException("receiptCumulativeGasUsed is a required property for Transaction and cannot be null");
            }
            this.ReceiptCumulativeGasUsed = receiptCumulativeGasUsed;
            // to ensure "receiptGasUsed" is required (not null)
            if (receiptGasUsed == null)
            {
                throw new ArgumentNullException("receiptGasUsed is a required property for Transaction and cannot be null");
            }
            this.ReceiptGasUsed = receiptGasUsed;
            // to ensure "receiptContractAddress" is required (not null)
            if (receiptContractAddress == null)
            {
                throw new ArgumentNullException("receiptContractAddress is a required property for Transaction and cannot be null");
            }
            this.ReceiptContractAddress = receiptContractAddress;
            // to ensure "receiptRoot" is required (not null)
            if (receiptRoot == null)
            {
                throw new ArgumentNullException("receiptRoot is a required property for Transaction and cannot be null");
            }
            this.ReceiptRoot = receiptRoot;
            // to ensure "receiptStatus" is required (not null)
            if (receiptStatus == null)
            {
                throw new ArgumentNullException("receiptStatus is a required property for Transaction and cannot be null");
            }
            this.ReceiptStatus = receiptStatus;
            // to ensure "blockTimestamp" is required (not null)
            if (blockTimestamp == null)
            {
                throw new ArgumentNullException("blockTimestamp is a required property for Transaction and cannot be null");
            }
            this.BlockTimestamp = blockTimestamp;
            // to ensure "blockNumber" is required (not null)
            if (blockNumber == null)
            {
                throw new ArgumentNullException("blockNumber is a required property for Transaction and cannot be null");
            }
            this.BlockNumber = blockNumber;
            // to ensure "blockHash" is required (not null)
            if (blockHash == null)
            {
                throw new ArgumentNullException("blockHash is a required property for Transaction and cannot be null");
            }
            this.BlockHash = blockHash;
        }

        /// <summary>
        /// The hash of the transaction
        /// </summary>
        /// <value>The hash of the transaction</value>
        [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = true)]
        public string Hash { get; set; }

        /// <summary>
        /// The nonce of the transaction
        /// </summary>
        /// <value>The nonce of the transaction</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public string Nonce { get; set; }

        /// <summary>
        /// The transaction index
        /// </summary>
        /// <value>The transaction index</value>
        [DataMember(Name = "transaction_index", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionIndex { get; set; }

        /// <summary>
        /// The sender
        /// </summary>
        /// <value>The sender</value>
        [DataMember(Name = "from_address", IsRequired = true, EmitDefaultValue = true)]
        public string FromAddress { get; set; }

        /// <summary>
        /// The recipient
        /// </summary>
        /// <value>The recipient</value>
        [DataMember(Name = "to_address", IsRequired = true, EmitDefaultValue = true)]
        public string ToAddress { get; set; }

        /// <summary>
        /// The value that was transferred (in wei)
        /// </summary>
        /// <value>The value that was transferred (in wei)</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// The gas of the transaction
        /// </summary>
        /// <value>The gas of the transaction</value>
        [DataMember(Name = "gas", IsRequired = true, EmitDefaultValue = true)]
        public string Gas { get; set; }

        /// <summary>
        /// The gas price
        /// </summary>
        /// <value>The gas price</value>
        [DataMember(Name = "gas_price", IsRequired = true, EmitDefaultValue = true)]
        public string GasPrice { get; set; }

        /// <summary>
        /// The input
        /// </summary>
        /// <value>The input</value>
        [DataMember(Name = "input", IsRequired = true, EmitDefaultValue = true)]
        public string Input { get; set; }

        /// <summary>
        /// The receipt cumulative gas used
        /// </summary>
        /// <value>The receipt cumulative gas used</value>
        [DataMember(Name = "receipt_cumulative_gas_used", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiptCumulativeGasUsed { get; set; }

        /// <summary>
        /// The receipt gas used
        /// </summary>
        /// <value>The receipt gas used</value>
        [DataMember(Name = "receipt_gas_used", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiptGasUsed { get; set; }

        /// <summary>
        /// The receipt contract address
        /// </summary>
        /// <value>The receipt contract address</value>
        [DataMember(Name = "receipt_contract_address", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiptContractAddress { get; set; }

        /// <summary>
        /// The receipt root
        /// </summary>
        /// <value>The receipt root</value>
        [DataMember(Name = "receipt_root", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiptRoot { get; set; }

        /// <summary>
        /// The receipt status
        /// </summary>
        /// <value>The receipt status</value>
        [DataMember(Name = "receipt_status", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiptStatus { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Transaction {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  TransactionIndex: ").Append(TransactionIndex).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Gas: ").Append(Gas).Append("\n");
            sb.Append("  GasPrice: ").Append(GasPrice).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  ReceiptCumulativeGasUsed: ").Append(ReceiptCumulativeGasUsed).Append("\n");
            sb.Append("  ReceiptGasUsed: ").Append(ReceiptGasUsed).Append("\n");
            sb.Append("  ReceiptContractAddress: ").Append(ReceiptContractAddress).Append("\n");
            sb.Append("  ReceiptRoot: ").Append(ReceiptRoot).Append("\n");
            sb.Append("  ReceiptStatus: ").Append(ReceiptStatus).Append("\n");
            sb.Append("  BlockTimestamp: ").Append(BlockTimestamp).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  BlockHash: ").Append(BlockHash).Append("\n");
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
            return this.Equals(input as Transaction);
        }

        /// <summary>
        /// Returns true if Transaction instances are equal
        /// </summary>
        /// <param name="input">Instance of Transaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Transaction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.TransactionIndex == input.TransactionIndex ||
                    (this.TransactionIndex != null &&
                    this.TransactionIndex.Equals(input.TransactionIndex))
                ) && 
                (
                    this.FromAddress == input.FromAddress ||
                    (this.FromAddress != null &&
                    this.FromAddress.Equals(input.FromAddress))
                ) && 
                (
                    this.ToAddress == input.ToAddress ||
                    (this.ToAddress != null &&
                    this.ToAddress.Equals(input.ToAddress))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Gas == input.Gas ||
                    (this.Gas != null &&
                    this.Gas.Equals(input.Gas))
                ) && 
                (
                    this.GasPrice == input.GasPrice ||
                    (this.GasPrice != null &&
                    this.GasPrice.Equals(input.GasPrice))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.ReceiptCumulativeGasUsed == input.ReceiptCumulativeGasUsed ||
                    (this.ReceiptCumulativeGasUsed != null &&
                    this.ReceiptCumulativeGasUsed.Equals(input.ReceiptCumulativeGasUsed))
                ) && 
                (
                    this.ReceiptGasUsed == input.ReceiptGasUsed ||
                    (this.ReceiptGasUsed != null &&
                    this.ReceiptGasUsed.Equals(input.ReceiptGasUsed))
                ) && 
                (
                    this.ReceiptContractAddress == input.ReceiptContractAddress ||
                    (this.ReceiptContractAddress != null &&
                    this.ReceiptContractAddress.Equals(input.ReceiptContractAddress))
                ) && 
                (
                    this.ReceiptRoot == input.ReceiptRoot ||
                    (this.ReceiptRoot != null &&
                    this.ReceiptRoot.Equals(input.ReceiptRoot))
                ) && 
                (
                    this.ReceiptStatus == input.ReceiptStatus ||
                    (this.ReceiptStatus != null &&
                    this.ReceiptStatus.Equals(input.ReceiptStatus))
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
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.TransactionIndex != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionIndex.GetHashCode();
                }
                if (this.FromAddress != null)
                {
                    hashCode = (hashCode * 59) + this.FromAddress.GetHashCode();
                }
                if (this.ToAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ToAddress.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Gas != null)
                {
                    hashCode = (hashCode * 59) + this.Gas.GetHashCode();
                }
                if (this.GasPrice != null)
                {
                    hashCode = (hashCode * 59) + this.GasPrice.GetHashCode();
                }
                if (this.Input != null)
                {
                    hashCode = (hashCode * 59) + this.Input.GetHashCode();
                }
                if (this.ReceiptCumulativeGasUsed != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptCumulativeGasUsed.GetHashCode();
                }
                if (this.ReceiptGasUsed != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptGasUsed.GetHashCode();
                }
                if (this.ReceiptContractAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptContractAddress.GetHashCode();
                }
                if (this.ReceiptRoot != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptRoot.GetHashCode();
                }
                if (this.ReceiptStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptStatus.GetHashCode();
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
                return hashCode;
            }
        }

    }

}
