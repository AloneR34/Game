using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubsHendler : MonoBehaviour

{
    public GameObject[] sqares;
    public int RandoMs;

    public void OnClick()
    {
        for (int x = 0; x < sqares.Length; x++)
        {
            RandoMs = Random.Range(1, 3);
            if (RandoMs == 1)
            {
                sqares[x].SetActive(false);
            }
            if (RandoMs == 2)
            {
                sqares[x].SetActive(true);
            }
            RandoMs = 0;
        }
    }
}
