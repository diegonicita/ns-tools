using UnityEngine;

namespace NicitaSoftware.Tools
{
    public class RotacionContinua : MonoBehaviour
    {
        public float velocidadX, velocidadY, velocidadZ; 
        void Update()
        {
            transform.Rotate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);
        }
    }
}
