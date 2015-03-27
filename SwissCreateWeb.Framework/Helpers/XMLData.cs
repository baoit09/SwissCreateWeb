using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileFolder;
using System.Windows;
using System.IO;

namespace SwissCreateWeb.Framework.Helpers
{
    public interface XMLData
    {
        
    }
    public class XMLData<TEntity>  where TEntity: class,new()
    {
        public static TEntity[] GetAllEntities(string path)
        {
            try
            {
                byte[] dataPerson = FileBinaryHelper.ReadFile_Bytes(path);
                if (dataPerson != null)
                {
                    return SerializerHelper.DeserializeArray<TEntity>(dataPerson);
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
        }
        public static TEntity GetEntity(string path)
        {
            try
            {
                byte[] dataPerson1 = FileBinaryHelper.ReadFile_Bytes(path);
                byte[] dataPerson = System.Text.Encoding.UTF8.GetBytes(FileTextHelper.ReadFile_String_AllFile(path));
                if (dataPerson != null)
                {
                    return  SerializerHelper.Deserialize<TEntity>(dataPerson);                    
                }                
            }
            catch (Exception e)
            {
                return null;
            }
            return null;            
        }
        /// <summary>
        /// Cần cắt khúc endBytes ở khúc cuối
        /// </summary>
        /// <param name="path"></param>
        /// <param name="endBytes"></param>
        /// <returns></returns>
        public static TEntity GetEntity(string path, byte[] endBytes)
        {
            try
            {
                byte[] dataPerson = FileBinaryHelper.ReadFile_Bytes(path);
                if (dataPerson != null)
                {
                    if (endBytes != null && endBytes.Length > 0)
                    {
                        int n = dataPerson.Length - 1;
                        for (int i = n; i >= endBytes.Length+1; i--)
                        {
                            int IsFound = i;
                            for (int j =0; j< endBytes.Length - 1; j++)
                            {
                                if (dataPerson[i - j] != endBytes[endBytes.Length - 1 - j])
                                {
                                    IsFound = -1;
                                    break;
                                }
                            }
                            //Tim thay, vi tri cuoi la i
                            if (IsFound == i)
                            {
                                dataPerson = dataPerson.Take(IsFound+1).ToArray();
                            }
                        }
                    }
                    return SerializerHelper.Deserialize<TEntity>(dataPerson);
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
        }
        public static List<TEntity> GetAllEntities_List(string path, bool AutoNewIfNull)
        {
            TEntity[] ts = GetAllEntities(path);
            return ts == null ? (AutoNewIfNull == false? null: (new List<TEntity>())): ts.ToList();
        }
        public static bool SaveAllEntities(string path, TEntity[] entities)
        {
            try
            {
                DeleteFileBeforeSave(path);
                byte[] data = SerializerHelper.SerializeArray<TEntity>(entities);
                FileBinaryHelper.WriteFile(path, data);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }
        public static bool SaveEntity(string path, TEntity entity)
        {
            try
            {
                DeleteFileBeforeSave(path);
                byte[] data = SerializerHelper.Serialize<TEntity>(entity);
                return FileBinaryHelper.WriteFile(path, data);                
            }
            catch (Exception e)
            {
                return false;
            }

        }

        private static void DeleteFileBeforeSave(string path)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);
            }
            catch { }
        }
    }
}
