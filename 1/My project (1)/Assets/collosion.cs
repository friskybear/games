using UnityEngine.UI;
using UnityEngine;

public class collosion : MonoBehaviour
{
  
    public Text text_score;
    public Transform transform;
    int score = 0;
    Vector3 pose;
    public void OnCollisionEnter(Collision collision)
    {
        score = (int.Parse(text_score.text) + 1);
        text_score.text = score.ToString();

       

        Random random = new Random();
        int nextZ = random.Next(-49, 49 + 1);
        int nextY = random.Next(-49, 49 + 1);
        pose[0] = 1.00f;
        pose[1] = nextY;
        pose[2] = nextZ;
        transform.Position = pose;

    }
}
