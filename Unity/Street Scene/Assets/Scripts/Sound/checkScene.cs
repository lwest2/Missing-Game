using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace China
{
    public class checkScene : MonoBehaviour
    {
        private DontDestroyOnLoad m_dontDestroyOnLoad_script;

        // Use this for initialization
        void Start()
        {
            if (GameObject.Find("Music"))
            {
                m_dontDestroyOnLoad_script = GameObject.Find("Music").GetComponent<DontDestroyOnLoad>();
                m_dontDestroyOnLoad_script.PlayMusic();
            }
        }

        
    }
}
