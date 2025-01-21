using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    public int lvl = 1;
    public float speed = 1.2f;
    public Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        health += lvl; //здоровье и лвл
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;

    }
}
