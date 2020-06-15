using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Objects;
    void Start()
    {
        InvokeRepeating("RandomObject", 0, 3f);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Return))
			CancelInvoke("RandomObject");

		if (Input.GetKeyDown(KeyCode.Space))
			RandomObject();

		if (Input.GetKeyDown(KeyCode.Alpha1))
			Generuj(0);

		if (Input.GetKeyDown(KeyCode.Alpha2))
			Generuj(1);

		if (Input.GetKeyDown(KeyCode.Alpha3))
			Generuj(2);

		if (Input.GetKeyDown(KeyCode.Alpha4))
			Generuj(3);

		if (Input.GetKeyDown(KeyCode.Alpha5))
			Generuj(4);
	}
	void RandomObject()
	{
		Generuj(Random.Range(0, Objects.Length));
	}
	void Generuj(int num)
	{
		Instantiate(Objects[num], transform.position, Quaternion.identity);
	}
}
