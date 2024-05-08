using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SanBlasVR
{
    public class BotonActivador : MonoBehaviour
    {
        public List<GameObject> objectsToActivate;
        public string interactorObjectName;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name == interactorObjectName)
            {
                foreach (var obj in objectsToActivate)
                {
                    obj.SetActive(true);
                }
            }
        }
    }
}
