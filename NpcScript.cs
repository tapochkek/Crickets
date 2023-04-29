using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcScript : MonoBehaviour
{
    //здоровье нпс
    public int health = 5;
    //уровень нпс
    public int level = 1;
    //скорость нпс
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        //здоровье зависит от уровня, умножаясь на значение уровня
        health *= level;
        //вывод значения здоровья нпс
        print("Здоровье нпс - " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
