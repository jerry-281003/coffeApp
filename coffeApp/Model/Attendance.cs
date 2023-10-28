using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp.Model
{
	public class Attendance
	{
		public int AttendanceId { get; set; }
		public int StaffId { get; set;}
		public string Status { get; set; }
		public DateTime DateTime { get; set; }
	}
}
