using UnityEngine;

public class pipe_move : MonoBehaviour
{

    public float pipemove_speed = 0;
    float dead_zone = -70f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipemove_speed )* Time.deltaTime;
        if(transform.position.x < dead_zone)
        {
            Destroy(gameObject);
        }
    }
}
