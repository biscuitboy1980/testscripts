/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/20/2011
 * Time: 2:21 PM
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
    /// Description of J17_0_Test.
    /// </summary>
    [TestModule("8340966E-4D2F-4674-97AE-41C73928E91A", ModuleType.UserCode, 1)]
    public class J17_0_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("760BE91B-6357-4578-BF77-B1F7B897A4E2")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("4B3787C0-8235-401F-83C4-B02B266B5752")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("EC0C6EB9-C270-47D2-A515-F4E3599FF583")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        
        public J17_0_Test()
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
            
            TacViewLib.LinkSpecific.TrackManagement.WeatherOverTarget.CreateTargetTrack.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.TrackManagement.WeatherOverTarget.CreateWOT.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.TrackManagement.WeatherOverTarget.ValidateWOT.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.TrackManagement.WeatherOverTarget.ValidateWOT.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.TrackManagement.DropTrack.DropTrack.Instance.Connection1 = Con1;
           
            int x = Convert.ToInt32(NumberOfRepeats);
            int y = 0;
            
            while (x > y)
            {
            	TacViewLib.LinkSpecific.TrackManagement.WeatherOverTarget.CreateTargetTrack.Start();
            	TacViewLib.LinkSpecific.TrackManagement.WeatherOverTarget.CreateWOT.Start();
            	TacViewLib.LinkSpecific.TrackManagement.WeatherOverTarget.ValidateWOT.Start();
            	y ++;
            }
        }
    }
}
