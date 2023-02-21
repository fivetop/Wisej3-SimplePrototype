using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using Wisej.Web;

namespace simplepa2
{

	public static class Helper
	{

		public static DataTable Table(this DataGridView dgv)
		{
			DataTable dt;
			if (dgv.DataSource is BindingSource)
				dt = ((BindingSource)dgv.DataSource).Table();
			else if (dgv.DataSource is DataSet)
				dt = ((DataSet)dgv.DataSource).Tables[dgv.DataMember];
			else if (dgv.DataSource is DataTable)
				dt = (DataTable)dgv.DataSource;
			else
				dt = null;
			return dt;
		}

		public static DataTable Table(this BindingSource bs)
		{
			var bsFirst = bs;
			while (bsFirst.DataSource is BindingSource)
				bsFirst = (BindingSource)bsFirst.DataSource;

			DataTable dt;
			if (bsFirst.DataSource is DataSet)
				dt = ((DataSet)bsFirst.DataSource).Tables[bsFirst.DataMember];
			else if (bsFirst.DataSource is DataTable)
				dt = (DataTable)bsFirst.DataSource;
			else
				return null;

			if (bsFirst != bs)
			{
				if (dt.DataSet == null) return null;
				dt = dt.DataSet.Relations[bs.DataMember].ChildTable;
			}

			return dt;
		}

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
							//PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
							//propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

							PropertyInfo p = obj.GetType().GetProperty(prop.Name);
							Type columnType = p.PropertyType;

							if (p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
							{
								// If it is NULLABLE, then get the underlying type. eg if "Nullable<int>" then this will return just "int"
								columnType = p.PropertyType.GetGenericArguments()[0];
							}

							p.SetValue(obj, Convert.ChangeType(row[prop.Name], columnType), null);
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