using UnityEngine;
using UnityEngine.UI;

namespace NicitaSoftware.Tools
{
    public class AnimationCurveScript : MonoBehaviour
    {        
        private Vector3 initialScale;
        private Vector3 finalScale;       
        [HeaderAttribute("Animation Curve")]
        public AnimationCurve lerpCurve;
        private float graphValue;
        bool myFlag = false;
        float tiempo = 0;

        private void Awake()
        {
            initialScale = Vector3.zero;
            finalScale = new Vector3(0.5f, 0.5f, 0.5f);
            lerpCurve.postWrapMode = WrapMode.Once;            
            myFlag = false;
        }

        void OnEnable()
        {
            tiempo = 0;
            initialScale = Vector3.zero;
            transform.localScale = initialScale;
            myFlag = true;
        }       

        // Start is called before the first frame update
         void Update()
         {
            if (myFlag)
            {
                tiempo += Time.deltaTime;
                graphValue = lerpCurve.Evaluate(tiempo);
                transform.localScale = finalScale * graphValue;
                if (tiempo > 1) myFlag = false;
            }

         }
      
    }

}