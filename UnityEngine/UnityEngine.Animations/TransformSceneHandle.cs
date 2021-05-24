[NativeHeaderAttribute] // RVA: 0xE9D30 Offset: 0xE9E31 VA: 0xE9D30
[NativeHeaderAttribute] // RVA: 0xE9D30 Offset: 0xE9E31 VA: 0xE9D30
[MovedFromAttribute] // RVA: 0xE9D30 Offset: 0xE9E31 VA: 0xE9D30
public struct TransformSceneHandle // TypeDefIndex: 3537
{
	// Fields
	private uint valid; // 0x0
	private int transformSceneHandleDefinitionIndex; // 0x4

	// Properties
	private bool createdByNative { get; }
	private bool hasTransformSceneHandleDefinitionIndex { get; }

	// Methods

	// RVA: 0x1CE10 Offset: 0x1CF11 VA: 0x1CE10
	public bool IsValid(AnimationStream stream) { }

	// RVA: 0x1CEB0 Offset: 0x1CFB1 VA: 0x1CEB0
	private bool get_createdByNative() { }

	// RVA: 0x1CEC0 Offset: 0x1CFC1 VA: 0x1CEC0
	private bool get_hasTransformSceneHandleDefinitionIndex() { }

	// RVA: 0x1CED0 Offset: 0x1CFD1 VA: 0x1CED0
	private void CheckIsValid(ref AnimationStream stream) { }

	// RVA: 0x1CEE0 Offset: 0x1CFE1 VA: 0x1CEE0
	public Vector3 GetPosition(AnimationStream stream) { }

	[ThreadSafeAttribute] // RVA: 0xECF20 Offset: 0xED021 VA: 0xECF20
	// RVA: 0x1CF70 Offset: 0x1D071 VA: 0x1CF70
	private bool HasValidTransform(ref AnimationStream stream) { }

	[NativeMethodAttribute] // RVA: 0xECF30 Offset: 0xED031 VA: 0xECF30
	// RVA: 0x1CFC0 Offset: 0x1D0C1 VA: 0x1CFC0
	private Vector3 GetPositionInternal(ref AnimationStream stream) { }

	// RVA: 0x1AF6040 Offset: 0x1AF6141 VA: 0x1AF6040
	private static bool HasValidTransform_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream) { }

	// RVA: 0x1AF6090 Offset: 0x1AF6191 VA: 0x1AF6090
	private static void GetPositionInternal_Injected(ref TransformSceneHandle _unity_self, ref AnimationStream stream, out Vector3 ret) { }
}

