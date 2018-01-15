using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace China
{
    public class LivesCounter : MonoBehaviour
    {
        private AudioSource m_as;
        private Text m_text;
        private int lives = 3;

        // Use this for initialization
        void Start()
        {
            m_as = GetComponent<AudioSource>();
            m_text = GetComponent<Text>();
            updateLives();
        }

        void updateLives()
        {
            m_text.text = "Lives - " + lives;

            m_as.PlayOneShot(m_as.clip);

            if (lives <= 0)
            {
                // KIDNAPPED ANIMATION HERE

                SceneManager.LoadScene(5);
            }
        }

        public int getLives()
        {
            return lives;
        }

        public void setLives(int livesToSet)
        {
            lives -= livesToSet;
            updateLives();
        }
    }
}