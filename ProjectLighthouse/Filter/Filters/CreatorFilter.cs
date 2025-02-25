﻿using System;
using System.Linq.Expressions;
using LBPUnion.ProjectLighthouse.Extensions;
using LBPUnion.ProjectLighthouse.Types.Entities.Level;
using LBPUnion.ProjectLighthouse.Types.Filter;

namespace LBPUnion.ProjectLighthouse.Filter.Filters;

public class CreatorFilter : ISlotFilter
{
    private readonly int creatorId;

    public CreatorFilter(int creatorId)
    {
        this.creatorId = creatorId;
    }

    public Expression<Func<SlotEntity, bool>> GetPredicate() =>
        PredicateExtensions.True<SlotEntity>().And(s => s.CreatorId == this.creatorId);
}