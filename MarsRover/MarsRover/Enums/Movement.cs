using System.ComponentModel;

namespace MarsRover.Enums
{
    public enum Movement
    {
        [Description("Move forward one grid point, and maintain the same heading")]
        M,

        [Description("Spin the rover 90 degrees left, without moving from its current spot")]
        L,

        [Description("Spin the rover 90 degrees right, without moving from its current spot")]
        R
    }
}
