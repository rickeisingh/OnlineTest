// ---------------------------------------------------------------------------------------------------
//  <copyright file="QuestionSet.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------

namespace Competology.Domain
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A set of questions from the question bank for specified criteria
    /// </summary>
    public class QuestionSet
    {
        /// <summary>
        /// Gets or sets the question set identifier.
        /// </summary>
        /// <value>The question set identifier.</value>
        public Guid QuestionSetId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the count of questions.
        /// </summary>
        /// <value>The count.</value>
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the questions.
        /// </summary>
        /// <value>The questions.</value>
        public List<ObjectiveQuestion> Questions { get; set; }

        /// <summary>
        /// Gets or sets the test explanations.
        /// </summary>
        /// <value>The test explanations.</value>
        public string SummaryAndExplanations { get; set; }

        /// <summary>
        /// Gets or sets the attachments.
        /// </summary>
        /// <value>The attachments.</value>
        public List<Guid> Attachments { get; set; }
    }
}