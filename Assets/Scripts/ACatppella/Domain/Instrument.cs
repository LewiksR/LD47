using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ACatppella.Domain
{
    public class Instrument
    {
        public Instrument(string name, List<AudioClip> audioNotes)
        {
            Name = name;
            AudioNotes = audioNotes;
        }

        public string Name { get; }
        public List<AudioClip> AudioNotes { get; }
    }
}
