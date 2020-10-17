using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace NicitaSoftware.Tools
{
    public class AnimationCurveScript : MonoBehaviour
    {
        public float waitTime = 0;
        private Vector3 initialScale;
        private Vector3 finalScale;       
        [HeaderAttribute("Animation Curve")]
        public AnimationCurve lerpCurve;
        private float graphValue;       

        private void Awake()
        {
            initialScale = Vector3.zero;
            finalScale = new Vector3();
            finalScale = transform.localScale;
            lerpCurve.postWrapMode = WrapMode.Once;         
        }

        public void Start()
        {
            StartCoroutine(Anime(waitTime));
        }

        void OnEnable()
        {        
            initialScale = Vector3.zero;
            transform.localScale = initialScale;
            StartCoroutine(Anime(waitTime));
        } 

        public IEnumerator Anime(float wt)
        {
            float tiempo = 0;
            Image ima = this.GetComponent<Image>();
            yield return new WaitForSeconds(wt);
            while (tiempo < 1)
            {
                tiempo += Time.deltaTime;
                graphValue = lerpCurve.Evaluate(tiempo);
                transform.localScale = finalScale * graphValue;                
                yield return null;
            }
        }

    }

}