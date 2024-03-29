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
    /// Erc20Allowance
    /// </summary>
    [DataContract(Name = "erc20Allowance")]
    public partial class Erc20Allowance : IEquatable<Erc20Allowance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Erc20Allowance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Erc20Allowance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Erc20Allowance" /> class.
        /// </summary>
        /// <param name="allowance">The allowance (required).</param>
        public Erc20Allowance(string allowance = default(string))
        {
            // to ensure "allowance" is required (not null)
            if (allowance == null)
            {
                throw new ArgumentNullException("allowance is a required property for Erc20Allowance and cannot be null");
            }
            this.Allowance = allowance;
        }

        /// <summary>
        /// The allowance
        /// </summary>
        /// <value>The allowance</value>
        [DataMember(Name = "allowance", IsRequired = true, EmitDefaultValue = true)]
        public string Allowance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Erc20Allowance {\n");
            sb.Append("  Allowance: ").Append(Allowance).Append("\n");
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
            return this.Equals(input as Erc20Allowance);
        }

        /// <summary>
        /// Returns true if Erc20Allowance instances are equal
        /// </summary>
        /// <param name="input">Instance of Erc20Allowance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Erc20Allowance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allowance == input.Allowance ||
                    (this.Allowance != null &&
                    this.Allowance.Equals(input.Allowance))
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
                if (this.Allowance != null)
                {
                    hashCode = (hashCode * 59) + this.Allowance.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
