using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Data;

class clsDataNative
{
    public bool AppConfigUpdater(string key, string value)
    {
        var result = false;

        try
        {
            Configuration conf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            conf.AppSettings.Settings[key].Value = value;
            conf.Save();
            result = true;
        }
        catch (Exception) { }

        return result;
    }
    /// <summary>
    /// ดึงข้อมูลต่างๆออกจาก ConnectionString ในไฟล์ AppConfig
    /// </summary>
    /// <param name="appSettingName"></param>
    /// <param name="appConfigConnectionKey"></param>
    /// <returns></returns>
    /// <example>
    /// clsDataNative clsData = new clsDataNative();
    /// clsData.AppConfigConnectionSelector("cs", clsDataNative.AppConfigConnectionKeys.Server);
    /// </example>
    public string AppConfigConnectionSelector(string appSettingName, AppConfigConnectionKeys appConfigConnectionKey)
    {
        #region Variable
        var result = "";
        var appConfig = System.Configuration.ConfigurationManager.AppSettings[appSettingName];
        string[] appConfigItems;
        #endregion
        #region Procedure
        try
        {
            appConfigItems=appConfig.Split(';');
            for (int i = 0; i < appConfig.Length; i++)
            {
                var items = appConfigItems[i].Split('=');
                if (items[0].Trim().ToLower() == appConfigConnectionKey.ToString().Trim().ToLower())
                {
                    result = items[1].Trim();
                    break;
                }
            }
        }
        catch (Exception) { }
        #endregion
        return result;
    }
    public enum AppConfigConnectionKeys { Server, UID, PWD, Database }
    /// <summary>
    /// เพิ่ม แก้ไข ข้อมูลในไฟล์ INI
    /// </summary>
    /// <param name="PathFile">ที่อยู่ของไฟล์</param>
    /// <param name="Key">ชื่อ</param>
    /// <param name="Value">ค่า</param>
    /// <returns>true=สำเร็จ , false=ไม่สำเร็จ</returns>
    /// <example>
    /// INIUpdater(AppDomain.CurrentDomain.BaseDirectory + @"\Config.ini", "cs", "SQLServer");
    /// </example>
    public bool INIUpdater(string PathFile, string Key, string Value)
    {
        #region Variable
        var fi = new FileInfo(PathFile);
        var result = false;
        string[] readLines;
        var writeLines = new List<string>();
        var searchFound = false;
        #endregion
        #region Write File
        try
        {
            if (fi.Exists)
            {
                #region ReadFile
                const Int32 BufferSize = 128;
                using (var fileStream = File.OpenRead(PathFile))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        readLines = line.Split('=');
                        if (readLines[0].Trim().ToLower() == Key.Trim().ToLower())
                        {
                            searchFound = true;
                            readLines[1] = Value.Trim();
                        }
                        writeLines.Add(readLines[0] + "=" + readLines[1]);
                    }
                    if (!searchFound)
                    {
                        writeLines.Add(Key + "=" + Value);
                    }
                }
                #endregion
            }
            else
            {
                writeLines.Add(Key + "=" + Value);
            }
            #region WriteFile
            using (var sw = new StreamWriter(PathFile, false, System.Text.Encoding.UTF8))
            {
                for (int i = 0; i < writeLines.Count(); i++)
                {
                    sw.WriteLine(writeLines[i]);
                }
                result = true;
            }
            #endregion
        }
        catch (Exception)
        {
            result = false;
        }
        #endregion

        return result;
    }
    /// <summary>
    /// ดึงค่าจาก Key ที่ต้องการในไฟล์ INI
    /// </summary>
    /// <param name="PathFile">ที่เก็บไฟล์</param>
    /// <param name="Key">ชื่อที่ต้องการ</param>
    /// <returns></returns>
    /// <example>
    /// MessageBox.Show(INISelecter(AppDomain.CurrentDomain.BaseDirectory+@"\Config.ini","cs"));
    /// </example>
    public string INISelecter(string PathFile, string Key)
    {
        #region Variable
        var result = "";
        var fi = new FileInfo(PathFile);
        string[] readLines;
        #endregion
        #region Procedure
        if (fi.Exists)
        {
            #region ReadFile
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(PathFile))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    readLines = line.Split('=');
                    if (readLines[0].Trim().ToLower() == Key.Trim().ToLower())
                    {
                        result = readLines[1];
                        break;
                    }
                }
            }
            #endregion
        }
        #endregion
        return result;
    }
    public DataTable XMLSelecter(string PathFile)
    {
        #region Variable
        var result = new DataTable();
        var ds = new DataSet();
        #endregion
        #region Procedure
        try
        {
            if (!string.IsNullOrEmpty(PathFile))
            {
                if (PathFile.Contains(".xml") || PathFile.Contains(".XML"))
                {
                    if (new FileInfo(PathFile).Exists)
                    {
                        ds.ReadXml(PathFile);
                        result = ds.Tables[0];
                    }
                }
            }
        }
        catch (Exception) { }
        #endregion
        return result;
    }
    public bool XMLCreator(DataTable dt, string PathFile)
    {
        #region Variable
        var result = false;
        var ds = new DataSet();
        #endregion
        #region Procedure
        try
        {
            if (!string.IsNullOrEmpty(PathFile))
            {
                if (PathFile.Contains(".xml") || PathFile.Contains(".XML"))
                {
                    ds.Tables.Add(dt);
                    ds.WriteXml(PathFile);
                    result = true;
                }
            }
        }
        catch (Exception) { }
        #endregion
        return result;
    }

    /// <summary>
    /// แปลงไฟล์ CSV ที่ต้องการเป็น DataTable
    /// </summary>
    /// <param name="FilePath">Path ไฟล์ CSV พร้อมชื่อไฟล์</param>
    /// <returns>DataTable ที่แปลงได้</returns>
    /// <example>
    /// clsData.CSVSelecter("DB\FileList.csv");
    /// </example>
    public DataTable CSVSelecter(string FilePath)
    {
        #region Variable
        var dt = new DataTable();
        var fi = new FileInfo(@FilePath);
        #endregion
        #region Procedure
        #region File Exist
        if (fi.Exists)
        {
            #region CSV Extension Check
            if (fi.Extension.ToLower() == ".csv")
            {
                try
                {
                    string line;

                    using (StreamReader reader = new StreamReader(Path.GetFullPath(FilePath), Encoding.GetEncoding(874)))
                    {
                        line = reader.ReadLine();
                        #region Loop Line
                        do
                        {
                            if (!string.IsNullOrEmpty(line))
                            {
                                string[] arrLine = line.Trim().Split(',');
                                DataRow dr;

                                #region Build Column
                                if (dt.Columns.Count == 0)
                                {
                                    for (int i = 0; i < arrLine.Length; i++)
                                    {
                                        dt.Columns.Add(i.ToString());
                                    }
                                }
                                else if (dt.Columns.Count < arrLine.Length)
                                {
                                    for (int i = dt.Columns.Count; i < arrLine.Length; i++)
                                    {
                                        dt.Columns.Add(i.ToString());
                                    }
                                }
                                #endregion
                                #region Build Row
                                dr = dt.NewRow();
                                for (int i = 0; i < arrLine.Length; i++)
                                {
                                    dr[i] = arrLine[i].Trim();
                                }
                                dt.Rows.Add(dr);
                                #endregion
                            }
                            line = reader.ReadLine();
                        } while (!string.IsNullOrEmpty(line));
                        #endregion
                    }
                }
                catch (Exception)
                {
                    //Error : Read File
                }
            }
            #endregion
        }
        #endregion
        return dt;
        #endregion
    }

    /// <summary>
    /// เขียนไฟล์ CSV
    /// </summary>
    /// <param name="PathFile">Path ไฟล์ CSV พร้อมชื่อไฟล์</param>
    /// <param name="Values">Array ค่าที่ต้องการใส่</param>
    /// <param name="EnableAddDateTime">true=บันทึกเวลาที่ฟิลด์แรก , false=ไม่บันทึก</param>
    /// <returns>true=งานสำเร็จ , false=ไม่สำเร็จ</returns>
    /// <example>
    /// clsData.CSVCreater("Path\Log.csv", new string[] { "ทดสอบ 1", "Test 1", "Test 2" });
    /// </example>
    public bool CSVCreater(string PathFile, string[] Values, bool EnableAddDateTime = false, bool EnableDeleteOldFile = false)
    {
        #region Variable
        var fi = new FileInfo(PathFile);
        var rtnValue = false;
        #endregion
        #region Procedure
        #region DeleteOldFile
        if (EnableDeleteOldFile)
        {
            try
            {
                if (fi.Exists)
                {
                    fi.Delete();
                }
            }
            catch (Exception){}
        }
        #endregion
        #region WriteFile
        try
        {
            var sw = new StreamWriter(PathFile, true, System.Text.Encoding.UTF8);
            var strValue = new StringBuilder();

            #region Build Data
            if (EnableAddDateTime)
            {
                strValue.Append(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                strValue.Append(",");
            }
            #region Build Data by Array
            for (int i = 0; i < Values.Length; i++)
            {
                strValue.Append(Values[i].Trim().Replace(",", "#"));
                if (i < Values.Length - 1)
                {
                    strValue.Append(",");
                }
            }
            #endregion
            #endregion
            sw.WriteLine(strValue.ToString());
            strValue.Length = 0; strValue.Capacity = 0;
            sw.Close();
            rtnValue = true;
        }
        catch (Exception) { }
        #endregion
        return rtnValue;
        #endregion
    }
}