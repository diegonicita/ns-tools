using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NicitaSoftware.Tools
{
    public class PlaySound : MonoBehaviour
    {
        public float waitTime = 1;
        private AudioSource audioSource;
        public AudioClip audioClip;

        // Start is called before the first frame update
        void Awake()
        {
            gameObject.AddComponent<AudioSource>();
            audioSource = GetComponent<AudioSource>();
            audioSource.playOnAwake = false;
            audioSource.clip = audioClip;
            
        }

        public void OnEnable()
        {
            StartCoroutine(Play(waitTime));
        }

        public IEnumerator Play(float wt)
        {
            yield return new WaitForSeconds(wt);

            audioSource.Play();
        }
    }
}
