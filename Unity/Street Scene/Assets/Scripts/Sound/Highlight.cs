using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour {

    [SerializeField]
    private AudioSource m_as;

    [SerializeField]
    private AudioClip m_highlight;

    [SerializeField]
    private AudioClip m_playButton;

    [SerializeField]
    private AudioClip m_menuButton;

    private void Start()
    {
        m_as = GetComponent<AudioSource>();
    }


	public void HighlightSound()
    {
        m_as.clip = m_highlight;
        m_as.PlayOneShot(m_as.clip);
    }

    public void MenuButtonSound()
    {
        m_as.clip = m_menuButton;
        m_as.PlayOneShot(m_as.clip);
    }

    public void PlayButtonSound()
    {
        m_as.clip = m_playButton;
        m_as.PlayOneShot(m_as.clip);
    }
}
