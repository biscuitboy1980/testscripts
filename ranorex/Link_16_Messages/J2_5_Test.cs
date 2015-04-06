/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/12/2011
 * Time: 7:34 PM
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
    /// Description of J2_5_Test.
    /// </summary>
    [TestModule("88C309B3-6FB9-4060-B782-82B22E2CAB48", ModuleType.UserCode, 1)]
    public class J2_5_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("C249C23D-F41A-44D8-B6DA-6AB19C3F4253")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _CommunicatingScripts = "Default Value";
        [TestVariable("F3381839-C82E-4431-8900-8D6819A0D2E9")]
        public string CommunicationScripts
        {
        	get { return _CommunicatingScripts; }
        	set { _CommunicatingScripts = value; }
        }
        
        string _TestRole = "Default Value";
        [TestVariable("E3157174-FBDA-4353-8401-079FEF240D49")]
        public string TestRole
        {
        	get { return _TestRole; }
        	set { _TestRole = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("A5E07246-BAA5-49E7-98A8-AAC4997F5042")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("39D6C828-1A6F-4B47-B5C6-AB9CDED76C87")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J2_5_Test()
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
            		SystemManagerLib.LinkSpecific.PPLIRegression.J2_5PPLI.J2_5CreateSite.Start();
            		TacViewLib.LinkSpecific.PPLIRegression.J2_5PPLI.J2_5ValidateSite.Instance.connection1 = Con1;
            		TacViewLib.LinkSpecific.PPLIRegression.J2_5PPLI.J2_5ValidateSite.Instance.connection2 = Con2;
            		TacViewLib.LinkSpecific.PPLIRegression.J2_5PPLI.J2_5ValidateSite.Start();
	            	y ++;
            	}
            
        }
    }
}
