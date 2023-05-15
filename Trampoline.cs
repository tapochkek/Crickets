using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //увеличение силы прыжка при в ходе в триггер
        other.GetComponent<Jump>().jumpStrength = 10;
    }
    void OnTriggerExit(Collider other)
    {
        //возвращение обычной силы прыжка при выходе из триггера
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
