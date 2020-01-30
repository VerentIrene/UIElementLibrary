using progress_bar;
using System;

namespace UIElementLibrary.progress_bar
{
    public interface ILoadingBar
    {

        LoadingBar setText(String _text, String _color);
        LoadingBar setDuration(int _duration);
        LoadingBar setColor(String _color);

        void animate();
    }
}
