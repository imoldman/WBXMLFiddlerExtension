﻿// Copyright 2009 - Johan de Koning (johan@johandekoning.nl)
// 
// This file is part of WBXML .Net Library.
// The WBXML .Net Library is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
// 
// The WBXML .Net Library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// The WAP Binary XML (WBXML) specification is developed by the 
// Open Mobile Alliance (http://www.openmobilealliance.org/)
// Details about this specification can be found at
// http://www.openmobilealliance.org/tech/affiliates/wap/wap-192-wbxml-20010725-a.pdf

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WBXML
{
    public abstract class TagCodeSpace
    {
        private List<TagCodePage> codePages = new List<TagCodePage>();

        public void AddCodePage(TagCodePage codePage)
        {
            codePages.Add(codePage);

            if (codePage.CodePageId > -1)
            {
                codePages = codePages.OrderBy((x) => x.CodePageId).ToList();
            }
            else
            {
                codePage.CodePageId = codePages.Count - 1;
            }
        }

        public virtual TagCodePage GetCodePage(int codepageId)
        {
            return codePages[codepageId];
        }

        public int ContainsTag(int codepageId, string name)
        {
            if (codePages[codepageId].ContainsTag(name))
            {
                return codepageId;
            }

            for (int i = 0; i < codePages.Count; i++)
            {
                if (i != codepageId)
                {
                    if (codePages[i].ContainsTag(name))
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public abstract int GetPublicIdentifier();
    }
}
