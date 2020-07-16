using UnityEngine;
using System.Collections;
using Windows.Kinect;

public class DetectJoints : MonoBehaviour
{
  public GameObject BodySrcManager;
  public JointType TrackedJoint;
  public JointType TrackedJoint1;
  private BodySourceManager bodyManager;
  private Body[] bodies;
  public float multiplier = 10f;
  void Start ()
  {
     if (BodySrcManager == null)
    {
      Debug.Log("Assign Game Object with Body Source Manager");
    }
     else
     {
       bodyManager = BodySrcManager.GetComponent<BodySourceManager>();
     }
  }
	
void Update ()
{
  if(BodySrcManager == null)
  {
    return;
  }
  if(bodies == null)
  {
    return;
  }
    foreach (var body in bodies)
  {
    if(body == null)
    {
      continue;
    }
      if (body.IsTracked)
      {
        var pos = body.Joints[TrackedJoint].Position;
        gameObject.transform.position = new Vector3(pos.X * multiplier, pos.Y*multiplier);
       }
   }
 }
}
