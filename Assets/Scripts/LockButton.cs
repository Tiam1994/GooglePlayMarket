using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LockButton : MonoBehaviour
{
    [SerializeField] GameObject panel;


    public void TurnOn()
    {
        panel.SetActive(true);
    }

    public void TurnOff()
    {
        panel.SetActive(false);
    }
}
