using System;
using VerbotenMode.Common.Globals.Systems;

namespace VerbotenMode.Common.ModSupport
{
    public class VerbotenCalls
    {
        public static object Call(params object[] args)
        {
            if (args is null || args.Length <= 0)
                return new ArgumentException("ERROR: No function name specified. First argument must be a function name.");
            if (args[0] is not string)
                return new ArgumentException("ERROR: First argument must be a string function name.");

            string methodName = args[0].ToString();
            switch (methodName)
            {
                case "GetVerbotenActive":
                    return WorldSaveSystem.VerbotenMode;
                case "SetVerbotenActive":
                    return WorldSaveSystem.VerbotenMode = (bool)args[1];
            }

            return null;
        }
    }
}