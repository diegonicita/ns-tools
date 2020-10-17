using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NicitaSoftware.Tools
{
    public class FadeObject : MonoBehaviour
    {
        public float waitTime = 1;
        private float fadeSpeed = 0.5f;
        [SerializeField]
        Color colorOriginal = new Color(0, 0, 0, 0); 
        [SerializeField]
        float alphaModificado;        
        Image im;

        public void Start()
        {       
            im = this.GetComponent<Image>(); 
            colorOriginal = im.material.color;             
        }

        public void OnEnable()
        {           
            alphaModificado = 0;
            im = this.GetComponent<Image>();
            im.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, alphaModificado);
            StartCoroutine(FadeOut(waitTime));          
        }
       
        public IEnumerator FadeOut(float wt)
        {
            Image ima = this.GetComponent<Image>();

            yield return new WaitForSeconds(wt);

            while (alphaModificado < colorOriginal.a)
            {              
                alphaModificado += (fadeSpeed * Time.deltaTime);                
                ima.color = new Color(colorOriginal.r, colorOriginal.g, colorOriginal.b, alphaModificado);
                yield return null;               
            }
        }
        
    }
}
