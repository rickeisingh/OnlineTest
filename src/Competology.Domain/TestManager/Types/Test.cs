// ---------------------------------------------------------------------------------------------------
//  <copyright file="Test.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------

namespace Competology.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Online Test entity.
    /// Container for all test assets and test behavior implementation.
    /// </summary>
    public class Test
    {
        /// <summary>
        /// Gets or sets the test identifier.
        /// </summary>
        /// <value>The test identifier.</value>
        public Guid TestId { get; set; }

        /// <summary>
        /// Gets or sets the question set.
        /// </summary>
        /// <value>The question set.</value>
        public QuestionSet QuestionSet { get; set; }

        /// <summary>
        /// Gets or sets the test response.
        /// </summary>
        /// <value>The test response.</value>
        public TestResponse TestResponse { get; set; }

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public TestConfiguration Configuration { get; set; }
    }
}