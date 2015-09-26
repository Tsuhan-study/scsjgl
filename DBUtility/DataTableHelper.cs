using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace System.Data
{
    public static class DataTableHelper
    {

        /// <summary>
        /// DataTable转泛型List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<T> ToList<T>(this DataTable table)
        {
            List<T> list = new List<T>();
            Type typeInfo = typeof(T);
            //得到T内所有的公共属性
            PropertyInfo[] propertys = typeInfo.GetProperties();
            foreach (DataRow rowItem in table.Rows)
            {
                //通过反射动态创建对象
                T objT = Activator.CreateInstance<T>();
                //给objT的所有属性赋值
                foreach (DataColumn columnItem in table.Columns)
                {
                    foreach (PropertyInfo property in propertys)
                    {
                        if (DataTableHelper.GetSimpleColumnName(columnItem.ColumnName).Equals(DataTableHelper.GetSimpleColumnName(property.Name)))
                        {
                            try
                            {
                                //获取指定单元格的值
                                object value = rowItem[columnItem.ColumnName];
                                if (value != DBNull.Value)
                                {
                                    property.SetValue(objT, value, null);
                                }
                            }
                            catch { }
                            break;
                        }
                    }
                }
                list.Add(objT);
            }
            return list;
        }


        public static T ToEntity<T>(this IDataReader reader, bool autoClose=true)
        {

            Type typeInfo = typeof(T);
            //得到T内所有的公共属性
            PropertyInfo[] propertys = typeInfo.GetProperties();
            if (reader.IsClosed == false && reader.Read())
            {
                //通过反射动态创建对象
                T objT = Activator.CreateInstance<T>();
                //给objT的所有属性赋值
                foreach (PropertyInfo property in propertys)
                {
                    try
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.IsDBNull(i) == false)
                            {
                                string columnName = reader.GetName(i);
                                if (DataTableHelper.GetSimpleColumnName(columnName).Equals(DataTableHelper.GetSimpleColumnName(property.Name)))
                                {
                                    object value = reader[property.Name];
                                    property.SetValue(objT, value, null);
                                    break;
                                }
                            }
                        }
                    }
                    catch 
                    {
                        continue;
                    }
                }
                if (autoClose == true)
                {
                    reader.Close();
                }
                return objT;
            }
            return default(T);
        }

        public static List<T> ToList<T>(this IDataReader reader, bool autoClose = true)
        {
            List<T> list = new List<T>();
            Type typeInfo = typeof(T);
            //得到T内所有的公共属性
            PropertyInfo[] propertys = typeInfo.GetProperties();
            while (reader.IsClosed == false && reader.Read())
            {
                //通过反射动态创建对象
                T objT = Activator.CreateInstance<T>();
                //给objT的所有属性赋值
                foreach (PropertyInfo property in propertys)
                {
                    try
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.IsDBNull(i) == false)
                            {
                                string columnName = reader.GetName(i);
                                if (DataTableHelper.GetSimpleColumnName(columnName).Equals(DataTableHelper.GetSimpleColumnName(property.Name)))
                                {
                                    object value = reader[property.Name];
                                    property.SetValue(objT, value, null);
                                }
                                break;
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                list.Add(objT);
            }
            if (autoClose == true)
            {
                reader.Close();
            }
            return list;
        }


        public static string GetSimpleColumnName(string columnName)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                return string.Empty;
            }
            columnName = columnName.ToLower();
            if (columnName.StartsWith("int") || columnName.StartsWith("flt") 
                || columnName.StartsWith("dbl") || columnName.StartsWith("dtm") 
                || columnName.StartsWith("bit") || columnName.StartsWith("chv") 
                || columnName.StartsWith("txt"))
            {
                columnName = columnName.Substring(3);
            }
            return columnName;
        }

    }
}
