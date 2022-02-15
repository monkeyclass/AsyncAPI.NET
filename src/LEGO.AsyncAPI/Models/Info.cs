﻿// Copyright (c) The LEGO Group. All rights reserved.

using LEGO.AsyncAPI.Any;
using LEGO.AsyncAPI.Models.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LEGO.AsyncAPI.Models
{
    /// <summary>
    /// The object provides metadata about the API. The metadata can be used by the clients if needed.
    /// </summary>
    public class Info : IExtensible
    {
        public Info(string title, string version)
        {
            Title = title;
            Version = version;
        }

        /// <summary>
        /// REQUIRED. The title of the application.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// REQUIRED. Provides the version of the application API (not to be confused with the specification version).
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// A short description of the application. CommonMark syntax can be used for rich text representation.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A URL to the Terms of Service for the API. MUST be in the format of a URL.
        /// </summary>
        [JsonProperty("termsOfService")]
        public Uri TermsOfService { get; set; }

        /// <summary>
        /// The contact information for the exposed API.
        /// </summary>
        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        /// <summary>
        /// The license information for the exposed API.
        /// </summary>
        [JsonProperty("license")]
        public List<License> License { get; set; }

        /// <inheritdoc/>
        public IDictionary<string, IAny> Extensions { get; set; }
    }
}