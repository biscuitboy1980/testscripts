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
using Microsoft.Win32;

using Ranorex;
using Ranorex.Core;

namespace TacViewLib.UISpecific.Setup
{
	/// <summary>
	/// The Setup recording.
	/// </summary>
	public partial class Setup
	{
		static Setup()
		{
		string regKey="Software\\Ultra Electronics Inc\\TacViewC2\\";
		Registry.CurrentUser.DeleteSubKeyTree(regKey);
		}

	}
}