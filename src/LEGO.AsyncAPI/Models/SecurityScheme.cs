﻿// Copyright (c) The LEGO Group. All rights reserved.

using LEGO.AsyncAPI.Any;
using LEGO.AsyncAPI.Models.Interfaces;
using Newtonsoft.Json.Linq;

namespace LEGO.AsyncAPI.Models
{
    /// <summary>
    /// Defines a security scheme that can be used by the operations.
    /// </summary>
    public class SecurityScheme : IExtensible, IReferenceable
    {
        /// <summary>
        /// REQUIRED. The type of the security scheme. Valid values are "apiKey", "http", "oauth2", "openIdConnect".
        /// </summary>
        public SecuritySchemeType Type { get; set; }

        /// <summary>
        /// A short description for security scheme. CommonMark syntax MAY be used for rich text representation.
        /// </summary>
        /// <remarks>
        /// Applies to type: Any.
        /// </remarks>
        public string Description { get; set; }

        /// <summary>
        /// REQUIRED. The name of the header, query or cookie parameter to be used.
        /// </summary>
        /// <remarks>
        /// Applies to type: <see cref="SecuritySchemeType.HttpApiKey"/>.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// REQUIRED. The name of the HTTP Authorization scheme to be used in the Authorization header as defined in RFC7235.
        /// </summary>
        /// <remarks>
        /// Applies to type: <see cref="SecuritySchemeType.Http"/>.
        /// </remarks>
        public string Scheme { get; set; }

        /// <summary>
        /// A hint to the client to identify how the bearer token is formatted.
        /// Bearer tokens are usually generated by an authorization server,
        /// so this information is primarily for documentation purposes.
        /// </summary>
        /// <remarks>
        /// Applies to type: <see cref="SecuritySchemeType.Http"/> ("bearer").
        /// </remarks>
        public string BearerFormat { get; set; }

        /// <summary>
        /// REQUIRED. An object containing configuration information for the flow types supported.
        /// </summary>
        /// <remarks>
        /// Applies to type: <see cref="SecuritySchemeType.Oauth2"/>.
        /// </remarks>
        public OAuthFlows Flows { get; set; }

        /// <summary>
        /// REQUIRED. OpenId Connect URL to discover OAuth2 configuration values.
        /// </summary>
        /// <remarks>
        /// Applies to type: <see cref="SecuritySchemeType.Oauth2"/>.
        /// </remarks>
        public Uri OpenIdConnectUrl { get; set; }

        /// <inheritdoc/>
        public IDictionary<string, IAny> Extensions { get; set; }

        /// <inheritdoc/>
        public bool? UnresolvedReference { get; set; }

        /// <inheritdoc/>
        public Reference Reference { get; set; }
    }
}