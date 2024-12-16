namespace HLight.Enums
{
    public enum ChannelType
    {
        MasterDimmer = 0,
        Dimmer = 1,
        Red = 2,
        Green = 3,
        Blue = 4,
        Strobe = 5,
        SetProgram = 6,
        Speed = 7
    }

    public static class ChanneTypeString
    {
        public static string GetString(ChannelType type)
        {
            switch (type)
            {
                case ChannelType.MasterDimmer:
                    return "Dimmer Mètre";
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
