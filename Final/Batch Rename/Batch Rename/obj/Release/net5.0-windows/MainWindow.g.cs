﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "433E2AF9EC300A4CDBE5553173507B65DCED5104"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fluent;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Batch_Rename {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnStart;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnPreview;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnReset;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnAddFiles;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnAddFolders;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.RadioButton RbnDirectlyFile;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.RadioButton RbnFolder;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnDelete;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnClear;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnSavePreset;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnDeletePreset;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.Button BtnDeleteRule;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.ComboBox CbxRules;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Fluent.ComboBox CbxPresets;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListRules;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListItems;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtRuleNameDesc;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtDesc;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Batch Rename;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((Batch_Rename.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.RibbonWindow_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\MainWindow.xaml"
            ((Batch_Rename.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.RibbonWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnStart = ((Fluent.Button)(target));
            
            #line 15 "..\..\..\MainWindow.xaml"
            this.BtnStart.Click += new System.Windows.RoutedEventHandler(this.BtnStart_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnPreview = ((Fluent.Button)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.BtnPreview.Click += new System.Windows.RoutedEventHandler(this.BtnPreview_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnReset = ((Fluent.Button)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.BtnReset.Click += new System.Windows.RoutedEventHandler(this.BtnReset_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnAddFiles = ((Fluent.Button)(target));
            
            #line 35 "..\..\..\MainWindow.xaml"
            this.BtnAddFiles.Click += new System.Windows.RoutedEventHandler(this.BtnAddFiles_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnAddFolders = ((Fluent.Button)(target));
            
            #line 41 "..\..\..\MainWindow.xaml"
            this.BtnAddFolders.Click += new System.Windows.RoutedEventHandler(this.BtnAddFolders_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.RbnDirectlyFile = ((Fluent.RadioButton)(target));
            return;
            case 8:
            this.RbnFolder = ((Fluent.RadioButton)(target));
            return;
            case 9:
            this.BtnDelete = ((Fluent.Button)(target));
            
            #line 50 "..\..\..\MainWindow.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnClear = ((Fluent.Button)(target));
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.BtnClear.Click += new System.Windows.RoutedEventHandler(this.BtnClear_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnSavePreset = ((Fluent.Button)(target));
            
            #line 64 "..\..\..\MainWindow.xaml"
            this.BtnSavePreset.Click += new System.Windows.RoutedEventHandler(this.BtnSavePreset_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BtnDeletePreset = ((Fluent.Button)(target));
            
            #line 69 "..\..\..\MainWindow.xaml"
            this.BtnDeletePreset.Click += new System.Windows.RoutedEventHandler(this.BtnDeletePreset_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.BtnAdd = ((Fluent.Button)(target));
            
            #line 75 "..\..\..\MainWindow.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.BtnDeleteRule = ((Fluent.Button)(target));
            
            #line 81 "..\..\..\MainWindow.xaml"
            this.BtnDeleteRule.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteRule_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.CbxRules = ((Fluent.ComboBox)(target));
            
            #line 89 "..\..\..\MainWindow.xaml"
            this.CbxRules.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbxRules_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.CbxPresets = ((Fluent.ComboBox)(target));
            
            #line 96 "..\..\..\MainWindow.xaml"
            this.CbxPresets.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbxPresets_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.ListRules = ((System.Windows.Controls.ListView)(target));
            
            #line 113 "..\..\..\MainWindow.xaml"
            this.ListRules.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.ListRules_MouseUp);
            
            #line default
            #line hidden
            
            #line 113 "..\..\..\MainWindow.xaml"
            this.ListRules.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ListRules_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 18:
            this.ListItems = ((System.Windows.Controls.ListView)(target));
            
            #line 122 "..\..\..\MainWindow.xaml"
            this.ListItems.Drop += new System.Windows.DragEventHandler(this.ListItems_Drop);
            
            #line default
            #line hidden
            return;
            case 19:
            this.TxtRuleNameDesc = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 20:
            this.TxtDesc = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
