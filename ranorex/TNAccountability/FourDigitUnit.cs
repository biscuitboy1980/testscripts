/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/19/2011
 * Time: 4:25 PM
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
    /// Description of FourDigitUnit.
    /// </summary>
    [TestModule("4484186D-FA73-4806-B98A-4F18BE86C615", ModuleType.UserCode, 1)]
    public class FourDigitUnit : ITestModule
    {
    	
    	string _Con2 = "Default Value";
    	[TestVariable("3216223B-56C6-4832-928A-4E7990B0770F")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("8389445B-D392-404A-99D9-65AE11548EF5")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }

        
        public FourDigitUnit()
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
            		SystemManagerLib.LinkSpecific.TNAccountability.Four_Digit_JU.Start();
            		TacViewLib.LinkSpecific.TNAccountability.UnitValidate.Start();
	            	y ++;
            	}
            	
        }
    }
}
