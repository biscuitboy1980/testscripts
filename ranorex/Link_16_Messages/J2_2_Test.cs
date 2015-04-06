/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/12/2011
 * Time: 6:02 PM
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
    /// Description of J2_2_Test.
    /// </summary>
    [TestModule("E798C4E6-3CF4-4AEF-B207-612BB78A7A97", ModuleType.UserCode, 1)]
    public class J2_2_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("8644DB01-F4CB-4E4A-8003-971200B57534")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _CommunicatingScripts = "Default Value";
        [TestVariable("D62750DD-FA6D-49C9-B18A-2611A4FBD812")]
        public string CommunicationScripts
        {
        	get { return _CommunicatingScripts; }
        	set { _CommunicatingScripts = value; }
        }
        
        string _TestRole = "Default Value";
        [TestVariable("44AC68F7-D1C8-4DEC-9536-661E90D4BB4B")]
        public string TestRole
        {
        	get { return _TestRole; }
        	set { _TestRole = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("252A061D-33A1-4811-892A-10BF67D8B19E")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("2F7C74E7-E731-4105-8879-B410E5F98A20")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J2_2_Test()
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
            		SystemManagerLib.LinkSpecific.PPLIRegression.J2_2PPLI.J2_2CreateSite.Start();
            		TacViewLib.LinkSpecific.PPLIRegression.J2_2PPLI.J2_2ValidateSite.Instance.connection1 = Con1;
         			TacViewLib.LinkSpecific.PPLIRegression.J2_2PPLI.J2_2ValidateSite.Instance.connection2 = Con2;
            		TacViewLib.LinkSpecific.PPLIRegression.J2_2PPLI.J2_2ValidateSite.Start();
	            	y ++;
            	}
            
        }
    }
}
