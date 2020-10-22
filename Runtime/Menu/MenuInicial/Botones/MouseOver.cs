using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

namespace NicitaSoftware.Tools
{
    public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler 
    {
        [SerializeField]
        Vector3 escalaBase = new Vector3();
        public float scaleFactor = 1.05f;
        GameObject shadow;

        public void Awake()
        {
            escalaBase = transform.localScale;          
            shadow = transform.GetChild(0).gameObject;
            shadow.gameObject.SetActive(false);
        }

        //Do this when the cursor enters the rect area of this selectable UI object.
        public void OnPointerEnter(PointerEventData eventData)
        {            
            transform.localScale = escalaBase * scaleFactor;           
            shadow.gameObject.SetActive(true);  
        }

        //Do this when the cursor enters the rect area of this selectable UI object.
        public void OnPointerExit(PointerEventData eventData)
        {           
            transform.localScale = escalaBase;
            shadow.gameObject.SetActive(false);
        }

    }
}
