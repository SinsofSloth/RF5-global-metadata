public class VideoPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 11808
{
	// Fields
	public VideoPlayer videoPlayer; // 0x10
	public VideoClip videoClip; // 0x18
	public bool mute; // 0x20
	public bool loop; // 0x21
	public double preloadTime; // 0x28
	public double clipInTime; // 0x30
	private bool playedOnce; // 0x38
	private bool preparing; // 0x39

	// Methods

	// RVA: 0x1CFB0D0 Offset: 0x1CFB1D1 VA: 0x1CFB0D0
	public void PrepareVideo() { }

	// RVA: 0x1CFB510 Offset: 0x1CFB611 VA: 0x1CFB510
	private void LoopPointReached(VideoPlayer vp) { }

	// RVA: 0x1CFB520 Offset: 0x1CFB621 VA: 0x1CFB520 Slot: 19
	public override void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1CFB820 Offset: 0x1CFB921 VA: 0x1CFB820 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1CFB9F0 Offset: 0x1CFBAF1 VA: 0x1CFB9F0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1CFBBF0 Offset: 0x1CFBCF1 VA: 0x1CFBBF0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1CFBDF0 Offset: 0x1CFBEF1 VA: 0x1CFBDF0 Slot: 13
	public override void OnGraphStart(Playable playable) { }

	// RVA: 0x1CFBE00 Offset: 0x1CFBF01 VA: 0x1CFBE00 Slot: 14
	public override void OnGraphStop(Playable playable) { }

	// RVA: 0x1CFBEA0 Offset: 0x1CFBFA1 VA: 0x1CFBEA0 Slot: 16
	public override void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x1CFB8E0 Offset: 0x1CFB9E1 VA: 0x1CFB8E0
	public void PlayVideo() { }

	// RVA: 0x1CFBB60 Offset: 0x1CFBC61 VA: 0x1CFBB60
	public void PauseVideo() { }

	// RVA: 0x1CFB470 Offset: 0x1CFB571 VA: 0x1CFB470
	public void StopVideo() { }

	// RVA: 0x1CFB6A0 Offset: 0x1CFB7A1 VA: 0x1CFB6A0
	private void SyncVideoToPlayable(Playable playable) { }

	// RVA: 0x1CFBF40 Offset: 0x1CFC041 VA: 0x1CFBF40
	public void .ctor() { }
}

