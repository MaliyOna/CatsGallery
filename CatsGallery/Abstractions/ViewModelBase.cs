﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CatsGallery.Abstractions;
public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


    protected virtual bool SetProperty<T>(ref T backingStore,
                                          T value,
                                          [CallerMemberName] string propertyName = "",
                                          Action? onChanged = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
            return false;

        backingStore = value;
        onChanged?.Invoke();
        OnPropertyChanged(propertyName);
        return true;
    }
}
