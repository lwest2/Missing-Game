using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambient : MonoBehaviour {

    [SerializeField]
    private AudioSource m_as;

    [SerializeField]
    private AudioClip[] m_callout = new AudioClip[3];

    private int m_randomIndex;

    private void Start()
    {
        m_as = GetComponent<AudioSource>();
        InvokeRepeating("CallOut", 5f, Random.Range(7f, 20f));
    }
    
    void CallOut()
    {
        m_randomIndex = Random.Range(0, 3);
        Debug.Log(m_randomIndex);
        m_as.clip = m_callout[m_randomIndex];
        m_as.PlayOneShot(m_as.clip);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}
