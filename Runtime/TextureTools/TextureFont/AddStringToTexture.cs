using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class AddStringToTexture : MonoBehaviour
{
    public string pathFont = "myFont Alpha 2";
    public string pathSprite = "Dcmnt-1";    
    private Texture2D destinoTex;
    private Texture2D myFontTex;
    private Sprite spr;
    Dictionary<int, Vector2> letras;

    private void Awake()
    {
        LoadPng(ref destinoTex, pathSprite);
        LoadPng(ref myFontTex, pathFont);
        letras = new Dictionary<int, Vector2>();

        letras.Add(32, new Vector2(0, 9)); // SPACE
        letras.Add(33, new Vector2(1, 9)); // !
        letras.Add(34, new Vector2(2, 9)); // "
        letras.Add(35, new Vector2(3, 9)); // #
        letras.Add(36, new Vector2(4, 9)); // $
        letras.Add(37, new Vector2(5, 9)); // %
        letras.Add(38, new Vector2(6, 9)); // &        
        letras.Add(39, new Vector2(7, 9)); // '
        letras.Add(40, new Vector2(8, 9)); // (
        letras.Add(41, new Vector2(9, 9)); // )        

        letras.Add(65, new Vector2(3, 6)); // A
        letras.Add(66, new Vector2(4, 6)); // B
        letras.Add(67, new Vector2(5, 6)); // C
        letras.Add(68, new Vector2(6, 6)); // D
        letras.Add(69, new Vector2(7, 6)); // E
        letras.Add(70, new Vector2(8, 6)); // F
        letras.Add(71, new Vector2(9, 6)); // G        

        letras.Add(72, new Vector2(0, 5)); // H
        letras.Add(73, new Vector2(1, 5)); // I
        letras.Add(74, new Vector2(2, 5)); // J
        letras.Add(75, new Vector2(3, 5)); // K
        letras.Add(76, new Vector2(4, 5)); // L
        letras.Add(77, new Vector2(5, 5)); // M
        letras.Add(78, new Vector2(6, 5)); // N        
        letras.Add(79, new Vector2(7, 5)); // O
        letras.Add(80, new Vector2(8, 5)); // P
        letras.Add(81, new Vector2(9, 5)); // Q        

        letras.Add(82, new Vector2(0, 4)); // R
        letras.Add(83, new Vector2(1, 4)); // S
        letras.Add(84, new Vector2(2, 4)); // T
        letras.Add(85, new Vector2(3, 4)); // U
        letras.Add(86, new Vector2(4, 4)); // V
        letras.Add(87, new Vector2(5, 4)); // W
        letras.Add(88, new Vector2(6, 4)); // X        
        letras.Add(89, new Vector2(7, 4)); // Y
        letras.Add(90, new Vector2(8, 4)); // Z        
    }

    public Vector2 GetFontPos(int value)
    {
        return letras[value];
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

    public int GetX(int valor)
    {
        return 3;
    }

    public int GetY(int valor)
    {
        return 5;
    }

    public void FillPng(ref Texture2D tex, int x0, int y0, string texto)
    {
        Vector2 posXY = new Vector2(0,0);

        for (int i = 0; i < texto.Length; i++)
        {
            posXY = GetFontPos((int)texto[i]);            

            for (int y = y0; y < y0 + 65; y++)
            {
                for (int x = x0; x < x0 + 61; x++) //Goes through each pixel
                {
                    Color32 pixelColour;
                    pixelColour = myFontTex.GetPixel(61 * (int) posXY.x + x - x0, 65 * (int) posXY.y + y - y0);
                    if (pixelColour.a == 0) continue;
                    tex.SetPixel(x + i * 30, y, pixelColour);
                }
            }

            tex.Apply();
        }
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
        FillPng(ref destinoTex, 0, 500, " !()$&ABCDEFGHIJKLMNOPQRSTUVWXYZ");       
        byte[] itemBGBytes = itemBGTex.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/Save Files/imageSavedWithFont.png", itemBGBytes);       
    }   
}


