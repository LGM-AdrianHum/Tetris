﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tetris.Model.UI;
using Tetris.Model.UI.DisplayBehaviours;
using Tetris.Model;
using System.Diagnostics;

namespace Tetris.Views
{
    /// <summary>
    /// Interaktionslogik für CreditsView.xaml
    /// </summary>
    public partial class CreditsView : OverlayUserControl
    {
        public CreditsView()
        {
            InitializeComponent();
            DisplayBehaviour = new DisplayFlowFromRight(this);
        }

        public new void Show()
        {
            base.Show();
            //Start playing the credits background music
            Settings.Instance.MusicPlayer.PlayResourceFile(new Uri("Tetris;component/Sounds/Music/Kanon.mid", UriKind.Relative));
        }

        public new void Hide()
        {
            base.Hide();

            //Start playing the normal background music again
            Settings.Instance.MusicPlayer.PlayResourceFile(new Uri("Tetris;component/Sounds/Music/Gee.mp3", UriKind.Relative));
        }

        private void cmdBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var __link = ((Hyperlink)sender).NavigateUri;
                Process.Start(__link.AbsoluteUri);
            }
            catch (Exception) { }
        }
    }
}
