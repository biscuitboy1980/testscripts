/*
 * Created by Ranorex
 * User: gguenther
 * Date: 7/13/2011
 * Time: 11:19 AM
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
    /// Description of J3_2_Test.
    /// </summary>
    [TestModule("E9A66854-79A2-4358-B135-79E84FC63C24", ModuleType.UserCode, 1)]
    public class J3_2_Test: ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// 
        string _NumberOfRepeats = "Default Value";
        [TestVariable("BA524B0F-D6E0-4C17-8048-F6329F80D98F")]
        public string NumberOfRepeats
        {
        	get { return _NumberOfRepeats; }
        	set { _NumberOfRepeats = value; }
        }
        
        string _CommunicatingScripts = "Default Value";
        [TestVariable("70B22B1A-D0EF-4D72-BC2B-5B85101BB231")]
        public string CommunicationScripts
        {
        	get { return _CommunicatingScripts; }
        	set { _CommunicatingScripts = value; }
        }
        
        string _TestRole = "Default Value";
        [TestVariable("2C36025D-929B-4A89-8D9A-879D1C98C24D")]
        public string TestRole
        {
        	get { return _TestRole; }
        	set { _TestRole = value; }
        }
        
        string _Con1 = "Default Value";
        [TestVariable("487A679B-6B25-4B50-AC5C-389D554784F1")]
        public string Con1
        {
        	get { return _Con1; }
        	set { _Con1 = value; }
        }
        
        string _Con2 = "Default Value";
        [TestVariable("577A3FE2-BD5F-415B-9EC9-6671BDA34A3A")]
        public string Con2
        {
        	get { return _Con2; }
        	set { _Con2 = value; }
        }
        
        public J3_2_Test()
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
            
            TacViewLib.LinkSpecific.Surveillance.Air.CreateTrack.AirCreateTrackRegression.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Air.CreateTrack.AirCreateTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Air.ValidateTrack.AirValidateTrackRegression.Instance.Connection1 = Con1;
            TacViewLib.LinkSpecific.Surveillance.Air.ValidateTrack.AirValidateTrackRegression.Instance.Connection2 = Con2;
            TacViewLib.LinkSpecific.Surveillance.Drop_Track.DropTrack.Instance.Connection1 = Con1;
            
            if (CommunicationScripts == "yes")
            {
//            	CommonUtilLib.CreateSocket.Start();
            	
            	if (TestRole == "Injector")
            	{
            	int x = Convert.ToInt32(NumberOfRepeats);
            	int y = 0;
            
	            	while (x > y)
	            	{
//	            		CommonUtilLib.Server.currentstate = "1";
		            	TacViewLib.LinkSpecific.Surveillance.Air.CreateTrack.AirCreateTrackRegression.Start();
//		            	CommonUtilLib.Server.currentstate = "2";
		            	y ++;
	            	}
            	}
            	
            	else if (TestRole == "Validator")
            	{
            	int x = Convert.ToInt32(NumberOfRepeats);
            	int y = 0;
            
	            	while (x > y)
	            	{
//	            		CommonUtilLib.TCPStream.currentstate = "3";
		            	TacViewLib.LinkSpecific.Surveillance.Air.ValidateTrack.AirValidateTrackRegression.Start();
//		            	CommonUtilLib.TCPStream.currentstate = "4";
		            	y ++;
	            	}
            	}
            	
//            	CommonUtilLib.TCPStream.currentstate = "5";
            }
 	
            else
            {            
                int x = Convert.ToInt32(NumberOfRepeats);
            	int y = 0;
            
            	while (x > y)
            	{
	            	TacViewLib.LinkSpecific.Surveillance.Air.CreateTrack.AirCreateTrackRegression.Start();
	            	TacViewLib.LinkSpecific.Surveillance.Air.ValidateTrack.AirValidateTrackRegression.Start();
	            	y ++;
            	}
            }
            

        }
    }
}
