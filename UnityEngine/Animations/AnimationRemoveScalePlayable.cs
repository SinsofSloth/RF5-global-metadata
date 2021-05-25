[NativeHeaderAttribute] // RVA: 0xE9A60 Offset: 0xE9B61 VA: 0xE9A60
[RequiredByNativeCodeAttribute] // RVA: 0xE9A60 Offset: 0xE9B61 VA: 0xE9A60
[NativeHeaderAttribute] // RVA: 0xE9A60 Offset: 0xE9B61 VA: 0xE9A60
[NativeHeaderAttribute] // RVA: 0xE9A60 Offset: 0xE9B61 VA: 0xE9A60
[StaticAccessorAttribute] // RVA: 0xE9A60 Offset: 0xE9B61 VA: 0xE9A60
internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 3533
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1AF1400 Offset: 0x1AF1501 VA: 0x1AF1400
	public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount) { }

	// RVA: 0x1AF14B0 Offset: 0x1AF15B1 VA: 0x1AF14B0
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) { }

	// RVA: 0x1C720 Offset: 0x1C821 VA: 0x1C720
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1C730 Offset: 0x1C831 VA: 0x1C730 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1AF17C0 Offset: 0x1AF18C1 VA: 0x1AF17C0
	public static Playable op_Implicit(AnimationRemoveScalePlayable playable) { }

	// RVA: 0x1C740 Offset: 0x1C841 VA: 0x1C740 Slot: 5
	public bool Equals(AnimationRemoveScalePlayable other) { }

	[NativeThrowsAttribute] // RVA: 0xECCD0 Offset: 0xECDD1 VA: 0xECCD0
	// RVA: 0x1AF1700 Offset: 0x1AF1801 VA: 0x1AF1700
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0x1AF1910 Offset: 0x1AF1A11 VA: 0x1AF1910
	private static void .cctor() { }

	// RVA: 0x1AF18C0 Offset: 0x1AF19C1 VA: 0x1AF18C0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

