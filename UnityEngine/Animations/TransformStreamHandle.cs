[MovedFromAttribute] // RVA: 0xE9CA0 Offset: 0xE9DA1 VA: 0xE9CA0
[NativeHeaderAttribute] // RVA: 0xE9CA0 Offset: 0xE9DA1 VA: 0xE9CA0
[NativeHeaderAttribute] // RVA: 0xE9CA0 Offset: 0xE9DA1 VA: 0xE9CA0
public struct TransformStreamHandle // TypeDefIndex: 3536
{
	// Fields
	private uint m_AnimatorBindingsVersion; // 0x0
	private int handleIndex; // 0x4
	private int skeletonIndex; // 0x8

	// Properties
	private bool createdByNative { get; }
	private bool hasHandleIndex { get; }
	private bool hasSkeletonIndex { get; }
	internal uint animatorBindingsVersion { get; }

	// Methods

	// RVA: 0x1D030 Offset: 0x1D131 VA: 0x1D030
	public bool IsValid(AnimationStream stream) { }

	// RVA: 0x1D0C0 Offset: 0x1D1C1 VA: 0x1D0C0
	private bool IsValidInternal(ref AnimationStream stream) { }

	// RVA: 0x1D120 Offset: 0x1D221 VA: 0x1D120
	private bool get_createdByNative() { }

	// RVA: 0x1D130 Offset: 0x1D231 VA: 0x1D130
	private bool IsSameVersionAsStream(ref AnimationStream stream) { }

	// RVA: 0x1D150 Offset: 0x1D251 VA: 0x1D150
	private bool get_hasHandleIndex() { }

	// RVA: 0x1D160 Offset: 0x1D261 VA: 0x1D160
	private bool get_hasSkeletonIndex() { }

	// RVA: 0x1D170 Offset: 0x1D271 VA: 0x1D170
	internal uint get_animatorBindingsVersion() { }

	// RVA: 0x1D180 Offset: 0x1D281 VA: 0x1D180
	private bool IsResolvedInternal(ref AnimationStream stream) { }

	// RVA: 0x1D220 Offset: 0x1D321 VA: 0x1D220
	private void CheckIsValidAndResolve(ref AnimationStream stream) { }

	// RVA: 0x1D230 Offset: 0x1D331 VA: 0x1D230
	public Vector3 GetPosition(AnimationStream stream) { }

	// RVA: 0x1D2C0 Offset: 0x1D3C1 VA: 0x1D2C0
	public Quaternion GetRotation(AnimationStream stream) { }

	// RVA: 0x1D350 Offset: 0x1D451 VA: 0x1D350
	public void SetRotation(AnimationStream stream, Quaternion rotation) { }

	// RVA: 0x1D400 Offset: 0x1D501 VA: 0x1D400
	public Quaternion GetLocalRotation(AnimationStream stream) { }

	// RVA: 0x1D490 Offset: 0x1D591 VA: 0x1D490
	public void SetLocalRotation(AnimationStream stream, Quaternion rotation) { }

	[NativeMethodAttribute] // RVA: 0xECCF0 Offset: 0xECDF1 VA: 0xECCF0
	// RVA: 0x1D540 Offset: 0x1D641 VA: 0x1D540
	private void ResolveInternal(ref AnimationStream stream) { }

	[NativeMethodAttribute] // RVA: 0xECD40 Offset: 0xECE41 VA: 0xECD40
	// RVA: 0x1D590 Offset: 0x1D691 VA: 0x1D590
	private Vector3 GetPositionInternal(ref AnimationStream stream) { }

	[NativeMethodAttribute] // RVA: 0xECDA0 Offset: 0xECEA1 VA: 0xECDA0
	// RVA: 0x1D600 Offset: 0x1D701 VA: 0x1D600
	private Quaternion GetRotationInternal(ref AnimationStream stream) { }

	[NativeMethodAttribute] // RVA: 0xECE00 Offset: 0xECF01 VA: 0xECE00
	// RVA: 0x1D670 Offset: 0x1D771 VA: 0x1D670
	private void SetRotationInternal(ref AnimationStream stream, Quaternion rotation) { }

	[NativeMethodAttribute] // RVA: 0xECE60 Offset: 0xECF61 VA: 0xECE60
	// RVA: 0x1D6E0 Offset: 0x1D7E1 VA: 0x1D6E0
	private Quaternion GetLocalRotationInternal(ref AnimationStream stream) { }

	[NativeMethodAttribute] // RVA: 0xECEC0 Offset: 0xECFC1 VA: 0xECEC0
	// RVA: 0x1D750 Offset: 0x1D851 VA: 0x1D750
	private void SetLocalRotationInternal(ref AnimationStream stream, Quaternion rotation) { }

	// RVA: 0x1AF6980 Offset: 0x1AF6A81 VA: 0x1AF6980
	private static void ResolveInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream) { }

	// RVA: 0x1AF69D0 Offset: 0x1AF6AD1 VA: 0x1AF69D0
	private static void GetPositionInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Vector3 ret) { }

	// RVA: 0x1AF6A30 Offset: 0x1AF6B31 VA: 0x1AF6A30
	private static void GetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret) { }

	// RVA: 0x1AF6A90 Offset: 0x1AF6B91 VA: 0x1AF6A90
	private static void SetRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation) { }

	// RVA: 0x1AF6AF0 Offset: 0x1AF6BF1 VA: 0x1AF6AF0
	private static void GetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, out Quaternion ret) { }

	// RVA: 0x1AF6B50 Offset: 0x1AF6C51 VA: 0x1AF6B50
	private static void SetLocalRotationInternal_Injected(ref TransformStreamHandle _unity_self, ref AnimationStream stream, ref Quaternion rotation) { }
}

