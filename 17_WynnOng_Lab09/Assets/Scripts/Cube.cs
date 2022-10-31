using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int health;
    // Update is called once per frame
    void Update()
    {
        DisableOnDeath();
    }

    public void DisableOnDeath()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
