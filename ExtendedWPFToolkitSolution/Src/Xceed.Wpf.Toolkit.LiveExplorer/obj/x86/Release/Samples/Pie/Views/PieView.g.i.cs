﻿#pragma checksum "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A199BC0E53011756378485BD4B51DDB87CAA705"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.LiveExplorer;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace Xceed.Wpf.Toolkit.LiveExplorer.Samples.Pie.Views {
    
    
    /// <summary>
    /// PieView
    /// </summary>
    public partial class PieView : Xceed.Wpf.Toolkit.LiveExplorer.DemoView, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.LiveExplorer.Samples.Pie.Views.PieView demo;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider endAngleSlider;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider sliceSlider;
        
        #line default
        #line hidden
        
        
        #line 190 "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker FillSelector;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker StrokeSelector;
        
        #line default
        #line hidden
        
        
        #line 216 "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.Pie pie;
        
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
            System.Uri resourceLocater = new System.Uri("/Xceed.Wpf.Toolkit.LiveExplorer;component/samples/pie/views/pieview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.demo = ((Xceed.Wpf.Toolkit.LiveExplorer.Samples.Pie.Views.PieView)(target));
            return;
            case 2:
            
            #line 79 "..\..\..\..\..\..\Samples\Pie\Views\PieView.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.endAngleSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.sliceSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.FillSelector = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            return;
            case 6:
            this.StrokeSelector = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            return;
            case 7:
            this.pie = ((Xceed.Wpf.Toolkit.Pie)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

