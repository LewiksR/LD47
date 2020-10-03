using ACatppella.Domain;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ACatppella
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;

        private AudioSource audioSource;

        private void Awake()
        {
            Instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        private void SetupInstruments()
        {
            List<Instrument> instruments = RepositoryManager.Instance.Instruments;

            foreach (Instrument instrument in instruments)
            {

            }
        }

        public void PlayNote(AudioClip audioClip)
        {
            audioSource.PlayOneShot(audioClip);
        }

        // Update is called once per frame
        void Update()
        {
            //if (Input.GetKeyDown(KeyCode.A))
            //{
            //    audioSource.PlayOneShot(notes[0]);
            //}

            //if (Input.GetKeyDown(KeyCode.S))
            //{
            //    audioSource.PlayOneShot(notes[1]);
            //}

            //if (Input.GetKeyDown(KeyCode.D))
            //{
            //    audioSource.PlayOneShot(notes[2]);
            //}

            //if (Input.GetKeyDown(KeyCode.F))
            //{
            //    audioSource.PlayOneShot(notes[3]);
            //}

            //if (Input.GetKeyDown(KeyCode.G))
            //{
            //    audioSource.PlayOneShot(notes[4]);
            //}
        }
    }
}
