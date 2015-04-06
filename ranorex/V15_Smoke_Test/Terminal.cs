/*
 * Created by Ranorex
 * User: gguenther
 * Date: 7/26/2011
 * Time: 3:20 PM
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
    /// Description of Terminal.
    /// </summary>
    [TestModule("8EE8B985-FA08-4B0E-B66F-D7C6821E5665", ModuleType.UserCode, 1)]
    public class Terminal : ITestModule
    {
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Terminal()
        {
            SystemManagerLib.LinkSpecific.TurnLinkON.Terminal = true;
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
