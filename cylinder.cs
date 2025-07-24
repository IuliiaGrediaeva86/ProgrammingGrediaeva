using UnityEngine;
using UnityEngine.UIElements;

public class cylinder : MonoBehaviour
{

    public float speed = 15;
    public float amplitude = 10;

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.PingPong(Time.time, speed * 2) - amplitude;
        transform.position = new(offset, 2, 4);
    }
}
