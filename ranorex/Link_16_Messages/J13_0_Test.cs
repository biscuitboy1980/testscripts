/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/20/2011
 * Time: 2:23 PM
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
    /// Description of J13_0_Test.
    /// </summary>
    [TestModule("0E7561AF-DBCB-4A45-8FAC-5DCAE4116F2E", ModuleType.UserCode, 1)]
    public class J13_0_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>

        string _NumberOfRepeats = "Default Value";
        [TestVariable("DA4CD80F-C1CA-4071-9850-28923A7D6235")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("3E13C4B9-3C65-4886-A211-5B294B578DB7")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("76834BE2-8F7D-4C29-96F5-08CF70E4C516")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J13_0_Test()
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
            
            TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.CreateAirfieldLandTrack.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.CreateAirfieldLandTrack.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.CreateAirfieldStatus.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.CreateAirfieldStatus.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.ValidateAirfieldStatus.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.ValidateAirfieldStatus.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.TrackManagement.DropTrack.DropTrack.Instance.Connection1 = Con1;
           
            int x = Convert.ToInt32(NumberOfRepeats);
            int y = 0;
            
            while (x > y)
            {
            	TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.CreateAirfieldLandTrack.Start();
            	TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.CreateAirfieldStatus.Start();
            	TacViewLib.LinkSpecific.TrackManagement.AirfieldStatus.ValidateAirfieldStatus.Start();
               	y ++;
            }
        }
    }
}
