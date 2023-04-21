using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public List<Transform> points;

    int index;

    [Range(0.0f, 1.0f)]
    public float time = 0.0f;

    // Update is called once per frame
    void Update()
    {
        float t = time / 2.0f;
        Vector3 src = points[index].position;
        Vector3 dst = points[(index + 1) % points.Count].position;
        transform.position = Vector3.Lerp(src, dst, t);

        time += Time.deltaTime;
        if (time >= 2.0f)
        {
            time = 0.0f;
            ++index;
            index %= points.Count;
        }
    }
}
