using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace China
{
    public class NPCspawn : MonoBehaviour
    {

        private int m_randomNumber;     // randomNumber to select parent
        private int m_randomChooser;    // randomNumber to select which NPC spawns next

        [SerializeField]
        private GameObject[] m_NPC = new GameObject[6];

        private GameObject m_parent;

        private GameObject[] m_spawnedNPC = new GameObject[30];

        private Transform m_transform;  // location of spawner

        private int m_index;  // index of parent

        private void OnEnable()
        {
            m_randomNumber = Random.Range(0, 6);
        }
        // Use this for initialization
        void Start()
        {
            m_transform = GetComponent<Transform>();
            m_parent = m_NPC[m_randomNumber];
            Debug.Log("RandomNumber: " + m_randomNumber);
            for (int j = 0; j < m_spawnedNPC.Length; j++)
            {
                // for every NPC object possible to spawn
                for (int i = 0; i < m_NPC.Length; i++)
                {
                    // if npc is not equal to the same as the parent model
                    if (m_NPC[i] != m_parent)
                    {
                        // chooses random number
                        m_randomChooser = Random.Range(0, 2);
                        Debug.Log(m_randomChooser);

                        // if randomNumber is 0
                        if (m_randomChooser == 0)
                        {
                            // Spawn NPC
                            Debug.Log("Spawning: " + m_NPC[i]);
                            // Instantiate NPC at random position
                            GameObject temp = Instantiate(m_NPC[i], Random.insideUnitSphere * 1 + m_transform.position, Quaternion.identity);

                            // add to spawned NPC's
                            temp.tag = "NPC";
                            m_spawnedNPC[j] = temp;
                        }
                    }
                }
            }
            m_parent = Instantiate(m_parent, Random.insideUnitSphere * 1 + m_transform.position, Quaternion.identity);

            Debug.Log("Spawned parent: " + m_parent);
            m_parent.tag = "parent";

        }

        public int getIndex()
        {
            m_index = m_randomNumber;
            return m_index;
        }
    }
}