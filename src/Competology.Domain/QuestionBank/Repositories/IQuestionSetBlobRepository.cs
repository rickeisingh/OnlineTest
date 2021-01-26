// ---------------------------------------------------------------------------------------------------
//  <copyright file="IQuestionSetBlobRepository.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Domain
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// Contract for storing Blobs to be made available as a part of test summary as explanations.
    /// </summary>
    public interface IQuestionSetBlobRepository
    {
        /// <summary>
        /// Adds the BLOB.
        /// </summary>
        /// <param name="blob">The BLOB.</param>
        /// <param name="questionId">The question identifier.</param>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <returns>Guid.</returns>
        Guid AddOrUpdateBlob(Blob blob, Guid questionId = default, Guid questionSetId = default);
        
        /// <summary>
        /// Deletes the BLOB.
        /// </summary>
        /// <param name="blobGuid">The BLOB unique identifier.</param>
        /// <returns>Guid.</returns>
        Guid DeleteBlob(Guid blobGuid);

        /// <summary>
        /// Gets the blobs.
        /// </summary>
        /// <param name="questionId">The question identifier.</param>
        /// <param name="questionSetId">The question set identifier.</param>
        /// <returns>List&lt;Blob&gt;.</returns>
        List<Blob> GetBlobs(Guid questionId = default, Guid questionSetId = default);

        /// <summary>
        /// Gets the BLOB.
        /// </summary>
        /// <param name="blobId">The blob identifier.</param>
        /// <returns>Blob.</returns>
        Blob GetBlob(Guid blobId);
    }

    public class Blob
    {
        /// <summary>
        /// Gets or sets the BLOB unique identifier.
        /// </summary>
        /// <value>The BLOB unique identifier.</value>
        public Guid BlobId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the memory stream.
        /// </summary>
        /// <value>The memory stream.</value>
        public MemoryStream MemoryStream { get; set; }
    }
}