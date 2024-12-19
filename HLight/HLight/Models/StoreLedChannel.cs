using HLight.Enums;
using System;

namespace HLight.Models
{
    public class StoreLedChannel : Channel
    {
        public int StoreLedId { get; set; }
        public StoreLed StoreLed { get; set; }
    }
}
