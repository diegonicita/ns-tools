using UnityEngine;

namespace NicitaSoftware.Tools
{
    public class MovimientoContinuo : MonoBehaviour
    {
        public float velocidadX, velocidadY, velocidadZ;      

        void Update()
        {
            transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, velocidadZ * Time.deltaTime);
        }
    }
}

