using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour {

    [SerializeField]
    private AudioSource m_as;

    [SerializeField]
    private AudioClip m_highlight;

    private void Start()
    {
        m_as.GetComponent<AudioSource>();
    }


	public void HighlightSound()
    {
        m_as.PlayOneShot(m_highlight);
    }
}
