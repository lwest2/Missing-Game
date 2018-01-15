using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace China
{
    public class StartLevel : MonoBehaviour
    {

        private CanvasGroup m_canvasGroup;
        private CanvasGroup m_canvasGroup_crosshair;
        private Text m_text;
        private Image m_image;

        private bool m_grantControls;

        // Use this for initialization
        void Start()
        {
            m_canvasGroup = GetComponent<CanvasGroup>();
            m_canvasGroup_crosshair = GameObject.FindGameObjectWithTag("crosshair").GetComponent<CanvasGroup>();
            m_text = GameObject.FindGameObjectWithTag("countdown").GetComponent<Text>();
            StartCoroutine(Starting());
            m_grantControls = false;
            m_image = GameObject.Find("Timer").GetComponent<Image>();
        }

        IEnumerator Starting()
        {
            m_text.text = "";
            yield return new WaitForSecondsRealtime(3);

            while (m_canvasGroup.alpha > 0)
            {
                m_canvasGroup.alpha -= Time.deltaTime / 2;
                yield return null;
            }

            while (m_canvasGroup_crosshair.alpha < .5)
            {
                m_canvasGroup_crosshair.alpha += Time.deltaTime * 2;
                yield return null;
            }


            m_text.text = "3";
            yield return new WaitForSecondsRealtime(1);
            m_text.text = "2";
            yield return new WaitForSecondsRealtime(1);
            m_text.text = "1";
            yield return new WaitForSecondsRealtime(1);
            m_text.text = "GO!";
            yield return new WaitForSecondsRealtime(1);
            m_text.text = "";
            m_grantControls = true;

            while (m_image.fillAmount > 0)
            {
                m_image.fillAmount -= 0.008f;
                yield return new WaitForSecondsRealtime(1);
            }

            if(m_image.fillAmount <= 0)
            {
                // KIDNAP ANIMATION
            }
            yield return null;
        }

        public bool getGrantControls()
        {
            return m_grantControls;
        }
    }
}