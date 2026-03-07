using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRunner : MonoBehaviour
{
    private GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        var stage = GameObject.CreatePrimitive(PrimitiveType.Cube);
        stage.transform.localScale = new Vector3(3, 1, 100);
        stage.transform.position = new Vector3(0, 0, 40);

        _player = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        _player.transform.position = new Vector3(0, 0.75f, -5);
        _player.transform.localScale = new Vector3(0.5F, 0.5F, 0.5F);
        _player.AddComponent<Rigidbody>();
        var playerRenderer = _player.GetComponent<Renderer>();
        playerRenderer.material.color = Color.blue;

        for(var i = 0;i<10; i++) 
        {
            var x = Random.Range(-1, 2);
            var obstacle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obstacle.transform.position = new Vector3(x, 1, i * 5);

            var obstacleRenderer = obstacle.GetComponent<Renderer>();
            obstacleRenderer.material.color = Color.yellow;
        }
        Camera.main.transform.rotation = Quaternion.Euler(90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        var r = _player.GetComponent<Rigidbody>();
        r.AddForce(0, 0, 1);
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            r.AddForce(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            r.AddForce(1, 0, 0);
        }

        var p = _player.transform.position;
        Camera.main.transform.position = new Vector3(p.x, p.y + 5, p.z + 2);
    }
}
