using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonAscensor : MonoBehaviour
{
    public int siguienteEscena;
    public string interactorObjectName;
    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == interactorObjectName)
            {
                SceneManager.LoadScene(siguienteEscena);        
            }
        }
}
