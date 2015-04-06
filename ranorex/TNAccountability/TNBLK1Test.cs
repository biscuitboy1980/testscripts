/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/19/2011
 * Time: 5:32 PM
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
    /// Description of TNBLK1Test.
    /// </summary>
    [TestModule("27F2AF6B-294E-4029-9CED-CB3263A6EC83", ModuleType.UserCode, 1)]
    public class TNBLK1Test : ITestModule
    {
    	
    	string _Con1 = "Default Value";
    	[TestVariable("97935D8E-8D14-45A7-9105-8E18C5306A06")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
    	
    	string _Con2 = "Default Value";
    	[TestVariable("C4C7B127-6A03-4883-8F77-AC7BC5B63DD0")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("01F494BD-CFBE-4A7D-8FA2-B9EF5BEF0850")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TNBLK1Test()
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
            		SystemManagerLib.LinkSpecific.TNAccountability.TNBLK1.Start();
					TacViewLib.LinkSpecific.TNAccountability.TNBLKValidate.Instance.connection1 = Con1;
					TacViewLib.LinkSpecific.TNAccountability.TNBLKValidate.Instance.Connection2 = Con2;
            		TacViewLib.LinkSpecific.TNAccountability.TNBLKValidate.Start();
	            	y ++;
            	}
        }
    }
}
