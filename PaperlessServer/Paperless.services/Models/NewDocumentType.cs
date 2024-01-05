/*
 * Mock Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Paperless.services.Converters;

namespace Paperless.services.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class NewDocumentType
    {
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name = "match", EmitDefaultValue = true)]
        public string Match { get; set; }

        /// <summary>
        /// Gets or Sets MatchingAlgorithm
        /// </summary>
        [DataMember(Name = "matching_algorithm", EmitDefaultValue = true)]
        public long MatchingAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets IsInsensitive
        /// </summary>
        [DataMember(Name = "is_insensitive", EmitDefaultValue = true)]
        public bool IsInsensitive { get; set; }

    }
}
