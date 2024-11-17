using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRotationController : MonoBehaviour
{
    void Update()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z + 80 * Time.deltaTime);
    }
}
