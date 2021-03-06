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
using Ranorex.Core.Testing;

namespace TacViewLib.LinkSpecific.Surveillance.EW.CreateTrack
{
    public partial class CreateEWTrackL16_L11
    {
		public static int TCount;
		
		//************************************************************************************//
		//*********************************Gets Track Count***********************************//
		//************************************************************************************//
		
		public void GetTrackCount()
		{			
			Ranorex.Container cont1 = repo.FormTacViewC2.ContainerRvView;
			IList<Picture> list1 = cont1.Find<Picture>(@"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']");
			TCount = list1.Count;		    
		}			
		
		//************************************************************************************//
		//******************************Randomly Plots a Track********************************//
		//************************************************************************************//		
		
		public void RandCoord()
		{	
			CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			SharedFunctions.RandCoord();
		}					
		
		//************************************************************************************//
		//*********************************Gets Track Number**********************************//
		//************************************************************************************//
		
		public void GetTrackNum()			
		{			
		    TCount++;
		    Accessible pic1 = @"/form[@title~'^TacViewC2\ \ \ \(map:\ .*']/element/container/picture[@accessiblevalue='Track']" + "[" + TCount + "]";
		    Accessible accElement = new Accessible(pic1);
			string track1 = accElement.Name;
	  		Report.Info("Track Number = " + track1);
	 		ValidateTrack.ValidateEWTrackL16_L11.TrackNum = track1;
	  		Drop_Track.DropTrack.TrackNum = track1;   	 
		}
		
		//**************************************************************************************//
		//*****************************Ranorex Generated Init Method****************************//
		//**************************************************************************************//
		
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}
	}
}
