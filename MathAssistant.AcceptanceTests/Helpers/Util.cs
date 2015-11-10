﻿using System;

namespace MathAssistant.AcceptanceTests.Helpers
{
    public static class Util
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
