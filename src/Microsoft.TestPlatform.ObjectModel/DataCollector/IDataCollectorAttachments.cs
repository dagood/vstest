﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary>
    /// Interface for data collectors add-ins that choose to handle attachment(s) generated
    /// </summary>
    public interface IDataCollectorAttachments
    {
        /// <summary>
        /// Gets the attachment set after Test Run Session
        /// </summary>
        /// <returns>Gets the attachment set after Test Run Session</returns>
        ICollection<AttachmentSet> HandleDataCollectionAttachmentSets(ICollection<AttachmentSet> dataCollectionAttachments, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the attachment Uri, which is handled by current Collector
        /// </summary>
        Uri GetExtensionUri();
    }
}
