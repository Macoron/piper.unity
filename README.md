# piper.unity

This is the Unity3d port of [Piper](https://github.com/rhasspy/piper) text-to-speech (TTS) library. It provides fast, local, and high-quality speech generation for multiple languages. Inference is done by using [Unity Sentis](https://docs.unity3d.com/Packages/com.unity.sentis@latest).

Supports only Windows x86-64.

## Samples

https://github.com/Macoron/piper.unity/assets/6161335/7ab818f0-acd6-46cf-ab5b-09c847aca2dc

*"en_US-lessac-medium" model tested on English text*

https://github.com/Macoron/piper.unity/assets/6161335/fd6a5826-23e7-4dca-acdd-00469d71c882

*"ru_RU-ruslan-medium" model tested on Russian text*

## Getting started

1. Clone this repository and open it as a regular Unity project.
2. Download a `.onnx` model file, such as [en_US-lessac-medium.onnx](https://huggingface.co/rhasspy/piper-voices/resolve/v1.0.0/en/en_US/lessac/medium/en_US-lessac-medium.onnx)
3. Place it somewhere inside your `Assets` folder. Sentis should automatically transform it into model asset
4. Open `Assets/Piper/Samples/PiperSample` scene in Unity Editor
5. Find `Piper` GameObject and set `PiperManager.Model` field to previously downloaded model 
6. Press Play and test speech generation

You can find more [piper models here](https://huggingface.co/rhasspy/piper-voices). Each model comes with a model card describing the training dataset and license (for example [en_US-lessac-medium model card](https://huggingface.co/rhasspy/piper-voices/resolve/v1.0.0/en/en_US/lessac/medium/MODEL_CARD)). 

You would also need to set correct the  "voice" (language code) and sample rate for the model. This can be find in json located near the model, like in [en_US-lessac-medium.onnx.json](https://huggingface.co/rhasspy/piper-voices/resolve/v1.0.0/en/en_US/lessac/medium/en_US-lessac-medium.onnx.json).

## License

piper.unity is released under the GPLv3 license.

It uses [eSpeak NG](https://github.com/espeak-ng/espeak-ng) compiled libraries and data which are under GPLv3 license.

It also uses [Piper Phonemization fork](https://github.com/Macoron/piper-phonemize) compiled library which is under MIT license.

Models aren't included in this repository. Please contact the original model's creators to learn more about their licenses.
