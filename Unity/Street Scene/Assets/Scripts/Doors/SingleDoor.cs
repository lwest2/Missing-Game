using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleDoor : MonoBehaviour {

    private AudioSource m_as;
    [SerializeField]
    private AudioClip m_close;
    [SerializeField]
    private AudioClip m_open;

    private Animator m_anim;

    [SerializeField]
    private Transform m_player;

    private Vector3 m_heading;
    private float m_maxRange = 3.0f;

    private Transform m_door;

    // Use this for initialization
    void Start()
    {
        m_anim = GetComponent<Animator>();
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

                if (m_anim.GetBool("open") == false)
                {
                    // Door opens
                    m_anim.SetBool("open", true);


                    m_as.clip = m_open;
                    m_as.PlayOneShot(m_as.clip);
                    // door open sound effect
                }
                else
                {
                    // Door closes
                    m_anim.SetBool("open", false);

                    m_as.clip = m_close;
                    m_as.PlayOneShot(m_as.clip);
                    // door close sound effect
                }
            }
        }
    }
}
