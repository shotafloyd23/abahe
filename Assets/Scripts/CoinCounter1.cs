using UnityEngine;
using UnityEngine.UI;

public class CoinCounter1 : MonoBehaviour
{

	public int score1 = 0;
	public Text scoreText1;
	public Text resultText1;
	public string coinTagString1;
	public string badCoinTagString1;
	public GameObject menu;
	public playermover2 mymover1;
	public Rigidbody body1;
	public string losestring1;
	public string winstring1;
	int targetscore1;
	void Start() {
		targetscore1 = GameObject.FindGameObjectsWithTag(coinTagString1).Length;
		menu.SetActive (false);

	}


	void OnCollisionEnter(Collision col)
	{
		Debug.Log("Collision " + col.gameObject.name);
	}

	void OnTriggerEnter(Collider other1)
	{
		if (other1.tag == coinTagString1) {
			score1 = score1 + 1;
		} else if (other1.tag == badCoinTagString1) {
			menu.SetActive (true);
			mymover1.enabled = false;
			body1.isKinematic = true;
			resultText1.text = losestring1;


		}

		Debug.Log ("Triggered " + score1 + " " + other1.gameObject.name);

		scoreText1.text = "2nd Score: " + score1;


		Destroy (other1.gameObject);
	}



	void Update() {


		if (menu.activeSelf) {
			mymover1.enabled = false;
			body1.isKinematic = true;
		}

		 else if (GameObject.FindGameObjectsWithTag (coinTagString1).Length == 0) {
			menu.SetActive (true);
			mymover1.enabled = false;
			body1.isKinematic = true;
			if (score1 > targetscore1 / 2) {

				resultText1.text = winstring1;

			} else {
				resultText1.text = losestring1;
			}



		}
		else if (GameObject.FindGameObjectsWithTag (badCoinTagString1).Length ==  10) {
			menu.SetActive (true);
			mymover1.enabled = false;
			body1.isKinematic = true;

	}
}
}










