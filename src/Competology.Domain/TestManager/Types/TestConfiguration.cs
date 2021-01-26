// ---------------------------------------------------------------------------------------------------
//  <copyright file="TestConfiguration.cs" company="Competology, Inc.">
//   Copyright © 2021 Competology, Inc. All rights reserved.
//   Refer https://competology.com/ or contact info@competology.com
//  </copyright>
// ---------------------------------------------------------------------------------------------------
// 

namespace Competology.Domain
{
    using System;

    /// <summary>
    /// Test Configuration
    /// </summary>
    public class TestConfiguration
    {
        /// <summary>
        /// Gets or sets the duration of the test.
        /// </summary>
        /// <value>The duration of the test.</value>
        public TimeSpan TestDuration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TestConfiguration"/> is resumable.
        /// </summary>
        /// <value><c>true</c> if resumable; otherwise, <c>false</c>.</value>
        public bool Resumable { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic complete on pause].
        /// </summary>
        /// <value><c>true</c> if [automatic complete on pause]; otherwise, <c>false</c>.</value>
        public bool AutoCompleteOnPause { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [automatic submit on time end].
        /// </summary>
        /// <value><c>true</c> if [automatic submit on time end]; otherwise, <c>false</c>.</value>
        public bool AutoSubmitOnTimeEnd { get; set; }
    }
}