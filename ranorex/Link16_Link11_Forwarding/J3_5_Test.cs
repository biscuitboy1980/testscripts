/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/11/2011
 * Time: 4:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace Link16_Link11_Regression
{
    /// <summary>
    /// Description of J3_5_Test.
    /// </summary>
    [TestModule("71D80C01-A90C-4CD4-9184-00EF560EE9AE", ModuleType.UserCode, 1)]
    public class J3_5_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>

        string _MyTestVariable = "Default Value";
        [TestVariable("03D4A72A-19CE-4114-A677-733529FF5CDB")]
        public string MyTestVariable
        {
        	get { return _MyTestVariable; }
        	set { _MyTestVariable = value; }
        }
        
        public J3_5_Test()
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

            int x = Convert.ToInt32(MyTestVariable);
            int y = 0;
            
            Report.Success("//////////BEGINNING J3.5 LINK16_LINK11 REGRESSION TEST//////////");
            
            while (x > y)
            {
            	TacViewLib.LinkSpecific.Surveillance.Land.CreateTrack.CreateLandTrackL16_L11.Start();
            	TacViewLib.LinkSpecific.Surveillance.Land.ValidateTrack.ValidateLandTrackL16_L11.Start();
            	
            	y++;
            }
            
            Report.Success("//////////J3.5 LINK16_LINK11 REGRESSION TEST COMPLETE//////////");
        }
    }
}
