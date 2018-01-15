using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace China
{
    public class choosePhoto : MonoBehaviour
    {
        private NPCspawn m_npcSpawn_script;

        private int m_index;

        [SerializeField]
        private Sprite[] m_photos = new Sprite[6];

        private Image m_image;

        // Use this for initialization
        void Start()
        {
            m_image = GetComponent<Image>();
            m_npcSpawn_script = GameObject.Find("GameManager").GetComponent<NPCspawn>();
            m_index = m_npcSpawn_script.getIndex();
            Debug.Log("RandomNumberCont:" + m_index);
            m_image.sprite = m_photos[m_index];
        }
    }
}