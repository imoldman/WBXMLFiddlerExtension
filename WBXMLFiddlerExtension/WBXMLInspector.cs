using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel.Channels;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WBXML;
using ActiveSyncDemo;

using Fiddler;
using Samples;

namespace WBXMLFiddlerExtension
{
    public class WBXMLInspector : Inspector2
    {
        private XMLView view;
        private byte[] rawBody;

        public override void AddToTab(TabPage o)
        {
            view = new XMLView();
            o.Text = "WBXML";
            o.Controls.Add(view);
            o.Controls[0].Dock = DockStyle.Fill;
        }

        public override int GetOrder()
        {
            return 0;
        }

        public void Clear()
        {
            view.Clear();
            rawBody = null;
        }

        private void UpdateView(byte[] raw)
        {
            WBXMLDocument doc = new WBXMLDocument();
            doc.VersionNumber = 1.3;
            doc.TagCodeSpace = new ActiveSyncCodeSpace();
            doc.AttributeCodeSpace = new ActiveSyncAttributeCodeSpace();
            doc.Encoding = Encoding.UTF8;

            rawBody = raw;
            doc.LoadBytes(rawBody);
            view.SetXML(doc);
        }

        public byte[] body
        {
            get { return rawBody; }
            set { UpdateView(value); }
        }

        public bool bDirty
        {
            get { return false; }
        }

        public bool bReadOnly
        {
            get { return true; }
            set { }
        }

    }

    public class WBXMLRequestInspector : WBXMLInspector, IRequestInspector2
    {
        public HTTPRequestHeaders headers
        {
            get { return null; }
            set { }
        }
    }

    public class WBXMLResponseInspector : WBXMLInspector, IResponseInspector2
    {
        public HTTPResponseHeaders headers
        {
            get { return null; }
            set { }
        }
    }
}
