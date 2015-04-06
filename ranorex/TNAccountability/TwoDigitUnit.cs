/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/19/2011
 * Time: 4:07 PM
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
    /// Description of TwoDigitUnit.
    /// </summary>
    [TestModule("1F2DDF01-AD3E-4FD1-90EF-C81049462289", ModuleType.UserCode, 1)]
    public class TwoDigitUnit : ITestModule
    {
        
        string _Con2 = "Default Value";
        [TestVariable("8EC9EAB9-0E37-463B-B0BB-781645133925")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("EAECC0CA-16CD-4F33-A5F4-B1AA446C651A")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TwoDigitUnit()
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
            		SystemManagerLib.LinkSpecific.TNAccountability.Two_Digit_JU.Start();
            		TacViewLib.LinkSpecific.TNAccountability.UnitValidate.Start();
	            	y ++;
            	}
        }
    }
}
