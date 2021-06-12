using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loule : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rigid;
    [SerializeField] float accelerationSpeed;
    [SerializeField] float drag;

    [SerializeField] GameObject boumiereLeft;
    [SerializeField] GameObject boumiereRight;

    [SerializeField] float gapBetweenBoumiere;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Division();
        }
    }

    private void FixedUpdate()
    {             
            rigid.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
    }

    public void Division()
    {
        Vector3 pos = transform.position;
        GameObject boumiereControled;
        GameObject boumiereNotControled;
        boumiereControled=Instantiate(boumiereLeft, new Vector3(pos.x - gapBetweenBoumiere, pos.y, pos.z), Quaternion.identity);
        boumiereNotControled= Instantiate(boumiereRight, new Vector3(pos.x + gapBetweenBoumiere, pos.y, pos.z), Quaternion.identity);
        boumiereControled.GetComponent<Boumiere>().boumiereNotControled = boumiereNotControled;
        Destroy(this.gameObject);
    }
}
