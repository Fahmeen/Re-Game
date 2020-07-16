using UnityEngine;
using System.Collections;

public class RotatorZ : MonoBehaviour 
{
  void Start () 
    {
    }

void Update () 
    {
        transform.Rotate(new Vector3(360, 360, 360) * Time.deltaTime);
    }
}

