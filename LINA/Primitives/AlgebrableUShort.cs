﻿//
// AlgebrableUShort.cs
//
// Author:
//       Zach Deibert <zachdeibert@gmail.com>
//
// Copyright (c) 2016 Zach Deibert
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

namespace LINA.Primitives {
    /// <summary>
    /// An Algebrable class representing a primitive ushort.
    /// </summary>
    public class AlgebrableUShort : PrimitiveAlgebrable<ushort> {
        private ushort Value;

        /// <summary>
        /// Converts a decimal value to an algebrable object
        /// </summary>
        /// <returns>The algebrable object.</returns>
        /// <param name="value">The decimal value.</param>
        public override Algebrable ToAlgebrable(decimal value) {
            return new AlgebrableUShort((ushort) value);
        }

        /// <summary>
        /// Converts this instance to a decimal value.
        /// </summary>
        /// <returns>The decimal value.</returns>
        public override decimal ToDecimal() {
            return Value;
        }

        /// Converts an ushort to an <see cref="LINA.Primitives.AlgebrableUShort"/>
        /// <param name="value">The primitivie value.</param>
        public static implicit operator AlgebrableUShort(ushort value) {
            return new AlgebrableUShort(value);
        }

        /// Converts an <see cref="LINA.Primitives.AlgebrableUShort"/> to an ushort
        /// <param name="value">The algebrable value.</param>
        public static implicit operator ushort(AlgebrableUShort value) {
            return value.Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LINA.Primitives.AlgebrableUShort"/> class.
        /// </summary>
        /// <param name="value">The primitive value.</param>
        public AlgebrableUShort(ushort value) {
            this.Value = value;
        }
    }
}

