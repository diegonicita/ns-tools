using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NicitaSoftware.Tools
{
    public class Query : MonoBehaviour
    {
        // reference to our database manager object in the scene
        // public SimpleSQL.SimpleSQLManager dbManager;
        public Text texto;
        [SerializeField]
        List<Quest> values;
        int id = 0;

        // Start is called before the first frame update
        void Start()
        {
            Actualizar();
        }

        void Actualizar()
        {
            // Gather a list of weapons and their type names pulled from the weapontype table
            // values = dbManager.Query<Quest>("SELECT * FROM Preguntas WHERE id = " + id);
            // texto.text = "Pregunta " + values[0].numero + " : " + values[0].texto;
        }

        public void Siguiente()
        {
            id++;
            Actualizar();
        }

        public void Anterior()
        {
            id--;
            Actualizar();
        }

    }
}
