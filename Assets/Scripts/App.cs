using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class App : MonoBehaviour
{
    public string name;
    public Sprite icon;
    public Sprite[] screenshots;
    [TextArea(10, 10)] public string about;
}
