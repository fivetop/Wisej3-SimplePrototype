using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;

namespace pa_web
{

	public static class Helper
	{
		public static DataTable ToDataTable<T>(this IList<T> data)
		{
			PropertyDescriptorCollection properties =
				TypeDescriptor.GetProperties(typeof(T));
			DataTable table = new DataTable();
			foreach (PropertyDescriptor prop in properties)
				table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			foreach (T item in data)
			{
				DataRow row = table.NewRow();
				foreach (PropertyDescriptor prop in properties)
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
				table.Rows.Add(row);
			}
			return table;
		}

		public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
		{
			try
			{
				List<T> list = new List<T>();

				foreach (var row in table.AsEnumerable())
				{
					T obj = new T();

					foreach (var prop in obj.GetType().GetProperties())
					{
						try
						{
							PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
							propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
						}
						catch
						{
							continue;
						}
					}

					list.Add(obj);
				}

				return list;
			}
			catch
			{
				return null;
			}
		}
	}
}