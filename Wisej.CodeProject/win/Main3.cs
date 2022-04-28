using System;
using Wisej.Web;
using System.Threading;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using DataClass;
using static Wisej.CodeProject.DataSet1;
using Wisej.Web.Ext.FullCalendar;

namespace Wisej.CodeProject
{
	public partial class Main3 : Form
	{
		MyDesktop myDesktop { get; set; }

		public Main3()
		{
			var t1 = new Wisej.Web.MenuItem();
			InitializeComponent();

			this.button1.Enabled = true;
			this.button2.Enabled = false;

			this.WindowState = FormWindowState.Maximized;
			myDesktop  = (MyDesktop)Application.Desktop;
		}

		private void Main_Load(object sender, EventArgs e)
		{
			this.fullCalendar1.CurrentDate = DateTime.Now.Date;
			this.fullCalendar1.View = ViewType.AgendaWeek;

			this.fullCalendar1.Events.Add(new Event()
			{
				Id = "Event1",
				Start = DateTime.Now,
				End = DateTime.Now.AddHours(1),
				Title = "Try Wisej!",
				ClassName = "Other"
			});

		}


		#region // 버튼 처리 
		private void button1_Click(object sender, EventArgs e)
        {
		}

		Guid guid { get; set; } = Guid.Empty;

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{
			this.fullCalendar1.CurrentDate = e.Start;
		}

		private void fullCalendar1_EventDoubleClick(object sender, EventClickEventArgs e)
		{
			// edit the event
			using (EventEditor editor = new EventEditor())
			{
				editor.eventEntry = e.Event;
				editor.ShowDialog(this.FindForm());
			}
		}


        #endregion

        private void fullCalendar1_DayDoubleClick(object sender, DayClickEventArgs e)
        {
			// create an empty event
			Wisej.Web.Ext.FullCalendar.Event ev = new Event();
			ev.Start = e.Day;
			ev.End = e.Day.AddHours(0.5);

			// show the editor
			using (EventEditor editor = new EventEditor())
			{
				editor.eventEntry = ev;
				if (editor.ShowDialog(this.FindForm()) == DialogResult.OK)
					this.fullCalendar1.Events.Add(ev);
			}
			return;
		}
	}
}
