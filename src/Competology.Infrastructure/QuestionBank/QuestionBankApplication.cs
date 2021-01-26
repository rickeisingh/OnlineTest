// ---------------------------------------------------------------------------------------------------
//  <copyright file="QuestionBankApplication.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Infrastructure.QuestionBank
{
    using Competology.Domain;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contract for frontend : CRUDs for questions and question sets.
    /// Implements the <see cref="Competology.Domain.IQuestionBankApplication" />
    /// </summary>
    /// <seealso cref="Competology.Domain.IQuestionBankApplication" />
    public class QuestionBankApplication : QuestionSetRepository, IQuestionBankApplication
    {
        /// <summary>
        /// Adds the questions to question set.
        /// </summary>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <param name="questionGuidList">The question identifiers.</param>
        public void AddQuestionsToQuestionSet(Guid questionSetId, List<Guid> questionGuidList)
        {
            var inputValidated = base.IsValidQuestionSetGuid(questionSetId)
                                 && questionGuidList.TrueForAll(id => base.IsValidQuestionGuid(id));

            if (inputValidated)
            {
                base.UpdateQuestionSet(questionSetId, questionGuidList);
            }
        }

        /// <summary>
        /// Removes the questions from question set.
        /// </summary>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <param name="questionGuidList">The question unique identifier list.</param>
        public void RemoveQuestionsFromQuestionSet(Guid questionSetId, List<Guid> questionGuidList)
        {
            var inputValidated = base.IsValidQuestionSetGuid(questionSetId)
                                 && questionGuidList.Any(id => base.IsValidQuestionGuid(id));

            if (inputValidated)
            {
                base.UpdateQuestionSet(questionSetId, questionGuidList);
            }
        }
    }
}