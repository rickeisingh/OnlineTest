// ---------------------------------------------------------------------------------------------------
//  <copyright file="TestRepository.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Infrastructure.TestManager
{
    using System;
    using Competology.Domain;

    /// <summary>
    /// Concrete implementation for test repository.
    /// Implements the <see cref="Competology.Domain.ITestRepository" />
    /// </summary>
    /// <seealso cref="Competology.Domain.ITestRepository" />
    public class TestRepository : ITestRepository
    {
        /// <inheritdoc />
        public Test CreateTest(Guid subscriberId, Guid questionSet, Language language = Language.None)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Test ResumeTest(Guid subscriberId, Guid testGuid)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Test UpdateTest(Guid subscriberId, Guid testGuid, TestResponse response)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void DeleteTest(Guid subscriberId, Guid testGuid)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Test GetTestById(Guid testId)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}