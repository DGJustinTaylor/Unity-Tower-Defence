using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour {

    public Color hoverColor;
    private Color startColor;

    private GameObject turret;

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseDown()
    {
        if (turret != null)
        {
            //TODO: Display message
            return;
        }

        GameObject turretToBuild = BuildManager.instance.getTurretToBuilt();
        turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);
    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
