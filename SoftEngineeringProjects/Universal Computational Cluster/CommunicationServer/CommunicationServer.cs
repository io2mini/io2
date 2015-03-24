﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationServer.Control;
using Common;
using System.Xml.Serialization;
using System.IO;
namespace CommunicationServer
{
    public class CommunicationServer : SystemComponent
    {
        
        public bool IsWorking { get; set; }
        protected override void SaveConfig(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CommunicationServerCommunicationInfo));
            xmlSerializer.Serialize(new FileStream(path, FileMode.Create), communicationServerInfo);
        }
        protected override void LoadConfig(string path)
        {
            base.LoadConfig(path);
        }
        public CommunicationServer()
        {
            IsWorking = true;
        }

        
    }
}
