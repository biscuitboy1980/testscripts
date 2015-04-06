/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/12/2011
 * Time: 7:40 PM
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
    /// Description of J2_6_Test.
    /// </summary>
    [TestModule("7A9D2245-E33E-4B97-890F-140C21FB71BC", ModuleType.UserCode, 1)]
    public class J2_6_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("3FD506D2-0283-42CB-A355-5A4F6A01BF29")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _CommunicatingScripts = "Default Value";
        [TestVariable("CE598ABB-B1CA-45EA-A456-BD29DF869CA1")]

        public string CommunicationScripts
        {
        	get { return _CommunicatingScripts; }
        	set { _CommunicatingScripts = value; }
        }
        
        string _TestRole = "Default Value";
        [TestVariable("84A10612-0CCF-4945-A9FF-2F12A09D1760")]
        public string TestRole
        {
        	get { return _TestRole; }
        	set { _TestRole = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("B4DD14C6-D47D-4FCA-804F-D8453ACB1D92")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("B551949E-4DA1-4F69-9D74-01FEF56865BE")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J2_6_Test()
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
            		SystemManagerLib.LinkSpecific.PPLIRegression.J2_6PPLI.J2_6CreateSite.Start();
            		TacViewLib.LinkSpecific.PPLIRegression.J2_6PPLI.J2_6ValidateSite.Instance.connection1 = Con1;
					TacViewLib.LinkSpecific.PPLIRegression.J2_6PPLI.J2_6ValidateSite.Instance.connection2 = Con2;
            		TacViewLib.LinkSpecific.PPLIRegression.J2_6PPLI.J2_6ValidateSite.Start();
	            	y ++;
            	}
            
        }
    }
}
