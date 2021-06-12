using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boumiere : MonoBehaviour
{

    [SerializeField] float speed;
    Rigidbody2D rigid;

    [SerializeField] bool isControled;

    [SerializeField] GameObject loule;
    [SerializeField] public GameObject boumiereNotControled;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if(isControled==true)
        rigid.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        else
            rigid.velocity = new Vector2(-Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);

}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        Debug.Log(boumiereNotControled);
        if (collision.gameObject == boumiereNotControled)
        {
            Debug.Log("Enter here");
            Assemble();
        }
    }

    public void Assemble()
    {
        Vector3 pos = transform.position;
        Debug.Log(pos.x + "  " + boumiereNotControled.transform.position.x + "   " + (pos.x + boumiereNotControled.transform.position.x));
        Instantiate(loule, new Vector3((pos.x + boumiereNotControled.transform.position.x)/2, pos.y, pos.z), Quaternion.identity);
        Destroy(boumiereNotControled);
        Destroy(this.gameObject);
    }
}
