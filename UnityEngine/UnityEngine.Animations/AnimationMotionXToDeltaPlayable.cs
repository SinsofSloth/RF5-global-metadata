[NativeHeaderAttribute] // RVA: 0xE95D0 Offset: 0xE96D1 VA: 0xE95D0
[RequiredByNativeCodeAttribute] // RVA: 0xE95D0 Offset: 0xE96D1 VA: 0xE95D0
[StaticAccessorAttribute] // RVA: 0xE95D0 Offset: 0xE96D1 VA: 0xE95D0
internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 3527
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1AEFE40 Offset: 0x1AEFF41 VA: 0x1AEFE40
	public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) { }

	// RVA: 0x1AEFEE0 Offset: 0x1AEFFE1 VA: 0x1AEFEE0
	private static PlayableHandle CreateHandle(PlayableGraph graph) { }

	// RVA: 0x1C340 Offset: 0x1C441 VA: 0x1C340
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x1C350 Offset: 0x1C451 VA: 0x1C350 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1AF01E0 Offset: 0x1AF02E1 VA: 0x1AF01E0
	public static Playable op_Implicit(AnimationMotionXToDeltaPlayable playable) { }

	// RVA: 0x1C360 Offset: 0x1C461 VA: 0x1C360 Slot: 5
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x1C3F0 Offset: 0x1C4F1 VA: 0x1C3F0
	public void SetAbsoluteMotion(bool value) { }

	[NativeThrowsAttribute] // RVA: 0xECC30 Offset: 0xECD31 VA: 0xECC30
	// RVA: 0x1AF0120 Offset: 0x1AF0221 VA: 0x1AF0120
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[NativeThrowsAttribute] // RVA: 0xECC40 Offset: 0xECD41 VA: 0xECC40
	// RVA: 0x1AF0360 Offset: 0x1AF0461 VA: 0x1AF0360
	private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x1AF0400 Offset: 0x1AF0501 VA: 0x1AF0400
	private static void .cctor() { }

	// RVA: 0x1AF03B0 Offset: 0x1AF04B1 VA: 0x1AF03B0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

