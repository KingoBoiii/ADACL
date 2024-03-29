﻿using ADACL.Models;
using System.Runtime.Versioning;

namespace ADACL.ActiveDirectory.Models.Mappers;

public interface IDomainMapper
{
    ValueTask<Domain> MapAsync(ADDomain? activeDirectoryDomain);
}

[SupportedOSPlatform("windows")]
internal class WindowsDomainMapper : IDomainMapper
{
    public ValueTask<Domain> MapAsync(ADDomain? activeDirectoryDomain)
    {
        ArgumentNullException.ThrowIfNull(activeDirectoryDomain);

        return ValueTask.FromResult(new Domain
        {
            Name = activeDirectoryDomain.Name
        });
    }
}
