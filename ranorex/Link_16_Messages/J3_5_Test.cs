/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/20/2011
 * Time: 2:16 PM
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

namespace Link_16_Regression
{
    /// <summary>
    /// Description of J3_5_Test.
    /// </summary>
    [TestModule("2645BD62-AABB-4D13-881D-A422F0E499B2", ModuleType.UserCode, 1)]
    public class J3_5_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>

        string _NumberOfRepeats = "Default Value";
        [TestVariable("6D265041-4437-44B2-876C-BF238C858A9D")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("C63E69E8-4027-4E3D-8ED7-0568CAF95D9E")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("FFA35292-6574-49F5-B648-528530B4320F")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
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
           
            TacViewLib.LinkSpecific.Surveillance.Land.CreateTrack.LandCreateTrackRegression.Instance.connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Land.ValidateTrack.LandValidateTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Instance.Connection1 = Con1;
            
            int x = Convert.ToInt32(NumberOfRepeats);
            int y = 0;
            
            while (x > y)
            {
            	TacViewLib.LinkSpecific.Surveillance.Land.CreateTrack.LandCreateTrackRegression.Start();
            	TacViewLib.LinkSpecific.Surveillance.Land.ValidateTrack.LandValidateTrackRegression.Start();
            	y ++;
            }
        }
    }
}
