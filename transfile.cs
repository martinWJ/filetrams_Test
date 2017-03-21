using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace transferFile_test
{    
       class Program    
       {        
       
       static void Main(string[] args)        
       {            
       
       //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////            
       //今日日期            
       DateTime Date = DateTime.Now;            
       string TodyMillisecond = Date.ToString("yyyy-MM-dd HH:mm:ss");            
       string Tody = Date.ToString("yyyy-MM-dd");            
       FileInfo[] fileList = null;            
       
       //COMM_Test.EventLog.FilePath = (@"D:\Martin_Yang\test_destinationfile", @"D:\Martin_Yang\test_destinationfile");            
       
       
       string sourcePath = @"D:\Martin_Yang\test_LocationB";                //初始檔案位置            
       string destinationPath = @"D:\Martin_Yang\test_LocationA";                //目的地檔案位置            
       
       //如果此路徑沒有資料夾            
       if (!Directory.Exists(@"D:\Martin_Yang\Transfer_Log"))           
       {                
       
       //新增資料夾               
       Directory.CreateDirectory(@"D:\Martin_Yang\Transfer_Log");            
       }            
       
       
       //如果此路徑沒有資料夾            
       if (!Directory.Exists(destinationPath))            
       {                
       //新增資料夾                
       Directory.CreateDirectory(destinationPath);            
       }            
       
       
       //把內容寫到目的檔案，若檔案存在則附加在原本內容之後(換行)            
       ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////                        if (Directory.Exists(sourcePath))            {                DirectoryInfo di = new DirectoryInfo(sourcePath);                fileList = di.GetFiles();            }            for (int i = 0; i < fileList.Length; i++)            {                string fileName = destinationPath + @"\" + fileList.GetValue(i).ToString();                string desFileName = sourcePath + @"\" + fileList.GetValue(i).ToString();                //File.Copy(desFileName, fileName);                //File.Delete(desFileName);    File.Move(desFileName, fileName);                File.AppendAllText(@"D:\Martin_Yang\Transfer_Log\\" + Tody + ".txt", "\r\n" + TodyMillisecond + "\0->擷取檔案\0" + fileList.GetValue(i).ToString());                            }        }    }}
