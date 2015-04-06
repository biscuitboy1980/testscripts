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

namespace TacViewLib.LinkSpecific.Surveillance.Land_Disused.CreateTrack
{
    /// <summary>
    /// The CreateLandTrackDisused6016D recording.
    /// </summary>
    [TestModule("75e867c4-8f74-43d5-8e4f-687b0c5f59e0", ModuleType.Recording, 1)]
    public partial class CreateLandTrackDisused6016D : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepositoryDisusedValues repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepositoryDisusedValues repo = TacViewLib.TacViewLibRepositoryDisusedValues.Instance;

        static CreateLandTrackDisused6016D instance = new CreateLandTrackDisused6016D();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateLandTrackDisused6016D()
        {
            Plat = "";
            Act = "";
            Stype = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateLandTrackDisused6016D Instance
        {
            get { return instance; }
        }

#region Variables

        string _Plat;

        /// <summary>
        /// Gets or sets the value of variable Plat.
        /// </summary>
        [TestVariable("3c6c9604-3fda-4efa-b81e-1d8382f44672")]
        public string Plat
        {
            get { return _Plat; }
            set { _Plat = value; }
        }

        string _Act;

        /// <summary>
        /// Gets or sets the value of variable Act.
        /// </summary>
        [TestVariable("c91dff56-a492-4a61-8c0c-6ce55a074610")]
        public string Act
        {
            get { return _Act; }
            set { _Act = value; }
        }

        string _Stype;

        /// <summary>
        /// Gets or sets the value of variable Stype.
        /// </summary>
        [TestVariable("6ebac3ed-36f0-42d1-b958-2a24371ce7d2")]
        public string Stype
        {
            get { return _Stype; }
            set { _Stype = value; }
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

            ValidateDropTrack();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FormTacViewC2.ContainerRvView' at 507;278.", repo.FormTacViewC2.ContainerRvViewInfo, new RecordItemIndex(1));
            repo.FormTacViewC2.ContainerRvView.Click(System.Windows.Forms.MouseButtons.Right, "507;278");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMainSelect.MenuItemCreate_Track' at 54;11.", repo.FormMainSelect.MenuItemCreate_TrackInfo, new RecordItemIndex(2));
            repo.FormMainSelect.MenuItemCreate_Track.Click("54;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCreate_Track.MenuItemTOAD' at Center.", repo.FormCreate_Track.MenuItemTOADInfo, new RecordItemIndex(3));
            repo.FormCreate_Track.MenuItemTOAD.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTOAD.MenuItemLand' at Center.", repo.FormTOAD.MenuItemLandInfo, new RecordItemIndex(4));
            repo.FormTOAD.MenuItemLand.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Land_Point_Track_TN.ListItemPoint_Track_Ind' at Center.", repo.FormMain__Land_Point_Track_TN.ListItemPoint_Track_IndInfo, new RecordItemIndex(5));
            repo.FormMain__Land_Point_Track_TN.ListItemPoint_Track_Ind.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(6));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(150);
            
            Indval();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}'.", new RecordItemIndex(8));
            Keyboard.Press("{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            IDval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(10));
            Keyboard.Press("{Tab}{Tab}");
            Delay.Milliseconds(50);
            
            Platval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(12));
            Keyboard.Press("{Tab}{Tab}");
            Delay.Milliseconds(50);
            
            Actval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(14));
            Keyboard.Press("{Tab}{Tab}");
            Delay.Milliseconds(50);
            
            Stypeval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Land_Point_Track_TN.ButtonSave' at 12;21.", repo.FormMain__Land_Point_Track_TN.ButtonSaveInfo, new RecordItemIndex(16));
            repo.FormMain__Land_Point_Track_TN.ButtonSave.Click("12;21");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}