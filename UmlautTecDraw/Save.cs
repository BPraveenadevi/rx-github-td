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
using Ranorex.Core.Repository;

namespace UmlautTecDraw
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Save recording.
    /// </summary>
    [TestModule("ec5a6a77-3e5a-4db3-a8b8-fb2278469fd6", ModuleType.Recording, 1)]
    public partial class Save : ITestModule
    {
        /// <summary>
        /// Holds an instance of the UmlautTecDrawRepository repository.
        /// </summary>
        public static UmlautTecDrawRepository repo = UmlautTecDrawRepository.Instance;

        static Save instance = new Save();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Save()
        {
            filenamePrefix = "Praveena";
            fileExtension = "";
            fileName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Save Instance
        {
            get { return instance; }
        }

#region Variables

        string _filenamePrefix;

        /// <summary>
        /// Gets or sets the value of variable filenamePrefix.
        /// </summary>
        [TestVariable("787fcac4-9c8a-427c-a64a-17d11ee24549")]
        public string filenamePrefix
        {
            get { return _filenamePrefix; }
            set { _filenamePrefix = value; }
        }

        string _fileExtension;

        /// <summary>
        /// Gets or sets the value of variable fileExtension.
        /// </summary>
        [TestVariable("a9d2acb6-1023-4157-ab73-7743d06b1b46")]
        public string fileExtension
        {
            get { return _fileExtension; }
            set { _fileExtension = value; }
        }

        string _fileName;

        /// <summary>
        /// Gets or sets the value of variable fileName.
        /// </summary>
        [TestVariable("309af681-85f9-4ee6-9425-b45335bf2808")]
        public string fileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.File' at 15;15.", repo.MainWin.FileInfo, new RecordItemIndex(0));
            //repo.MainWin.File.Click("15;15");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainWin.File' at 13;10.", repo.MainWin.FileInfo, new RecordItemIndex(1));
            repo.MainWin.File.Click("13;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UmlautTecDraw1.Save' at 80;13.", repo.UmlautTecDraw1.SaveInfo, new RecordItemIndex(2));
            repo.UmlautTecDraw1.Save.Click("80;13");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Save.DropDown' at 7;10.", repo.Save.DropDownInfo, new RecordItemIndex(3));
            //repo.Save.DropDown.Click("7;10");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Save.Text1001' at 126;1.", repo.Save.Text1001Info, new RecordItemIndex(4));
            //repo.Save.Text1001.Click("126;1");
            //Delay.Milliseconds(0);
            
            fileName = GeneralUtilities.filename(filenamePrefix, fileExtension);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Save.Text1001' at 115;7.", repo.Save.Text1001Info, new RecordItemIndex(6));
            //repo.Save.Text1001.Click("115;7");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'Save'.", repo.Save.SelfInfo, new RecordItemIndex(7));
            repo.Save.Self.EnsureVisible();
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$fileName' with focus on 'Save'.", repo.Save.SelfInfo, new RecordItemIndex(8));
            repo.Save.Self.EnsureVisible();
            Keyboard.Press(fileName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Save.ButtonSave' at 46;14.", repo.Save.ButtonSaveInfo, new RecordItemIndex(9));
            repo.Save.ButtonSave.Click("46;14");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Save.ButtonSave' at 45;12.", repo.Save.ButtonSaveInfo, new RecordItemIndex(10));
            //repo.Save.ButtonSave.Click("45;12");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}