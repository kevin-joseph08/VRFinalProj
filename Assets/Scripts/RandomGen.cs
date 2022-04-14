using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGen : MonoBehaviour
{
    public int obj;

    public GameObject coin;

    void Awake()
    {
        RaycastHit hit;

        for (int i = 0; i < obj; i++)
        {
            Vector3 position = new Vector3(Random.Range(-100.0f, 100.0f), 0, Random.Range(-100.0f, 100.0f));
            //Do a raycast along Vector3.down -> if you hit something the result will be given to you in the "hit" variable
            //This raycast will only find results between +-100 units of your original"position" (ofc you can adjust the numbers as you like)
            if (Physics.Raycast(position + new Vector3(0, 100.0f, 0), Vector3.down, out hit, 200.0f))
            {
                Instantiate(coin, hit.point, Quaternion.identity);
            }
            else
            {
                Debug.Log("there seems to be no ground at this position");
            }
        }
    }
}
