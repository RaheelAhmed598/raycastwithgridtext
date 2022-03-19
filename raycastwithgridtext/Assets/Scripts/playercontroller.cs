using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
   private Rigidbody playerrb;
   public GameMnager gm;
   Ray ray,rayz,rayx,rayxx;
   RaycastHit raycasthit;
    // Start is called before the first frame update
    void Start()
    {
        gm=GameObject.FindGameObjectWithTag("gm").GetComponent<GameMnager>();
        playerrb=GetComponent<Rigidbody>();
        playerrb.position=new Vector3(gm.row-gm.row,transform.position.y,gm.column-gm.column);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastMovement();
       
    }

    void RaycastMovement()
    {
        ray = new Ray(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z + 0.5f), Vector3.forward);
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Physics.Raycast(ray, out raycasthit, 2f))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
            }
        }
        rayz = new Ray(new Vector3(transform.position.x, transform.position.y - 1, transform.position.z - 0.5f), Vector3.back);
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (Physics.Raycast(rayz, out raycasthit, 2f))
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);
        }
        rayx = new Ray(new Vector3(transform.position.x + 0.5f, transform.position.y - 1, transform.position.z), Vector3.left);
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (Physics.Raycast(rayx, out raycasthit, 2f))
            {
                transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
            }
        }
        rayxx = new Ray(new Vector3(transform.position.x + 0.5f, transform.position.y - 1, transform.position.z), Vector3.right);
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (Physics.Raycast(rayxx, out raycasthit, 2f))
            {
                transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);
            }
        }
    }
}
