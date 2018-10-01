using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movingTarget : MonoBehaviour {

    public float timer;
    public int newtarget;
    public float speed;
    public NavMeshAgent nav;
    public Vector3 Target;
    private GameObject[] RandomPoint;
    private int current;


    void Start() {
        nav = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update() {
        timer += Time.deltaTime;
        if(timer >= newtarget) {
            newTarget();
            timer = 0;
            nav.speed = speed;
        }
    }

    void newTarget() {
        float newX = gameObject.transform.position.x;
        float newZ = gameObject.transform.position.z;
        float xPos = newX + Random.Range(newX-100,newX+100);
        float zPos = newZ + Random.Range(newZ-100,newZ+100);

        Target = new Vector3(xPos, gameObject.transform.position.y, zPos);
        nav.SetDestination(Target);
    }

    // Use this for initialization
    //private void Start () {
    //       nm = this.GetComponent<NavMeshAgent>();
    //       RandomPoint = GameObject.FindGameObjectsWithTag("capsule");
    //}

    //// Update is called once per frame
    //private void Update () {
    //    if(nm.hasPath == false) {
    //        current = Random.Range(0, RandomPoint.Length+1);
    //        nm.SetDestination(RandomPoint[current].transform.position);
    //    }
    //}

}
