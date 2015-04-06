/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/20/2011
 * Time: 2:15 PM
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
    /// Description of J3_4_Test.
    /// </summary>
    [TestModule("6890B85E-EFF1-469F-9793-CD30CE7C7D52", ModuleType.UserCode, 1)]
    public class J3_4_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("950FF741-0F68-4E12-A7AC-F069801B067D")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("7DDE3BEE-BEA3-4B47-ADF9-944B91A79F13")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("7F50DCE2-CE49-4B18-AD24-0A8908300713")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J3_4_Test()
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
            
            TacViewLib.LinkSpecific.Surveillance.Subsurface.CreateTrack.SubsufaceCreateTrackRegression.Instance.connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Subsurface.ValidateTrack.SubsurfaceValidateTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Instance.Connection1 = Con1;
            
           
            int x = Convert.ToInt32(NumberOfRepeats);
            int y = 0;
            
            while (x > y)
            {
            	TacViewLib.LinkSpecific.Surveillance.Subsurface.CreateTrack.SubsufaceCreateTrackRegression.Start();
            	TacViewLib.LinkSpecific.Surveillance.Subsurface.ValidateTrack.SubsurfaceValidateTrackRegression.Start();
            	y ++;
            }
        }
    }
}
