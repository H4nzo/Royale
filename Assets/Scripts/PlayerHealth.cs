using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hanzo
{

    public class PlayerHealth : MonoBehaviour
    {
        public float health = 100;


        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void ReduceHealth(float damage)
        {
            health -= damage;

            if (health < 1)
            {
                if (this.gameObject.tag == "Enemy")
                {
                    Destroy(this.gameObject);
                }
                if (this.gameObject.tag == "Player")
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
                }
            }
        }
    }

}