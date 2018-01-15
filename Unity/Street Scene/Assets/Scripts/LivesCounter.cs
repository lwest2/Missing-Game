using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace China
{
    public class LivesCounter : MonoBehaviour
    {

        private Text m_text;
        private int lives = 3;

        // Use this for initialization
        void Start()
        {
            m_text = GetComponent<Text>();
            updateLives();
        }

        void updateLives()
        {
            m_text.text = "Lives - " + lives;

            if (lives <= 0)
            {
                // KIDNAPPED ANIMATION HERE
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