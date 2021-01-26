// ---------------------------------------------------------------------------------------------------
//  <copyright file="IOnlineTestManager.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------

namespace Competology.Domain
{
    /// <summary>
    /// Test session for tracking subscriber activity.
    /// </summary>
    public class TestSession
    {
        /// <summary>
        /// Gets or sets the test tracker.
        /// </summary>
        /// <value>The test tracker.</value>
        public TestTracker TestTracker { get; set; }

        /// <summary>
        /// Gets or sets the online test.
        /// </summary>
        /// <value>The online test.</value>
        public Test OnlineTest { get; set; }

        /// <summary>
        /// Gets or sets the summarizer.
        /// </summary>
        /// <value>The summarizer.</value>
        public TestSummarizer Summarizer { get; set; }
    }
}