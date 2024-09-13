﻿namespace MenuSystem;

public class MenuItem
{
    private string _title;
    private string _shortcut;

    public string Title
    {
        get => _title;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ApplicationException("Cannot be null or empty");
            }

            _title = value;
        }
    }

    public string Shortcut
    {
        get => _shortcut;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ApplicationException("Cannot be null or empty");
            }

            _shortcut = value;
        }
    }

    public override string ToString()
    {
        return Shortcut + ") " + Title;
    }
}