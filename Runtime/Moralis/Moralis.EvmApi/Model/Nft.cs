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
    /// Nft
    /// </summary>
    [DataContract(Name = "nft")]
    public partial class Nft : IEquatable<Nft>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Nft" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Nft() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Nft" /> class.
        /// </summary>
        /// <param name="tokenAddress">The address of the NFT contract (required).</param>
        /// <param name="tokenId">The token ID of the NFT (required).</param>
        /// <param name="ownerOf">The wallet address of the owner of the NFT.</param>
        /// <param name="tokenHash">The token hash.</param>
        /// <param name="blockNumber">The block number when the amount or owner changed.</param>
        /// <param name="blockNumberMinted">The block number when the NFT was minted.</param>
        /// <param name="contractType">The type of NFT contract standard (required).</param>
        /// <param name="tokenUri">The URI to the metadata of the token.</param>
        /// <param name="metadata">The metadata of the token.</param>
        /// <param name="normalizedMetadata">normalizedMetadata.</param>
        /// <param name="minterAddress">The address that minted the NFT.</param>
        /// <param name="lastTokenUriSync">When the token_uri was last updated.</param>
        /// <param name="lastMetadataSync">When the metadata was last updated.</param>
        /// <param name="amount">The quantity of this item that the user owns (used by ERC1155).</param>
        /// <param name="name">The name of the NFT contract (required).</param>
        /// <param name="symbol">The symbol of the NFT contract (required).</param>
        public Nft(string tokenAddress = default(string), string tokenId = default(string), string ownerOf = default(string), string tokenHash = default(string), string blockNumber = default(string), string blockNumberMinted = default(string), string contractType = default(string), string tokenUri = default(string), string metadata = default(string), NormalizedMetadata normalizedMetadata = default(NormalizedMetadata), string minterAddress = default(string), string lastTokenUriSync = default(string), string lastMetadataSync = default(string), string amount = default(string), string name = default(string), string symbol = default(string))
        {
            // to ensure "tokenAddress" is required (not null)
            if (tokenAddress == null)
            {
                throw new ArgumentNullException("tokenAddress is a required property for Nft and cannot be null");
            }
            this.TokenAddress = tokenAddress;
            // to ensure "tokenId" is required (not null)
            if (tokenId == null)
            {
                throw new ArgumentNullException("tokenId is a required property for Nft and cannot be null");
            }
            this.TokenId = tokenId;
            // to ensure "contractType" is required (not null)
            if (contractType == null)
            {
                throw new ArgumentNullException("contractType is a required property for Nft and cannot be null");
            }
            this.ContractType = contractType;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Nft and cannot be null");
            }
            this.Name = name;
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for Nft and cannot be null");
            }
            this.Symbol = symbol;
            this.OwnerOf = ownerOf;
            this.TokenHash = tokenHash;
            this.BlockNumber = blockNumber;
            this.BlockNumberMinted = blockNumberMinted;
            this.TokenUri = tokenUri;
            this.Metadata = metadata;
            this.NormalizedMetadata = normalizedMetadata;
            this.MinterAddress = minterAddress;
            this.LastTokenUriSync = lastTokenUriSync;
            this.LastMetadataSync = lastMetadataSync;
            this.Amount = amount;
        }

        /// <summary>
        /// The address of the NFT contract
        /// </summary>
        /// <value>The address of the NFT contract</value>
        [DataMember(Name = "token_address", IsRequired = true, EmitDefaultValue = true)]
        public string TokenAddress { get; set; }

        /// <summary>
        /// The token ID of the NFT
        /// </summary>
        /// <value>The token ID of the NFT</value>
        [DataMember(Name = "token_id", IsRequired = true, EmitDefaultValue = true)]
        public string TokenId { get; set; }

        /// <summary>
        /// The wallet address of the owner of the NFT
        /// </summary>
        /// <value>The wallet address of the owner of the NFT</value>
        [DataMember(Name = "owner_of", EmitDefaultValue = false)]
        public string OwnerOf { get; set; }

        /// <summary>
        /// The token hash
        /// </summary>
        /// <value>The token hash</value>
        [DataMember(Name = "token_hash", EmitDefaultValue = false)]
        public string TokenHash { get; set; }

        /// <summary>
        /// The block number when the amount or owner changed
        /// </summary>
        /// <value>The block number when the amount or owner changed</value>
        [DataMember(Name = "block_number", EmitDefaultValue = false)]
        public string BlockNumber { get; set; }

        /// <summary>
        /// The block number when the NFT was minted
        /// </summary>
        /// <value>The block number when the NFT was minted</value>
        [DataMember(Name = "block_number_minted", EmitDefaultValue = false)]
        public string BlockNumberMinted { get; set; }

        /// <summary>
        /// The type of NFT contract standard
        /// </summary>
        /// <value>The type of NFT contract standard</value>
        [DataMember(Name = "contract_type", IsRequired = true, EmitDefaultValue = true)]
        public string ContractType { get; set; }

        /// <summary>
        /// The URI to the metadata of the token
        /// </summary>
        /// <value>The URI to the metadata of the token</value>
        [DataMember(Name = "token_uri", EmitDefaultValue = false)]
        public string TokenUri { get; set; }

        /// <summary>
        /// The metadata of the token
        /// </summary>
        /// <value>The metadata of the token</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets NormalizedMetadata
        /// </summary>
        [DataMember(Name = "normalized_metadata", EmitDefaultValue = false)]
        public NormalizedMetadata NormalizedMetadata { get; set; }

        /// <summary>
        /// The address that minted the NFT
        /// </summary>
        /// <value>The address that minted the NFT</value>
        [DataMember(Name = "minter_address", EmitDefaultValue = false)]
        public string MinterAddress { get; set; }

        /// <summary>
        /// When the token_uri was last updated
        /// </summary>
        /// <value>When the token_uri was last updated</value>
        [DataMember(Name = "last_token_uri_sync", EmitDefaultValue = false)]
        public string LastTokenUriSync { get; set; }

        /// <summary>
        /// When the metadata was last updated
        /// </summary>
        /// <value>When the metadata was last updated</value>
        [DataMember(Name = "last_metadata_sync", EmitDefaultValue = false)]
        public string LastMetadataSync { get; set; }

        /// <summary>
        /// The quantity of this item that the user owns (used by ERC1155)
        /// </summary>
        /// <value>The quantity of this item that the user owns (used by ERC1155)</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// The name of the NFT contract
        /// </summary>
        /// <value>The name of the NFT contract</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The symbol of the NFT contract
        /// </summary>
        /// <value>The symbol of the NFT contract</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Nft {\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  OwnerOf: ").Append(OwnerOf).Append("\n");
            sb.Append("  TokenHash: ").Append(TokenHash).Append("\n");
            sb.Append("  BlockNumber: ").Append(BlockNumber).Append("\n");
            sb.Append("  BlockNumberMinted: ").Append(BlockNumberMinted).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  TokenUri: ").Append(TokenUri).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  NormalizedMetadata: ").Append(NormalizedMetadata).Append("\n");
            sb.Append("  MinterAddress: ").Append(MinterAddress).Append("\n");
            sb.Append("  LastTokenUriSync: ").Append(LastTokenUriSync).Append("\n");
            sb.Append("  LastMetadataSync: ").Append(LastMetadataSync).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            return this.Equals(input as Nft);
        }

        /// <summary>
        /// Returns true if Nft instances are equal
        /// </summary>
        /// <param name="input">Instance of Nft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Nft input)
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
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.OwnerOf == input.OwnerOf ||
                    (this.OwnerOf != null &&
                    this.OwnerOf.Equals(input.OwnerOf))
                ) && 
                (
                    this.TokenHash == input.TokenHash ||
                    (this.TokenHash != null &&
                    this.TokenHash.Equals(input.TokenHash))
                ) && 
                (
                    this.BlockNumber == input.BlockNumber ||
                    (this.BlockNumber != null &&
                    this.BlockNumber.Equals(input.BlockNumber))
                ) && 
                (
                    this.BlockNumberMinted == input.BlockNumberMinted ||
                    (this.BlockNumberMinted != null &&
                    this.BlockNumberMinted.Equals(input.BlockNumberMinted))
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) && 
                (
                    this.TokenUri == input.TokenUri ||
                    (this.TokenUri != null &&
                    this.TokenUri.Equals(input.TokenUri))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.NormalizedMetadata == input.NormalizedMetadata ||
                    (this.NormalizedMetadata != null &&
                    this.NormalizedMetadata.Equals(input.NormalizedMetadata))
                ) && 
                (
                    this.MinterAddress == input.MinterAddress ||
                    (this.MinterAddress != null &&
                    this.MinterAddress.Equals(input.MinterAddress))
                ) && 
                (
                    this.LastTokenUriSync == input.LastTokenUriSync ||
                    (this.LastTokenUriSync != null &&
                    this.LastTokenUriSync.Equals(input.LastTokenUriSync))
                ) && 
                (
                    this.LastMetadataSync == input.LastMetadataSync ||
                    (this.LastMetadataSync != null &&
                    this.LastMetadataSync.Equals(input.LastMetadataSync))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
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
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.OwnerOf != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerOf.GetHashCode();
                }
                if (this.TokenHash != null)
                {
                    hashCode = (hashCode * 59) + this.TokenHash.GetHashCode();
                }
                if (this.BlockNumber != null)
                {
                    hashCode = (hashCode * 59) + this.BlockNumber.GetHashCode();
                }
                if (this.BlockNumberMinted != null)
                {
                    hashCode = (hashCode * 59) + this.BlockNumberMinted.GetHashCode();
                }
                if (this.ContractType != null)
                {
                    hashCode = (hashCode * 59) + this.ContractType.GetHashCode();
                }
                if (this.TokenUri != null)
                {
                    hashCode = (hashCode * 59) + this.TokenUri.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.NormalizedMetadata != null)
                {
                    hashCode = (hashCode * 59) + this.NormalizedMetadata.GetHashCode();
                }
                if (this.MinterAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MinterAddress.GetHashCode();
                }
                if (this.LastTokenUriSync != null)
                {
                    hashCode = (hashCode * 59) + this.LastTokenUriSync.GetHashCode();
                }
                if (this.LastMetadataSync != null)
                {
                    hashCode = (hashCode * 59) + this.LastMetadataSync.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
