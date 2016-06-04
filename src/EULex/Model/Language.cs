//
// Copyright 2016 Bertrand Lorentz
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
using System.Xml.Serialization;

namespace EULex.Model
{
    /// <summary>
    /// Languages supported by the search system.
    /// </summary>
    [XmlType (Namespace="http://eur-lex.europa.eu/search")]
    public enum Language
    {
        /// <summary>
        /// Bulgarian
        /// </summary>
        bg,
        /// <summary>
        /// Czech
        /// </summary>
        cs,
        /// <summary>
        /// Danish
        /// </summary>
        da,
        /// <summary>
        /// German
        /// </summary>
        de,
        /// <summary>
        /// Greek
        /// </summary>
        el,
        /// <summary>
        /// English
        /// </summary>
        en,
        /// <summary>
        /// Spanish
        /// </summary>
        es,
        /// <summary>
        /// Estonian
        /// </summary>
        et,
        /// <summary>
        /// Finnish
        /// </summary>
        fi,
        /// <summary>
        /// French
        /// </summary>
        fr,
        /// <summary>
        /// Irish
        /// </summary>
        ga,
        /// <summary>
        /// Croatian
        /// </summary>
        hr,
        /// <summary>
        /// Hungarian
        /// </summary>
        hu,
        /// <summary>
        /// Italian
        /// </summary>
        it,
        /// <summary>
        /// Lithuanian
        /// </summary>
        lt,
        /// <summary>
        /// Latvian
        /// </summary>
        lv,
        /// <summary>
        /// Maltese
        /// </summary>
        mt,
        /// <summary>
        /// Dutch
        /// </summary>
        nl,
        /// <summary>
        /// Polish
        /// </summary>
        pl,
        /// <summary>
        /// Portuguese
        /// </summary>
        pt,
        /// <summary>
        /// Romanian
        /// </summary>
        ro,
        /// <summary>
        /// Slovak
        /// </summary>
        sk,
        /// <summary>
        /// Slovenian
        /// </summary>
        sl,
        /// <summary>
        /// Swedish
        /// </summary>
        sv,
    }
}

