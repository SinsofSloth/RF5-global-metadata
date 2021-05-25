[NativeHeaderAttribute] // RVA: 0xE9310 Offset: 0xE9411 VA: 0xE9310
[StaticAccessorAttribute] // RVA: 0xE9310 Offset: 0xE9411 VA: 0xE9310
[NativeHeaderAttribute] // RVA: 0xE9310 Offset: 0xE9411 VA: 0xE9310
[RequiredByNativeCodeAttribute] // RVA: 0xE9310 Offset: 0xE9411 VA: 0xE9310
public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable> // TypeDefIndex: 3523
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x1AEEA10 Offset: 0x1AEEB11 VA: 0x1AEEA10
	public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0x1AEEA50 Offset: 0x1AEEB51 VA: 0x1AEEA50
	private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0x1BF90 Offset: 0x1C091 VA: 0x1BF90
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1BFA0 Offset: 0x1C0A1 VA: 0x1BFA0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1AEEC80 Offset: 0x1AEED81 VA: 0x1AEEC80
	public static Playable op_Implicit(AnimationClipPlayable playable) { }

	// RVA: 0x1BFB0 Offset: 0x1C0B1 VA: 0x1BFB0 Slot: 5
	public bool Equals(AnimationClipPlayable other) { }

	// RVA: 0x1C040 Offset: 0x1C141 VA: 0x1C040
	public void SetApplyFootIK(bool value) { }

	// RVA: 0x1C090 Offset: 0x1C191 VA: 0x1C090
	public void SetApplyPlayableIK(bool value) { }

	// RVA: 0x1C0E0 Offset: 0x1C1E1 VA: 0x1C0E0
	internal void SetRemoveStartOffset(bool value) { }

	// RVA: 0x1C130 Offset: 0x1C231 VA: 0x1C130
	internal void SetOverrideLoopTime(bool value) { }

	// RVA: 0x1C180 Offset: 0x1C281 VA: 0x1C180
	internal void SetLoopTime(bool value) { }

	[NativeThrowsAttribute] // RVA: 0xECBA0 Offset: 0xECCA1 VA: 0xECBA0
	// RVA: 0x1AEEC00 Offset: 0x1AEED01 VA: 0x1AEEC00
	private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

	[NativeThrowsAttribute] // RVA: 0xECBB0 Offset: 0xECCB1 VA: 0xECBB0
	// RVA: 0x1AEEDA0 Offset: 0x1AEEEA1 VA: 0x1AEEDA0
	private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrowsAttribute] // RVA: 0xECBC0 Offset: 0xECCC1 VA: 0xECBC0
	// RVA: 0x1AEEE40 Offset: 0x1AEEF41 VA: 0x1AEEE40
	private static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrowsAttribute] // RVA: 0xECBD0 Offset: 0xECCD1 VA: 0xECBD0
	// RVA: 0x1AEEEE0 Offset: 0x1AEEFE1 VA: 0x1AEEEE0
	private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrowsAttribute] // RVA: 0xECBE0 Offset: 0xECCE1 VA: 0xECBE0
	// RVA: 0x1AEEF80 Offset: 0x1AEF081 VA: 0x1AEEF80
	private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrowsAttribute] // RVA: 0xECBF0 Offset: 0xECCF1 VA: 0xECBF0
	// RVA: 0x1AEF020 Offset: 0x1AEF121 VA: 0x1AEF020
	private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x1AEF070 Offset: 0x1AEF171 VA: 0x1AEF070
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }
}

