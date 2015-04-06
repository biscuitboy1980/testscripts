/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/12/2011
 * Time: 5:55 PM
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
    /// Description of J2_0_Test.
    /// </summary>
    [TestModule("6F794D8E-6609-443A-A44D-BD99205FAAA1", ModuleType.UserCode, 1)]
    public class J2_0_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("F8DC0AA1-0678-419D-92BB-6AA1A0D1A5FC")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _CommunicatingScripts = "Default Value";
        [TestVariable("B01316CD-39C2-4957-AEEA-2BCDC9C4A5FE")]
        public string CommunicationScripts
        {
        	get { return _CommunicatingScripts; }
        	set { _CommunicatingScripts = value; }
        }
        
        string _TestRole = "Default Value";
        [TestVariable("5800EFC0-324B-41F9-9A81-5E07FAFA17D3")]
        public string TestRole
        {
        	get { return _TestRole; }
        	set { _TestRole = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("89923A98-B749-4D52-B168-D6058F9BB880")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("0CD2C433-E386-488A-A1CA-C57A14DFCAFA")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J2_0_Test()
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

//			TacViewLib.LinkSpecific.PPLIRegression.J2_0PPLI.J2_0ValidateSite.Instance.connection1 = Con1;
//			TacViewLib.LinkSpecific.PPLIRegression.J2_0PPLI.J2_0ValidateSite.Instance.connection2 = Con2;
//            
            int x = Convert.ToInt32(NumberOfRepeats);
           	int y = 0;
            
            	while (x > y)
            	{
            		SystemManagerLib.LinkSpecific.PPLIRegression.J2_0PPLI.J2_0CreateSite.Start();
            		TacViewLib.LinkSpecific.PPLIRegression.J2_0PPLI.J2_0ValidateSite.Instance.connection1 = Con1;
					TacViewLib.LinkSpecific.PPLIRegression.J2_0PPLI.J2_0ValidateSite.Instance.connection2 = Con2;
            		TacViewLib.LinkSpecific.PPLIRegression.J2_0PPLI.J2_0ValidateSite.Start();
	            	y ++;
            	}
            
        }
    }
}
