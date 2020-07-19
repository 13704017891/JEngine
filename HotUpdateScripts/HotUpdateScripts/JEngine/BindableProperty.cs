﻿//
// BindableProperty.cs
//
// Author:
//       JasonXuDeveloper（傑） <jasonxudeveloper@gmail.com>
//
// Copyright (c) 2020 JEngine
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
using JEngine.UI;
using UnityEngine;
using UnityEngine.Events;

namespace JEngine.UI
{
    public interface IBindableProperty
    {
        object ValueBoxed { get; set; }
    }

    public class BindableProperty<T> : IBindableProperty
    {
        public Action OnChange = null;

        private T _value = default(T);
        public T Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (!Equals(_value, value))
                {
                    _value = value;
                    OnChange?.Invoke();
                }
            }
        }

        public BindableProperty(T val)
        {
            _value = Value = val;
        }

        public object ValueBoxed
        {
            get { return Value; }
            set { Value = (T)value; }
        }

        public override string ToString()
        {
            return (Value != null ? Value.ToString() : "null");
        }

        public void Clear()
        {
            _value = default(T);
        }

        public static implicit operator T(BindableProperty<T> t)
        {
            return t.Value;
        }
    }


}
