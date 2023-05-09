// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// 
// THIS FILE IS AUTOGENERATED, DO NOT MODIFY IT

using System.Runtime.Serialization;

namespace LSProtocol {
    /// <summary>
    /// A set of predefined position encoding kinds.
    /// 
    /// @since 3.17.0
    /// </summary>
    public enum PositionEncodingKind 
    {
        /// <summary>
        /// Character offsets count UTF-8 code units.
        /// </summary>
        [EnumMember(Value = "utf-8")]Utf8,

        /// <summary>
        /// Character offsets count UTF-16 code units.
        /// 
        /// This is the default and must always be supported
        /// by servers
        /// </summary>
        [EnumMember(Value = "utf-16")]Utf16,

        /// <summary>
        /// Character offsets count UTF-32 code units.
        /// 
        /// Implementation note: these are the same as Unicode code points,
        /// so this `PositionEncodingKind` may also be used for an
        /// encoding-agnostic representation of character offsets.
        /// </summary>
        [EnumMember(Value = "utf-32")]Utf32,

    }
}