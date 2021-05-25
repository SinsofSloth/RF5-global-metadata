[ExtensionAttribute] // RVA: 0x157360 Offset: 0x157461 VA: 0x157360
public static class DOTweenModuleAudio // TypeDefIndex: 11728
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1AFF70 Offset: 0x1B0071 VA: 0x1AFF70
	// RVA: 0x1C9B630 Offset: 0x1C9B731 VA: 0x1C9B630
	public static TweenerCore<float, float, FloatOptions> DOFade(AudioSource target, float endValue, float duration) { }

	[ExtensionAttribute] // RVA: 0x1AFF80 Offset: 0x1B0081 VA: 0x1AFF80
	// RVA: 0x1C9B7B0 Offset: 0x1C9B8B1 VA: 0x1C9B7B0
	public static TweenerCore<float, float, FloatOptions> DOPitch(AudioSource target, float endValue, float duration) { }

	[ExtensionAttribute] // RVA: 0x1AFF90 Offset: 0x1B0091 VA: 0x1AFF90
	// RVA: 0x1C9B910 Offset: 0x1C9BA11 VA: 0x1C9B910
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(AudioMixer target, string floatName, float endValue, float duration) { }

	[ExtensionAttribute] // RVA: 0x1AFFA0 Offset: 0x1B00A1 VA: 0x1AFFA0
	// RVA: 0x1C9BA80 Offset: 0x1C9BB81 VA: 0x1C9BA80
	public static int DOComplete(AudioMixer target, bool withCallbacks = False) { }

	[ExtensionAttribute] // RVA: 0x1AFFB0 Offset: 0x1B00B1 VA: 0x1AFFB0
	// RVA: 0x1C9BB00 Offset: 0x1C9BC01 VA: 0x1C9BB00
	public static int DOKill(AudioMixer target, bool complete = False) { }

	[ExtensionAttribute] // RVA: 0x1AFFC0 Offset: 0x1B00C1 VA: 0x1AFFC0
	// RVA: 0x1C9BB80 Offset: 0x1C9BC81 VA: 0x1C9BB80
	public static int DOFlip(AudioMixer target) { }

	[ExtensionAttribute] // RVA: 0x1AFFD0 Offset: 0x1B00D1 VA: 0x1AFFD0
	// RVA: 0x1C9BBF0 Offset: 0x1C9BCF1 VA: 0x1C9BBF0
	public static int DOGoto(AudioMixer target, float to, bool andPlay = False) { }

	[ExtensionAttribute] // RVA: 0x1AFFE0 Offset: 0x1B00E1 VA: 0x1AFFE0
	// RVA: 0x1C9BC80 Offset: 0x1C9BD81 VA: 0x1C9BC80
	public static int DOPause(AudioMixer target) { }

	[ExtensionAttribute] // RVA: 0x1AFFF0 Offset: 0x1B00F1 VA: 0x1AFFF0
	// RVA: 0x1C9BCF0 Offset: 0x1C9BDF1 VA: 0x1C9BCF0
	public static int DOPlay(AudioMixer target) { }

	[ExtensionAttribute] // RVA: 0x1B0000 Offset: 0x1B0101 VA: 0x1B0000
	// RVA: 0x1C9BD60 Offset: 0x1C9BE61 VA: 0x1C9BD60
	public static int DOPlayBackwards(AudioMixer target) { }

	[ExtensionAttribute] // RVA: 0x1B0010 Offset: 0x1B0111 VA: 0x1B0010
	// RVA: 0x1C9BDD0 Offset: 0x1C9BED1 VA: 0x1C9BDD0
	public static int DOPlayForward(AudioMixer target) { }

	[ExtensionAttribute] // RVA: 0x1B0020 Offset: 0x1B0121 VA: 0x1B0020
	// RVA: 0x1C9BE40 Offset: 0x1C9BF41 VA: 0x1C9BE40
	public static int DORestart(AudioMixer target) { }

	[ExtensionAttribute] // RVA: 0x1B0030 Offset: 0x1B0131 VA: 0x1B0030
	// RVA: 0x1C9BEB0 Offset: 0x1C9BFB1 VA: 0x1C9BEB0
	public static int DORewind(AudioMixer target) { }

	[ExtensionAttribute] // RVA: 0x1B0040 Offset: 0x1B0141 VA: 0x1B0040
	// RVA: 0x1C9BF20 Offset: 0x1C9C021 VA: 0x1C9BF20
	public static int DOSmoothRewind(AudioMixer target) { }

	[ExtensionAttribute] // RVA: 0x1B0050 Offset: 0x1B0151 VA: 0x1B0050
	// RVA: 0x1C9BF90 Offset: 0x1C9C091 VA: 0x1C9BF90
	public static int DOTogglePause(AudioMixer target) { }
}

