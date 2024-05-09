using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearths : MonoBehaviour
{

    public Health healthScript;
    public Image[] Hearth;

    public void Update()
    {
        if (healthScript.health < Hearth.Length)
        {
            for (int i = 0; i < Hearth.Length; i++)
            {
                Hearth[i].enabled = false;
            }
            for (int i = 0; i < healthScript.health; i++)
            {
                Hearth[i].enabled = true;
            }
        }
    }
}
