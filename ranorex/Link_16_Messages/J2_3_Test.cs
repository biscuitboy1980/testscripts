/*
 * Created by Ranorex
 * User: gguenther
 * Date: 10/12/2011
 * Time: 7:18 PM
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
    /// Description of J2_3_Test.
    /// </summary>
    [TestModule("F93FF358-F7A7-4629-A413-35ECC6678BB4", ModuleType.UserCode, 1)]
    public class J2_3_Test : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        
        string _NumberOfRepeats = "Default Value";
        [TestVariable("8A2F80D9-96AE-496D-BE48-42960F9E70E4")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _CommunicatingScripts = "Default Value";
        [TestVariable("06A36124-2792-4040-98DF-EB4569EA4CF9")]
        public string CommunicationScripts
        {
        	get { return _CommunicatingScripts; }
        	set { _CommunicatingScripts = value; }
        }
        
        string _TestRole = "Default Value";
        [TestVariable("49EFD974-2CC2-463F-BFF7-D8C8211C3CA6")]
        public string TestRole
        {
        	get { return _TestRole; }
        	set { _TestRole = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("1723816F-00D2-4166-B795-FABACFE8EF75")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("D0A5BE39-C9AA-488F-AEB9-A99D4187138E")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J2_3_Test()
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
            		SystemManagerLib.LinkSpecific.PPLIRegression.J2_3PPLI.J2_3CreateSite.Start();
            		TacViewLib.LinkSpecific.PPLIRegression.J2_3PPLI.J2_3ValidateSite.Instance.connection1 = Con1;
           			TacViewLib.LinkSpecific.PPLIRegression.J2_3PPLI.J2_3ValidateSite.Instance.connection2 = Con2;
            		TacViewLib.LinkSpecific.PPLIRegression.J2_3PPLI.J2_3ValidateSite.Start();
	            	y ++;
            	}
            
            
            
            
        }
    }
}
