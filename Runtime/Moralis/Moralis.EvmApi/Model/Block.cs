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
    /// Block
    /// </summary>
    [DataContract(Name = "block")]
    public partial class Block : IEquatable<Block>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Block" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Block() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Block" /> class.
        /// </summary>
        /// <param name="timestamp">The block timestamp (required).</param>
        /// <param name="number">The block number (required).</param>
        /// <param name="hash">The block hash (required).</param>
        /// <param name="parentHash">The block hash of the parent block (required).</param>
        /// <param name="nonce">The nonce (required).</param>
        /// <param name="sha3Uncles">sha3Uncles (required).</param>
        /// <param name="logsBloom">logsBloom (required).</param>
        /// <param name="transactionsRoot">transactionsRoot (required).</param>
        /// <param name="stateRoot">stateRoot (required).</param>
        /// <param name="receiptsRoot">receiptsRoot (required).</param>
        /// <param name="miner">The address of the miner (required).</param>
        /// <param name="difficulty">The difficulty of the block (required).</param>
        /// <param name="totalDifficulty">The total difficulty (required).</param>
        /// <param name="size">The block size (required).</param>
        /// <param name="extraData">extraData (required).</param>
        /// <param name="gasLimit">The gas limit (required).</param>
        /// <param name="gasUsed">The gas used (required).</param>
        /// <param name="transactionCount">The number of transactions in the block (required).</param>
        /// <param name="transactions">The transactions in the block (required).</param>
        public Block(string timestamp = default(string), string number = default(string), string hash = default(string), string parentHash = default(string), string nonce = default(string), string sha3Uncles = default(string), string logsBloom = default(string), string transactionsRoot = default(string), string stateRoot = default(string), string receiptsRoot = default(string), string miner = default(string), string difficulty = default(string), string totalDifficulty = default(string), string size = default(string), string extraData = default(string), string gasLimit = default(string), string gasUsed = default(string), string transactionCount = default(string), List<BlockTransaction> transactions = default(List<BlockTransaction>))
        {
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new ArgumentNullException("timestamp is a required property for Block and cannot be null");
            }
            this.Timestamp = timestamp;
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for Block and cannot be null");
            }
            this.Number = number;
            // to ensure "hash" is required (not null)
            if (hash == null)
            {
                throw new ArgumentNullException("hash is a required property for Block and cannot be null");
            }
            this.Hash = hash;
            // to ensure "parentHash" is required (not null)
            if (parentHash == null)
            {
                throw new ArgumentNullException("parentHash is a required property for Block and cannot be null");
            }
            this.ParentHash = parentHash;
            // to ensure "nonce" is required (not null)
            if (nonce == null)
            {
                throw new ArgumentNullException("nonce is a required property for Block and cannot be null");
            }
            this.Nonce = nonce;
            // to ensure "sha3Uncles" is required (not null)
            if (sha3Uncles == null)
            {
                throw new ArgumentNullException("sha3Uncles is a required property for Block and cannot be null");
            }
            this.Sha3Uncles = sha3Uncles;
            // to ensure "logsBloom" is required (not null)
            if (logsBloom == null)
            {
                throw new ArgumentNullException("logsBloom is a required property for Block and cannot be null");
            }
            this.LogsBloom = logsBloom;
            // to ensure "transactionsRoot" is required (not null)
            if (transactionsRoot == null)
            {
                throw new ArgumentNullException("transactionsRoot is a required property for Block and cannot be null");
            }
            this.TransactionsRoot = transactionsRoot;
            // to ensure "stateRoot" is required (not null)
            if (stateRoot == null)
            {
                throw new ArgumentNullException("stateRoot is a required property for Block and cannot be null");
            }
            this.StateRoot = stateRoot;
            // to ensure "receiptsRoot" is required (not null)
            if (receiptsRoot == null)
            {
                throw new ArgumentNullException("receiptsRoot is a required property for Block and cannot be null");
            }
            this.ReceiptsRoot = receiptsRoot;
            // to ensure "miner" is required (not null)
            if (miner == null)
            {
                throw new ArgumentNullException("miner is a required property for Block and cannot be null");
            }
            this.Miner = miner;
            // to ensure "difficulty" is required (not null)
            if (difficulty == null)
            {
                throw new ArgumentNullException("difficulty is a required property for Block and cannot be null");
            }
            this.Difficulty = difficulty;
            // to ensure "totalDifficulty" is required (not null)
            if (totalDifficulty == null)
            {
                throw new ArgumentNullException("totalDifficulty is a required property for Block and cannot be null");
            }
            this.TotalDifficulty = totalDifficulty;
            // to ensure "size" is required (not null)
            if (size == null)
            {
                throw new ArgumentNullException("size is a required property for Block and cannot be null");
            }
            this.Size = size;
            // to ensure "extraData" is required (not null)
            if (extraData == null)
            {
                throw new ArgumentNullException("extraData is a required property for Block and cannot be null");
            }
            this.ExtraData = extraData;
            // to ensure "gasLimit" is required (not null)
            if (gasLimit == null)
            {
                throw new ArgumentNullException("gasLimit is a required property for Block and cannot be null");
            }
            this.GasLimit = gasLimit;
            // to ensure "gasUsed" is required (not null)
            if (gasUsed == null)
            {
                throw new ArgumentNullException("gasUsed is a required property for Block and cannot be null");
            }
            this.GasUsed = gasUsed;
            // to ensure "transactionCount" is required (not null)
            if (transactionCount == null)
            {
                throw new ArgumentNullException("transactionCount is a required property for Block and cannot be null");
            }
            this.TransactionCount = transactionCount;
            // to ensure "transactions" is required (not null)
            if (transactions == null)
            {
                throw new ArgumentNullException("transactions is a required property for Block and cannot be null");
            }
            this.Transactions = transactions;
        }

        /// <summary>
        /// The block timestamp
        /// </summary>
        /// <value>The block timestamp</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string Timestamp { get; set; }

        /// <summary>
        /// The block number
        /// </summary>
        /// <value>The block number</value>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// The block hash
        /// </summary>
        /// <value>The block hash</value>
        [DataMember(Name = "hash", IsRequired = true, EmitDefaultValue = true)]
        public string Hash { get; set; }

        /// <summary>
        /// The block hash of the parent block
        /// </summary>
        /// <value>The block hash of the parent block</value>
        [DataMember(Name = "parent_hash", IsRequired = true, EmitDefaultValue = true)]
        public string ParentHash { get; set; }

        /// <summary>
        /// The nonce
        /// </summary>
        /// <value>The nonce</value>
        [DataMember(Name = "nonce", IsRequired = true, EmitDefaultValue = true)]
        public string Nonce { get; set; }

        /// <summary>
        /// Gets or Sets Sha3Uncles
        /// </summary>
        [DataMember(Name = "sha3_uncles", IsRequired = true, EmitDefaultValue = true)]
        public string Sha3Uncles { get; set; }

        /// <summary>
        /// Gets or Sets LogsBloom
        /// </summary>
        [DataMember(Name = "logs_bloom", IsRequired = true, EmitDefaultValue = true)]
        public string LogsBloom { get; set; }

        /// <summary>
        /// Gets or Sets TransactionsRoot
        /// </summary>
        [DataMember(Name = "transactions_root", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionsRoot { get; set; }

        /// <summary>
        /// Gets or Sets StateRoot
        /// </summary>
        [DataMember(Name = "state_root", IsRequired = true, EmitDefaultValue = true)]
        public string StateRoot { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptsRoot
        /// </summary>
        [DataMember(Name = "receipts_root", IsRequired = true, EmitDefaultValue = true)]
        public string ReceiptsRoot { get; set; }

        /// <summary>
        /// The address of the miner
        /// </summary>
        /// <value>The address of the miner</value>
        [DataMember(Name = "miner", IsRequired = true, EmitDefaultValue = true)]
        public string Miner { get; set; }

        /// <summary>
        /// The difficulty of the block
        /// </summary>
        /// <value>The difficulty of the block</value>
        [DataMember(Name = "difficulty", IsRequired = true, EmitDefaultValue = true)]
        public string Difficulty { get; set; }

        /// <summary>
        /// The total difficulty
        /// </summary>
        /// <value>The total difficulty</value>
        [DataMember(Name = "total_difficulty", IsRequired = true, EmitDefaultValue = true)]
        public string TotalDifficulty { get; set; }

        /// <summary>
        /// The block size
        /// </summary>
        /// <value>The block size</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = true)]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets ExtraData
        /// </summary>
        [DataMember(Name = "extra_data", IsRequired = true, EmitDefaultValue = true)]
        public string ExtraData { get; set; }

        /// <summary>
        /// The gas limit
        /// </summary>
        /// <value>The gas limit</value>
        [DataMember(Name = "gas_limit", IsRequired = true, EmitDefaultValue = true)]
        public string GasLimit { get; set; }

        /// <summary>
        /// The gas used
        /// </summary>
        /// <value>The gas used</value>
        [DataMember(Name = "gas_used", IsRequired = true, EmitDefaultValue = true)]
        public string GasUsed { get; set; }

        /// <summary>
        /// The number of transactions in the block
        /// </summary>
        /// <value>The number of transactions in the block</value>
        [DataMember(Name = "transaction_count", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionCount { get; set; }

        /// <summary>
        /// The transactions in the block
        /// </summary>
        /// <value>The transactions in the block</value>
        [DataMember(Name = "transactions", IsRequired = true, EmitDefaultValue = true)]
        public List<BlockTransaction> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Block {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  ParentHash: ").Append(ParentHash).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  Sha3Uncles: ").Append(Sha3Uncles).Append("\n");
            sb.Append("  LogsBloom: ").Append(LogsBloom).Append("\n");
            sb.Append("  TransactionsRoot: ").Append(TransactionsRoot).Append("\n");
            sb.Append("  StateRoot: ").Append(StateRoot).Append("\n");
            sb.Append("  ReceiptsRoot: ").Append(ReceiptsRoot).Append("\n");
            sb.Append("  Miner: ").Append(Miner).Append("\n");
            sb.Append("  Difficulty: ").Append(Difficulty).Append("\n");
            sb.Append("  TotalDifficulty: ").Append(TotalDifficulty).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ExtraData: ").Append(ExtraData).Append("\n");
            sb.Append("  GasLimit: ").Append(GasLimit).Append("\n");
            sb.Append("  GasUsed: ").Append(GasUsed).Append("\n");
            sb.Append("  TransactionCount: ").Append(TransactionCount).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as Block);
        }

        /// <summary>
        /// Returns true if Block instances are equal
        /// </summary>
        /// <param name="input">Instance of Block to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Block input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.ParentHash == input.ParentHash ||
                    (this.ParentHash != null &&
                    this.ParentHash.Equals(input.ParentHash))
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.Sha3Uncles == input.Sha3Uncles ||
                    (this.Sha3Uncles != null &&
                    this.Sha3Uncles.Equals(input.Sha3Uncles))
                ) && 
                (
                    this.LogsBloom == input.LogsBloom ||
                    (this.LogsBloom != null &&
                    this.LogsBloom.Equals(input.LogsBloom))
                ) && 
                (
                    this.TransactionsRoot == input.TransactionsRoot ||
                    (this.TransactionsRoot != null &&
                    this.TransactionsRoot.Equals(input.TransactionsRoot))
                ) && 
                (
                    this.StateRoot == input.StateRoot ||
                    (this.StateRoot != null &&
                    this.StateRoot.Equals(input.StateRoot))
                ) && 
                (
                    this.ReceiptsRoot == input.ReceiptsRoot ||
                    (this.ReceiptsRoot != null &&
                    this.ReceiptsRoot.Equals(input.ReceiptsRoot))
                ) && 
                (
                    this.Miner == input.Miner ||
                    (this.Miner != null &&
                    this.Miner.Equals(input.Miner))
                ) && 
                (
                    this.Difficulty == input.Difficulty ||
                    (this.Difficulty != null &&
                    this.Difficulty.Equals(input.Difficulty))
                ) && 
                (
                    this.TotalDifficulty == input.TotalDifficulty ||
                    (this.TotalDifficulty != null &&
                    this.TotalDifficulty.Equals(input.TotalDifficulty))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ExtraData == input.ExtraData ||
                    (this.ExtraData != null &&
                    this.ExtraData.Equals(input.ExtraData))
                ) && 
                (
                    this.GasLimit == input.GasLimit ||
                    (this.GasLimit != null &&
                    this.GasLimit.Equals(input.GasLimit))
                ) && 
                (
                    this.GasUsed == input.GasUsed ||
                    (this.GasUsed != null &&
                    this.GasUsed.Equals(input.GasUsed))
                ) && 
                (
                    this.TransactionCount == input.TransactionCount ||
                    (this.TransactionCount != null &&
                    this.TransactionCount.Equals(input.TransactionCount))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.ParentHash != null)
                {
                    hashCode = (hashCode * 59) + this.ParentHash.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.Sha3Uncles != null)
                {
                    hashCode = (hashCode * 59) + this.Sha3Uncles.GetHashCode();
                }
                if (this.LogsBloom != null)
                {
                    hashCode = (hashCode * 59) + this.LogsBloom.GetHashCode();
                }
                if (this.TransactionsRoot != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionsRoot.GetHashCode();
                }
                if (this.StateRoot != null)
                {
                    hashCode = (hashCode * 59) + this.StateRoot.GetHashCode();
                }
                if (this.ReceiptsRoot != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptsRoot.GetHashCode();
                }
                if (this.Miner != null)
                {
                    hashCode = (hashCode * 59) + this.Miner.GetHashCode();
                }
                if (this.Difficulty != null)
                {
                    hashCode = (hashCode * 59) + this.Difficulty.GetHashCode();
                }
                if (this.TotalDifficulty != null)
                {
                    hashCode = (hashCode * 59) + this.TotalDifficulty.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.ExtraData != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraData.GetHashCode();
                }
                if (this.GasLimit != null)
                {
                    hashCode = (hashCode * 59) + this.GasLimit.GetHashCode();
                }
                if (this.GasUsed != null)
                {
                    hashCode = (hashCode * 59) + this.GasUsed.GetHashCode();
                }
                if (this.TransactionCount != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionCount.GetHashCode();
                }
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}