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
        private XMLView xmlView;
        private RawView textView;
        private Control.ControlCollection tagPageControl;
        private WBXMLDocument wbxmlDoc;
        private byte[] rawBody;
        private bool validHeader;

        public WBXMLInspector()
        {
            wbxmlDoc = new WBXMLDocument();
            wbxmlDoc.VersionNumber = 1.3;
            wbxmlDoc.TagCodeSpace = new ActiveSyncCodeSpace();
            wbxmlDoc.AttributeCodeSpace = new ActiveSyncAttributeCodeSpace();
            wbxmlDoc.Encoding = Encoding.UTF8;
            xmlView = new XMLView();
            textView = new RawView(this);
            rawBody = null;
            validHeader = false;
            tagPageControl = null;
        }

        public override void AddToTab(TabPage o)
        {
            o.Text = "WBXML";
            tagPageControl = o.Controls;
        }

        public override int GetOrder()
        {
            return 0;
        }

        public void Clear()
        {
            xmlView.Clear();
            textView.txtRaw.Clear();
            wbxmlDoc.RemoveAll();
            rawBody = null;
            validHeader = false;
        }

        private void UpdateView(byte[] raw)
        {
            tagPageControl.Clear();
            if(validHeader)
            {
                tagPageControl.Add(xmlView);
                tagPageControl[0].Dock = DockStyle.Fill;
                rawBody = raw;
                wbxmlDoc.LoadBytes(rawBody);
                xmlView.SetXML(wbxmlDoc);
            }
            else
            {
                tagPageControl.Add(textView);
                tagPageControl[0].Dock = DockStyle.Fill;
                textView.txtRaw.AppendText("Not vnd.ms-sync.wbxml package");
            }
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

        protected void SetHeaders(HTTPHeaders header)
        {
            validHeader = (header["Content-Type"] == "application/vnd.ms-sync.wbxml");
        }
    }

    public class WBXMLRequestInspector : WBXMLInspector, IRequestInspector2
    {
        public HTTPRequestHeaders headers
        {
            get { return null; }
            set { SetHeaders(value); }
        }
    }

    public class WBXMLResponseInspector : WBXMLInspector, IResponseInspector2
    {
        public HTTPResponseHeaders headers
        {
            get { return null; }
            set { SetHeaders(value); }
        }
    }
}
