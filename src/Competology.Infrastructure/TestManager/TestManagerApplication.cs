// ---------------------------------------------------------------------------------------------------
//  <copyright file="TestManagerApplication.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Infrastructure.TestManager
{
    using Competology.Domain.TestManager;
    using System;
    using System.Collections.Generic;
    using Competology.Domain;

    /// <summary>
    /// Concrete implementation for test manager application.
    /// Implements the <see cref="Competology.Domain.TestManager.ITestManagerApplication" />
    /// </summary>
    /// <seealso cref="Competology.Domain.TestManager.ITestManagerApplication" />
    public class TestManagerApplication : TestRepository, ITestManagerApplication
    {
        /// <inheritdoc />
        public Test InitiateTestSession(Guid subscriberId, List<string> testTags)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void BeginTest(Guid testId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void PauseTest(Guid testId, TestResponse response)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Test ResumeTest(Guid testId)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void EndTest(Guid testId, TestResponse response)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public TestSummary ReviewTest(Guid testId)
        {
            throw new NotImplementedException();
        }
    }
}