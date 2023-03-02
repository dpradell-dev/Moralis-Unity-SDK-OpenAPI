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
    /// NftMetadata
    /// </summary>
    [DataContract(Name = "nftMetadata")]
    public partial class NftMetadata : IEquatable<NftMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NftMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NftMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NftMetadata" /> class.
        /// </summary>
        /// <param name="lastTokenUriSync">When the token_uri was last updated (required).</param>
        /// <param name="lastMetadataSync">When the metadata was last updated (required).</param>
        public NftMetadata(string lastTokenUriSync = default(string), string lastMetadataSync = default(string))
        {
            // to ensure "lastTokenUriSync" is required (not null)
            if (lastTokenUriSync == null)
            {
                throw new ArgumentNullException("lastTokenUriSync is a required property for NftMetadata and cannot be null");
            }
            this.LastTokenUriSync = lastTokenUriSync;
            // to ensure "lastMetadataSync" is required (not null)
            if (lastMetadataSync == null)
            {
                throw new ArgumentNullException("lastMetadataSync is a required property for NftMetadata and cannot be null");
            }
            this.LastMetadataSync = lastMetadataSync;
        }

        /// <summary>
        /// The token ID of the NFT
        /// </summary>
        /// <value>The token ID of the NFT</value>
        [DataMember(Name = "token_id", IsRequired = true, EmitDefaultValue = true)]
        public string TokenId { get; private set; }

        /// <summary>
        /// Returns false as TokenId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTokenId()
        {
            return false;
        }
        /// <summary>
        /// The address of the NFT contract
        /// </summary>
        /// <value>The address of the NFT contract</value>
        [DataMember(Name = "token_address", IsRequired = true, EmitDefaultValue = true)]
        public string TokenAddress { get; private set; }

        /// <summary>
        /// Returns false as TokenAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTokenAddress()
        {
            return false;
        }
        /// <summary>
        /// The URI to the metadata of the token
        /// </summary>
        /// <value>The URI to the metadata of the token</value>
        [DataMember(Name = "token_uri", IsRequired = true, EmitDefaultValue = true)]
        public string TokenUri { get; private set; }

        /// <summary>
        /// Returns false as TokenUri should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTokenUri()
        {
            return false;
        }
        /// <summary>
        /// The metadata of the token
        /// </summary>
        /// <value>The metadata of the token</value>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public string Metadata { get; private set; }

        /// <summary>
        /// Returns false as Metadata should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetadata()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets IsValid
        /// </summary>
        [DataMember(Name = "is_valid", IsRequired = true, EmitDefaultValue = true)]
        public decimal IsValid { get; private set; }

        /// <summary>
        /// Returns false as IsValid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsValid()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Syncing
        /// </summary>
        [DataMember(Name = "syncing", IsRequired = true, EmitDefaultValue = true)]
        public decimal Syncing { get; private set; }

        /// <summary>
        /// Returns false as Syncing should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSyncing()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Frozen
        /// </summary>
        [DataMember(Name = "frozen", IsRequired = true, EmitDefaultValue = true)]
        public decimal Frozen { get; private set; }

        /// <summary>
        /// Returns false as Frozen should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFrozen()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Resyncing
        /// </summary>
        [DataMember(Name = "resyncing", IsRequired = true, EmitDefaultValue = true)]
        public decimal Resyncing { get; private set; }

        /// <summary>
        /// Returns false as Resyncing should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeResyncing()
        {
            return false;
        }
        /// <summary>
        /// The type of NFT contract standard
        /// </summary>
        /// <value>The type of NFT contract standard</value>
        [DataMember(Name = "contract_type", IsRequired = true, EmitDefaultValue = true)]
        public string ContractType { get; private set; }

        /// <summary>
        /// Returns false as ContractType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContractType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TokenHash
        /// </summary>
        [DataMember(Name = "token_hash", IsRequired = true, EmitDefaultValue = true)]
        public string TokenHash { get; private set; }

        /// <summary>
        /// Returns false as TokenHash should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTokenHash()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name = "batch_id", IsRequired = true, EmitDefaultValue = true)]
        public string BatchId { get; private set; }

        /// <summary>
        /// Returns false as BatchId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBatchId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets MetadataName
        /// </summary>
        [DataMember(Name = "metadata_name", IsRequired = true, EmitDefaultValue = true)]
        public string MetadataName { get; private set; }

        /// <summary>
        /// Returns false as MetadataName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetadataName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets MetadataDescription
        /// </summary>
        [DataMember(Name = "metadata_description", IsRequired = true, EmitDefaultValue = true)]
        public string MetadataDescription { get; private set; }

        /// <summary>
        /// Returns false as MetadataDescription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetadataDescription()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets MetadataAttributes
        /// </summary>
        [DataMember(Name = "metadata_attributes", IsRequired = true, EmitDefaultValue = true)]
        public string MetadataAttributes { get; private set; }

        /// <summary>
        /// Returns false as MetadataAttributes should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMetadataAttributes()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets BlockNumberMinted
        /// </summary>
        [DataMember(Name = "block_number_minted", IsRequired = true, EmitDefaultValue = true)]
        public string BlockNumberMinted { get; private set; }

        /// <summary>
        /// Returns false as BlockNumberMinted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBlockNumberMinted()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets OpenseaLookup
        /// </summary>
        [DataMember(Name = "opensea_lookup", EmitDefaultValue = false)]
        public Object OpenseaLookup { get; private set; }

        /// <summary>
        /// Returns false as OpenseaLookup should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOpenseaLookup()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets MinterAddress
        /// </summary>
        [DataMember(Name = "minter_address", IsRequired = true, EmitDefaultValue = true)]
        public string MinterAddress { get; private set; }

        /// <summary>
        /// Returns false as MinterAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMinterAddress()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets TransactionMinted
        /// </summary>
        [DataMember(Name = "transaction_minted", IsRequired = true, EmitDefaultValue = true)]
        public string TransactionMinted { get; private set; }

        /// <summary>
        /// Returns false as TransactionMinted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionMinted()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FrozenLogIndex
        /// </summary>
        [DataMember(Name = "frozen_log_index", EmitDefaultValue = false)]
        public Object FrozenLogIndex { get; private set; }

        /// <summary>
        /// Returns false as FrozenLogIndex should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFrozenLogIndex()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Imported
        /// </summary>
        [DataMember(Name = "imported", EmitDefaultValue = false)]
        public Object Imported { get; private set; }

        /// <summary>
        /// Returns false as Imported should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeImported()
        {
            return false;
        }
        /// <summary>
        /// When the token_uri was last updated
        /// </summary>
        /// <value>When the token_uri was last updated</value>
        [DataMember(Name = "last_token_uri_sync", IsRequired = true, EmitDefaultValue = true)]
        public string LastTokenUriSync { get; set; }

        /// <summary>
        /// When the metadata was last updated
        /// </summary>
        /// <value>When the metadata was last updated</value>
        [DataMember(Name = "last_metadata_sync", IsRequired = true, EmitDefaultValue = true)]
        public string LastMetadataSync { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NftMetadata {\n");
            sb.Append("  TokenId: ").Append(TokenId).Append("\n");
            sb.Append("  TokenAddress: ").Append(TokenAddress).Append("\n");
            sb.Append("  TokenUri: ").Append(TokenUri).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Syncing: ").Append(Syncing).Append("\n");
            sb.Append("  Frozen: ").Append(Frozen).Append("\n");
            sb.Append("  Resyncing: ").Append(Resyncing).Append("\n");
            sb.Append("  ContractType: ").Append(ContractType).Append("\n");
            sb.Append("  TokenHash: ").Append(TokenHash).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  MetadataName: ").Append(MetadataName).Append("\n");
            sb.Append("  MetadataDescription: ").Append(MetadataDescription).Append("\n");
            sb.Append("  MetadataAttributes: ").Append(MetadataAttributes).Append("\n");
            sb.Append("  BlockNumberMinted: ").Append(BlockNumberMinted).Append("\n");
            sb.Append("  OpenseaLookup: ").Append(OpenseaLookup).Append("\n");
            sb.Append("  MinterAddress: ").Append(MinterAddress).Append("\n");
            sb.Append("  TransactionMinted: ").Append(TransactionMinted).Append("\n");
            sb.Append("  FrozenLogIndex: ").Append(FrozenLogIndex).Append("\n");
            sb.Append("  Imported: ").Append(Imported).Append("\n");
            sb.Append("  LastTokenUriSync: ").Append(LastTokenUriSync).Append("\n");
            sb.Append("  LastMetadataSync: ").Append(LastMetadataSync).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as NftMetadata);
        }

        /// <summary>
        /// Returns true if NftMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of NftMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NftMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TokenId == input.TokenId ||
                    (this.TokenId != null &&
                    this.TokenId.Equals(input.TokenId))
                ) && 
                (
                    this.TokenAddress == input.TokenAddress ||
                    (this.TokenAddress != null &&
                    this.TokenAddress.Equals(input.TokenAddress))
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
                    this.IsValid == input.IsValid ||
                    this.IsValid.Equals(input.IsValid)
                ) && 
                (
                    this.Syncing == input.Syncing ||
                    this.Syncing.Equals(input.Syncing)
                ) && 
                (
                    this.Frozen == input.Frozen ||
                    this.Frozen.Equals(input.Frozen)
                ) && 
                (
                    this.Resyncing == input.Resyncing ||
                    this.Resyncing.Equals(input.Resyncing)
                ) && 
                (
                    this.ContractType == input.ContractType ||
                    (this.ContractType != null &&
                    this.ContractType.Equals(input.ContractType))
                ) && 
                (
                    this.TokenHash == input.TokenHash ||
                    (this.TokenHash != null &&
                    this.TokenHash.Equals(input.TokenHash))
                ) && 
                (
                    this.BatchId == input.BatchId ||
                    (this.BatchId != null &&
                    this.BatchId.Equals(input.BatchId))
                ) && 
                (
                    this.MetadataName == input.MetadataName ||
                    (this.MetadataName != null &&
                    this.MetadataName.Equals(input.MetadataName))
                ) && 
                (
                    this.MetadataDescription == input.MetadataDescription ||
                    (this.MetadataDescription != null &&
                    this.MetadataDescription.Equals(input.MetadataDescription))
                ) && 
                (
                    this.MetadataAttributes == input.MetadataAttributes ||
                    (this.MetadataAttributes != null &&
                    this.MetadataAttributes.Equals(input.MetadataAttributes))
                ) && 
                (
                    this.BlockNumberMinted == input.BlockNumberMinted ||
                    (this.BlockNumberMinted != null &&
                    this.BlockNumberMinted.Equals(input.BlockNumberMinted))
                ) && 
                (
                    this.OpenseaLookup == input.OpenseaLookup ||
                    (this.OpenseaLookup != null &&
                    this.OpenseaLookup.Equals(input.OpenseaLookup))
                ) && 
                (
                    this.MinterAddress == input.MinterAddress ||
                    (this.MinterAddress != null &&
                    this.MinterAddress.Equals(input.MinterAddress))
                ) && 
                (
                    this.TransactionMinted == input.TransactionMinted ||
                    (this.TransactionMinted != null &&
                    this.TransactionMinted.Equals(input.TransactionMinted))
                ) && 
                (
                    this.FrozenLogIndex == input.FrozenLogIndex ||
                    (this.FrozenLogIndex != null &&
                    this.FrozenLogIndex.Equals(input.FrozenLogIndex))
                ) && 
                (
                    this.Imported == input.Imported ||
                    (this.Imported != null &&
                    this.Imported.Equals(input.Imported))
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.TokenId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenId.GetHashCode();
                }
                if (this.TokenAddress != null)
                {
                    hashCode = (hashCode * 59) + this.TokenAddress.GetHashCode();
                }
                if (this.TokenUri != null)
                {
                    hashCode = (hashCode * 59) + this.TokenUri.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsValid.GetHashCode();
                hashCode = (hashCode * 59) + this.Syncing.GetHashCode();
                hashCode = (hashCode * 59) + this.Frozen.GetHashCode();
                hashCode = (hashCode * 59) + this.Resyncing.GetHashCode();
                if (this.ContractType != null)
                {
                    hashCode = (hashCode * 59) + this.ContractType.GetHashCode();
                }
                if (this.TokenHash != null)
                {
                    hashCode = (hashCode * 59) + this.TokenHash.GetHashCode();
                }
                if (this.BatchId != null)
                {
                    hashCode = (hashCode * 59) + this.BatchId.GetHashCode();
                }
                if (this.MetadataName != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataName.GetHashCode();
                }
                if (this.MetadataDescription != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataDescription.GetHashCode();
                }
                if (this.MetadataAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.MetadataAttributes.GetHashCode();
                }
                if (this.BlockNumberMinted != null)
                {
                    hashCode = (hashCode * 59) + this.BlockNumberMinted.GetHashCode();
                }
                if (this.OpenseaLookup != null)
                {
                    hashCode = (hashCode * 59) + this.OpenseaLookup.GetHashCode();
                }
                if (this.MinterAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MinterAddress.GetHashCode();
                }
                if (this.TransactionMinted != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionMinted.GetHashCode();
                }
                if (this.FrozenLogIndex != null)
                {
                    hashCode = (hashCode * 59) + this.FrozenLogIndex.GetHashCode();
                }
                if (this.Imported != null)
                {
                    hashCode = (hashCode * 59) + this.Imported.GetHashCode();
                }
                if (this.LastTokenUriSync != null)
                {
                    hashCode = (hashCode * 59) + this.LastTokenUriSync.GetHashCode();
                }
                if (this.LastMetadataSync != null)
                {
                    hashCode = (hashCode * 59) + this.LastMetadataSync.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
