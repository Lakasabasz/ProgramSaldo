﻿#pragma checksum "..\..\..\..\PodOknaMain\AddUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06ADB1DFA35CB20D4DC6C2E9AC82EF1E636FBA9A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using ProgramPraca.PodOknaMain;
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


namespace ProgramPraca.PodOknaMain {
    
    
    /// <summary>
    /// AddUser
    /// </summary>
    public partial class AddUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\..\PodOknaMain\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextNewPassword;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\PodOknaMain\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextNewUsername;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\PodOknaMain\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxUserType;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\PodOknaMain\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxKsiegi;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\PodOknaMain\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxKadry;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\PodOknaMain\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxFaktury;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\PodOknaMain\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelStatus;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProgramPraca;component/podoknamain/adduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PodOknaMain\AddUser.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TextNewPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextNewUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 16 "..\..\..\..\PodOknaMain\AddUser.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveUser);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboBoxUserType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.CheckBoxKsiegi = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.CheckBoxKadry = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.CheckBoxFaktury = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.LabelStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

