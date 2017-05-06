using UnityEngine.SceneManagement;
using UnityEngine;

public class menuu : MonoBehaviour {


	public void restart() {
		SceneManager.LoadScene(0);

	}
	public void Quitgame() {
		Application.Quit();
	}

}
