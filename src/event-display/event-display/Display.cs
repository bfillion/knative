using System;
using Serilog;

namespace event_display
{
    public class Display
    {
        public Display()
        {
        }

        public string DisplayMessage(string message)
        {
            if (message == "")
            {
                message = "{\"msg\": \"No data!\"}";
            }

            Log.Information("Event Display received event: {content}", message);

            return message;
        }
    }
}
