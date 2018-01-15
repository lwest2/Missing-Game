using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour {

    [SerializeField]
    private AudioSource m_as;

    [SerializeField]
    private AudioClip m_locked;

    [SerializeField]
    private Transform m_player;

    private Vector3 m_heading;
    private float m_maxRange = 3.0f;

    private Transform m_door;

    // Use this for initialization
    void Start()
    {
        m_door = GetComponent<Transform>();
        m_as = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        m_heading = m_door.position - m_player.position;

        if (m_heading.sqrMagnitude < m_maxRange * m_maxRange)
        {
            // Insert fadein "E interaction" GUI element

            if (Input.GetKeyDown(KeyCode.E))
            {

                // Insert fadein "Locked" GUI element
                m_as.clip = m_locked;
                m_as.PlayOneShot(m_as.clip);
                // Insert Locked sound effect
            }
        }
    }
}
