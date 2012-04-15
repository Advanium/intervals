﻿//-----------------------------------------------------------------------
// <copyright file="IInterval`1.cs" company="(none)">
//  Copyright © 2012 John Gietzen. All rights reserved.
// </copyright>
// <author>John Gietzen</author>
//-----------------------------------------------------------------------

namespace Intervals
{
    using System;

    public interface IInterval<T> where T : IComparable<T>
    {
        T Start { get; }

        bool StartInclusive { get; }

        T End { get; }

        bool EndInclusive { get; }

        IInterval<T> Clone(T start, bool startInclusive, T end, bool endInclusive);
    }
}
