﻿
//using PropertyChanged;
using CollectionViewTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
//using Xamarin.Forms;

namespace PrayMore.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public App appInstance = ((App)App.Current);

        public bool IsBusy { get; set; }

        public INavigation Navigation
        {
            get => appInstance?.MainPage?.Navigation;
        }

        public string Title { get; set; }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action ? onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
