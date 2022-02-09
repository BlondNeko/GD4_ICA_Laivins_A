using System;
using System.Collections;
using System.Collections.Generic;
using System.Media;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMat : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public Material material;
    public Renderer renderer;
    public bool level1 = false;
    public bool lastLevel = false;
    public String unloadLevel;
    public String nextLevel;
    public bool levelKey;

    public void Swap()
    {
        
        renderer = GetComponent<Renderer>();
        renderer.enabled = true;
        renderer.sharedMaterial = material;

        if (levelKey&&!lastLevel)
        {

            if (!level1)
            {
                SceneManager.UnloadSceneAsync(unloadLevel);
            }
            SceneManager.LoadScene(nextLevel, LoadSceneMode.Additive);
        }
        else if(lastLevel)
        {
            SceneManager.LoadSceneAsync("EndScene");
        }
    }
}
