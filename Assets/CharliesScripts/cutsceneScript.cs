using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneScript : MonoBehaviour
{
    public List<Vector3> movement_points;

    public bool is_active = false;
    public bool loop = false;
    public bool teleport_to_start = false;
    public float speed_mod;

    private bool reverse = false;
    private bool move_to_next_point = true;
    public int current_point;

    public GameObject player_cam;
    public GameObject lookAt;
    public Camera scene_camera;
    public GameObject player_ref;

    private bool do_once = false;


    void Start()
    {
        // movement_points[0] = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_active)
        {
            if(lookAt != null)
                this.transform.LookAt(lookAt.transform);

            if(!do_once)
            {
                do_once = true;
                movement_points[movement_points.Count-1] = this.transform.position;
                movement_points[0] = player_cam.transform.position;
                this.transform.position = movement_points[0];

                player_cam.GetComponent<Camera>().enabled = false;
                scene_camera.enabled = true;
            }

            if (move_to_next_point)
            {
                updateMovement();
            }
            if(reverse && AlmostEqual(this.transform.position, movement_points[0]))
            {
                print("Done!");
                player_cam.GetComponent<Camera>().enabled = true;
                scene_camera.enabled = false;
                print("Destroy script!");
                Destroy(this);
            }
            flipMovement();
        }
    }

    private void updateMovement()
    {

        float step = speed_mod * Time.deltaTime;
        this.transform.position = Vector3.MoveTowards(this.transform.position, movement_points[current_point], step);
    }

    private void flipMovement()
    {
        if (AlmostEqual(this.transform.position, movement_points[current_point]))
        {

            if (reverse)
            {
                //is reverseing
                if (current_point == 0)
                {
                    if (teleport_to_start)
                    {
                        current_point = 0;
                        transform.position = movement_points[0];
                    }
                    else
                    {
                        reverse = false;
                    }
                }
                else
                {
                    current_point -= 1;
                }
            }
            else
            {
                //is not reverseing 
                if (current_point == movement_points.Count - 1)
                {
                    if (loop)
                    {
                        if (teleport_to_start)
                        {
                            current_point = 0;
                            transform.position = movement_points[0];
                        }
                        else
                        {
                            reverse = true;
                            Destroy(lookAt);
                            lookAt = player_ref;
                        }

                    }
                    else
                    {
                        is_active = false;
                    }
                }
                else
                {
                    current_point += 1;
                    if (current_point > 1)
                    {
                        lookAt.GetComponent<MeshRenderer>().enabled = false;
                        print("hide");
                    }
                }
            }
        }
    }

    private bool AlmostEqual(Vector3 v1, Vector3 v2)
    {
        if (Mathf.Abs(v1.x - v2.x) > 0.1) return false;
        if (Mathf.Abs(v1.y - v2.y) > 0.1) return false;
        if (Mathf.Abs(v1.z - v2.z) > 0.1) return false;

        return true;
    }
}
