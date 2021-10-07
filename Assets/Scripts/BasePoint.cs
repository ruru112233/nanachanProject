using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePoint : MonoBehaviour
{
    RectTransform rect = null;

    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();

        var centerPosition = rect.position;

        for (int elementId = 0; elementId < transform.childCount; elementId++)
        {
            var child = transform.GetChild(elementId) as RectTransform;
            var rotation = (centerPosition - child.position).normalized;
            child.transform.rotation = Quaternion.FromToRotation(Vector3.down, rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
