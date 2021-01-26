// ---------------------------------------------------------------------------------------------------
//  <copyright file="TestSummary.cs" company="Competology, Inc.">
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
    /// Class TestSummary.
    /// </summary>
    public class TestSummary
    {
        /// <summary>
        /// Gets or sets the question set.
        /// </summary>
        /// <value>The question set.</value>
        public List<QuestionSummary> Questions { get; set; }

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