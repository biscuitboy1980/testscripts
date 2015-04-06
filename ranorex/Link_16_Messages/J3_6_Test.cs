/*
 * Created by Ranorex
 * User: kbadura
 * Date: 7/20/2011
 * Time: 2:18 PM
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
    /// Description of J3_6_Test.
    /// </summary>
    [TestModule("32A27EFB-2878-49BA-AAAE-9083FE38D179", ModuleType.UserCode, 1)]
    public class J3_6_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>

        string _NumberOfRepeats = "Default Value";
        [TestVariable("D35A4CDE-C8A4-4BDE-A298-0203C4A26A3F")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("FEBEE2AF-1DD5-48B9-AEE7-BE34127ED76D")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("53F62C6D-B9F6-415C-9063-13E5F3E8D053")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J3_6_Test()
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
            
            TacViewLib.LinkSpecific.Surveillance.Space.CreateTrack.SpaceCreateTrackRegression.Instance.connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Space.ValidateTrack.SpaceValidateTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Instance.Connection1 = Con1;
           
            int x = Convert.ToInt32(NumberOfRepeats);
            int y = 0;
            
            while (x > y)
            {
            	TacViewLib.LinkSpecific.Surveillance.Space.CreateTrack.SpaceCreateTrackRegression.Start();
            	TacViewLib.LinkSpecific.Surveillance.Space.ValidateTrack.SpaceValidateTrackRegression.Start();
            	y ++;
            }
        }
    }
}
