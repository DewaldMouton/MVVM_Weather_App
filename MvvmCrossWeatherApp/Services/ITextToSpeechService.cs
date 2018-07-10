using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmCrossWeatherApp.Core.Services
{
    public interface ITextToSpeechService
    {
        void TextToSpeech(string text);
    }
}
