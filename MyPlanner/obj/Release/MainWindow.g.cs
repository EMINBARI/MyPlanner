﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41F1D8A5F4EAF9C15560D83552E0521B683677BC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MyPlanner;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace MyPlanner {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label todayBtn;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label forwardBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label allPlansBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addTaskBtn;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removeBtn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editBtn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxMain;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label noTasksLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyPlanner;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.todayBtn = ((System.Windows.Controls.Label)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.todayBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.todayBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.todayBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.todayBtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 23 "..\..\MainWindow.xaml"
            this.todayBtn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.todayBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.forwardBtn = ((System.Windows.Controls.Label)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.forwardBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.weekBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.forwardBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.weekBtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            this.forwardBtn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.forwardBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.allPlansBtn = ((System.Windows.Controls.Label)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.allPlansBtn.MouseEnter += new System.Windows.Input.MouseEventHandler(this.allPlansBtn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 29 "..\..\MainWindow.xaml"
            this.allPlansBtn.MouseLeave += new System.Windows.Input.MouseEventHandler(this.allPlansBtn_MouseLeave);
            
            #line default
            #line hidden
            
            #line 29 "..\..\MainWindow.xaml"
            this.allPlansBtn.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.allPlansBtn_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addTaskBtn = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.addTaskBtn.Click += new System.Windows.RoutedEventHandler(this.addTaskBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.removeBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.removeBtn.Click += new System.Windows.RoutedEventHandler(this.removeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editBtn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.editBtn.Click += new System.Windows.RoutedEventHandler(this.editBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.listBoxMain = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.noTasksLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

