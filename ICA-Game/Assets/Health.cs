using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChageHealth()
    {
        health -= 1;
        if (health == 0)
        {
            SceneManager.LoadScene("EndScene_2", LoadSceneMode.Single);
        }
    }
}
