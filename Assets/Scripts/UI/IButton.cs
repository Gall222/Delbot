using System;

namespace UI
{
    public interface IButton : IView
    {
        public event EventHandler Clicked;
    }
}
