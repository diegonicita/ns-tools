using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleSQL;

public class Quest
{
    public int numero { get; set; }
    [PrimaryKey]
    public int id { get; set; }
    public string texto { get; set; }
    public int opciones { get; set; }
    public int correcta { get; set; }
    public int tema { get; set; }
    public int ano { get; set; }
    public int examen { get; set; }
    public string opcion1 { get; set; }
    public string opcion2 { get; set; }
    public string opcion3 { get; set; }
    public string opcion4 { get; set; }
    public string opcion5 { get; set; }
    public int clasifica1 { get; set; }
    public int clasifica2 { get; set; }
    public int clasifica3 { get; set; }
    public int clasifica4 { get; set; }
    public int clasifica5 { get; set; }
    public string comentario { get; set; }

}
