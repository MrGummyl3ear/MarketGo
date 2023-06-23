using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Target",menuName="ImageTarget")]
public class ImageTarget:ScriptableObject {
    public string requirements;
    public string warranty;
    public GameObject rate;
    public Sprite Image;	
}
