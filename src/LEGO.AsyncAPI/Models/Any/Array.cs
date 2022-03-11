﻿// Copyright (c) The LEGO Group. All rights reserved.

namespace LEGO.AsyncAPI.Models.Any
{
    /// <summary>
    /// Async API array.
    /// </summary>
    public class Array : List<IAny>, IAny
    {
        /// <summary>
        /// The type of <see cref="IAny"/>.
        /// </summary>
        public AnyType AnyType { get; } = AnyType.Array;

        /// <summary>
        /// Array object value.
        /// </summary>
        public List<IAny> Value { get; set; }
    }
}