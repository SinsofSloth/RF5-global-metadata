[Serializable]
public class RF_AudioClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8361
{
	// Fields
	public RF_AudioBehaviour RF_AudioBehaviour; // 0x18
	public ExposedReference<Transform> TargetTransform; // 0x20
	[SerializeField] // RVA: 0x16F190 Offset: 0x16F291 VA: 0x16F190
	public string SoundIDString; // 0x30
	[SerializeField] // RVA: 0x16F1A0 Offset: 0x16F2A1 VA: 0x16F1A0
	public SoundID SoundID; // 0x38
	[SerializeField] // RVA: 0x16F1B0 Offset: 0x16F2B1 VA: 0x16F1B0
	public bool IsLoop; // 0x3C
	[SerializeField] // RVA: 0x16F1C0 Offset: 0x16F2C1 VA: 0x16F1C0
	[RangeAttribute] // RVA: 0x16F1C0 Offset: 0x16F2C1 VA: 0x16F1C0
	public float Volume; // 0x40
	[SerializeField] // RVA: 0x16F200 Offset: 0x16F301 VA: 0x16F200
	private double LastDuration; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x16F210 Offset: 0x16F311 VA: 0x16F210
	private GameObject <BindTarget>k__BackingField; // 0x50

	// Properties
	public override double duration { get; }
	public ClipCaps clipCaps { get; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x1DA9960 Offset: 0x1DA9A61 VA: 0x1DA9960 Slot: 7
	public override double get_duration() { }

	// RVA: 0x1DA9980 Offset: 0x1DA9A81 VA: 0x1DA9980 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7220 Offset: 0x1A7321 VA: 0x1A7220
	// RVA: 0x1DA9990 Offset: 0x1DA9A91 VA: 0x1DA9990
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7230 Offset: 0x1A7331 VA: 0x1A7230
	// RVA: 0x1DA99A0 Offset: 0x1DA9AA1 VA: 0x1DA99A0
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x1DA99B0 Offset: 0x1DA9AB1 VA: 0x1DA99B0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1DA9AF0 Offset: 0x1DA9BF1 VA: 0x1DA9AF0
	public void .ctor() { }
}

