/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/19/2011
 * Time: 1:56 PM
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
    /// Description of OneDigitUnit.
    /// </summary>
    [TestModule("410D1D97-0151-4652-A2C6-2A60B24589A1", ModuleType.UserCode, 1)]
    public class OneDigitUnit : ITestModule
    {
        
        string _Con2 = "Default Value";
        [TestVariable("A4CEDA56-F347-4724-92D4-612232501C80")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("E7921160-B79A-4E88-9E8E-AD2104FC65E2")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        public OneDigitUnit()
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
            		SystemManagerLib.LinkSpecific.TNAccountability.One_Digit_JU.Start();
            		TacViewLib.LinkSpecific.TNAccountability.UnitValidate.Start();
	            	y ++;
            	}
      
            
        }
    }
}
