using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SanBlasVR
{
    public class Boton : MonoBehaviour
    {
        public Color color;
        public string interactorObjectName;
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == interactorObjectName)
            {
                GetComponent<MeshRenderer>().material.color = color;
            }
        }
    }
}
