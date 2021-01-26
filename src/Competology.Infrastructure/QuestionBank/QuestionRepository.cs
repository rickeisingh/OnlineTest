// ---------------------------------------------------------------------------------------------------
//  <copyright file="QuestionRepository.cs" company="Competology, Inc.">
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
    /// Concrete implementation of questions repository.
    /// Implements the <see cref="Competology.Domain.IQuestionRepository" />
    /// </summary>
    /// <seealso cref="Competology.Domain.IQuestionRepository" />
    public class QuestionRepository : IQuestionRepository
    {
        /// <inheritdoc />
        public void AddQuestions(List<ObjectiveQuestion> questions)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void DeleteQuestions(List<Guid> questions)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void ReplaceQuestions(Dictionary<Guid, ObjectiveQuestion> questionMap)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public List<ObjectiveQuestion> GetQuestions(List<string> searchTags, int offset, int count)
        {
            // TODO:
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public bool IsValidQuestionGuid(Guid questionId)
        {
            // TODO:
            throw new NotImplementedException();
        }
    }
}