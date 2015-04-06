﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TacViewLib.LinkSpecific.Surveillance.TearDown
{
    public partial class CloseTrackPropertiesWindow
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_ButtonCLOSE1()
        {
        	Duration OrigDur = repo.FormTrackProperties.ButtonCLOSEInfo.SearchTimeout;
			repo.FormTrackProperties.ButtonCLOSEInfo.SearchTimeout = 1000;			       	
        	
        	if (repo.FormTrackProperties.ButtonCLOSEInfo.Exists())
        	{
            	Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTrackProperties.ButtonCLOSE' at Center.", repo.FormTrackProperties.ButtonCLOSEInfo, new RecordItemIndex(-1));
            	repo.FormTrackProperties.ButtonCLOSE.Click();
        	}
        	
        	repo.FormTrackProperties.ButtonCLOSEInfo.SearchTimeout = OrigDur;
        }

    }
}