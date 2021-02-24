using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Canvas canvas;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        //canvas.transform.Rotate(180, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 v = camera.transform.position - transform.position;
        v.x = v.z = 0.0f;
        canvas.transform.LookAt(camera.transform.position - v);
        canvas.transform.Rotate(0, 180, 0);
        */
    }

    public IEnumerator CorrectAnswer()
    {
        yield return new WaitForSeconds(2);

    }
}
