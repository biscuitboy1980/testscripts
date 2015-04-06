/*
 * Created by Ranorex
 * User: kbadura
 * Date: 8/29/2011
 * Time: 10:22 AM
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

namespace Link_16_Messages
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("6B5758F9-4C2D-4082-A6F4-623F5B97C2F7", ModuleType.UserCode, 1)]
    public class J7_2_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>

        string _NumberOfRepeats = "Default Value";
        [TestVariable("B6174DA9-D35D-4CF8-93C6-BFEA5D66B102")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        public J7_2_Test()
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
            	TacViewLib.LinkSpecific.TrackManagement.Correlation.Create1stTrack.Start();
            	TacViewLib.LinkSpecific.TrackManagement.Correlation.Create2ndTrack.Start();            	
				TacViewLib.LinkSpecific.TrackManagement.Correlation.CorrelateTracks.Start();               	
				TacViewLib.LinkSpecific.TrackManagement.Correlation.ValidateCorrelation.Start();
            	y ++;
            }
        }
    }
}
