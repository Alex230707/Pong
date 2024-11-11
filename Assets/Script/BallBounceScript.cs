using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallBounceScript : MonoBehaviour
{
    public float BallVelocity;
    public GameObject coordinate;
    public GameObject[] spawnPoints = new GameObject[5];
    private Rigidbody2D rb;
    Coroutine Respawn;
    Vector3 lastvelocity;
    int Values;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SpawnBall();
    }

    void SpawnBall()
    {
        rb.velocity = Vector3.zero;
        rb.AddForce(new Vector2(BallVelocity*100, Random.Range(-90,90)*5)); 
    }

    void Update()
    {   
        lastvelocity = rb.velocity;
        Debug.Log(BallVelocity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var Speed = lastvelocity.magnitude;
        var Direction = Vector3.Reflect(lastvelocity.normalized, collision.contacts[0].normal);

        rb.velocity = Direction * Speed;
    }

    private void OnBecameInvisible()
    {
            Respawn = StartCoroutine(ReplaceBall());
            Debug.Log("Not Visible");
    }

    IEnumerator ReplaceBall()
    {
        yield return new WaitForSeconds(2);
        gameObject.transform.position = spawnPoints[Random.Range(0,4)].transform.position;
        SpawnBall();
    }
}
