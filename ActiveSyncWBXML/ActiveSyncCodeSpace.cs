// Copyright 2009 - Johan de Koning (johan@johandekoning.nl)
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
//
// The ActiveSync WAP Binary XML (MS-ASWBXML) specification is 
// developed by Microsoft (http://www.microsoft.com/)
// Details about this specification can be found at 
// http://msdn.microsoft.com/en-us/library/dd299442.aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WBXML;

namespace ActiveSyncDemo
{
    public class ActiveSyncCodeSpace : TagCodeSpace
    {
        public ActiveSyncCodeSpace()
        {
            AddCodePage(new AirSyncCodePage() { CodePageId = 0x00, Namespace = "AirSync:", Xmlns = "airsync" });
            AddCodePage(new ContactsCodePage() { CodePageId = 0x01, Namespace = "Contacts:", Xmlns = "contacts" });
            AddCodePage(new EmailCodePage() { CodePageId = 0x02, Namespace = "Email:", Xmlns = "email" });
            AddCodePage(new AirNotifyCodePage() { CodePageId = 0x03, Namespace = "AirNotify:", Xmlns = "airnotify" });
            AddCodePage(new CalendarCodePage() { CodePageId = 0x04, Namespace = "Calendar:", Xmlns = "calendar" });
            AddCodePage(new MoveCodePage() { CodePageId = 0x05, Namespace = "Move:", Xmlns = "move" });
            AddCodePage(new ItemEstimateCodePage() { CodePageId = 0x06, Namespace = "ItemEstimate:", Xmlns = "itemestimate" });
            AddCodePage(new FolderHierarchyCodePage() { CodePageId = 0x07, Namespace = "FolderHierarchy:", Xmlns = "folderhierarchy" });
            AddCodePage(new MeetingResponseCodePage() { CodePageId = 0x08, Namespace = "MeetingResponse:", Xmlns = "meetingresponse" });
            AddCodePage(new TasksCodePage() { CodePageId = 0x09, Namespace = "Tasks:", Xmlns = "tasks" });
            AddCodePage(new ResolveRecipientsCodePage() { CodePageId = 0x10, Namespace = "ResolveRecipients:", Xmlns = "resolverecipients" });
            AddCodePage(new ValidateCertCodePage() { CodePageId = 0x11, Namespace = "ValidateCert:", Xmlns = "validatecert" });
            AddCodePage(new Contacts2CodePage() { CodePageId = 0x12, Namespace = "Contacts2:", Xmlns = "contacts2" });
            AddCodePage(new PingCodePage() { CodePageId = 0x13, Namespace = "Ping:", Xmlns = "ping" });
            AddCodePage(new ProvisionCodePage() { CodePageId = 0x14, Namespace = "Provision:", Xmlns = "provision" });
            AddCodePage(new SearchCodePage() { CodePageId = 0x15, Namespace = "Search:", Xmlns = "search" });
            AddCodePage(new GALCodePage() { CodePageId = 0x16, Namespace = "GAL:", Xmlns = "gal" });
            AddCodePage(new AirSyncBaseCodePage() { CodePageId = 0x17, Namespace = "AirSyncBase:", Xmlns = "airsyncbase" });
            AddCodePage(new SettingsCodePage() { CodePageId = 0x18, Namespace = "Settings:", Xmlns = "settings" });
            AddCodePage(new DocumentLibraryCodePage() { CodePageId = 0x19, Namespace = "DocumentLibray:", Xmlns = "documentlibrary" });
            AddCodePage(new ItemOperationsCodePage() { CodePageId = 0x20, Namespace = "ItemOperations:", Xmlns = "itemoperations" });
            AddCodePage(new ComposeMailCodePage() { CodePageId = 0x21, Namespace = "ComposeMail:", Xmlns = "composemail" });
            AddCodePage(new Email2CodePage() { CodePageId = 0x22, Namespace = "Email2:", Xmlns = "email2" });
            AddCodePage(new NotesCodePage() { CodePageId = 0x23, Namespace = "Notes:", Xmlns = "notes" });
        }

        public override int GetPublicIdentifier()
        {
            return (int)0x01;
        }
    }
}
