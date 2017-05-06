using UnityEngine;

public class CoinRotor : MonoBehaviour
{
    public float rotationSpeed;    

	void Update ()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
	}
}
