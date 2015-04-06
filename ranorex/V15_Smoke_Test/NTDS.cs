/*
 * Created by Ranorex
 * User: gguenther
 * Date: 7/26/2011
 * Time: 3:49 PM
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

namespace V15_Smoke_Test
{
    /// <summary>
    /// Description of NTDS.
    /// </summary>
    [TestModule("CA937288-AF14-42CD-A0EE-ACEDAAEC29F4", ModuleType.UserCode, 1)]
    public class NTDS : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NTDS()
        {
            SystemManagerLib.LinkSpecific.TurnLinkON.NTDS = true;
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
        }
    }
}
