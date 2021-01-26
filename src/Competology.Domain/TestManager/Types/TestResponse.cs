// ---------------------------------------------------------------------------------------------------
//  <copyright file="TestResponse.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------

namespace Competology.Domain
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Test response details.
    /// </summary>
    public class TestResponse
    {
        /// <summary>
        /// Gets or sets the test identifier.
        /// </summary>
        /// <value>The test identifier.</value>
        public Guid TestId { get; set; }

        /// <summary>
        /// Gets or sets the submission map.
        /// </summary>
        /// <value>The submission map.</value>
        /// <remarks>
        /// Maps the question guid to submitted option Guid.
        /// </remarks>
        public Dictionary<Guid, Guid> SubmissionMap { get; set; }
    }
}