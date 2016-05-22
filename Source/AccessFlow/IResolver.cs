#region copyright
// Copyright 2016 Christoph M�ller
// 
// This file is part of AccessFlow.
// 
// AccessFlow is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AccessFlow is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with AccessFlow.  If not, see <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessFlow
{
    /// <summary>
    /// Allows to resolve a value.
    /// This class is the counterpart to <see cref="IFuture{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the value resolved.</typeparam>
    public interface IResolver<in T>
    {
        /// <summary>
        /// Resolves the value.
        /// </summary>
        /// <param name="value">The determined value.</param>
        void Resolve(T value);
    }
}