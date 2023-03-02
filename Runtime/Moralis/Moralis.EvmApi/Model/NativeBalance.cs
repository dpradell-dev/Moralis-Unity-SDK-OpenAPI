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
    /// NativeBalance
    /// </summary>
    [DataContract(Name = "nativeBalance")]
    public partial class NativeBalance : IEquatable<NativeBalance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NativeBalance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NativeBalance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NativeBalance" /> class.
        /// </summary>
        /// <param name="balance">The balance (required).</param>
        public NativeBalance(string balance = default(string))
        {
            // to ensure "balance" is required (not null)
            if (balance == null)
            {
                throw new ArgumentNullException("balance is a required property for NativeBalance and cannot be null");
            }
            this.Balance = balance;
        }

        /// <summary>
        /// The balance
        /// </summary>
        /// <value>The balance</value>
        [DataMember(Name = "balance", IsRequired = true, EmitDefaultValue = true)]
        public string Balance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NativeBalance {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
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
            return this.Equals(input as NativeBalance);
        }

        /// <summary>
        /// Returns true if NativeBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of NativeBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NativeBalance input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
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
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
