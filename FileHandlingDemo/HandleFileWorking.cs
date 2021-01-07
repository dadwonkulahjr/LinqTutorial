using System;
using System.IO;

namespace FileHandlingDemo
{
    public class HandleFileWorking
    {
        private StreamReader _streamReader;
        private string _readData;
        public HandleFileWorking()
        {
            _streamReader = new StreamReader(@"C:\Users\Dad S. Wonkulah Jr\Documents\Bardnesville First Day.txt");
        }
        public string ReadData
        {
            get { return _readData; }
            private set
            {
                if (_readData != null)
                    _readData = value;
                else
                    _readData = null;
            }
        }
        public void GetData()
        {
            while (!_streamReader.EndOfStream)
            {
                _readData = _streamReader.ReadToEnd();
            }
            //Console.WriteLine();
            _streamReader.Close();
        }
    }
}
