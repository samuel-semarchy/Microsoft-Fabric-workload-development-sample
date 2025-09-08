﻿// <copyright company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

using Boilerplate.Contracts;
using System;
using System.Threading.Tasks;

namespace Boilerplate.Services
{
    public interface IItemMetadataStore
    {
        Task Upsert<TItemMetadata>(Guid tenantObjectId, Guid itemObjectId, CommonItemMetadata commonMetadata, TItemMetadata typeSpecificMetadata);
        Task<ItemMetadata<TItemMetadata>> Load<TItemMetadata>(Guid tenantObjectId, Guid itemObjectId);
        Task Delete(Guid tenantObjectId, Guid itemObjectId);
        bool Exists(Guid tenantObjectId, Guid itemObjectId);
        
        Task UpsertJob(Guid tenantObjectId, Guid itemObjectId, Guid jobInstanceId, ItemJobMetadata itemJobMetadata);
        Task<ItemJobMetadata> LoadJob(Guid tenantObjectId, Guid itemObjectId, Guid jobInstanceId);
        bool ExistsJob(Guid tenantObjectId, Guid itemObjectId, Guid jobInstanceId);
    }
}
