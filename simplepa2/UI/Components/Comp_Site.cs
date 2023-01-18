using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows;
using Wisej.Base;
using Wisej.Web;
using static simplepa2.DataSet1;

namespace simplepa2.UI.Components
{
    public partial class Comp_Site : Wisej.Web.UserControl
    {
        public Comp_Site()
        {
            InitializeComponent();
        }

        public void reDraw()
        {
			this.cb_SiteName.DataSource = null;
			this.cb_SiteName.DataSource = _dataSet;
			if(this.cb_SiteName.Items.Count > 0)
				this.cb_SiteName.SelectedIndex = 0;
		}

		/// <summary>
		/// Returns or sets the indentation in pixels for child items.
		/// </summary>
		[ResponsiveProperty]
		[DefaultValue(0)]
		public List<string> dataSet
		{
			get { return this._dataSet; }
			set
			{
				if (this._dataSet != value)
				{
					this._dataSet = value;
				}
			}
		}
		private List<string> _dataSet = null;

        public string selectedItem { get; set; }

        [Description("Fired when the user clicks.")]
		public event EventHandler SelectedValueChanged;

		private void cb_SiteName_SelectedValueChanged(object sender, EventArgs e)
        {
			try
			{
				selectedItem = this.cb_SiteName.SelectedItem as string; 
				//string selectedItem = ((this.cb_SiteName.SelectedItem as DataRowView).Row as DataSet1.EMServerWithWholeColRow).EMNAME;
				this.SelectedValueChanged?.Invoke(selectedItem, e);
			}
			catch (Exception e1)
			{ 
				gweb.Log(e1.Message);
			}
		}

		protected virtual void OnSelectedValueChanged(EventArgs e)
		{
			this.SelectedValueChanged?.Invoke(this, e);
		}
	}
}
