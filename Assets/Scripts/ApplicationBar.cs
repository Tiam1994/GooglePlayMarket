using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplicationBar : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Text name;
    [SerializeField] private Text about;
    [SerializeField] private Image[] screenshots;

    public void SetApp(App app)
    {
        this.icon.sprite = app.icon;
        this.name.text = app.name;
        this.about.text = app.about;

        for (int i = 0; i < app.screenshots.Length; i++)
        {
            this.screenshots[i].sprite = app.screenshots[i];
        }
    }
}
