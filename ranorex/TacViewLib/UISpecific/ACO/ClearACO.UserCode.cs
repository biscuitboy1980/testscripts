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
	/// The ClearACO recording.
	/// </summary>
	public partial class ClearACO
	{
		static ClearACO()
		{
			//Your recording specific initialization code goes here.
		}

		public void Validate_ACM_Overlays__0_overlays()
		{
			Report.Info("Validating AttributeEqual (Title='ACM Overlays (0 overlays)') on item 'Overlays.ACM_Overlays_607_overlays.ACM_Overlays_607_overlays'.");
			Validate.Attribute(repo.Overlays.FormACM_Overlays__0_overlays.FormACM_Overlays__0_overlaysInfo, "Title", "ACM Overlays (0 overlays)", Validate.DefaultMessage, false);
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}
