using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dangerWalking : MonoBehaviour
{
    public int RandoMs;
    public Rigidbody dangerrridg;
    public bool running;



    public float speed = 5f; //unit per second

    public void Start()
    {
     
    }


    //Destroy(other.gameObject);
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PlayerTag")) //тег  игрока

        {
            SceneManager.LoadScene("Endding");
        }
    }

        void Update()
    {

        // Do the job until running is set to false

        RandoMs = Random.Range(1, 5);

            if (RandoMs == 1)
            {
                dangerrridg.AddForce(0, 0, speed * Time.deltaTime);
                //player.transform.position += (new Vector3(0, 1)*Time.deltaTime);

            }
            if (RandoMs == 2)
            {
                dangerrridg.AddForce(0, 0, -speed * Time.deltaTime);
                //player.transform.position += (new Vector3(0, -1) * Time.deltaTime);

            }
            if (RandoMs == 3)
            {
                dangerrridg.AddForce(-speed * Time.deltaTime, 0, 0);
                //player.transform.position += (new Vector3(-1, 0) * Time.deltaTime);

            }
            if (RandoMs == 4)
            {
                dangerrridg.AddForce(speed * Time.deltaTime, 0, 0);
                //player.transform.position += (new Vector3(1, 0) * Time.deltaTime);

            }

            RandoMs = 0;
            // wait for seconds

        }

    }



