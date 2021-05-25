private enum AudioSourceController.Command<IDType> // TypeDefIndex: 9865
{
	// Fields
	public int value__; // 0x0
	public const AudioSourceController.Command<IDType> Reset = 0;
	public const AudioSourceController.Command<IDType> DoLoad = 1;
	public const AudioSourceController.Command<IDType> ImmediatePlay = 2;
	public const AudioSourceController.Command<IDType> ImmediateFadeIn = 3;
	public const AudioSourceController.Command<IDType> LoadEnd = 4;
	public const AudioSourceController.Command<IDType> LoadEnd_FadeIn = 5;
	public const AudioSourceController.Command<IDType> LoadEnd_Play = 6;
	public const AudioSourceController.Command<IDType> FadeInEnd = 7;
	public const AudioSourceController.Command<IDType> DoFadeOut = 8;
	public const AudioSourceController.Command<IDType> DoFadeIn = 9;
	public const AudioSourceController.Command<IDType> FadeOutEnd = 10;
	public const AudioSourceController.Command<IDType> DoEnd = 11;
	public const AudioSourceController.Command<IDType> ImmediateEnd = 12;
}

