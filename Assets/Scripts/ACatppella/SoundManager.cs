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
    }
}
