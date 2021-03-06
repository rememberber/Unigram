﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Telegram.Api.TL;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Unigram.Controls.Views
{
    public sealed partial class JoinChatView : BottomSheet
    {
        public TLChatInvite ViewModel => DataContext as TLChatInvite;

        public JoinChatView()
        {
            this.InitializeComponent();
        }

        public string ConvertCount(int total, bool hasParticipants)
        {
            var key = "{0} members";
            if (total == 1)
            {
                key = hasParticipants ? "{0} member:" : "{0} member";
            }
            else
            {
                key = hasParticipants ? "{0} members:" : "{0} members";
            }

            return string.Format(key, total);
        }

        public Visibility ConvertMoreVisibility(int total, int count)
        {
            return total - count > 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        public string ConvertMore(int total, int count)
        {
            return string.Format("+{0}", total - count);
        }

        private void Join_Click(object sender, RoutedEventArgs e)
        {
            Hide(ContentDialogBaseResult.OK);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Hide(ContentDialogBaseResult.Cancel);
        }
    }
}
