﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EDDF75CFE59DFAE67502310757E4399C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MP3Player;
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


namespace MP3Player {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid container;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView songs;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView librarys;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addLibrary;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delLibrary;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label song;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image cover;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button playButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button previousButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nextButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button stopButton;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pauseButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button muteButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadButton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox destinationText;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider progressBar;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider volume;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label volumeLabel;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label progresLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/MP3Player;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.container = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.songs = ((System.Windows.Controls.ListView)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.songs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.songs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.librarys = ((System.Windows.Controls.ListView)(target));
            
            #line 43 "..\..\MainWindow.xaml"
            this.librarys.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.librarys_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addLibrary = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.addLibrary.Click += new System.Windows.RoutedEventHandler(this.addLibrary_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.delLibrary = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.song = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cover = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.playButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.playButton.Click += new System.Windows.RoutedEventHandler(this.play_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.previousButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.previousButton.Click += new System.Windows.RoutedEventHandler(this.previous_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.nextButton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.nextButton.Click += new System.Windows.RoutedEventHandler(this.next_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.stopButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\MainWindow.xaml"
            this.stopButton.Click += new System.Windows.RoutedEventHandler(this.stop_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.pauseButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\MainWindow.xaml"
            this.pauseButton.Click += new System.Windows.RoutedEventHandler(this.pause_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.muteButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\MainWindow.xaml"
            this.muteButton.Click += new System.Windows.RoutedEventHandler(this.mute_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.loadButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.loadButton.Click += new System.Windows.RoutedEventHandler(this.load_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.destinationText = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\MainWindow.xaml"
            this.destinationText.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.destinationText_TextChanged);
            
            #line default
            #line hidden
            return;
            case 16:
            this.progressBar = ((System.Windows.Controls.Slider)(target));
            
            #line 68 "..\..\MainWindow.xaml"
            this.progressBar.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.progressBar_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.volume = ((System.Windows.Controls.Slider)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.volume.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.volume_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.volumeLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 19:
            this.progresLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

