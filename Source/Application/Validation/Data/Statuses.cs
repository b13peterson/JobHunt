using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.Data
{
	public static class Statuses
	{
		public static List<string> Names = new List<string>()
		{
			"APPLIED",
			"REJECTED",
			"DECLINED",
			"ACCEPTED",
			"OFFERED",
			"CODE CHALLENGE",
			"INTERVIEW",
			"MESSED UP",
			"PHONE CALL",
			"UNDER REVIEW"
		};
	}
}
