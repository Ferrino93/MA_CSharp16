﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace CSharp_Net_module1_7_1_lab
{
    class InOutOperation
    {
        // 1) declare properties  CurrentPath - path to file (without name of file), CurrentDirectory - name of current directory,
        // CurrentFile - name of current file
        private string currentPath;

        public string CurrentPath
        {
            get { return currentPath; }
            set { currentPath = value; }
        }


        private int currentDirectory;

        public int CurrentDirectory
        {
            get { return currentDirectory; }
            set { currentDirectory = value; }
        }


        private int currentFile;

        public int CurrentFile
        {
            get { return currentFile; }
            set { currentFile = value; }
        }



        // 2) declare public methods:
        //ChangeLocation() - change of CurrentPath; 
        // method takes new file path as parameter, creates new directories (if it is necessary)

        public void ChangeLocation(string filePath)
        {

        }


        // CreateDirectory() - create new directory in current location
        public void CreateDirectory(string path, string dirName)
        {
            DirectoryInfo dir = Directory.CreateDirectory(path+dirName);
            dir.Create();
        }

        
            public void CreateFile(string path, string fileName, string text)
        {
            try
            {
                //using (FileStream fileStream = File.Open("Hello.txt", FileMode.Create))
                //{
                //    string msg = "Hello I/O";
                //    byte[] msg_Arr = Encoding.Default.GetBytes(msg);
                //    fileStream.Write(msg_Arr, 0, msg_Arr.Length);
                //}
                FileInfo fi = new FileInfo(path+fileName);
                using (FileStream fs = fi.Open(FileMode.OpenOrCreate,
                       FileAccess.ReadWrite, FileShare.None))
                {
                    byte[] textArr = Encoding.Default.GetBytes(text);
                    fs.Write(textArr, 0, text.Length);

                };

                
                

                // Open the stream and read it back.
                //using (StreamReader sr = File.OpenText(path))
                //{
                //    string s = "";
                //    while ((s = sr.ReadLine()) != null)
                //    {
                //        Console.WriteLine(s);
                //    }
                //}
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // WriteData() – save data to file
        // method takes data (info about computers) as parameter
        public string WriteData(Computer comp)
        {
            string str = "";
            str += "Cores:\t" + comp.Cores+"\n";
            str += "Frequency:\t" + comp.Frequency + "\n";
            str += "Memory:\t" + comp.Memory + "\n";
            str += "HDD:\t" + comp.Hdd + "\n\n";

            return str;

            //StreamWriter strWr = new StreamWriter(str);
            //strWr.Close();

        }


        // ReadData() – read data from file
        // method returns info about computers after reading it from file
        public Computer ReadData()
        {
            Computer comp = new Computer();
            return comp;
        }

        // WriteZip() – save data to zip file
        // method takes data (info about computers) as parameter
        public void WriteZip(string inFl, string outFl)
        {
            FileStream src = File.OpenRead(inFl);
            //src.Close();
            FileStream dst = File.Create(outFl);

            GZipStream zipStr = new GZipStream(dst, CompressionMode.Compress);
            int oneByte = src.ReadByte();

            while(oneByte!=-1)
            {
                zipStr.WriteByte((byte)oneByte);
                oneByte = src.ReadByte();

            }

            src.Close();
            zipStr.Close();
            dst.Close();
        }


        // ReadZip() – read data from file
        // method returns info about computers after reading it from file
        public void ReadZip()
        {

        }


        // ReadAsync() – read data from file asynchronously
        // method is async
        // method returns Task with info about computers
        // use ReadLineAsync() method to read data from file
        // Note: don't forget about await

        public async void ReadAsync()
        {

        }

        // 7)
        // ADVANCED:
        // WriteToMemoryStream() – save data to memory stream
        // method takes data (info about computers) as parameter
        // info about computers is saved to Memory Stream
        public void WriteToMemoryStream(Computer data)
        {

        }


        // use  method GetBytes() from class UnicodeEncoding to save array of bytes from string data 
        // create new file stream
        // use method WriteTo() to save memory stream to file stream 
        // method returns file stream

        // WriteToFileFromMemoryStream() – save data to file from memory stream and read it
        // method takes file stream as parameter
        // save data to file      


        // Note: 
        // - use '//' in path string or @ before it (for correct path handling without escape sequence)
        // - use 'using' keyword to organize correct working with files
        // - don't forget to check path before any file or directory operations
        // - don't forget to check existed directory and file before creating
        // use File class to check files, Directory class to check directories, Path to check path


    }
}