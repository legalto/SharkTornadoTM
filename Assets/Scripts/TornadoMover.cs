using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Test Comment A. Liu
public class TornadoMover : MonoBehaviour {

    public static int Tornados = 0;

    public int TornadoId { get;  set; }
    public Transform target;
    public float speed = 5f;
    public Vector3 endPos;
    public int areasize = 4;
    public Vector3 center { get; set; }

    // Use this for initialization
    public void Start () {
        Tornados += 1;
        TornadoId = Tornados;
        transform.position = new Vector3(10*areasize*Random.value*GenerateSign(),18,10*areasize*GenerateSign()*Random.value);
        endPos = new Vector3(transform.position.x*-1, 18, transform.position.z*-1);
    }
	
	// Update is called once per frame
	 public void Update () {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, endPos, step);
        center = transform.position;
    }

    private int GenerateSign()
    {
        float num = Random.value;
        if (num < 0.50001f)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
// A.Liu Testing append

