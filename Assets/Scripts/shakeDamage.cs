using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class shakeDamage : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    private Vector2 initial;
    public float force;


    public void OnEnable()
    {
        PlayerControl.OnPlayerCollision += ShakeCamera;
    }
    public void ShakeCamera(float time, float intensity)
    {
        initial = virtualCamera.transform.position;
        float x = initial.x + Random.Range(-intensity, intensity) * force;
        float y = initial.y + Random.Range(-intensity, intensity) * force;
        x = Mathf.MoveTowards(x, initial.x, time * Time.deltaTime);
        y = Mathf.MoveTowards(y, initial.y, time * Time.deltaTime);
        virtualCamera.transform.position = new Vector2(x, y);
        //virtualCamera.transform.position = new Vector2(transform.position.x, transform.position.y);
        //Vector2 shake = new Vector2(transform.position.x * intensity+ time, transform.position.y * intensity + time);

    }
  
}
