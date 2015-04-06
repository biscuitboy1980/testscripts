/*
 * Created by Ranorex
 * User: gguenther
 * Date: 2/1/2012
 * Time: 10:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace TNAccountability
{
    /// <summary>
    /// Description of TNBLK2.
    /// </summary>
    [TestModule("937D5354-CF74-469D-8919-FAC0E8358634", ModuleType.UserCode, 1)]
    public class TNBLK2 : ITestModule
    {
    	
    	string _Con1 = "Default Value";
    	[TestVariable("0F604F26-11C4-4ECE-A563-2A1A49061814")]
    	public string Con1
    	{
    		get { return _Con1; }
    		set { _Con1 = value; }
    	}
    	
    	string _Con2 = "Default Value";
    	[TestVariable("4C44A1F5-149D-4E11-8891-47F93AF88640")]
    	public string Con2
    	{
    		get { return _Con2; }
    		set { _Con2 = value; }
    	}
    	
    	string _NumberOfRepeats = "Default Value";
    	[TestVariable("573D6C65-1A10-40B8-BFA7-CD1B3E03B36A")]
    	public string NumberOfRepeats
    	{
    		get { return _NumberOfRepeats; }
    		set { _NumberOfRepeats = value; }
    	}
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TNBLK2()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            
            int x = Convert.ToInt32(NumberOfRepeats);
           	int y = 0;
            
            	while (x > y)
            	{
            		SystemManagerLib.LinkSpecific.TNAccountability.TNBLK2.Start();
					TacViewLib.LinkSpecific.TNAccountability.TNBLKValidate.Instance.connection1 = Con1;
					TacViewLib.LinkSpecific.TNAccountability.TNBLKValidate.Instance.Connection2 = Con2;
            		TacViewLib.LinkSpecific.TNAccountability.TNBLKValidate.Start();
	            	y ++;
            	}            
            
        }
    }
}
