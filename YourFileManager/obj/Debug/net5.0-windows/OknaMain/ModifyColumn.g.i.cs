﻿#pragma checksum "..\..\..\..\OknaMain\ModifyColumn.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "442FE2BAD8ACFD729DBEE54BD549479F098E32D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using ProgramPraca.OknaMain;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
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


namespace ProgramPraca.OknaMain {
    
    
    /// <summary>
    /// ModifyColumn
    /// </summary>
    public partial class ModifyColumn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\OknaMain\ModifyColumn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboboxColumn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\OknaMain\ModifyColumn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxColumnType;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\OknaMain\ModifyColumn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxEnumValue;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\OknaMain\ModifyColumn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxEnumValues;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\OknaMain\ModifyColumn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEnumValueAdd;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\OknaMain\ModifyColumn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEnumValueRemove;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProgramPraca;V1.0.0.0;component/oknamain/modifycolumn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\OknaMain\ModifyColumn.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ComboboxColumn = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.ComboBoxColumnType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\..\..\OknaMain\ModifyColumn.xaml"
            this.ComboBoxColumnType.DropDownClosed += new System.EventHandler(this.CheckIfEnum);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\..\..\OknaMain\ModifyColumn.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetNewColumnParams);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxEnumValue = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ListBoxEnumValues = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.ButtonEnumValueAdd = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\OknaMain\ModifyColumn.xaml"
            this.ButtonEnumValueAdd.Click += new System.Windows.RoutedEventHandler(this.AddNewEnumValue);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonEnumValueRemove = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\OknaMain\ModifyColumn.xaml"
            this.ButtonEnumValueRemove.Click += new System.Windows.RoutedEventHandler(this.DeleteEnumValue);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

