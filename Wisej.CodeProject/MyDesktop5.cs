using Wisej.Web;
using System.Threading;
using Wisej.CodeProject.Examples;
using Wisej.CodeProject.Setup;
using Wisej.ChatServer;
using Wisej.CodeProject.SignalR;
using System.Collections.Generic;
using static Wisej.CodeProject.DataSet1;
using System.Linq;
using Microsoft.Ajax.Utilities;
using DataClass;
using System.Drawing;
using Wisej.CodeProject.win;
using System;
using Wisej.Web.Ext.FullCalendar;

namespace Wisej.CodeProject
{
    // 정규 예약 방송 
    public partial class MyDesktop : Desktop
    {
		private void Main_Load52(object sender, EventArgs e)
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