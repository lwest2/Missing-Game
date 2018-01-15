using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace China
{
    public class Raycast : MonoBehaviour
    {

        private LivesCounter m_livesCounter_script;

        private void Start()
        {
            m_livesCounter_script = GameObject.Find("Lives").GetComponent<LivesCounter>();
        }

        // Update is called once per frame
        private void FixedUpdate()
        {
            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit, 2.0f))
            {
                if (Input.GetMouseButtonDown(0))
                {


                    if (hit.collider.tag == "parent")
                    {
                        // WIN ANIMATION

                        SceneManager.LoadScene(4);

                    }
                    else
                    {
                        m_livesCounter_script.setLives(1);
                    }
                }
            }
        }
    }

}