// ---------------------------------------------------------------------------------------------------
//  <copyright file="QuestionSetRepository.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Infrastructure.QuestionBank
{
    using System;
    using System.Collections.Generic;
    using Competology.Domain;

    /// <summary>
    /// Concrete implementation for question set repository.
    /// Implements the <see cref="Competology.Domain.IQuestionSetRepository" />
    /// </summary>
    /// <seealso cref="Competology.Domain.IQuestionSetRepository" />
    public class QuestionSetRepository : QuestionRepository, IQuestionSetRepository
    {
        /// <inheritdoc />
        public QuestionSet FetchAutoQuestionSet(List<string> questionSearchTags, int questionCount, Language language)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public QuestionSet FetchQuestionSetById(Guid questionSetId, Language language)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Guid CreateQuestionSet(string name, Language language)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void UpdateQuestionSet(Guid questionSetId, List<Guid> questions, Language language = Language.None)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void DeleteQuestionSet(List<Guid> questionSetIds)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public List<QuestionSet> GetQuestionSets(List<string> questionSetSearchTags)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool IsValidQuestionSetGuid(Guid questionSetId)
        {
            // TODO:
            throw new NotImplementedException();
        }
    }
}