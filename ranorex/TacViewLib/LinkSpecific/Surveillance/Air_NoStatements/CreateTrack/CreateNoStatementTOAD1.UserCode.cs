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

namespace TacViewLib.LinkSpecific.Surveillance.Air_NoStatements.CreateTrack
{
	/// <summary>
	/// The CreateTrack recording.
	/// </summary>
	
	
		//************************************************************************************//
		//**************Default values to enter for track if csv file not present*************//
		//************************************************************************************//
	
	public partial class CreateNoStatementTOAD1
	{
		public static string ID = "Hostile";
		public static string Plat = "Bomber";
		public static string Act = "Escorting";
		public static string Stype = "F-15 EAGLE";
		
        
		//************************************************************************************//
		//***************************Enters Identity Value************************************//
		//************************************************************************************//
		
		public void IDval()
		{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == ID )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}
		
		//************************************************************************************//
		//****************************Enters Platform Value***********************************//
		//************************************************************************************//
		
		public void Platval()
		{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Plat )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}

		//************************************************************************************//
		//****************************Enters Activity Value***********************************//
		//************************************************************************************//
		
		public void Actval()
		{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Act )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}

		//************************************************************************************//
		//***************************Enters Specific Type Value*******************************//
		//************************************************************************************//
		
		public void Stypeval()
		{
			Keyboard.Press("{LMenu down}{Down}{LMenu up}");
	       	foreach( ListItem item in repo.ListRealView.Self.Items )
        	{
           		if ( item.Text == Stype )
           		{
            	item.Select();
            	item.Click();
               	break;        
           		}           		
        	}
		}
		
		//************************************************************************************//
		//********************Validates the created track is dropped**************************//
		//************************************************************************************//
		
		public void ValidateDropTrack()
		{
		Delay.Milliseconds(1500, false);
		if (repo.FormTacViewC2.PictureTrackCreateDropInfo.Exists())
			{
				TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Start();
			}
		}

		static CreateNoStatementTOAD1()
		{
			//Your recording specific initialization code goes here.
		}

		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

	}
}
