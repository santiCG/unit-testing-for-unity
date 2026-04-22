using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    float sides = 30.0f;
    float speedMax = 0.3f;
    private static int colorID;

    private Vector3 velocity;
    private Vector3 framePos;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        colorID = Shader.PropertyToID("_Color");
        velocity = new Vector3(Random.Range(0.0f, speedMax),
                        Random.Range(0.0f, speedMax),
                        Random.Range(0.0f, speedMax));
    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }
    
    void Update()
    {
        transform.Translate(velocity);
        framePos = transform.position;

        if (framePos.x > sides)
        {
            velocity.x = -velocity.x;
        }
        if (framePos.x < -sides)
        {
            velocity.x = -velocity.x;
        }
        if (framePos.y > sides)
        {
            velocity.y = -velocity.y;
        }
        if (framePos.y < -sides)
        {
            velocity.y = -velocity.y;
        }
        if (framePos.z > sides)
        {
            velocity.z = -velocity.z;
        }
        if (framePos.z < -sides)
        {
            velocity.z = -velocity.z;
        }

        rend.material.SetColor(colorID, new Color(framePos.x/sides,
                                                  framePos.y/sides,
                                                  framePos.z/sides));
    }
}
