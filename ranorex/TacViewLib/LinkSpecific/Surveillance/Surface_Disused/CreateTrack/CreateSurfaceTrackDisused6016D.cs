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

namespace TacViewLib.LinkSpecific.Surveillance.Surface_Disused.CreateTrack
{
    /// <summary>
    /// The CreateSurfaceTrackDisused6016D recording.
    /// </summary>
    [TestModule("897eae34-a4f1-4678-b5ac-fa43a3f35798", ModuleType.Recording, 1)]
    public partial class CreateSurfaceTrackDisused6016D : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TacViewLib.TacViewLibRepositoryDisusedValues repository.
        /// </summary>
        public static TacViewLib.TacViewLibRepositoryDisusedValues repo = TacViewLib.TacViewLibRepositoryDisusedValues.Instance;

        static CreateSurfaceTrackDisused6016D instance = new CreateSurfaceTrackDisused6016D();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateSurfaceTrackDisused6016D()
        {
            Plat = "";
            Act = "";
            Stype = "";
            Sam = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateSurfaceTrackDisused6016D Instance
        {
            get { return instance; }
        }

#region Variables

        string _Plat;

        /// <summary>
        /// Gets or sets the value of variable Plat.
        /// </summary>
        [TestVariable("61fc9622-db4f-4efa-afc2-4dad80355a34")]
        public string Plat
        {
            get { return _Plat; }
            set { _Plat = value; }
        }

        string _Act;

        /// <summary>
        /// Gets or sets the value of variable Act.
        /// </summary>
        [TestVariable("775a75bd-1de8-40b3-a5c6-af4841c3bfca")]
        public string Act
        {
            get { return _Act; }
            set { _Act = value; }
        }

        string _Stype;

        /// <summary>
        /// Gets or sets the value of variable Stype.
        /// </summary>
        [TestVariable("f3da1967-cb16-4346-9be9-23f98b6ff15b")]
        public string Stype
        {
            get { return _Stype; }
            set { _Stype = value; }
        }

        string _Sam;

        /// <summary>
        /// Gets or sets the value of variable Sam.
        /// </summary>
        [TestVariable("81f5032d-4a88-4155-b9e1-40715b864056")]
        public string Sam
        {
            get { return _Sam; }
            set { _Sam = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormTOAD.MenuItemSurface' at Center.", repo.FormTOAD.MenuItemSurfaceInfo, new RecordItemIndex(4));
            repo.FormTOAD.MenuItemSurface.Click(300);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Surface_TN___CREATING.ListItemIdentity' at 68;6.", repo.FormMain__Surface_TN___CREATING.ListItemIdentityInfo, new RecordItemIndex(5));
            repo.FormMain__Surface_TN___CREATING.ListItemIdentity.Click("68;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(6));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(150);
            
            IDval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(8));
            Keyboard.Press("{Tab}{Tab}");
            Delay.Milliseconds(50);
            
            Platval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(10));
            Keyboard.Press("{Tab}{Tab}");
            Delay.Milliseconds(50);
            
            Actval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}'.", new RecordItemIndex(12));
            Keyboard.Press("{Tab}{Tab}");
            Delay.Milliseconds(50);
            
            Stypeval();
            Delay.Milliseconds(250);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Next}{Next}'.", new RecordItemIndex(14));
            Keyboard.Press("{Next}{Next}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Surface_TN___CREATING.ListItemSAM_SSM_Type' at 48;8.", repo.FormMain__Surface_TN___CREATING.ListItemSAM_SSM_TypeInfo, new RecordItemIndex(15));
            repo.FormMain__Surface_TN___CREATING.ListItemSAM_SSM_Type.Click("48;8", 300);
            Delay.Milliseconds(870);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(16));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Samtype();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormMain__Surface_TN___CREATING.ButtonSave' at 12;21.", repo.FormMain__Surface_TN___CREATING.ButtonSaveInfo, new RecordItemIndex(18));
            repo.FormMain__Surface_TN___CREATING.ButtonSave.Click("12;21");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
}
