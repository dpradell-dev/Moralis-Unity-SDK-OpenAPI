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
    /// NormalizedMetadata
    /// </summary>
    [DataContract(Name = "normalizedMetadata")]
    public partial class NormalizedMetadata : IEquatable<NormalizedMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NormalizedMetadata" /> class.
        /// </summary>
        /// <param name="name">The name or title of the NFT.</param>
        /// <param name="description">A detailed description of the NFT.</param>
        /// <param name="image">The URL of the NFT&#39;s image.</param>
        /// <param name="externalLink">A link to additional information.</param>
        /// <param name="animationUrl">An animated version of the NFT&#39;s image.</param>
        /// <param name="attributes">attributes.</param>
        public NormalizedMetadata(string name = default(string), string description = default(string), string image = default(string), string externalLink = default(string), string animationUrl = default(string), List<NormalizedMetadataAttribute> attributes = default(List<NormalizedMetadataAttribute>))
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.ExternalLink = externalLink;
            this.AnimationUrl = animationUrl;
            this.Attributes = attributes;
        }

        /// <summary>
        /// The name or title of the NFT
        /// </summary>
        /// <value>The name or title of the NFT</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A detailed description of the NFT
        /// </summary>
        /// <value>A detailed description of the NFT</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The URL of the NFT&#39;s image
        /// </summary>
        /// <value>The URL of the NFT&#39;s image</value>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// A link to additional information
        /// </summary>
        /// <value>A link to additional information</value>
        [DataMember(Name = "external_link", EmitDefaultValue = false)]
        public string ExternalLink { get; set; }

        /// <summary>
        /// An animated version of the NFT&#39;s image
        /// </summary>
        /// <value>An animated version of the NFT&#39;s image</value>
        [DataMember(Name = "animation_url", EmitDefaultValue = false)]
        public string AnimationUrl { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public List<NormalizedMetadataAttribute> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NormalizedMetadata {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  ExternalLink: ").Append(ExternalLink).Append("\n");
            sb.Append("  AnimationUrl: ").Append(AnimationUrl).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as NormalizedMetadata);
        }

        /// <summary>
        /// Returns true if NormalizedMetadata instances are equal
        /// </summary>
        /// <param name="input">Instance of NormalizedMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NormalizedMetadata input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.ExternalLink == input.ExternalLink ||
                    (this.ExternalLink != null &&
                    this.ExternalLink.Equals(input.ExternalLink))
                ) && 
                (
                    this.AnimationUrl == input.AnimationUrl ||
                    (this.AnimationUrl != null &&
                    this.AnimationUrl.Equals(input.AnimationUrl))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.ExternalLink != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalLink.GetHashCode();
                }
                if (this.AnimationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AnimationUrl.GetHashCode();
                }
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}