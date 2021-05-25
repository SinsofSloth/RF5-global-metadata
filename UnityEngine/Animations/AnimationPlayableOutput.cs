[NativeHeaderAttribute] // RVA: 0xE9890 Offset: 0xE9991 VA: 0xE9890
[RequiredByNativeCodeAttribute] // RVA: 0xE9890 Offset: 0xE9991 VA: 0xE9890
[NativeHeaderAttribute] // RVA: 0xE9890 Offset: 0xE9991 VA: 0xE9890
[NativeHeaderAttribute] // RVA: 0xE9890 Offset: 0xE9991 VA: 0xE9890
[NativeHeaderAttribute] // RVA: 0xE9890 Offset: 0xE9991 VA: 0xE9890
[NativeHeaderAttribute] // RVA: 0xE9890 Offset: 0xE9991 VA: 0xE9890
[StaticAccessorAttribute] // RVA: 0xE9890 Offset: 0xE9991 VA: 0xE9890
public struct AnimationPlayableOutput : IPlayableOutput // TypeDefIndex: 3531
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static AnimationPlayableOutput Null { get; }

	// Methods

	// RVA: 0x1AF0C20 Offset: 0x1AF0D21 VA: 0x1AF0C20
	public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target) { }

	// RVA: 0x1C580 Offset: 0x1C681 VA: 0x1C580
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x1AF0EE0 Offset: 0x1AF0FE1 VA: 0x1AF0EE0
	public static AnimationPlayableOutput get_Null() { }

	// RVA: 0x1C590 Offset: 0x1C691 VA: 0x1C590 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x1AF0D40 Offset: 0x1AF0E41 VA: 0x1AF0D40
	public static PlayableOutput op_Implicit(AnimationPlayableOutput output) { }

	// RVA: 0x1AF1090 Offset: 0x1AF1191 VA: 0x1AF1090
	public static AnimationPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0x1C5A0 Offset: 0x1C6A1 VA: 0x1C5A0
	public Animator GetTarget() { }

	// RVA: 0x1C5F0 Offset: 0x1C6F1 VA: 0x1C5F0
	public void SetTarget(Animator value) { }

	[NativeThrowsAttribute] // RVA: 0xECCB0 Offset: 0xECDB1 VA: 0xECCB0
	// RVA: 0x1AF1130 Offset: 0x1AF1231 VA: 0x1AF1130
	private static Animator InternalGetTarget(ref PlayableOutputHandle handle) { }

	[NativeThrowsAttribute] // RVA: 0xECCC0 Offset: 0xECDC1 VA: 0xECCC0
	// RVA: 0x1AF1180 Offset: 0x1AF1281 VA: 0x1AF1180
	private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) { }
}

