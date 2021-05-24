[TrackClipTypeAttribute] // RVA: 0x12A6B0 Offset: 0x12A7B1 VA: 0x12A6B0
[TrackBindingTypeAttribute] // RVA: 0x12A6B0 Offset: 0x12A7B1 VA: 0x12A6B0
[ExcludeFromPresetAttribute] // RVA: 0x12A6B0 Offset: 0x12A7B1 VA: 0x12A6B0
[Serializable]
public class AudioTrack : TrackAsset // TypeDefIndex: 4569
{
	// Fields
	[SerializeField] // RVA: 0x12BAB0 Offset: 0x12BBB1 VA: 0x12BAB0
	private AudioMixerProperties m_TrackProperties; // 0xA0

	// Properties
	public override IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: 0x17D9830 Offset: 0x17D9931 VA: 0x17D9830
	public TimelineClip CreateClip(AudioClip clip) { }

	// RVA: 0x17D99A0 Offset: 0x17D9AA1 VA: 0x17D99A0 Slot: 25
	internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	[IteratorStateMachineAttribute] // RVA: 0x12C180 Offset: 0x12C281 VA: 0x12C180
	// RVA: 0x17DA0B0 Offset: 0x17DA1B1 VA: 0x17DA0B0 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x17DA180 Offset: 0x17DA281 VA: 0x17DA180
	private void OnValidate() { }

	// RVA: 0x17DA240 Offset: 0x17DA341 VA: 0x17DA240
	public void .ctor() { }
}

