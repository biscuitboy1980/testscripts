/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/20/2011
 * Time: 2:13 PM
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
    /// Description of J3_3_Test.
    /// </summary>
    [TestModule("9868EE68-A455-488C-BB02-9E9F05312C17", ModuleType.UserCode, 1)]
    public class J3_3_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
 
        string _NumberOfRepeats = "Default Value";
        [TestVariable("DACFE515-D88F-42F8-945F-857A3A4F393A")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("923A3150-33ED-40F6-BC73-FAF8EC641253")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("C232B55C-BC06-4636-ABE4-3131E97DC56C")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J3_3_Test()
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
           
            TacViewLib.LinkSpecific.Surveillance.Surface.CreateTrack.SurfaceCreateTrackRegression.Instance.connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Surface.ValidateTrack.SurfaceValidateTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Instance.Connection1 = Con1;
            
            int x = Convert.ToInt32(NumberOfRepeats);
            int y = 0;
            
            while (x > y)
            {
            	TacViewLib.LinkSpecific.Surveillance.Surface.CreateTrack.SurfaceCreateTrackRegression.Start();
            	TacViewLib.LinkSpecific.Surveillance.Surface.ValidateTrack.SurfaceValidateTrackRegression.Start();
            	y ++;
            }
        }
    }
}
