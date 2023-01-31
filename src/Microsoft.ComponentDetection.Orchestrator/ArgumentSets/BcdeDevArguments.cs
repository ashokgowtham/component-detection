﻿namespace Microsoft.ComponentDetection.Orchestrator.ArgumentSets;
using System.Composition;
using CommandLine;

[Verb("dev", HelpText = "Dev command", Hidden = true)]
[Export(typeof(IScanArguments))]
public class BcdeDevArguments : BcdeArguments, IDetectionArguments
{
    // TODO: Add option to specify download directory for GH database
}
