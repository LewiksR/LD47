using ACatppella.Domain;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ACatppella
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private GameObject notesTrackContainer;
        [SerializeField]
        private GameObject notesContainer;
        [SerializeField]
        private GameObject notePrefab;

        private RectTransform notesTrack;

        private float tempo = 120f;
        private float speed = 1f;

        private float measureHeight;

        private Instrument currentInstrument;

        void Start()
        {
            notesTrack = notesTrackContainer.GetComponent<RectTransform>();

            measureHeight = notesTrack.sizeDelta.y;

            Track track = RepositoryManager.Instance.Tracks.FirstOrDefault();

            RenderTrack(track);
        }

        void Update()
        {
            MoveTrack();

            PlayNotes();
        }

        private void PlayNotes()
        {
            if (currentInstrument != null)
            {
                List<AudioClip> notes = currentInstrument.AudioNotes;

                if (Input.GetKeyDown(KeyCode.A))
                {
                    SoundManager.Instance.PlayNote(notes[0]);
                }

                if (Input.GetKeyDown(KeyCode.S))
                {
                    SoundManager.Instance.PlayNote(notes[1]);
                }

                if (Input.GetKeyDown(KeyCode.D))
                {
                    SoundManager.Instance.PlayNote(notes[2]);
                }

                if (Input.GetKeyDown(KeyCode.F))
                {
                    SoundManager.Instance.PlayNote(notes[3]);
                }

                if (Input.GetKeyDown(KeyCode.G))
                {
                    SoundManager.Instance.PlayNote(notes[4]);
                }
            }
        }

        private void MoveTrack()
        {

        }

        private void RenderTrack(Track track)
        {
            float horizontalOffset = notesTrack.sizeDelta.x / (track.Instrument.AudioNotes.Count + 1);

            // Notes interval
            float verticalOffset = measureHeight / 8f;

            currentInstrument = track.Instrument;

            for (int i = 0; i < track.Notes.Length; i++)
            {
                if (track.Notes[i] > 0)
                {
                    Vector2 position = new Vector2((track.Notes[i]) * horizontalOffset, i * verticalOffset);
                    
                    CreateNote(track.Notes[i], Color.red, position);
                }
            }
        }

        private void CreateNote(int note, Color color, Vector2 position)
        {
            GameObject noteGameObject = Instantiate(notePrefab, notesContainer.transform);

            Image image = noteGameObject.GetComponent<Image>();
            image.color = color;

            RectTransform rectTransform = noteGameObject.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = position;
        }
    }
}