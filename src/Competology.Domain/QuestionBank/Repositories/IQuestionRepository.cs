// ---------------------------------------------------------------------------------------------------
//  <copyright file="IQuestionRepository.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------

namespace Competology.Domain
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contract for Create, update and delete operations on Test Question bank.
    /// </summary>
    public interface IQuestionRepository
    {
        /// <summary>
        /// Adds the questions in bulk to question bank.
        /// </summary>
        /// <param name="questions">The questions.</param>
        void AddQuestions(List<ObjectiveQuestion> questions);

        /// <summary>
        /// Deletes the questions by specified Ids.
        /// </summary>
        /// <param name="questions">The questions.</param>
        void DeleteQuestions(List<Guid> questions);

        /// <summary>
        /// Replaces the questions. - Update
        /// </summary>
        /// <param name="questionMap">The question map.</param>
        void ReplaceQuestions(Dictionary<Guid, ObjectiveQuestion> questionMap);

        /// <summary>
        /// Gets the questions.
        /// </summary>
        /// <param name="searchTags">The search tags.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="count">The count.</param>
        /// <returns>List&lt;ObjectiveQuestion&gt;.</returns>
        List<ObjectiveQuestion> GetQuestions(List<string> searchTags, int offset, int count);

        /// <summary>
        /// Determines whether [is valid question unique identifier] [the specified question identifier].
        /// </summary>
        /// <param name="questionId">The question identifier.</param>
        /// <returns><c>true</c> if [is valid question unique identifier] [the specified question identifier]; otherwise, <c>false</c>.</returns>
        bool IsValidQuestionGuid(Guid questionId);
    }
}