using UnityEngine;
using UnityEngine.UI;

namespace NicitaSoftware.Tools
{
    public class EnlaceScript : MonoBehaviour
    {
        public EnlaceButtonWindow enlace;
        private GameObject window;
        private AudioSource audiosource;
        bool playIfWindowIsClosed = false;

        // Start is called before the first frame update
        void Awake()
        {
            if (enlace != null)
            { 
            window = Instantiate(enlace.prefabWindow);
            window.SetActive(false);
            window.transform.SetParent(GameObject.Find("CanvasMenu").transform, false);
            Button btn = GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
            gameObject.AddComponent<AudioSource>();
            audiosource = GetComponent<AudioSource>();
            audiosource.clip = enlace.audioClip;
            }
            else
            {
                print("no existe el enlace");
            }
        }        

        void TaskOnClick()
        {
            audiosource.Play();
            window.SetActive(true);
            playIfWindowIsClosed = true;

        }

        void Update()
        {
            if (enlace != null)
            if (window.activeSelf == false && playIfWindowIsClosed == true)
            {
                audiosource.Play();
                playIfWindowIsClosed = false;
            }

        }

    }

}