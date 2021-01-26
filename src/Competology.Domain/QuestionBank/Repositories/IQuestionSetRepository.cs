// ---------------------------------------------------------------------------------------------------
//  <copyright file="IQuestionSetRepository.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------

namespace Competology.Domain
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Question set repository contract.
    /// </summary>
    public interface IQuestionSetRepository
    {
        /// <summary>
        /// Fetches the question set.
        /// </summary>
        /// <param name="questionSearchTags">The question search tags.</param>
        /// <param name="questionCount">The question count.</param>
        /// <param name="language">The language.</param>
        /// <returns>QuestionSet.</returns>
        QuestionSet FetchAutoQuestionSet(List<string> questionSearchTags, int questionCount, Language language);

        /// <summary>
        /// Fetches the question set by identifier.
        /// </summary>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <param name="language">The language.</param>
        /// <returns>QuestionSet.</returns>
        QuestionSet FetchQuestionSetById(Guid questionSetId, Language language);

        /// <summary>
        /// Creates the question set.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="language">The language.</param>
        /// <returns>Guid.</returns>
        Guid CreateQuestionSet(string name, Language language);

        /// <summary>
        /// Updates the question set.
        /// </summary>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <param name="questions">The questions.</param>
        /// <param name="language">The language.</param>
        /// <remarks>
        /// Language is only updated if specified other than Language.None.
        /// </remarks>
        void UpdateQuestionSet(Guid questionSetId, List<Guid> questions, Language language = Language.None);
        
        /// <summary>
        /// Deletes the question set.
        /// </summary>
        /// <param name="questionSetIds">The question set ids.</param>
        void DeleteQuestionSet(List<Guid> questionSetIds);

        /// <summary>
        /// Gets the question sets.
        /// </summary>
        /// <param name="questionSetSearchTags">The question set search tags.</param>
        /// <returns>List&lt;QuestionSet&gt;.</returns>
        List<QuestionSet> GetQuestionSets(List<string> questionSetSearchTags);

        /// <summary>
        /// Determines whether [is valid question set unique identifier] [the specified question set identifier].
        /// </summary>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <returns><c>true</c> if [is valid question set unique identifier] [the specified question set identifier]; otherwise, <c>false</c>.</returns>
        bool IsValidQuestionSetGuid(Guid questionSetId);
    }
}