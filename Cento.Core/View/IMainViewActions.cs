﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cento.Core.View
{
    public class OpenProjectEventArgs : EventArgs
    {
        public string ProjectFilename
        {
            get;
            set;
        }
    }

    public class SelectDataImageIndexChangedEventArgs : EventArgs
    {
        public int Index
        {
            get;
            set;
        }
    }

    public interface IMainViewActions
    {
        event EventHandler<OpenProjectEventArgs> OpenProject;

        event EventHandler FirstDataImage;

        event EventHandler PreviousDataImage;

        event EventHandler NextDataImage;

        event EventHandler LastDataImage;

        event EventHandler<SelectDataImageIndexChangedEventArgs> SelectDataImageIndexChanged;

        event EventHandler ToggleDisplayGrid;

        event EventHandler ToggleDisplayClassification;

        event EventHandler Exit;
    }
}
