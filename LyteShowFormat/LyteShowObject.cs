using System;
using Lyteshow;

namespace Lyteshow
{
    public class ShowObjectData
    {
        public string? Colour { get; set; }
        public int Length { get; set; }
        public string? ColourFrom { get; set; }
        public string? ColourTo { get; set; }
    }
    // Currently unused, might not bother with conversion functions
    // We'll see
    public enum ShowObjectType
    {
        SET,
        FADE,
        // Might be removed
        PULSE
    }
    public class ShowObject
    {
        // Time offset (in ms) for the object
        public int Time { get; set; }
        // Type of object
        public string? Type { get; set; }
        // Data for the object, some of these fields go unused depending on the object's type
        public ShowObjectData? Data { get; set; }
    }
}