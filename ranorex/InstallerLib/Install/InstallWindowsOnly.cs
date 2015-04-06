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

namespace InstallerLib.Install
{
    /// <summary>
    /// The InstallWindowsOnly recording.
    /// </summary>
    [TestModule("89f48b5a-6a1e-4b49-b37e-1c67e6b60012", ModuleType.Recording, 1)]
    public partial class InstallWindowsOnly : ITestModule
    {
        /// <summary>
        /// Holds an instance of the InstallerLib.InstallHudsonRepository repository.
        /// </summary>
        public static InstallerLib.InstallHudsonRepository repo = InstallerLib.InstallHudsonRepository.Instance;

        static InstallWindowsOnly instance = new InstallWindowsOnly();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InstallWindowsOnly()
        {
            buildtype = "promoted";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InstallWindowsOnly Instance
        {
            get { return instance; }
        }

#region Variables

        string _buildtype;

        /// <summary>
        /// Gets or sets the value of variable buildtype.
        /// </summary>
        [TestVariable("15c09584-3115-4eb4-bba6-4188b3027113")]
        public string buildtype
        {
            get { return _buildtype; }
            set { _buildtype = value; }
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

            GetCurrentDirectory();
            Delay.Milliseconds(0);
            
            CreateDirs();
            Delay.Milliseconds(0);
            
            GetRevision();
            Delay.Milliseconds(0);
            
            Is64BitSystem();
            Delay.Milliseconds(0);
            
            Check7zip();
            Delay.Milliseconds(0);
            
            DownloadLatestWin();
            Delay.Milliseconds(0);
            
            UnzipLatestWin();
            Delay.Milliseconds(0);
            
            InstallLatestWin();
            Delay.Milliseconds(0);
            
            DownloadTacView();
            Delay.Milliseconds(0);
            
            UnzipTacView();
            Delay.Milliseconds(0);
            
            InstallTacView();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Success, "User", "Windows only Installation was successfull", new RecordItemIndex(11));
            
        }

#region Image Feature Data
#endregion
    }
}