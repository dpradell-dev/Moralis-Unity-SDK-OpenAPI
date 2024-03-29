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
    /// NativeBalancesInner
    /// </summary>
    [DataContract(Name = "nativeBalances_inner")]
    public partial class NativeBalancesInner : IEquatable<NativeBalancesInner>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NativeBalancesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NativeBalancesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NativeBalancesInner" /> class.
        /// </summary>
        /// <param name="chain">The chain (required).</param>
        /// <param name="chainId">The chain id (required).</param>
        /// <param name="totalBalance">The total balances for all the walttes (required).</param>
        /// <param name="blockNumber">The block Number (required).</param>
        /// <param name="blockTimestamp">The block timestamp (required).</param>
        /// <param name="totalBalanceFormatted">The total balances for all the walttes formatted (required).</param>
        /// <param name="walletBalances">walletBalances (required).</param>
        public NativeBalancesInner(string chain = default(string), string chainId = default(string), string totalBalance = default(string), string blockNumber = default(string), string blockTimestamp = default(string), string totalBalanceFormatted = default(string), List<NativeBalancesInnerWalletBalancesInner> walletBalances = default(List<NativeBalancesInnerWalletBalancesInner>))
        {
            // to ensure "chain" is required (not null)
            if (chain == null)
            {
                throw new ArgumentNullException("chain is a required property for NativeBalancesInner and cannot be null");
            }
            this.Chain = chain;
            // to ensure "chainId" is required (not null)
            if (chainId == null)
            {
                throw new ArgumentNullException("chainId is a required property for NativeBalancesInner and cannot be null");
            }
            this.ChainId = chainId;
            // to ensure "totalBalance" is required (not null)
            if (totalBalance == null)
            {
                throw new ArgumentNullException("totalBalance is a required property for NativeBalancesInner and cannot be null");
            }
            this.TotalBalance = totalBalance;
            // to ensure "blockNumber" is required (not null)
            if (blockNumber == null)
            {
                throw new ArgumentNullException("blockNumber is a required property for NativeBalancesInner and cannot be null");
            }
            this.BlockNumber = blockNumber;
            // to ensure "blockTimestamp" is required (not null)
            if (blockTimestamp == null)
            {
                throw new ArgumentNullException("blockTimestamp is a required property for NativeBalancesInner and cannot be null");
            }
            this.BlockTimestamp = blockTimestamp;
            // to ensure "totalBalanceFormatted" is required (not null)
            if (totalBalanceFormatted == null)
            {
                throw new ArgumentNullException("totalBalanceFormatted is a required property for NativeBalancesInner and cannot be null");
            }
            this.TotalBalanceFormatted = totalBalanceFormatted;
            // to ensure "walletBalances" is required (not null)
            if (walletBalances == null)
            {
                throw new ArgumentNullException("walletBalances is a required property for NativeBalancesInner and cannot be null");
            }
            this.WalletBalances = walletBalances;
        }

        /// <summary>
        /// The chain
        /// </summary>
        /// <value>The chain</value>
        [DataMember(Name = "chain", IsRequired = true, EmitDefaultValue = true)]
        public string Chain { get; set; }

        /// <summary>
        /// The chain id
        /// </summary>
        /// <value>The chain id</value>
        [DataMember(Name = "chain_id", IsRequired = true, EmitDefaultValue = true)]
        public string ChainId { get; set; }

        /// <summary>
        /// The total balances for all the walttes
        /// </summary>
        /// <value>The total balances for all the walttes</value>
        [DataMember(Name = "total_balance", IsRequired = true, EmitDefaultValue = true)]
        public string TotalBalance { get; set; }

        /// <summary>
        /// The block Number
        /// </summary>
        /// <value>The block Number</value>
        [DataMember(Name = "block_number", IsRequired = true, EmitDefaultValue = true)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// The block timestamp
        /// </summary>
        /// <value>The block timestamp</value>
        [DataMember(Name = "block_timestamp", IsRequired = true, EmitDefaultValue = true)]
        public string BlockTimestamp { get; set; }

        /// <summary>
        /// The total balances for all the walttes formatted
        /// </summary>
        /// <value>The total balances for all the walttes formatted</value>
        [DataMember(Name = "total_balance_formatted", IsRequired = true, EmitDefaultValue = true)]
        public string TotalBalanceFormatted { get; set; }

        /// <summary>
        /// Gets or Sets WalletBalances
        /// </summary>
        [DataMember(Name = "wallet_balances", IsRequired = true, EmitDefaultValue = true)]
        public List<NativeBalancesInnerWalletBalancesInner> WalletBalances { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NativeBalancesInner {\n");
            sb.Append("  Chain: ").Append(Chain).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  TotalBalance: ").Append(TotalBalance).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  BlockTimestamp: ").Append(BlockTimestamp).Append("\n");
            sb.Append("  TotalBalanceFormatted: ").Append(TotalBalanceFormatted).Append("\n");
            sb.Append("  WalletBalances: ").Append(WalletBalances).Append("\n");
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
            return this.Equals(input as NativeBalancesInner);
        }

        /// <summary>
        /// Returns true if NativeBalancesInner instances are equal
        /// </summary>
        /// <param name="input">Instance of NativeBalancesInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NativeBalancesInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Chain == input.Chain ||
                    (this.Chain != null &&
                    this.Chain.Equals(input.Chain))
                ) && 
                (
                    this.ChainId == input.ChainId ||
                    (this.ChainId != null &&
                    this.ChainId.Equals(input.ChainId))
                ) && 
                (
                    this.TotalBalance == input.TotalBalance ||
                    (this.TotalBalance != null &&
                    this.TotalBalance.Equals(input.TotalBalance))
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    (this.BlockNumber != null &&
                    this.BlockNumber.Equals(input.BlockNumber))
                ) && 
                (
                    this.BlockTimestamp == input.BlockTimestamp ||
                    (this.BlockTimestamp != null &&
                    this.BlockTimestamp.Equals(input.BlockTimestamp))
                ) && 
                (
                    this.TotalBalanceFormatted == input.TotalBalanceFormatted ||
                    (this.TotalBalanceFormatted != null &&
                    this.TotalBalanceFormatted.Equals(input.TotalBalanceFormatted))
                ) && 
                (
                    this.WalletBalances == input.WalletBalances ||
                    this.WalletBalances != null &&
                    input.WalletBalances != null &&
                    this.WalletBalances.SequenceEqual(input.WalletBalances)
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
                if (this.Chain != null)
                {
                    hashCode = (hashCode * 59) + this.Chain.GetHashCode();
                }
                if (this.ChainId != null)
                {
                    hashCode = (hashCode * 59) + this.ChainId.GetHashCode();
                }
                if (this.TotalBalance != null)
                {
                    hashCode = (hashCode * 59) + this.TotalBalance.GetHashCode();
                }
                if (this.BlockNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BlockNumber.GetHashCode();
                }
                if (this.BlockTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.BlockTimestamp.GetHashCode();
                }
                if (this.TotalBalanceFormatted != null)
                {
                    hashCode = (hashCode * 59) + this.TotalBalanceFormatted.GetHashCode();
                }
                if (this.WalletBalances != null)
                {
                    hashCode = (hashCode * 59) + this.WalletBalances.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
