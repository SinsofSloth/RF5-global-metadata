[Serializable]
public class ChangeAvatorClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8319
{
	// Fields
	public ChangeAvatorBehavior template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16ED80 Offset: 0x16EE81 VA: 0x16ED80
	private Animator <TargetAnimator>k__BackingField; // 0x20
	[SerializeField] // RVA: 0x16ED90 Offset: 0x16EE91 VA: 0x16ED90
	private Avatar Avatar; // 0x28

	// Properties
	public Animator TargetAnimator { get; set; }
	public ClipCaps clipCaps { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6D90 Offset: 0x1A6E91 VA: 0x1A6D90
	// RVA: 0x1D3F7C0 Offset: 0x1D3F8C1 VA: 0x1D3F7C0
	public Animator get_TargetAnimator() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6DA0 Offset: 0x1A6EA1 VA: 0x1A6DA0
	// RVA: 0x1D3F7D0 Offset: 0x1D3F8D1 VA: 0x1D3F7D0
	public void set_TargetAnimator(Animator value) { }

	// RVA: 0x1D3F7E0 Offset: 0x1D3F8E1 VA: 0x1D3F7E0 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x1D3F7F0 Offset: 0x1D3F8F1 VA: 0x1D3F7F0
	public void SetAvatar(Avatar avatar) { }

	// RVA: 0x1D3F800 Offset: 0x1D3F901 VA: 0x1D3F800 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1D3F900 Offset: 0x1D3FA01 VA: 0x1D3F900
	public void .ctor() { }
}

