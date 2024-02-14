using System;
using UnityEngine;
using UnityEngine.UI;

namespace Piper.Samples
{
    public class PiperSample : MonoBehaviour
    {
        public PiperManager piper;
        public InputField input;
        public Button submitButton;
        public Text timerText;
        public GameObject cube;

        private AudioSource _source;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            input.onSubmit.AddListener(OnInputSubmit);
            submitButton.onClick.AddListener(OnButtonPressed);
        }

        private void Update()
        {
            cube.transform.Rotate(Vector3.one * (Time.deltaTime * 10f));
        }

        private void OnButtonPressed()
        {
            var text = input.text;
            OnInputSubmit(text);
        }

        private async void OnInputSubmit(string text)
        {
            var sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            var audio = piper.TextToSpeech(text);
            timerText.text = $"Time: {sw.ElapsedMilliseconds} ms";

            _source.Stop();
            if (_source && _source.clip)
                Destroy(_source.clip);

            _source.clip = await audio;
            _source.Play();
        }

        private void OnDestroy()
        {
            if (_source && _source.clip)
                Destroy(_source.clip);
        }
    }

}

