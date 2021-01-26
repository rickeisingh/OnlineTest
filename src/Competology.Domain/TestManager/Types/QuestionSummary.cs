// ---------------------------------------------------------------------------------------------------
//  <copyright file="QuestionSummary.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Domain
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Question summary for reviewing usecase post test.
    /// </summary>
    public class QuestionSummary
    {
        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        /// <value>The question text.</value>
        public string QuestionText { get; set; }

        /// <summary>
        /// Gets or sets the multiple choices responses for question.
        /// </summary>
        /// <value>The choices.</value>
        public List<ChoiceOptions> ChoiceSet { get; set; }

        /// <summary>
        /// Gets or sets the user choice identifier.
        /// </summary>
        /// <value>The user choice identifier.</value>
        public Guid UserChoiceId { get; set; }
    }
}