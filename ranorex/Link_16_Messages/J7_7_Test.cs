/*
 * Created by Ranorex
 * User: kbadura
 * Date: 8/31/2011
 * Time: 1:29 PM
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

namespace Link_16_Messages
{
    /// <summary>
    /// Description of J7_7_Test.
    /// </summary>
    [TestModule("CACDD14C-46BB-4D4D-AFE7-77F6215B642A", ModuleType.UserCode, 1)]
    public class J7_7_Test : ITestModule
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
        
        public J7_7_Test()
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
            	TacViewLib.LinkSpecific.Weapons.Association.Create1stTrack.Start();
            	TacViewLib.LinkSpecific.Weapons.Association.Create2ndTrack.Start();      
            	TacViewLib.LinkSpecific.Weapons.Association.AssociateTracks.Start();
            	TacViewLib.LinkSpecific.Weapons.Association.ValidateAssociation.Start();
            	y ++;
            }
        }
    }
}
