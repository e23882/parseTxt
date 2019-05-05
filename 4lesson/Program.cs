using System;
using System.Collections.Generic;
using System.IO;

namespace _4lesson
{
    #region Property
    public class data
    {
        public string key { get; set; }
        public string vlaue { get; set; }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            List<data> list = new List<data>();
            StreamReader str = new StreamReader(@"D:\key.txt");

            string item = string.Empty;
            while ((item = str.ReadLine())!=null)
            {

                if (item.IndexOf("raw") != -1)
                {
                    list.Add(
                        new data
                        {
                            key = item.Substring(item.IndexOf("raw") + 4, item.IndexOf("=") - (item.IndexOf("raw") + 4)),
                            vlaue = item.Substring(item.IndexOf("=") + 1, item.Length - (item.IndexOf("=") + 1))
                        });    
                }
            }
            str.Close();


            //read log.txt
            StreamReader strInput = new StreamReader(@"D:\key.txt");

            while ((item = str.ReadLine()) != null)
            {
                //phase data n do something
            }
        }
    }
}
