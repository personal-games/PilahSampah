using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour {
    public static int score;
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

	// Use this for initialization
	private void Start () {
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
        MediaPlayerBenar.clip = audioBenar;

        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audioSalah;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            score += 25;
            textScore.text = score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }else
        {
            score -= 5;
            textScore.text = score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }
    }

    
}
