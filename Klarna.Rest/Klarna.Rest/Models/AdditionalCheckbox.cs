﻿#region Copyright Header
//-----------------------------------------------------------------------
// <copyright file="AdditionalCheckbox.cs" company="Klarna AB">
//     Copyright 2014 Klarna AB
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------
#endregion
namespace Klarna.Rest.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Checkout options data model.
    /// </summary>
    public class AdditionalCheckbox
    {
        /// <summary>
        /// Gets or sets a value indicating whether the customer's date of birth is mandatory or not.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer should be able to supply a different shipping address or not.
        /// </summary>
        [JsonProperty("checked")]
        public bool? Checked { get; set; }
    }
}
