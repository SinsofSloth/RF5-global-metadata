[NativeHeaderAttribute] // RVA: 0xE9DC0 Offset: 0xE9EC1 VA: 0xE9DC0
[MovedFromAttribute] // RVA: 0xE9DC0 Offset: 0xE9EC1 VA: 0xE9DC0
public struct PropertySceneHandle // TypeDefIndex: 3538
{
	// Fields
	private uint valid; // 0x0
	private int handleIndex; // 0x4

	// Properties
	private bool createdByNative { get; }
	private bool hasHandleIndex { get; }

	// Methods

	// RVA: 0x1CB20 Offset: 0x1CC21 VA: 0x1CB20
	private bool get_createdByNative() { }

	// RVA: 0x1CB30 Offset: 0x1CC31 VA: 0x1CB30
	private bool get_hasHandleIndex() { }

	// RVA: 0x1CB40 Offset: 0x1CC41 VA: 0x1CB40
	private void CheckIsValid(ref AnimationStream stream) { }

	// RVA: 0x1CB50 Offset: 0x1CC51 VA: 0x1CB50
	public float GetFloat(AnimationStream stream) { }

	// RVA: 0x1CBD0 Offset: 0x1CCD1 VA: 0x1CBD0
	public int GetInt(AnimationStream stream) { }

	// RVA: 0x1CC50 Offset: 0x1CD51 VA: 0x1CC50
	public bool GetBool(AnimationStream stream) { }

	[ThreadSafeAttribute] // RVA: 0xECF90 Offset: 0xED091 VA: 0xECF90
	// RVA: 0x1CCD0 Offset: 0x1CDD1 VA: 0x1CCD0
	private bool HasValidTransform(ref AnimationStream stream) { }

	[NativeMethodAttribute] // RVA: 0xECFA0 Offset: 0xED0A1 VA: 0xECFA0
	// RVA: 0x1CD20 Offset: 0x1CE21 VA: 0x1CD20
	private float GetFloatInternal(ref AnimationStream stream) { }

	[NativeMethodAttribute] // RVA: 0xECFF0 Offset: 0xED0F1 VA: 0xECFF0
	// RVA: 0x1CD70 Offset: 0x1CE71 VA: 0x1CD70
	private int GetIntInternal(ref AnimationStream stream) { }

	[NativeMethodAttribute] // RVA: 0xED040 Offset: 0xED141 VA: 0xED040
	// RVA: 0x1CDC0 Offset: 0x1CEC1 VA: 0x1CDC0
	private bool GetBoolInternal(ref AnimationStream stream) { }

	// RVA: 0x1AF4E30 Offset: 0x1AF4F31 VA: 0x1AF4E30
	private static bool HasValidTransform_Injected(ref PropertySceneHandle _unity_self, ref AnimationStream stream) { }

	// RVA: 0x1AF4E80 Offset: 0x1AF4F81 VA: 0x1AF4E80
	private static float GetFloatInternal_Injected(ref PropertySceneHandle _unity_self, ref AnimationStream stream) { }

	// RVA: 0x1AF4ED0 Offset: 0x1AF4FD1 VA: 0x1AF4ED0
	private static int GetIntInternal_Injected(ref PropertySceneHandle _unity_self, ref AnimationStream stream) { }

	// RVA: 0x1AF4F20 Offset: 0x1AF5021 VA: 0x1AF4F20
	private static bool GetBoolInternal_Injected(ref PropertySceneHandle _unity_self, ref AnimationStream stream) { }
}

