using UnityEngine;
using UnityEngine.UI;

namespace NicitaSoftware.Tools
{
    public class EnlaceScript : MonoBehaviour
    {
        public EnlaceButtonWindow enlace;
        private GameObject window;        

        // Start is called before the first frame update
        void Awake()
        {
            window = Instantiate(enlace.prefabWindow);
            window.SetActive(false);
            window.transform.SetParent(GameObject.Find("CanvasMenu").transform, false);
            Button btn = GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }        

        void TaskOnClick()
        {
            window.SetActive(true);
        }

    }

}