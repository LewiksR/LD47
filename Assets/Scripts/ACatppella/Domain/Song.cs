using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ACatppella.Domain
{
    public class Song
    {
        public Song(string name, List<Track> tracks)
        {
            Name = name;
            Tracks = tracks;
        }

        public string Name { get; }

        public List<Track> Tracks { get; } = new List<Track>();

        public int[] songA = new int[]
        {
            1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 0
        };
    }
}