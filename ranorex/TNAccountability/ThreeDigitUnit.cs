/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/19/2011
 * Time: 4:19 PM
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
    /// Description of ThreeDigitUnit.
    /// </summary>
    [TestModule("9567A27B-111D-4F57-9902-88C59EBEFF58", ModuleType.UserCode, 1)]
    public class ThreeDigitUnit : ITestModule
    {
    	
        string _Con2 = "Default Value";
        [TestVariable("EC46A949-73F3-427D-9D8B-E30CCBD9E3E6")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("F75D6F0F-6BEB-4294-8376-8DA9BD31E34F")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
    	
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ThreeDigitUnit()
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
            		SystemManagerLib.LinkSpecific.TNAccountability.Three_Digit_JU.Start();
            		TacViewLib.LinkSpecific.TNAccountability.UnitValidate.Start();
	            	y ++;
            	}
        }
    }
}
