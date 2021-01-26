// ---------------------------------------------------------------------------------------------------
//  <copyright file="Language.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Domain
{
    /// <summary>
    /// Indicates that the language preference for the test session.
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// Indicates Language preference is English.
        /// </summary>
        English,

        /// <summary>
        /// Indicates language preference is Hindi.
        /// </summary>
        Hindi,

        /// <summary>
        /// Indicates that the english and hindi texts must be shown together.
        /// </summary>
        EnglishAndHindi,

        /// <summary>
        /// The Language agnostic;
        /// </summary>
        None
    }
}