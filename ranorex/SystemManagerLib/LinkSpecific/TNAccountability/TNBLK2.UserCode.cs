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
using System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace SystemManagerLib.LinkSpecific.TNAccountability
{
    public partial class TNBLK2
    {
    	
    	public int LowTNBLK;
    	public int HighTNBLK;
    	
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }


        public void EnterLowTNBLK()
        {
        	CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
			string a = SharedFunctions.Random(4096, 32764);
			string b = SharedFunctions.DecimalToBase(Convert.ToInt32(a), 8);
			TacViewLib.LinkSpecific.TNAccountability.TNBLKValidate.Instance.TNBLKstart = b;
			LowTNBLK = Convert.ToInt32(b);
   			Report.Info("Low TNBLK Entered = " + b);
   			Keyboard.Press(Convert.ToString(b));
        }

        public void EnterHighTNBLK()
        {
        	CommonUtilLib.Util SharedFunctions = new CommonUtilLib.Util();
        	int a = SharedFunctions.BaseToDecimal(Convert.ToString(LowTNBLK), 8);
        	HighTNBLK = a + 2;
         	string b = SharedFunctions.DecimalToBase(HighTNBLK, 8);
			HighTNBLK = Convert.ToInt32(b);
   			Report.Info("High TNBLK Entered = " + b);
   			Keyboard.Press(Convert.ToString(HighTNBLK));
        }

        public void GetOwnUnit()
        {
        	Accessible accElement = new Accessible (repo.FormSystem_Manager___UNCLASS.TextUnit);
        	string UnitNum = accElement.Name;
        	
        	UnitNum = UnitNum.Substring(UnitNum.IndexOf(':') + 1);
        	
        	UnitNum = UnitNum.Trim();
        	
        	Report.Info("Own Unit Number = " + UnitNum);

        	TacViewLib.LinkSpecific.TNAccountability.TNBLKValidate.Instance.ownunit = UnitNum;
        	TacViewLib.LinkSpecific.TNAccountability.DropLocalTracks.Instance.ownunit = UnitNum;
        }

    }
}