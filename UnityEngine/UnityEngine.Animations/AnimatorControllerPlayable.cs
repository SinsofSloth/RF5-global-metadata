[RequiredByNativeCodeAttribute] // RVA: 0xE9E20 Offset: 0xE9F21 VA: 0xE9E20
[StaticAccessorAttribute] // RVA: 0xE9E20 Offset: 0xE9F21 VA: 0xE9E20
[NativeHeaderAttribute] // RVA: 0xE9E20 Offset: 0xE9F21 VA: 0xE9E20
[NativeHeaderAttribute] // RVA: 0xE9E20 Offset: 0xE9F21 VA: 0xE9E20
[NativeHeaderAttribute] // RVA: 0xE9E20 Offset: 0xE9F21 VA: 0xE9E20
[NativeHeaderAttribute] // RVA: 0xE9E20 Offset: 0xE9F21 VA: 0xE9E20
[NativeHeaderAttribute] // RVA: 0xE9E20 Offset: 0xE9F21 VA: 0xE9E20
public struct AnimatorControllerPlayable : IPlayable, IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 3539
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1AF1E30 Offset: 0x1AF1F31 VA: 0x1AF1E30
	public static AnimatorControllerPlayable Create(PlayableGraph graph, RuntimeAnimatorController controller) { }

	// RVA: 0x1AF1F30 Offset: 0x1AF2031 VA: 0x1AF1F30
	private static PlayableHandle CreateHandle(PlayableGraph graph, RuntimeAnimatorController controller) { }

	// RVA: 0x1C960 Offset: 0x1CA61 VA: 0x1C960
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1CA00 Offset: 0x1CB01 VA: 0x1CA00 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x1CA10 Offset: 0x1CB11 VA: 0x1CA10
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x1CA20 Offset: 0x1CB21 VA: 0x1CA20 Slot: 5
	public bool Equals(AnimatorControllerPlayable other) { }

	[NativeThrowsAttribute] // RVA: 0xED090 Offset: 0xED191 VA: 0xED090
	// RVA: 0x1AF2140 Offset: 0x1AF2241 VA: 0x1AF2140
	private static bool CreateHandleInternal(PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle) { }

	// RVA: 0x1AF2400 Offset: 0x1AF2501 VA: 0x1AF2400
	private static void .cctor() { }

	// RVA: 0x1AF23A0 Offset: 0x1AF24A1 VA: 0x1AF23A0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, RuntimeAnimatorController controller, ref PlayableHandle handle) { }
}

