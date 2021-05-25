[StaticAccessorAttribute] // RVA: 0xE9450 Offset: 0xE9551 VA: 0xE9450
[RequiredByNativeCodeAttribute] // RVA: 0xE9450 Offset: 0xE9551 VA: 0xE9450
[NativeHeaderAttribute] // RVA: 0xE9450 Offset: 0xE9551 VA: 0xE9450
[NativeHeaderAttribute] // RVA: 0xE9450 Offset: 0xE9551 VA: 0xE9450
[NativeHeaderAttribute] // RVA: 0xE9450 Offset: 0xE9551 VA: 0xE9450
public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 3525
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1AEF0D0 Offset: 0x1AEF1D1 VA: 0x1AEF0D0
	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x1AEF180 Offset: 0x1AEF281 VA: 0x1AEF180
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x1C1D0 Offset: 0x1C2D1 VA: 0x1C1D0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1C1E0 Offset: 0x1C2E1 VA: 0x1C1E0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1AEF490 Offset: 0x1AEF591 VA: 0x1AEF490
	public static Playable op_Implicit(AnimationLayerMixerPlayable playable) { }

	// RVA: 0x1C1F0 Offset: 0x1C2F1 VA: 0x1C1F0 Slot: 5
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x1C280 Offset: 0x1C381 VA: 0x1C280
	public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask) { }

	[NativeThrowsAttribute] // RVA: 0xECC00 Offset: 0xECD01 VA: 0xECC00
	// RVA: 0x1AEF3D0 Offset: 0x1AEF4D1 VA: 0x1AEF3D0
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[NativeThrowsAttribute] // RVA: 0xECC10 Offset: 0xECD11 VA: 0xECC10
	// RVA: 0x1AEF740 Offset: 0x1AEF841 VA: 0x1AEF740
	private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask) { }

	// RVA: 0x1AEF7F0 Offset: 0x1AEF8F1 VA: 0x1AEF7F0
	private static void .cctor() { }

	// RVA: 0x1AEF7A0 Offset: 0x1AEF8A1 VA: 0x1AEF7A0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

