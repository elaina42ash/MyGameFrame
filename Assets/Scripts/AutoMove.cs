using UnityEngine;

public class AutoMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(10 * Time.deltaTime * Vector3.forward);
    }
}
