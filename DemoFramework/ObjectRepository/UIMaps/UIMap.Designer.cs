﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace DemoFramework.ObjectRepository.UIMaps.UIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// AddTwoNumbers - Use 'AddTwoNumbersParams' to pass parameters into this method.
        /// </summary>
        public void AddTwoNumbers()
        {
            #region Variable Declarations
            WinComboBox uIOpenComboBox = this.UIRunWindow.UIItemWindow.UIOpenComboBox;
            WinEdit uIOpenEdit = this.UIRunWindow.UIItemWindow1.UIOpenEdit;
            #endregion

            // Press keyboard shortcut keys 'Windows + r'
            Keyboard.SendKeys(this.AddTwoNumbersParams.SendKeys, ModifierKeys.Windows);

            // Select 'calc' in 'Open:' combo box
            uIOpenComboBox.EditableItem = this.AddTwoNumbersParams.UIOpenComboBoxEditableItem;

            // Type '{Enter}' in 'Open:' text box
            Keyboard.SendKeys(uIOpenEdit, this.AddTwoNumbersParams.UIOpenEditSendKeys, ModifierKeys.None);

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.
        }
        
        #region Properties
        public virtual AddTwoNumbersParams AddTwoNumbersParams
        {
            get
            {
                if ((this.mAddTwoNumbersParams == null))
                {
                    this.mAddTwoNumbersParams = new AddTwoNumbersParams();
                }
                return this.mAddTwoNumbersParams;
            }
        }
        
        public UIRunWindow UIRunWindow
        {
            get
            {
                if ((this.mUIRunWindow == null))
                {
                    this.mUIRunWindow = new UIRunWindow();
                }
                return this.mUIRunWindow;
            }
        }
        
        public UISolutionsTeshouseIntWindow UISolutionsTeshouseIntWindow
        {
            get
            {
                if ((this.mUISolutionsTeshouseIntWindow == null))
                {
                    this.mUISolutionsTeshouseIntWindow = new UISolutionsTeshouseIntWindow();
                }
                return this.mUISolutionsTeshouseIntWindow;
            }
        }
        #endregion
        
        #region Fields
        private AddTwoNumbersParams mAddTwoNumbersParams;
        
        private UIRunWindow mUIRunWindow;
        
        private UISolutionsTeshouseIntWindow mUISolutionsTeshouseIntWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AddTwoNumbers'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class AddTwoNumbersParams
    {
        
        #region Fields
        /// <summary>
        /// Press keyboard shortcut keys 'Windows + r'
        /// </summary>
        public string SendKeys = "r";
        
        /// <summary>
        /// Select 'calc' in 'Open:' combo box
        /// </summary>
        public string UIOpenComboBoxEditableItem = "calc";
        
        /// <summary>
        /// Type '{Enter}' in 'Open:' text box
        /// </summary>
        public string UIOpenEditSendKeys = "{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRunWindow : WinWindow
    {
        
        public UIRunWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Run";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "12298";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIOpenComboBox
        {
            get
            {
                if ((this.mUIOpenComboBox == null))
                {
                    this.mUIOpenComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIOpenComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Open:";
                    this.mUIOpenComboBox.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOpenComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIOpenComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1001";
            this.WindowTitles.Add("Run");
            #endregion
        }
        
        #region Properties
        public WinEdit UIOpenEdit
        {
            get
            {
                if ((this.mUIOpenEdit == null))
                {
                    this.mUIOpenEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIOpenEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Open:";
                    this.mUIOpenEdit.WindowTitles.Add("Run");
                    #endregion
                }
                return this.mUIOpenEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIOpenEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISolutionsTeshouseIntWindow : BrowserWindow
    {
        
        public UISolutionsTeshouseIntWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Solutions | Teshouse";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Solutions | Teshouse");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UISolutionsTeshouseDocument UISolutionsTeshouseDocument
        {
            get
            {
                if ((this.mUISolutionsTeshouseDocument == null))
                {
                    this.mUISolutionsTeshouseDocument = new UISolutionsTeshouseDocument(this);
                }
                return this.mUISolutionsTeshouseDocument;
            }
        }
        #endregion
        
        #region Fields
        private UISolutionsTeshouseDocument mUISolutionsTeshouseDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISolutionsTeshouseDocument : HtmlDocument
    {
        
        public UISolutionsTeshouseDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Solutions | Teshouse";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/solutions/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://www.testhouse.net/solutions/";
            this.WindowTitles.Add("Solutions | Teshouse");
            #endregion
        }
        
        #region Properties
        public UIContentsection1Custom UIContentsection1Custom
        {
            get
            {
                if ((this.mUIContentsection1Custom == null))
                {
                    this.mUIContentsection1Custom = new UIContentsection1Custom(this);
                }
                return this.mUIContentsection1Custom;
            }
        }
        #endregion
        
        #region Fields
        private UIContentsection1Custom mUIContentsection1Custom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIContentsection1Custom : HtmlCustom
    {
        
        public UIContentsection1Custom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "SECTION";
            this.SearchProperties["Id"] = "content-section-1";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"content-section-1\"";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("Solutions | Teshouse");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIDynamicsCRMAXERPCRMsPane
        {
            get
            {
                if ((this.mUIDynamicsCRMAXERPCRMsPane == null))
                {
                    this.mUIDynamicsCRMAXERPCRMsPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIDynamicsCRMAXERPCRMsPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIDynamicsCRMAXERPCRMsPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIDynamicsCRMAXERPCRMsPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Dynamics CRM & AX\r\n\r\n\r\n\r\nERP & CRM syste";
                    this.mUIDynamicsCRMAXERPCRMsPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIDynamicsCRMAXERPCRMsPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "gdlr-item gdlr-column-service-item";
                    this.mUIDynamicsCRMAXERPCRMsPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"gdlr-item gdlr-column-service-item\" style=\"margin-bottom: 50px;\"";
                    this.mUIDynamicsCRMAXERPCRMsPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "40";
                    this.mUIDynamicsCRMAXERPCRMsPane.WindowTitles.Add("Solutions | Teshouse");
                    #endregion
                }
                return this.mUIDynamicsCRMAXERPCRMsPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIDynamicsCRMAXERPCRMsPane;
        #endregion
    }
}
