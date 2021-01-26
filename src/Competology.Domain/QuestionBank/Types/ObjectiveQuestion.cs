// ---------------------------------------------------------------------------------------------------
//  <copyright file="ObjectiveQuestion.cs" company="Competology, Inc.">
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
    /// Container for Test Assets.
    /// </summary>
    public class ObjectiveQuestion
    {
        /// <summary>
        /// Gets or sets the test identifier.
        /// </summary>
        /// <value>The test identifier.</value>
        public Guid TestId { get; set; }

        /// <summary>
        /// Gets or sets the language for the display text.
        /// </summary>
        /// <value>The language.</value>
        public Language Language { get; set; }

        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        /// <value>The question text.</value>
        public string QuestionText { get; set; }

        /// <summary>
        /// Gets or sets the multiple choices responses for question.
        /// </summary>
        /// <value>The choices.</value>
        public List<Guid> ChoiceSet { get; set; }

        /// <summary>
        /// Gets or sets the search tags.
        /// </summary>
        /// <value>The search tags.</value>
        public List<string> SearchTags { get; set; }
    }
}