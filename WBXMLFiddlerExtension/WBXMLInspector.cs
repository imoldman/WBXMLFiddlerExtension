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
using Fiddler;
using WBXML;
using ActiveSyncDemo;

namespace WBXMLFiddlerExtension
{
    public class WBXMLInspector : Inspector2
    {
        private TextView view;
        private byte[] rawBody;

        public override void AddToTab(TabPage o)
        {
            view = new TextView();
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
            view.SetText(string.Empty);
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
            view.SetText(doc.OuterXml);
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
