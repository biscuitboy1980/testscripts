﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using Ranorex;
using Ranorex.Core;

namespace TacViewLib.UISpecific.ACO
{
	/// <summary>
	/// The ValidateACOImport recording.
	/// </summary>
	public partial class ValidateACOImport
	{
		static ValidateACOImport()
		{
			//Your recording specific initialization code goes here.
		}

		public void Validate_ACM_Overlays_607_overlays1()
		{
			Report.Info("Validating AttributeEqual (Title='ACM Overlays (607 overlays)') on item 'Overlays.ACM_Overlays_607_overlays.ACM_Overlays_607_overlays'.");
			Validate.Attribute(repo.Overlays.ACM_Overlays.ACM_OverlaysInfo, "Title", "ACM Overlays (607 overlays)", Validate.DefaultMessage, false);
		}

		public void Validate_ACM_Overlays_607_overlays2()
		{
			Report.Info("Validating AttributeEqual (WindowText='ACM Overlays (607 overlays)') on item 'Overlays.ACM_Overlays_607_overlays.ACM_Overlays_607_overlays'.");
			Validate.Attribute(repo.Overlays.ACM_Overlays.ACM_OverlaysInfo, "WindowText", "ACM Overlays (607 overlays)", Validate.DefaultMessage, false);
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}
