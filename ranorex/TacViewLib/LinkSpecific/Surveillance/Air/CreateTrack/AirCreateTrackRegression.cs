﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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

namespace TacViewLib.LinkSpecific.Surveillance.Air.CreateTrack
{
    /// <summary>
    /// The AirCreateTrackRegression recording.
    /// </summary>
    [TestModule("4f33e15d-452f-4851-9357-84d9cdde4df5", ModuleType.Recording, 1)]
    public partial class AirCreateTrackRegression : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static AirCreateTrackRegression instance = new AirCreateTrackRegression();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AirCreateTrackRegression()
        {
            Connection1 = "";
            Connection2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AirCreateTrackRegression Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Connection1.
        /// </summary>
        [TestVariable("4b5710a6-6b7b-4dc5-956b-bc64fb7e6bef")]
        public string Connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ownunit.
        /// </summary>
        [TestVariable("ae53e9c2-51e5-48e8-a15d-34d6d9b55ce6")]
        public string ownunit
        {
            get { return repo.ownunit; }
            set { repo.ownunit = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Connection2.
        /// </summary>
        [TestVariable("f096d2ce-3933-482e-90ba-043fa72a0972")]
        public string Connection2
        {
            get { return repo.connection2; }
            set { repo.connection2 = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.1.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.1.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 31;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 8.0;

            Init();

            GetTrackCount();
            Delay.Milliseconds(250);
            
            RandCoord();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRealView.MenuItemCreate_Track' at Center.", repo.FormRealView.MenuItemCreate_TrackInfo, new RecordItemIndex(2));
            repo.FormRealView.MenuItemCreate_Track.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemConnection1' at Center.", repo.FormCreate_Track.MenuItemConnection1Info, new RecordItemIndex(3));
            repo.FormCreate_Track.MenuItemConnection1.Click(100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormConnection1.MenuItemAir' at Center.", repo.FormConnection1.MenuItemAirInfo, new RecordItemIndex(4));
            repo.FormConnection1.MenuItemAir.Click(100);
            Delay.Milliseconds(150);
            
            IDval();
            Delay.Milliseconds(250);
            
            Platval();
            Delay.Milliseconds(250);
            
            Actval();
            Delay.Milliseconds(250);
            
            Stypeval();
            Delay.Milliseconds(250);
            
            Strengthval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemBasic_Track_Info' at CenterLeft.", repo.FormMainCreate.ListItemBasic_Track_InfoInfo, new RecordItemIndex(10));
            repo.FormMainCreate.ListItemBasic_Track_Info.DoubleClick(Location.CenterLeft, 100);
            Delay.Milliseconds(150);
            
            Altitudeval();
            Delay.Milliseconds(250);
            
            Velocityval();
            Delay.Milliseconds(250);
            
            Courseval();
            Delay.Milliseconds(250);
            
            GetMagneticCourse();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemPosition_and_SpeedVelocity' at CenterLeft.", repo.FormMainCreate.ListItemPosition_and_SpeedVelocityInfo, new RecordItemIndex(15));
            repo.FormMainCreate.ListItemPosition_and_SpeedVelocity.DoubleClick(Location.CenterLeft, 100);
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemPosition_Relative_To_Bul' at CenterLeft.", repo.FormMainCreate.ListItemPosition_Relative_To_BulInfo, new RecordItemIndex(16));
            repo.FormMainCreate.ListItemPosition_Relative_To_Bul.DoubleClick(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            TrackQualityval();
            Delay.Milliseconds(250);
            
            ReportingUnitval();
            Delay.Milliseconds(250);
            
            HiPrival();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemInterface_Info' at CenterLeft.", repo.FormMainCreate.ListItemInterface_InfoInfo, new RecordItemIndex(20));
            repo.FormMainCreate.ListItemInterface_Info.DoubleClick(Location.CenterLeft, 100);
            Delay.Milliseconds(150);
            
            Mode1val();
            Delay.Milliseconds(250);
            
            Mode2val();
            Delay.Milliseconds(250);
            
            Mode3val();
            Delay.Milliseconds(250);
            
            Mode4val();
            Delay.Milliseconds(250);
            
            Mode5val();
            Delay.Milliseconds(250);
            
            Mode5Natval();
            Delay.Milliseconds(250);
            
            M5IDval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemMode_Codes_Special_Codes' at CenterLeft.", repo.FormMainCreate.ListItemMode_Codes_Special_CodesInfo, new RecordItemIndex(28));
            repo.FormMainCreate.ListItemMode_Codes_Special_Codes.DoubleClick(Location.CenterLeft, 100);
            Delay.Milliseconds(150);
            
            SPIval();
            Delay.Milliseconds(250);
            
            //PassiveActiveval();
            //Delay.Milliseconds(250);
            
            SpecialIntval();
            Delay.Milliseconds(250);
            
            Hourval();
            Delay.Milliseconds(250);
            
            Minuteval();
            Delay.Milliseconds(250);
            
            AltSrcval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMainCreate.ListItemIndicators' at CenterLeft.", repo.FormMainCreate.ListItemIndicatorsInfo, new RecordItemIndex(35));
            repo.FormMainCreate.ListItemIndicators.DoubleClick(Location.CenterLeft, 100);
            Delay.Milliseconds(150);
            
            IDLval();
            Delay.Milliseconds(250);
            
            TADILval();
            Delay.Milliseconds(250);
            
            ATDL1val();
            Delay.Milliseconds(250);
            
            NL1val();
            Delay.Milliseconds(250);
            
            TADILJval();
            Delay.Milliseconds(250);
            
            Extval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainCreate.ButtonSave' at Center.", repo.FormMainCreate.ButtonSaveInfo, new RecordItemIndex(42));
            repo.FormMainCreate.ButtonSave.Click(100);
            Delay.Milliseconds(150);
            
            GetTrackNum();
            Delay.Milliseconds(250);
            
        }

#region Image Feature Data
#endregion
    }
}
