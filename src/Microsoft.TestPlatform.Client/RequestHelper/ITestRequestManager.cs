// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.Client.RequestHelper
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
    using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Interfaces;

    /// <summary>
    /// Defines the contract that command line
    /// </summary>
    public interface ITestRequestManager : IDisposable
    {
        /// <summary>
        /// Initializes the extensions while probing additional paths
        /// </summary>
        /// <param name="pathToAdditionalExtensions">Paths to Additional extensions</param>
        /// <param name="skipExtensionFilters">Skip extension filtering by name (if true)</param>
        void InitializeExtensions(IEnumerable<string> pathToAdditionalExtensions, bool skipExtensionFilters);

        /// <summary>
        /// Resets Vstest.console.exe Options
        /// </summary>
        void ResetOptions();

        /// <summary>
        /// Discover Tests given a list of sources, runsettings
        /// </summary>
        /// <param name="discoveryPayload">Discovery payload</param>
        /// <param name="disoveryEventsRegistrar">Discovery events registrar - registers and unregisters discovery events</param>
        /// <param name="protocolConfig">Protocol related information</param>
        void DiscoverTests(DiscoveryRequestPayload discoveryPayload, ITestDiscoveryEventsRegistrar disoveryEventsRegistrar, ProtocolConfig protocolConfig);

        /// <summary>
        /// Run Tests with given a test of sources
        /// </summary>
        /// <param name="testRunRequestPayLoad">Test Run Request payload</param>
        /// <param name="customTestHostLauncher">Custom testHostLauncher for the run</param>
        /// <param name="testRunEventsRegistrar">RunEvents registrar</param>
        /// <param name="protocolConfig">Protocol related information</param>
        void RunTests(TestRunRequestPayload testRunRequestPayLoad, ITestHostLauncher customTestHostLauncher, ITestRunEventsRegistrar testRunEventsRegistrar, ProtocolConfig protocolConfig);

        /// <summary>
        /// Finalize multi test runs
        /// </summary>
        /// <param name="multiTestRunsFinalizationPayload">Multi test runs finalization payload</param>
        /// <param name="multiTestRunsFinalizationEventsHandler">Multi test runs finalization events handler</param>
        void FinalizeMultiTestRuns(MultiTestRunsFinalizationPayload multiTestRunsFinalizationPayload, IMultiTestRunsFinalizationEventsHandler multiTestRunsFinalizationEventsHandler);

        /// <summary>
        /// Cancel the current TestRun request
        /// </summary>
        void CancelTestRun();

        /// <summary>
        /// Abort the current TestRun
        /// </summary>
        void AbortTestRun();

        /// <summary>
        /// Cancels the current discovery request
        /// </summary>
        void CancelDiscovery();

        /// <summary>
        /// Cancels the current multi test runs finalization request
        /// </summary>
        void CancelMultiTestRunsFinalization();
    }
}
