using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public float period = 1;
    private float lastBallTime;

    public CannonBall prefab;
    public Transform startTransform;

    public float rotationSpeed;
    private float direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        lastBallTime = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        lastBallTime += Time.deltaTime;

        if (lastBallTime >= period)
        {
            lastBallTime = 0;
            Instantiate(prefab, startTransform.position, startTransform.rotation);
        }

        if(lastBallTime > period/2)
        {
            float rotationValue = rotationSpeed * direction * Time.deltaTime;
            Vector3 rotateVector = new Vector3(0,0, rotationValue);
            startTransform.Rotate(rotateVector);

            if(startTransform.rotation.z < -0.999 || startTransform.rotation.z >0)
            {
                direction *= -1;
            }
        }
    }
}
