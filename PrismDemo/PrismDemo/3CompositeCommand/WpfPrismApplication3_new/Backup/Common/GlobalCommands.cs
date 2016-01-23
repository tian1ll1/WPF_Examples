using System;

namespace Common
{
    public static class GlobalCommands
    {
        public static CompositeCommand MyCompositeCommand = new CompositeCommand(true);
    }
}