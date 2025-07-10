using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    private float cameraZ;

    // Start is called before the first frame update
    void Start()
    {
        cameraZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + 0.5f, player.position.y + 0.5f, cameraZ);
    }
}
