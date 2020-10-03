using ACatppella.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACatppella
{
    public static class Repository
    {
        public static List<Instrument> Instruments = new List<Instrument>()
        {
            new Instrument("Keyboard", null),
            new Instrument("Guitar", null),
            new Instrument("Drums", null),
        };

        public static List<Track> Tracks = new List<Track>()
        {
            new Track(Instruments[0], NotesA),
            new Track(Instruments[1], NotesB),
            new Track(Instruments[2], NotesC)
        };

        private static int[] NotesA = new int[]
        {
            0, 1, 1, 2, 3, 0, 2, 1, 4, 1
        };

        private static int[] NotesB = new int[]
        {
            0, 1, 1, 2, 3, 0, 2, 1, 4, 1
        };

        private static int[] NotesC = new int[]
        {
            0, 1, 1, 2, 3, 0, 2, 1, 4, 1
        };

        public static List<Song> Songs = new List<Song>()
        {
            new Song("Sick Beat", Tracks)
        };
    }
}
