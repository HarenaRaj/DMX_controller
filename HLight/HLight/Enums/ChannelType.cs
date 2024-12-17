namespace HLight.Enums
{
    public enum ChannelType
    {
        MasterDimmer = 0,
        MasterSpeed = 1,
        Fader = 2,
        Dimmer = 3,
        Red = 4,
        Green = 5,
        Blue = 6,
        Strobe = 7,
        SetProgram = 8,
        Speed = 9
    }

    public static class ChanneTypeString
    {
        public static string GetString(ChannelType type)
        {
            switch (type)
            {
                case ChannelType.MasterDimmer:
                    return "Dimmer Mètre";
                case ChannelType.MasterSpeed:
                    return "Vitesse Mètre";
                case ChannelType.Fader:
                    return "Fader";
                case ChannelType.Dimmer:
                    return "Dimmer";
                case ChannelType.Red:
                    return "Rouge";
                case ChannelType.Green:
                    return "Vert";
                case ChannelType.Blue:
                    return "Bleu";
                case ChannelType.Strobe:
                    return "Stroboscope";
                case ChannelType.SetProgram:
                    return "Programme défini";
                case ChannelType.Speed:
                    return "Vitesse";
                default:
                    return "";
            }
        }
    }

}
