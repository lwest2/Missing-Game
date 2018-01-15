using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace China
{
    public class LoadSceneOnClick : MonoBehaviour
    {

        private CanvasGroup m_canvasGroup;
        private DontDestroyOnLoad m_dontDestroyOnLoad_script;

        private void Start()
        {
            if (GameObject.Find("menuMusic"))
            {
                m_dontDestroyOnLoad_script = GameObject.Find("menuMusic").GetComponent<DontDestroyOnLoad>();
            }

                if (GameObject.Find("BlackScreen"))
            {
                m_canvasGroup = GameObject.Find("BlackScreen").GetComponent<CanvasGroup>();
                if (m_canvasGroup != null)
                    m_canvasGroup.blocksRaycasts = false;
            }
        }

        public void LoadByIndex(int sceneIndex)
        {
            if (sceneIndex == 1)
            {
                if (GameObject.Find("menuMusic"))
                {
                    m_dontDestroyOnLoad_script.StopMusic();
                    StartCoroutine(fadeOut(sceneIndex));
                }
                else
                {
                    SceneManager.LoadScene(sceneIndex);
                }
            }
            else
            {
                SceneManager.LoadScene(sceneIndex);
            }
        }

        IEnumerator fadeOut(int sceneIndex)
        {
            
            m_canvasGroup.blocksRaycasts = true;
            while (m_canvasGroup.alpha < 1)
            {
                m_canvasGroup.alpha += Time.deltaTime / 2;
                yield return null;
            }
            yield return new WaitForSecondsRealtime(3);

            SceneManager.LoadScene(sceneIndex);
        }

    }
}