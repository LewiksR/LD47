using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ACatppella.Domain
{
    public class Song
    {
        public Song(string name, float bpm, List<Track> tracks)
        {
            Name = name;
            Bpm = bpm;
            Tracks = tracks;
        }

        public string Name { get; }

        public float Bpm { get; }

        public List<Track> Tracks { get; }
    }
}