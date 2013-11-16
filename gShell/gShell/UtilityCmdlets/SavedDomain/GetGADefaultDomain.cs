﻿using gShell.OAuth2;
using System.Management.Automation;

namespace gShell.UtilityCmdlets.SavedDomain
{
    [Cmdlet(VerbsCommon.Get, "GADefaultDomain",
          SupportsShouldProcess = true)]
    public class GetGADefaultDomainCommand : UtilityBase
    {
        protected override void ProcessRecord()
        {
            WriteObject(RetrieveDefaultDomain());
        }

        private string RetrieveDefaultDomain()
        {
            return SavedFile.GetDefaultDomain();
        }
    }
}