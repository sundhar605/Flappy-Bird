using Unity.VisualScripting;
using UnityEngine;

public class score : MonoBehaviour
{
    public logic_script logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    void Update()
    {
        
    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.score_increas();
        }
    }
}
