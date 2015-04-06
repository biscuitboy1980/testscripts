/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/19/2011
 * Time: 4:32 PM
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
    /// Description of FiveDigitUnit.
    /// </summary>
    [TestModule("E8A538F6-2E98-46C4-B122-8D9686B6A020", ModuleType.UserCode, 1)]
    public class FiveDigitUnit : ITestModule
    {
    	
    	string _Con2 = "Default Value";
    	[TestVariable("63525712-7E84-4A75-B2AD-2E770E07096C")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("8C5EB6DF-730E-42DF-A47D-3AB805FDD636")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FiveDigitUnit()
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
            
            TacViewLib.LinkSpecific.TNAccountability.UnitValidate.Instance.Connection2 = Con2;
            
            int x = Convert.ToInt32(NumberOfRepeats);
           	int y = 0;
            
            	while (x > y)
            	{
            		SystemManagerLib.LinkSpecific.TNAccountability.Five_Digit_JU.Start();
            		TacViewLib.LinkSpecific.TNAccountability.UnitValidate.Start();
	            	y ++;
            	}
        }
    }
}
