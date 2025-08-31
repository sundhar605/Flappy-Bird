using UnityEngine;

public class pipe_spawner : MonoBehaviour
{

    public GameObject pipe;
    public float time;
    public float spawn_rate = 2f;
    public float height_offset = 10f;

    void Start()
    {
        spawn();
    }

    void Update()
    {
        if(time < spawn_rate)
        {
            time += Time.deltaTime;
        }
        else
        {
            spawn();
            time = 0;
        }
    }
    void spawn()
    {
        float lowest_point = transform.position.y - height_offset;
        float highest_point = transform.position.y + height_offset;

        Instantiate(pipe, new Vector3(transform.position.x , Random.Range(highest_point,lowest_point),0), transform.rotation);
    }
}
