using Wisej.Web;

namespace Wisej.CustomCellRenderer
{
	public class MyCheckBoxColumn : DataGridViewCheckBoxColumn
	{
		public MyCheckBoxColumn()
		{
			this.CellRenderer = "my.CheckBoxCell";
		}
	}
}