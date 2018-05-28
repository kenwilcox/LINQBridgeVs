﻿#region License
// Copyright (c) 2013 - 2018 Coding Adventures
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System.Collections.Generic;
using BridgeVs.DynamicVisualizers.Helper;
using BridgeVs.Shared.Options;

namespace BridgeVs.DynamicVisualizers.Template
{
    public partial class Inspection
    {
        private readonly string _typeNamespace;

        private readonly List<string> _assemblies;
        private readonly string _typeToRetrieveFullName;
        private readonly string _typeName;
        private readonly SerializationOption _serializationOption;

        public Inspection(List<string> assemblies, string typeToRetrieveFullName, string typeNamespace, string typeName, SerializationOption serializationOption)
        {
            _serializationOption = serializationOption;
            _typeNamespace = typeNamespace;
            _typeName = typeName;
            _assemblies = assemblies;
            _typeToRetrieveFullName = TypeNameHelper.RemoveSystemNamespaces(typeToRetrieveFullName);
        }
    }
}