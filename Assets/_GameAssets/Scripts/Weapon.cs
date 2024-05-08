using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEditor;
using UnityEngine;

namespace SanBlasVR
{
    public class Weapon : MonoBehaviour
    {
        public GameObject prefabProjectile;
        public Transform spawnPoint;
        public float force;
        public bool infiniteBullets = true;
        public int bullets = 10;

        public void ApretarGatillo()
        {
            if (infiniteBullets || bullets > 0)
            {
                Fire();
            }
        }
        private void Fire()
        {
            if (infiniteBullets || bullets > 0)
            {
                bullets--;
                GameObject bullet = Instantiate(prefabProjectile, spawnPoint.position, spawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().AddForce(spawnPoint.transform.forward * force);
            }
        }
    }
}
