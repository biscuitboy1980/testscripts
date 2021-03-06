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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CommonUtilLib
{
    /// <summary>
    /// The class representing the CommonUtil element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "3.1.1"), RepositoryFolder("f0493506-6d2a-4eb3-ab02-96eb90eea29f")]
    public partial class CommonUtil : RepoGenBaseFolder
    {
        static CommonUtil instance = new CommonUtil();

        /// <summary>
        /// Gets the singleton class instance representing the CommonUtil element repository.
        /// </summary>
        [RepositoryFolder("f0493506-6d2a-4eb3-ab02-96eb90eea29f")]
        public static CommonUtil Instance {
            get { return instance; }
        }

        CommonUtilFolders.FormTacViewC2AppFolder _formtacviewc2;
        CommonUtilFolders.FormRealViewAppFolder _formrealview;

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public CommonUtil() : base("CommonUtil", "", null, 30000, false)
        {
            _formtacviewc2 = new CommonUtilFolders.FormTacViewC2AppFolder(this);
            _formrealview = new CommonUtilFolders.FormRealViewAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The FormTacViewC2 folder.
        /// </summary>
        [RepositoryFolder("8e7ecc04-50aa-4e8f-92c0-13e7a85b7b95")]
        public virtual CommonUtilFolders.FormTacViewC2AppFolder FormTacViewC2
        {
            get { return _formtacviewc2; }
        }

        /// <summary>
        /// The FormRealView folder.
        /// </summary>
        [RepositoryFolder("eafd4624-994b-4ca3-8997-b3e534b22752")]
        public virtual CommonUtilFolders.FormRealViewAppFolder FormRealView
        {
            get { return _formrealview; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    public partial class CommonUtilFolders
    {
        /// <summary>
        /// The FormTacViewC2AppFolder folder.
        /// </summary>
        [RepositoryFolder("8e7ecc04-50aa-4e8f-92c0-13e7a85b7b95")]
        public partial class FormTacViewC2AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _selfInfo;
            RepoItemInfo _containerrvviewInfo;

            /// <summary>
            /// Creates a new FormTacViewC2  folder.
            /// </summary>
            public FormTacViewC2AppFolder(RepoGenBaseFolder parentFolder) :
                    base("FormTacViewC2", "/form[@title~'^TacViewC2\\ \\ \\ \\(map:\\ .*']", parentFolder, 30000, false, "8e7ecc04-50aa-4e8f-92c0-13e7a85b7b95")
            {
                _selfInfo = new RepoItemInfo(this, "Self", "", 0, null, "8e7ecc04-50aa-4e8f-92c0-13e7a85b7b95");
                _containerrvviewInfo = new RepoItemInfo(this, "ContainerRvView", "element/container[@accessiblename='RvView']", 10000, null, "28a2178b-1784-4e00-bf26-185282b25119");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8e7ecc04-50aa-4e8f-92c0-13e7a85b7b95")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("8e7ecc04-50aa-4e8f-92c0-13e7a85b7b95")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ContainerRvView item.
            /// </summary>
            [RepositoryItem("28a2178b-1784-4e00-bf26-185282b25119")]
            public virtual Ranorex.Container ContainerRvView
            {
                get
                {
                    return _containerrvviewInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The ContainerRvView item info.
            /// </summary>
            [RepositoryItemInfo("28a2178b-1784-4e00-bf26-185282b25119")]
            public virtual RepoItemInfo ContainerRvViewInfo
            {
                get
                {
                    return _containerrvviewInfo;
                }
            }
        }

        /// <summary>
        /// The FormRealViewAppFolder folder.
        /// </summary>
        [RepositoryFolder("eafd4624-994b-4ca3-8997-b3e534b22752")]
        public partial class FormRealViewAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _selfInfo;
            RepoItemInfo _menuitemcreate_trackInfo;

            /// <summary>
            /// Creates a new FormRealView  folder.
            /// </summary>
            public FormRealViewAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FormRealView", "/form[@title='' and @processname='RealView' and @class='Afx:00400000:808:00010005:00000000:00000000' or @class='Afx:00400000:808:00010003:00000000:00000000']", parentFolder, 30000, true, "eafd4624-994b-4ca3-8997-b3e534b22752")
            {
                _selfInfo = new RepoItemInfo(this, "Self", "", 0, null, "eafd4624-994b-4ca3-8997-b3e534b22752");
                _menuitemcreate_trackInfo = new RepoItemInfo(this, "MenuItemCreate_Track", "contextmenu[1]/menuitem[@accessiblename='Create Track']", 10000, null, "b5621217-840f-403b-9eeb-5241411bd67d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("eafd4624-994b-4ca3-8997-b3e534b22752")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("eafd4624-994b-4ca3-8997-b3e534b22752")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MenuItemCreate_Track item.
            /// </summary>
            [RepositoryItem("b5621217-840f-403b-9eeb-5241411bd67d")]
            public virtual Ranorex.MenuItem MenuItemCreate_Track
            {
                get
                {
                    return _menuitemcreate_trackInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MenuItemCreate_Track item info.
            /// </summary>
            [RepositoryItemInfo("b5621217-840f-403b-9eeb-5241411bd67d")]
            public virtual RepoItemInfo MenuItemCreate_TrackInfo
            {
                get
                {
                    return _menuitemcreate_trackInfo;
                }
            }
        }

    }
}
