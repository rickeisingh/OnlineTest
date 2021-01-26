// ---------------------------------------------------------------------------------------------------
//  <copyright file="ITestRepository.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------


namespace Competology.Domain
{
    using System;

    /// <summary>
    /// Test Repository Contract is exposed to the test manager.
    /// </summary>
    public interface ITestRepository
    {
        /// <summary>
        /// Creates a new test.
        /// </summary>
        /// <param name="subscriberId">The subscriber identifier.</param>
        /// <param name="questionSet">The question set.</param>
        /// <param name="language">The language.</param>
        /// <returns>OnlineTest.</returns>
        Test CreateTest(Guid subscriberId, Guid questionSet, Language language = Language.None);

        /// <summary>
        /// Resumes the test by specified test Id.
        /// </summary>
        /// <param name="subscriberId">The subscriber identifier.</param>
        /// <param name="testGuid">The test unique identifier.</param>
        /// <returns>OnlineTest.</returns>
        Test ResumeTest(Guid subscriberId, Guid testGuid);

        /// <summary>
        /// Updates the test details.
        /// </summary>
        /// <param name="subscriberId">The subscriber identifier.</param>
        /// <param name="testGuid">The test unique identifier.</param>
        /// <param name="response">The response.</param>
        /// <returns>OnlineTest.</returns>
        Test UpdateTest(Guid subscriberId, Guid testGuid, TestResponse response);

        /// <summary>
        /// Deletes the test.
        /// </summary>
        /// <param name="subscriberId">The subscriber identifier.</param>
        /// <param name="testGuid">The test unique identifier.</param>
        /// <returns>OnlineTest.</returns>
        void DeleteTest(Guid subscriberId, Guid testGuid);


        /// <summary>
        /// Gets the test by identifier.
        /// </summary>
        /// <param name="testId">The test identifier.</param>
        Test GetTestById(Guid testId);
    }
}