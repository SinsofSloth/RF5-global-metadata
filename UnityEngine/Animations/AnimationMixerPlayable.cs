[NativeHeaderAttribute] // RVA: 0xE9510 Offset: 0xE9611 VA: 0xE9510
[NativeHeaderAttribute] // RVA: 0xE9510 Offset: 0xE9611 VA: 0xE9510
[RequiredByNativeCodeAttribute] // RVA: 0xE9510 Offset: 0xE9611 VA: 0xE9510
[NativeHeaderAttribute] // RVA: 0xE9510 Offset: 0xE9611 VA: 0xE9510
[StaticAccessorAttribute] // RVA: 0xE9510 Offset: 0xE9611 VA: 0xE9510
public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable> // TypeDefIndex: 3526
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1AEF890 Offset: 0x1AEF991 VA: 0x1AEF890
	public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeWeights = False) { }

	// RVA: 0x1AEF950 Offset: 0x1AEFA51 VA: 0x1AEF950
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0, bool normalizeWeights = False) { }

	// RVA: 0x1C290 Offset: 0x1C391 VA: 0x1C290
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1C2A0 Offset: 0x1C3A1 VA: 0x1C2A0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1AEFC70 Offset: 0x1AEFD71 VA: 0x1AEFC70
	public static Playable op_Implicit(AnimationMixerPlayable playable) { }

	// RVA: 0x1C2B0 Offset: 0x1C3B1 VA: 0x1C2B0 Slot: 5
	public bool Equals(AnimationMixerPlayable other) { }

	[NativeThrowsAttribute] // RVA: 0xECC20 Offset: 0xECD21 VA: 0xECC20
	// RVA: 0x1AEFBA0 Offset: 0x1AEFCA1 VA: 0x1AEFBA0
	private static bool CreateHandleInternal(PlayableGraph graph, bool normalizeWeights, ref PlayableHandle handle) { }

	// RVA: 0x1AEFDA0 Offset: 0x1AEFEA1 VA: 0x1AEFDA0
	private static void .cctor() { }

	// RVA: 0x1AEFD40 Offset: 0x1AEFE41 VA: 0x1AEFD40
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, bool normalizeWeights, ref PlayableHandle handle) { }
}

