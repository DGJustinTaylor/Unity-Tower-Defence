using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform target;

    public float speed = 70f;

    public GameObject impact;

    public void Seek(Transform _target)
    {
        target = _target;
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(target ==  null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;

        float distancePF = speed * Time.deltaTime;

        if(dir.magnitude <= distancePF)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distancePF, Space.World);
	}

    void HitTarget()
    {
        GameObject effect = (GameObject)Instantiate(impact, transform.position, transform.rotation);

        Destroy(effect, 2f);
        Destroy(target.gameObject);
        Destroy(gameObject);
    }
}
