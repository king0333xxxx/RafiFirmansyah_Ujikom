using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="AnimalList",menuName ="Animal/AnimalList")]
public class SO_Animal : ScriptableObject
{
    public List<GameObject> AnimalList;
}
