using UnityEngine;
using UnityEngine.UI;

namespace NicitaSoftware.Tools
{
    [CreateAssetMenu(fileName = "New EnlaceButtonWindow", menuName = "Enlace Button Window", order = 51)]
    [SerializeField]
    public class EnlaceButtonWindow : ScriptableObject
    {
        [SerializeField]
        public string enlaceName;
        [SerializeField]
        public GameObject prefabWindow;
        [SerializeField]
        public AudioSource prefabClickSound;

    }
}
