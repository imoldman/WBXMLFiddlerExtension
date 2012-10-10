using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WBXML;

namespace ActiveSyncDemo
{
    public class ActiveSyncAttributeCodeSpace : AttributeCodeSpace
    {
        public ActiveSyncAttributeCodeSpace()
        {
            AttributeCodePage codePage = new AttributeCodePage();

            codePage.AddAttributeStart(0x00, "xmlns", "AirSync");
            codePage.AddAttributeStart(0x01, "xmlns", "Contacts");
            codePage.AddAttributeStart(0x02, "xmlns", "Email");
            codePage.AddAttributeStart(0x03, "xmlns", "AirNotify");
            codePage.AddAttributeStart(0x04, "xmlns", "Calendar");
            codePage.AddAttributeStart(0x05, "xmlns", "Move");
            codePage.AddAttributeStart(0x06, "xmlns", "ItemEstimate");
            codePage.AddAttributeStart(0x07, "xmlns", "FolderHierarchy");
            codePage.AddAttributeStart(0x08, "xmlns", "MeetingResponse");
            codePage.AddAttributeStart(0x09, "xmlns", "Tasks");
            codePage.AddAttributeStart(0x10, "xmlns", "ResolveRecipients");
            codePage.AddAttributeStart(0x11, "xmlns", "ValidateCert");
            codePage.AddAttributeStart(0x12, "xmlns", "Contacts2");
            codePage.AddAttributeStart(0x13, "xmlns", "Ping");
            codePage.AddAttributeStart(0x14, "xmlns", "Provision");
            codePage.AddAttributeStart(0x15, "xmlns", "Search");
            codePage.AddAttributeStart(0x16, "xmlns", "GAL");
            codePage.AddAttributeStart(0x17, "xmlns", "AirSyncBase");
            codePage.AddAttributeStart(0x18, "xmlns", "Settings");
            codePage.AddAttributeStart(0x19, "xmlns", "DocumentLibrary");
            codePage.AddAttributeStart(0x20, "xmlns", "ItemOperations");
            codePage.AddAttributeStart(0x21, "xmlns", "ComposeMail");
            codePage.AddAttributeStart(0x22, "xmlns", "Email2");
            codePage.AddAttributeStart(0x23, "xmlns", "Notes");
            codePage.AddAttributeStart(0x24, "xmlns", "RightsManagement");

            AddCodePage(codePage);
        }
    }
}
