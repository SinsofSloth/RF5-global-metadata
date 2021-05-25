[TrackClipTypeAttribute] // RVA: 0x12A4F0 Offset: 0x12A5F1 VA: 0x12A4F0
[TrackBindingTypeAttribute] // RVA: 0x12A4F0 Offset: 0x12A5F1 VA: 0x12A4F0
[ExcludeFromPresetAttribute] // RVA: 0x12A4F0 Offset: 0x12A5F1 VA: 0x12A4F0
[Serializable]
public class ActivationTrack : TrackAsset // TypeDefIndex: 4528
{
	// Fields
	[SerializeField] // RVA: 0x12AE40 Offset: 0x12AF41 VA: 0x12AE40
	private ActivationTrack.PostPlaybackState m_PostPlaybackState; // 0xA0
	private ActivationMixerPlayable m_ActivationMixer; // 0xA8

	// Properties
	public ActivationTrack.PostPlaybackState postPlaybackState { get; set; }

	// Methods

	// RVA: 0x17D29E0 Offset: 0x17D2AE1 VA: 0x17D29E0 Slot: 33
	internal override bool CanCompileClips() { }

	// RVA: 0x17D2A20 Offset: 0x17D2B21 VA: 0x17D2A20
	public ActivationTrack.PostPlaybackState get_postPlaybackState() { }

	// RVA: 0x17D2A30 Offset: 0x17D2B31 VA: 0x17D2A30
	public void set_postPlaybackState(ActivationTrack.PostPlaybackState value) { }

	// RVA: 0x17D2A70 Offset: 0x17D2B71 VA: 0x17D2A70 Slot: 24
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	// RVA: 0x17D2A50 Offset: 0x17D2B51 VA: 0x17D2A50
	internal void UpdateTrackMode() { }

	// RVA: 0x17D2BB0 Offset: 0x17D2CB1 VA: 0x17D2BB0 Slot: 29
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	// RVA: 0x17D2CE0 Offset: 0x17D2DE1 VA: 0x17D2CE0 Slot: 30
	protected override void OnCreateClip(TimelineClip clip) { }

	// RVA: 0x17D2D60 Offset: 0x17D2E61 VA: 0x17D2D60
	public void .ctor() { }
}

