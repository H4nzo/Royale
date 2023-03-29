using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hanzo
{
    public class PlayerAttack : MonoBehaviour
    {
        bool attacking = false;
        public ParticleSystem bulletParticleSystem;
        private ParticleSystem.EmissionModule em;



        // Start is called before the first frame update
        void Start()
        {
            em = bulletParticleSystem.emission;
        }

        // Update is called once per frame
        void Update()
        {
            attacking = Input.GetMouseButton(0);

            if (attacking)
            {
                Attack();
            }
        }

        void Attack(){
            Ray ray = new Ray(bulletParticleSystem.transform.position, bulletParticleSystem.transform.forward);
        }






    }
}

