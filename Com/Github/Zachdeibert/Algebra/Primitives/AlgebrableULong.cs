﻿//
// AlgebrableULong.cs
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

namespace Com.Github.Zachdeibert.Algebra.Primitives {
    /// <summary>
    /// An Algebrable class representing a primitive ulong.
    /// </summary>
    public class AlgebrableULong : PrimitiveAlgebrable<ulong> {
        private ulong Value;

        /// <summary>
        /// Converts a decimal value to an algebrable object
        /// </summary>
        /// <returns>The algebrable object.</returns>
        /// <param name="value">The decimal value.</param>
        public override Algebrable ToAlgebrable(decimal value) {
            return new AlgebrableULong((ulong) value);
        }

        /// <summary>
        /// Converts this instance to a decimal value.
        /// </summary>
        /// <returns>The decimal value.</returns>
        public override decimal ToDecimal() {
            return Value;
        }

        /// Converts an ulong to an <see cref="Com.Github.Zachdeibert.Algebra.Primitives.AlgebrableULong"/>
        /// <param name="value">The primitivie value.</param>
        public static implicit operator AlgebrableULong(ulong value) {
            return new AlgebrableULong(value);
        }

        /// Converts an <see cref="Com.Github.Zachdeibert.Algebra.Primitives.AlgebrableULong"/> to an ulong
        /// <param name="value">The algebrable value.</param>
        public static implicit operator ulong(AlgebrableULong value) {
            return value.Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Com.Github.Zachdeibert.Algebra.Primitives.AlgebrableULong"/> class.
        /// </summary>
        /// <param name="value">The primitive value.</param>
        public AlgebrableULong(ulong value) {
            this.Value = value;
        }
    }
}

