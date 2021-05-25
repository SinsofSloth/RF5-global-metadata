[Serializable]
public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 4567
{
	// Fields
	[SerializeField] // RVA: 0x12BA40 Offset: 0x12BB41 VA: 0x12BA40
	private AudioClip m_Clip; // 0x18
	[SerializeField] // RVA: 0x12BA50 Offset: 0x12BB51 VA: 0x12BA50
	private bool m_Loop; // 0x20
	[SerializeField] // RVA: 0x12BA60 Offset: 0x12BB61 VA: 0x12BA60
	[HideInInspector] // RVA: 0x12BA60 Offset: 0x12BB61 VA: 0x12BA60
	private float m_bufferingTime; // 0x24
	[SerializeField] // RVA: 0x12BAA0 Offset: 0x12BBA1 VA: 0x12BAA0
	private AudioClipProperties m_ClipProperties; // 0x28

	// Properties
	internal float bufferingTime { get; set; }
	public AudioClip clip { get; set; }
	public bool loop { get; set; }
	public override double duration { get; }
	public override IEnumerable<PlayableBinding> outputs { get; }
	public ClipCaps clipCaps { get; }

	// Methods

	// RVA: 0x17D91E0 Offset: 0x17D92E1 VA: 0x17D91E0
	internal float get_bufferingTime() { }

	// RVA: 0x17D91F0 Offset: 0x17D92F1 VA: 0x17D91F0
	internal void set_bufferingTime(float value) { }

	// RVA: 0x17D9200 Offset: 0x17D9301 VA: 0x17D9200
	public AudioClip get_clip() { }

	// RVA: 0x17D9210 Offset: 0x17D9311 VA: 0x17D9210
	public void set_clip(AudioClip value) { }

	// RVA: 0x17D9220 Offset: 0x17D9321 VA: 0x17D9220
	public bool get_loop() { }

	// RVA: 0x17D9230 Offset: 0x17D9331 VA: 0x17D9230
	public void set_loop(bool value) { }

	// RVA: 0x17D9240 Offset: 0x17D9341 VA: 0x17D9240 Slot: 7
	public override double get_duration() { }

	[IteratorStateMachineAttribute] // RVA: 0x12C110 Offset: 0x12C211 VA: 0x12C110
	// RVA: 0x17D9300 Offset: 0x17D9401 VA: 0x17D9300 Slot: 8
	public override IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x17D93D0 Offset: 0x17D94D1 VA: 0x17D93D0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	// RVA: 0x17D9500 Offset: 0x17D9601 VA: 0x17D9500 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x17D9510 Offset: 0x17D9611 VA: 0x17D9510
	public void .ctor() { }
}

