using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiadorLuzAmbiental : MonoBehaviour
{
    
    void Start()
    {
        CambiarLuzAmbiental();    
    }

    void CambiarLuzAmbiental()
    {
        RenderSettings.ambientLight = new Color32(0, 0, 0, 0);
    }
}
