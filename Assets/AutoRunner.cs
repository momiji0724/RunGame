using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRunner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var stage = GameObject.CreatePrimitive(PrimitiveType.Cube);
        stage.transform.localScale = new Vector3(3, 1, 100);
        stage.transform.position = new Vector3(0, 0, 40);

        var player = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        player.transform.position = new Vector3(0, 0.75f, -5);
        player.transform.localScale = new Vector3(0.5F, 0.5F, 0.5F);

        for(var i = 0;i<10; i++) 
        {
            var obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obstacle.transform.position = new Vector3(0, 1, i * 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
