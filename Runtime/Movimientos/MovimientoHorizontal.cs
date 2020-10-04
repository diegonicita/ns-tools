using UnityEngine;

namespace NicitaSoftware.Tools
{
    public class MovimientoHorizontal : MonoBehaviour
    {
        public float velocidadX = 1;
        public float timer = 1;
        private int direccion = 1;
        private float tiempoTranscurrido;

        void Start()
        {
            tiempoTranscurrido = timer;
        }

        void Update()
        {
            tiempoTranscurrido = tiempoTranscurrido - Time.deltaTime;
            if (tiempoTranscurrido <= 0)
            {
                direccion *= -1; tiempoTranscurrido = timer;
            }
            transform.Translate(direccion * velocidadX * Time.deltaTime, 0, 0);
        }
    } 

}


