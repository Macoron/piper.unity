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

        private AudioSource _source;

        private void Awake()
        {
            _source = GetComponent<AudioSource>();
            input.onSubmit.AddListener(OnInputSubmit);
            submitButton.onClick.AddListener(OnButtonPressed);
        }

        private void OnButtonPressed()
        {
            var text = input.text;
            OnInputSubmit(text);
        }

        private void OnInputSubmit(string text)
        {
            var audio = piper.TextToSpeech(text);

            _source.Stop();
            if (_source && _source.clip)
                Destroy(_source.clip);

            _source.clip = audio;
            _source.Play();
        }

        private void OnDestroy()
        {
            if (_source && _source.clip)
                Destroy(_source.clip);
        }
    }

}

