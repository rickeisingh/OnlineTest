// ---------------------------------------------------------------------------------------------------
//  <copyright file="IQuestionBankApplication.cs" company="Competology, Inc.">
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
    /// Contract for test asset creation, update and deletions.
    /// </summary>
    public interface IQuestionBankApplication : IQuestionRepository, IQuestionSetRepository
    {
        /// <summary>
        /// Adds the question to question set.
        /// </summary>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <param name="questionId">The question identifier.</param>
        void AddQuestionsToQuestionSet(Guid questionSetId, List<Guid> questionId);
        /// <summary>
        /// Removes the questions from question set.
        /// </summary>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <param name="questionId">The question identifier.</param>
        void RemoveQuestionsFromQuestionSet(Guid questionSetId, List<Guid> questionId);
    }
}