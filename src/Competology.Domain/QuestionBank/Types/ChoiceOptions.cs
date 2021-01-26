// ---------------------------------------------------------------------------------------------------
//  <copyright file="ChoiceOptions.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Domain
{
    using System;

    /// <summary>
    /// Test choice text
    /// </summary>
    public class ChoiceOptions
    {
        /// <summary>
        /// Gets or sets the choice option identifier.
        /// </summary>
        /// <value>The option identifier.</value>
        public Guid ChoiceId { get; set; }
        /// <summary>
        /// Gets or sets the language for the display text.
        /// </summary>
        /// <value>The language.</value>
        public Language Language { get; set; }

        /// <summary>
        /// Gets or sets the choice text.
        /// </summary>
        /// <value>The choice text.</value>
        public string ChoiceText { get; set; }

        /// <summary>
        /// Gets or sets the flag to indicate that the option is correct.
        /// </summary>
        /// <value>The is correct option.</value>
        public string IsCorrectOption { get; set; }
    }
}