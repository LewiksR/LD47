using ACatppella.Domain;
using System.Linq;
using UnityEngine;

namespace ACatppella
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject notesTrackContainer;
        [SerializeField]
        private GameObject notesContainer;

        private RectTransform notesTrack;

        private float tempo = 120f;
        private float speed = 1f;

        void Start()
        {
            notesTrack = notesTrackContainer.GetComponent<RectTransform>();

            Track track = Repository.Tracks.FirstOrDefault();

            RenderTrack(track);
        }

        void Update()
        {
            MoveTrack();
        }

        private void MoveTrack()
        {

        }

        private void RenderTrack(Track track)
        {
            //float horizontalOffset = notesTrack.sizeDelta.x / (track.Instrument.AudioNotes.Count + 1);
            
            //for (int i = 0; i < track.Notes.Length; i++)
            //{
                
            //}
        }

        private void CreateNote(Note note)
        {

        }
    }
}