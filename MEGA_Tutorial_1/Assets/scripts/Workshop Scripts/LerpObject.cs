using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpObject : MonoBehaviour
{
    [SerializeField] float secondsMoving;
    [SerializeField] private Vector3 endTransform;
    /*
    void Start()
    {
        StartCoroutine(MoveToDestionation()); 
    }
    
    private IEnumerator MoveToDestionation()
    {
        float timePercentage = 0.0f;
        Vector3 startPos = transform.position;
        while(timePercentage < 1)
        {
            timePercentage += Time.deltaTime / secondsMoving;
            transform.position = MathsLib.VecLerp(startPos, endTransform, timePercentage);
            yield return null;
        }
    }
    */
}
