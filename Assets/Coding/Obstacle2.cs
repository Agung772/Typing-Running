using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * 2 * Time.deltaTime);
    }
}
