﻿using System.IO;

namespace Session4.Ex3
{
    class Reader
    {
        string fileName;
        public string Data { get; set; }
        public Reader(string fn) { fileName = fn; }

        public void Read()
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(s);
            Data = r.ReadToEnd();
            r.Close();
            s.Close();
        }
    }
}
