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
        private GameObject trackBackground;
        [SerializeField]
        private GameObject notePrefab;

        private RectTransform rectNotesTrack;
        private RectTransform rectTrackBackground;

        private float beatIntervalSeconds;

        private float measureHeight;

        private Song currentSong;
        private Track currentTrack;
        private Instrument currentInstrument;

        void Start()
        {
            // SETUP VARIABLES
            rectNotesTrack = notesTrackContainer.GetComponent<RectTransform>();
            measureHeight = rectNotesTrack.sizeDelta.y;

            rectTrackBackground = trackBackground.GetComponent<RectTransform>();
            // END SETUP VARIABLES

            StartSong(RepositoryManager.Instance.Songs.FirstOrDefault());
        }

        void Update()
        {
            PlayNotes();
        }

        private void StartSong(Song song)
        {
            beatIntervalSeconds = 60f / song.Bpm;

            StartTrack(song.Tracks.FirstOrDefault());
        }

        private void StartTrack(Track track)
        {
            currentInstrument = track.Instrument;

            RenderTrack(track);
        }

        private void FixedUpdate()
        {
            MoveTrack();
        }

        private void MoveTrack()
        {
            rectNotesTrack.Translate(Vector2.down * Time.deltaTime * measureHeight / 4 / beatIntervalSeconds);

            float backgroundVerticalOffset = -Mathf.Floor(rectNotesTrack.anchoredPosition.y / measureHeight) - 1;

            rectTrackBackground.anchoredPosition = new Vector2(0, measureHeight * backgroundVerticalOffset);
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

        private void RenderTrack(Track track)
        {
            float horizontalOffset = rectNotesTrack.sizeDelta.x / (track.Instrument.AudioNotes.Count + 1);

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