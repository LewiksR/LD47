using ACatppella.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ACatppella
{
    public class RepositoryManager : MonoBehaviour
    {
        public void Awake()
        {
            Instance = this;

            Instruments = new List<Instrument>()
            {
                new Instrument("Keyboard", KeyboardNotes),
                new Instrument("Bass", BassNotes),
                new Instrument("Drums", DrumsNotes),
            };

            Tracks = new List<Track>()
            {
                new Track(Instruments[2], NotesA),
                new Track(Instruments[2], NotesB),
                new Track(Instruments[2], NotesC)
            };

            Songs = new List<Song>()
            {
                new Song("Sick Beat", 120f, Tracks)
            };
        }

        public static RepositoryManager Instance;

        [SerializeField]
        private List<AudioClip> KeyboardNotes;
        [SerializeField]
        private List<AudioClip> BassNotes;
        [SerializeField]
        private List<AudioClip> DrumsNotes;

        public List<Instrument> Instruments;
        public List<Track> Tracks;
        public List<Song> Songs;

        private int[] NotesA = new int[]
        {
            1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 4, 3, 0, 0, 2, 0, 0, 0
        };

        private int[] NotesB = new int[]
        {
            0, 1, 1, 2, 3, 0, 2, 1, 4, 1
        };

        private int[] NotesC = new int[]
        {
            0, 1, 1, 2, 3, 0, 2, 1, 4, 1
        };
    }
}
