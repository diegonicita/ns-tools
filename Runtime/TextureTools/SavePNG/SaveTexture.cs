using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

namespace NicitaSoftware.Tools
{
    public class SaveTexture : MonoBehaviour
    {
        // nombre de un sprite que esta en Resources //
        public string pathSprite = "None";
        // path donde se grabara el sprite modificado y su nombre //
        public string pathToSave = "/Save Files/imageSaved.png";
        private Texture2D destinoTex;
        private Sprite spr;

        private void Awake()
        {
            LoadPng(ref destinoTex, pathSprite);
            FillPng(ref destinoTex);
            SavePng();
        }

        public void FillPng(ref Texture2D tex)
        {
            for (int y = 550; y < tex.height; y++)
            {
                for (int x = 550; x < tex.width; x++) //Goes through each pixel
                {
                    Color pixelColour;
                    if (Random.Range(0, 2) == 1) //50/50 chance it will be black or white
                    {
                        pixelColour = new Color(0, 0, 0, 1);
                    }
                    else
                    {
                        pixelColour = new Color(1, 1, 1, 1);
                    }
                    tex.SetPixel(x, y, pixelColour);
                }
            }
            tex.Apply();
        }

        public void LoadPng(ref Texture2D tex, string path)
        {
            var gameObject = new GameObject();
            var spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
            var sprite = Resources.Load<Sprite>(path);
            spriteRenderer.sprite = sprite;
            tex = spriteRenderer.sprite.texture;
        }

        // Start is called before the first frame update
        public void SavePng()
        {
            Texture2D itemBGTex = destinoTex;
            FillPng(ref destinoTex);
            byte[] itemBGBytes = itemBGTex.EncodeToPNG();
            File.WriteAllBytes(Application.dataPath + pathToSave, itemBGBytes);
        }
    }

}


