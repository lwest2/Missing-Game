using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace China
{
    public class DontDestroyOnLoad : MonoBehaviour
    {

        // reference - https://answers.unity.com/questions/1260393/make-music-continue-playing-through-scenes.html

        

        private AudioSource m_as;

        private void Awake()
        {
            DontDestroyOnLoad(this);

            if  (FindObjectsOfType(GetType()).Length > 1)
            {
                Destroy(gameObject);
            }
            
            m_as = GetComponent<AudioSource>();
        }

        public void PlayMusic()
        {
            if (m_as.isPlaying) return;
            m_as.Play();
        }

        public void StopMusic()
        {
            if(m_as.isPlaying)
            m_as.Stop();
        }
    }
}