using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FunctionTimer
{

    public static FunctionTimer Create(Action action, float timer)
    {

        GameObject gameObject = new GameObject("FunctionTimer", typeof(MonoBehaviourHood));
        FunctionTimer functionTimer = new FunctionTimer(action, timer, gameObject);


        gameObject.GetComponent<MonoBehaviourHood>().onUpdate = functionTimer.Update;

        return functionTimer;
    }

    private class MonoBehaviourHood : MonoBehaviour
    {
        public Action onUpdate;
        private void Update()
        {
            if (onUpdate != null) onUpdate();
        }
    }
    private Action action;
    private float timer;
    private GameObject gameObject;

    public float timeToWait = 1f;
    public float done = 0.0f;

    private bool isDestroyed;
    private FunctionTimer(Action action, float timer, GameObject gameObject)
    {
        this.action = action;
        this.timer = timer;
        this.gameObject = gameObject;
        isDestroyed = false;
    }

    public void Update()
    {
        if (!isDestroyed)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                if (Time.time > done)
                {
                    done = Time.time + timeToWait;
                    action();
                    
                }

            }
        }
    }

    private void DestroySelf()
    {
        isDestroyed = true;

    }

}
