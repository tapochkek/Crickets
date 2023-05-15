using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    //поле, которое хранит данные о точке в которую необходимо телепортироваться
    public Transform teleportPoint;
    //получение данных о позиции игрока, и замена их на позицию точки телепортации
    void OnTriggerEnter(Collider other) 
    {
        other.transform.position = teleportPoint.position;
    }
}
