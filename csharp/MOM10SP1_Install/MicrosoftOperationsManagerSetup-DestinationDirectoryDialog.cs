//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.288
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// ' For information on how interfaces are used in classes derived from Window,
// '   please see http://mauiweb.
namespace MOM10SP1_Install
{
    using System;
    using System.ComponentModel;
    using Maui.OS.WinControls;
    using Maui.OS;
    
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls
    {
        Button NextButton  {get;}
        Button BackButton  {get;}
        Button CancelButton  {get;}
        StaticControl SetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl  {get;}
        Button BrowseButton  {get;}
        StaticControl CMicrosoftOperationsManager2000StaticControl  {get;}
    }
    
    /// -----------------------------------------------------------------------------
    /// Project		:  Maui
    // Class		: 
    ///  Copyright (C) 2002, oration
    /// -----------------------------------------------------------------------------
    ///  <summary>
    ///  TODO: Add dialog functionality description here.
    ///  </summary>
    ///  <remarks></remarks>
    ///  <history>[deangj] 4/11/2003 Created
    ///  </history>
    /// -----------------------------------------------------------------------------
    /// 
    public class MicrosoftOperationsManagerSetupDestinationDirectoryDialog : Dialog, IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls
    {
        protected Button m_CachedNextButton;
        protected Button m_CachedBackButton;
        protected Button m_CachedCancelButton;
        protected StaticControl m_CachedSetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl;
        protected Button m_CachedBrowseButton;
        protected StaticControl m_CachedCMicrosoftOperationsManager2000StaticControl;
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  TODO: Add a description for your constructor.
        ///  </summary>
        ///  <remarks></remarks>
        ///  <history>[Dialog Maker Tool] 4/11/2003 - Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        public MicrosoftOperationsManagerSetupDestinationDirectoryDialog(App app) : 
                base(app, Init(app))
        {
            // TODO: Add Constructor logic here. 
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Exposes access to the raw controls for this dialog
        ///  </summary>
        ///  <value>An interface that groups all of the dialog's control properties together</value>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        public virtual IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls Controls
        {
            get
            {
                return this;
            }
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Exposes access to the NextButton control
        ///  </summary>
        ///  <value></value>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 - Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        Button IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls.NextButton
        {
            get
            {
                if ((m_CachedNextButton == null))
                {
                    m_CachedNextButton = new Button(this, ControlIDs.NextButton);
                }
                return m_CachedNextButton;
            }
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Exposes access to the BackButton control
        ///  </summary>
        ///  <value></value>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 - Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        Button IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls.BackButton
        {
            get
            {
                if ((m_CachedBackButton == null))
                {
                    m_CachedBackButton = new Button(this, ControlIDs.BackButton);
                }
                return m_CachedBackButton;
            }
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Exposes access to the CancelButton control
        ///  </summary>
        ///  <value></value>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 - Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        Button IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls.CancelButton
        {
            get
            {
                if ((m_CachedCancelButton == null))
                {
                    m_CachedCancelButton = new Button(this, ControlIDs.CancelButton);
                }
                return m_CachedCancelButton;
            }
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Exposes access to the SetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl control
        ///  </summary>
        ///  <value></value>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 - Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        StaticControl IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls.SetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl
        {
            get
            {
                if ((m_CachedSetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl == null))
                {
                    m_CachedSetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl = new StaticControl(this, ControlIDs.SetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl);
                }
                return m_CachedSetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl;
            }
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Exposes access to the BrowseButton control
        ///  </summary>
        ///  <value></value>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 - Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        Button IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls.BrowseButton
        {
            get
            {
                if ((m_CachedBrowseButton == null))
                {
                    m_CachedBrowseButton = new Button(this, ControlIDs.BrowseButton);
                }
                return m_CachedBrowseButton;
            }
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Exposes access to the CMicrosoftOperationsManager2000StaticControl control
        ///  </summary>
        ///  <value></value>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 - Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        StaticControl IMicrosoftOperationsManagerSetupDestinationDirectoryDialogControls.CMicrosoftOperationsManager2000StaticControl
        {
            get
            {
                if ((m_CachedCMicrosoftOperationsManager2000StaticControl == null))
                {
                    m_CachedCMicrosoftOperationsManager2000StaticControl = new StaticControl(this, ControlIDs.CMicrosoftOperationsManager2000StaticControl);
                }
                return m_CachedCMicrosoftOperationsManager2000StaticControl;
            }
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  This function will attempt to find a showing instance of the dialog.
        ///  </summary>
        ///  <returns>The dialog's hWnd</returns>
        ///  <remarks></remarks>)
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        private static int Init(App app)
        {
            // First check if the dialog is already up.
            Window tempWindow = new Window(Strings.DialogTitle, "GLBSWizard", true, 0, app.Process.Id);
            if ((tempWindow != null))
            {
                return tempWindow.Extended.HWnd;
            }
            // Dialog not found.  Need to invoke the dialog.
            // TODO: Add code to bring up dthe dialog
            // 
            // TODO: Remove next line.  Your code should return the handle of the dialog.
            return 0;
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Routine to click on button Next
        ///  </summary>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        public virtual void ClickNext()
        {
            Controls.NextButton.Click();
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Routine to click on button Back
        ///  </summary>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        public virtual void ClickBack()
        {
            Controls.BackButton.Click();
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Routine to click on button Cancel
        ///  </summary>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        public virtual void ClickCancel()
        {
            Controls.CancelButton.Click();
        }
        
        /// -----------------------------------------------------------------------------
        ///  <summary>
        ///  Routine to click on button Browse
        ///  </summary>
        ///  <remarks></remarks>
        ///  <history>[Dialog Class Maker Tool] 4/11/2003 Created
        ///  </history>
        /// -----------------------------------------------------------------------------
        public virtual void ClickBrowse()
        {
            Controls.BrowseButton.Click();
        }
        
        public class Strings
        {
            public const string DialogTitle = "Microsoft Operations Manager Setup - Destination Directory";
            public const string Next = "&Next >";
            public const string Back = "< &Back";
            public const string Cancel = "Cancel";
            public const string SetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfiles = "Setup is ready to begin installation of Microsoft Operations Manager files in the" +
" following location.\r\n\r\nTo install files in the folder shown, click Next.\r\n\r\nTo " +
"select a different installation folder, click Browse.";
            public const string Browse = "B&rowse...";
            public const string CMicrosoftOperationsManager2000 = "C:\\...\\Microsoft Operations Manager 2000";
        }
        
        public class ControlIDs
        {
            public const int NextButton = 3;
            public const int BackButton = 4;
            public const int CancelButton = 5;
            public const int SetupisreadytobegininstallationofMicrosoftOperationsManagerfilesinthefollowinglocationToinstallfilesStaticControl = 7;
            public const int BrowseButton = 9;
            public const int CMicrosoftOperationsManager2000StaticControl = 10;
        }
    }
}