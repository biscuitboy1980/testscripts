/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/20/2011
 * Time: 2:04 PM
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
    /// Description of J3_0_Test.
    /// </summary>
    [TestModule("53FC6D96-E4D5-43C0-BA85-ACAB3F116E38", ModuleType.UserCode, 1)]
    public class J3_0_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>

        string _NumberOfRepeats = "Default Value";
        [TestVariable("B93C28AD-3A92-4ACF-AD51-001FD1C25F4D")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }    
        
        string _Con1 = "Default Value";
        [TestVariable("22FFD745-03CE-4B42-9DE4-9379AE378668")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("9844E434-8691-45B5-8266-6146EE4A0A36")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        

 
        public J3_0_Test()
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
           
            TacViewLib.LinkSpecific.Surveillance.Reference.CreateTrack.ReferenceCreateSpaceTrackRegression.Instance.connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Reference.CreateTrack.ReferenceCreateSpaceTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Reference.CreateTrack.ReferenceCreateTrackRegression.Instance.connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Reference.CreateTrack.ReferenceCreateTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Reference.ValidateTrack.ReferenceValidateTrackRegression.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Reference.ValidateTrack.ReferenceValidateTrackRegression.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Reference.ValidateTrack.DropSpaceTrackRegression.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Reference.ValidateTrack.DropSpaceTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack4Space.Instance.Connection1 = Con1;
            
            int x = Convert.ToInt32(NumberOfRepeats);
            int y = 0;
            
            while (x > y)
            {
            	TacViewLib.LinkSpecific.Surveillance.Reference.CreateTrack.ReferenceCreateSpaceTrackRegression.Start();
            	TacViewLib.LinkSpecific.Surveillance.Reference.CreateTrack.ReferenceCreateTrackRegression.Start();
            	TacViewLib.LinkSpecific.Surveillance.Reference.ValidateTrack.ReferenceValidateTrackRegression.Start();
            	TacViewLib.LinkSpecific.Surveillance.Reference.ValidateTrack.DropSpaceTrackRegression.Start();
            	y ++;
            }
        }
    }
}
