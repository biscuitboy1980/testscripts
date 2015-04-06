/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/12/2011
 * Time: 7:26 PM
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
    /// Description of J2_4_Test.
    /// </summary>
    [TestModule("08B64BF7-222F-44DE-8A93-F9289CB1E1A0", ModuleType.UserCode, 1)]
    public class J2_4_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("A71EEA66-41A5-4AF1-B7CC-386568C8EF57")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _CommunicatingScripts = "Default Value";
        [TestVariable("9198CDA4-A10A-42A5-B21E-53D86062A8CF")]
        public string CommunicationScripts
        {
        	get { return _CommunicatingScripts; }
        	set { _CommunicatingScripts = value; }
        }
        
        string _TestRole = "Default Value";
        [TestVariable("B87AEB4C-CF3A-4EBE-A475-19DA9BE8E7AD")]
        public string TestRole
        {
        	get { return _TestRole; }
        	set { _TestRole = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("70DD2950-A21B-4099-844D-B56B1DE53835")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("72BA3856-A6EE-4179-A070-57D18F8DC9F5")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J2_4_Test()
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
            		SystemManagerLib.LinkSpecific.PPLIRegression.J2_4PPLI.J2_4CreateSite.Start();
            		TacViewLib.LinkSpecific.PPLIRegression.J2_4PPLI.J2_4ValidateSite.Instance.connection1 = Con1;
            		TacViewLib.LinkSpecific.PPLIRegression.J2_4PPLI.J2_4ValidateSite.Instance.connection2 = Con2;
            		TacViewLib.LinkSpecific.PPLIRegression.J2_4PPLI.J2_4ValidateSite.Start();
	            	y ++;
            	}
            
        }
    }
}
