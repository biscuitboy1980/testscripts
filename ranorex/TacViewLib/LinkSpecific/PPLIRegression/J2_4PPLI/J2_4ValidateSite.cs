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

namespace TacViewLib.LinkSpecific.PPLIRegression.J2_4PPLI
{
    /// <summary>
    /// The J2_4ValidateSite recording.
    /// </summary>
    [TestModule("ee43a586-c004-4886-9335-412291f8e719", ModuleType.Recording, 1)]
    public partial class J2_4ValidateSite : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.Link_16_RegressionRepository repository.
        /// </summary>
        public static TacViewLib.Link_16_RegressionRepository repo = TacViewLib.Link_16_RegressionRepository.Instance;

        static J2_4ValidateSite instance = new J2_4ValidateSite();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public J2_4ValidateSite()
        {
            tracknumber = "33";
            connection2 = "";
            connection1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static J2_4ValidateSite Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable tracknumber.
        /// </summary>
        [TestVariable("0e7134c7-12fa-4a08-9637-97c368cbef62")]
        public string tracknumber
        {
            get { return repo.tracknumber; }
            set { repo.tracknumber = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable connection2.
        /// </summary>
        [TestVariable("1b3dcde5-c8f8-415a-bfdc-847ba15d83a3")]
        public string connection2
        {
            get { return repo.connection2; }
            set { repo.connection2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable connection1.
        /// </summary>
        [TestVariable("26e238c2-bb16-4141-a8d2-abb967b2d44b")]
        public string connection1
        {
            get { return repo.connection1; }
            set { repo.connection1 = value; }
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
            Mouse.DefaultMoveTime = 250;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.TitleBarTacViewC2____map__Defaul' at Center.", repo.FormTacViewC2.TitleBarTacViewC2____map__DefaulInfo, new RecordItemIndex(0));
            repo.FormTacViewC2.TitleBarTacViewC2____map__Defaul.Click(150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.ButtonValue' at Center.", repo.FormTacViewC2.ButtonValueInfo, new RecordItemIndex(1));
            repo.FormTacViewC2.ButtonValue.Click(150);
            Delay.Milliseconds(0);
            
            KeyboardUnit();
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTacViewC2.ButtonSearch_For_Track' at Center.", repo.FormTacViewC2.ButtonSearch_For_TrackInfo, new RecordItemIndex(3));
            repo.FormTacViewC2.ButtonSearch_For_Track.Click(150);
            Delay.Milliseconds(0);
            
            JUCenter();
            Delay.Milliseconds(150);
            
            CreateTrackRepoItems();
            Delay.Milliseconds(150);
            
            RightClickTrack();
            Delay.Milliseconds(150);
            
            ViewTrackProperties();
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(8));
            Delay.Duration(10000, false);
            
            ValidateTrackNumber();
            Delay.Milliseconds(150);
            
            ValidateTrackType();
            Delay.Milliseconds(150);
            
            ValidateSiteEnvironment();
            Delay.Milliseconds(150);
            
            ValidatePlatform();
            Delay.Milliseconds(150);
            
            ValidateActivity();
            Delay.Milliseconds(150);
            
            ValidateStrength();
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__Site_TN.ListItemBasic_Track_Info' at CenterLeft.", repo.FormMain__Site_TN.ListItemBasic_Track_InfoInfo, new RecordItemIndex(15));
            repo.FormMain__Site_TN.ListItemBasic_Track_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__Site_TN.ListItemIndirect_Site_Info' at CenterLeft.", repo.FormMain__Site_TN.ListItemIndirect_Site_InfoInfo, new RecordItemIndex(16));
            repo.FormMain__Site_TN.ListItemIndirect_Site_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__Site_TN.ListItemPosition_and_Speed' at CenterLeft.", repo.FormMain__Site_TN.ListItemPosition_and_SpeedInfo, new RecordItemIndex(17));
            repo.FormMain__Site_TN.ListItemPosition_and_Speed.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__Site_TN.ListItemInterface_Info' at CenterLeft.", repo.FormMain__Site_TN.ListItemInterface_InfoInfo, new RecordItemIndex(18));
            repo.FormMain__Site_TN.ListItemInterface_Info.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(0);
            
            ValidateMode1();
            Delay.Milliseconds(150);
            
            ValidateMode2();
            Delay.Milliseconds(150);
            
            ValidateMode3();
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__Site_TN.ListItemMode_Codes' at CenterLeft.", repo.FormMain__Site_TN.ListItemMode_CodesInfo, new RecordItemIndex(22));
            repo.FormMain__Site_TN.ListItemMode_Codes.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FormMain__Site_TN.ListItemIndicators' at CenterLeft.", repo.FormMain__Site_TN.ListItemIndicatorsInfo, new RecordItemIndex(23));
            repo.FormMain__Site_TN.ListItemIndicators.DoubleClick(Location.CenterLeft, 150);
            Delay.Milliseconds(0);
            
            ValidateNPS();
            Delay.Milliseconds(150);
            
            ValidateIndirectIndicator();
            Delay.Milliseconds(150);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Site_TN.ButtonCLOSE' at Center.", repo.FormMain__Site_TN.ButtonCLOSEInfo, new RecordItemIndex(26));
            repo.FormMain__Site_TN.ButtonCLOSE.Click(150);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}