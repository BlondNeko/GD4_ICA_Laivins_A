using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void Swap()
    {
        renderer = GetComponent<Renderer>();
        renderer.enabled = true;
        renderer.sharedMaterial = material;
    }
}
