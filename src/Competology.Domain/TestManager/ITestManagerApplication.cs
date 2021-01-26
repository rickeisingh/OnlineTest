// ---------------------------------------------------------------------------------------------------
//  <copyright file="ITestManagerApplication.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Domain.TestManager
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contract for test manager application to be exposed to frontend.
    /// </summary>
    public interface ITestManagerApplication : ITestRepository
    {
        /// <summary>
        /// Initiates the test session.
        /// </summary>
        /// <param name="subscriberId">The subscriber identifier.</param>
        /// <param name="testTags">The test tags.</param>
        /// <returns>Test Session Guid.</returns>
        Test InitiateTestSession(Guid subscriberId, List<string> testTags);

        /// <summary>
        /// Begins the test.
        /// </summary>
        /// <param name="testId">The test identifier.</param>
        /// <returns>TestSession.</returns>
        void BeginTest(Guid testId);

        /// <summary>
        /// Pauses the test.
        /// </summary>
        /// <param name="testId">The test identifier.</param>
        /// <param name="response">The response.</param>
        void PauseTest(Guid testId, TestResponse response);

        /// <summary>
        /// Resumes the test.
        /// </summary>
        /// <param name="testId">The test identifier.</param>
        /// <returns>Test.</returns>
        Test ResumeTest(Guid testId);

        /// <summary>
        /// Pauses the test.
        /// </summary>
        /// <param name="testId">The test identifier.</param>
        /// <param name="response">The response.</param>
        void EndTest(Guid testId, TestResponse response);

        /// <summary>
        /// Reviews the test.
        /// </summary>
        /// <param name="testId">The test identifier.</param>
        /// <returns>TestSummary.</returns>
        TestSummary ReviewTest(Guid testId);
    }
}