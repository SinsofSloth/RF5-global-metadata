[NativeHeaderAttribute] // RVA: 0xE8F20 Offset: 0xE9021 VA: 0xE8F20
[MovedFromAttribute] // RVA: 0xE8F20 Offset: 0xE9021 VA: 0xE8F20
[NativeHeaderAttribute] // RVA: 0xE8F20 Offset: 0xE9021 VA: 0xE8F20
[UsedByNativeCodeAttribute] // RVA: 0xE8F20 Offset: 0xE9021 VA: 0xE8F20
public sealed class AvatarMask : Object // TypeDefIndex: 3498
{
	// Properties
	[ObsoleteAttribute] // RVA: 0xEE630 Offset: 0xEE731 VA: 0xEE630
	public int humanoidBodyPartCount { get; }
	public int transformCount { get; set; }
	internal bool hasFeetIK { get; }

	// Methods

	// RVA: 0x1AFF670 Offset: 0x1AFF771 VA: 0x1AFF670
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xEC470 Offset: 0xEC571 VA: 0xEC470
	// RVA: 0x1AFF710 Offset: 0x1AFF811 VA: 0x1AFF710
	private static void Internal_Create(AvatarMask self) { }

	// RVA: 0x1AFF760 Offset: 0x1AFF861 VA: 0x1AFF760
	public int get_humanoidBodyPartCount() { }

	[NativeMethodAttribute] // RVA: 0xEC4B0 Offset: 0xEC5B1 VA: 0xEC4B0
	// RVA: 0x1AFF770 Offset: 0x1AFF871 VA: 0x1AFF770
	public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index) { }

	[NativeMethodAttribute] // RVA: 0xEC4F0 Offset: 0xEC5F1 VA: 0xEC4F0
	// RVA: 0x1AFF7C0 Offset: 0x1AFF8C1 VA: 0x1AFF7C0
	public void SetHumanoidBodyPartActive(AvatarMaskBodyPart index, bool value) { }

	// RVA: 0x1AFF820 Offset: 0x1AFF921 VA: 0x1AFF820
	public int get_transformCount() { }

	// RVA: 0x1AFF870 Offset: 0x1AFF971 VA: 0x1AFF870
	public void set_transformCount(int value) { }

	// RVA: 0x1AFF8C0 Offset: 0x1AFF9C1 VA: 0x1AFF8C0
	public void AddTransformPath(Transform transform) { }

	// RVA: 0x1AFF920 Offset: 0x1AFFA21 VA: 0x1AFF920
	public void AddTransformPath(Transform transform, bool recursive) { }

	// RVA: 0x1AFF980 Offset: 0x1AFFA81 VA: 0x1AFF980
	public void RemoveTransformPath(Transform transform) { }

	// RVA: 0x1AFF9E0 Offset: 0x1AFFAE1 VA: 0x1AFF9E0
	public void RemoveTransformPath(Transform transform, bool recursive) { }

	// RVA: 0x1AFFA40 Offset: 0x1AFFB41 VA: 0x1AFFA40
	public string GetTransformPath(int index) { }

	// RVA: 0x1AFFA90 Offset: 0x1AFFB91 VA: 0x1AFFA90
	public void SetTransformPath(int index, string path) { }

	// RVA: 0x1AFFAF0 Offset: 0x1AFFBF1 VA: 0x1AFFAF0
	private float GetTransformWeight(int index) { }

	// RVA: 0x1AFFB40 Offset: 0x1AFFC41 VA: 0x1AFFB40
	private void SetTransformWeight(int index, float weight) { }

	// RVA: 0x1AFFBA0 Offset: 0x1AFFCA1 VA: 0x1AFFBA0
	public bool GetTransformActive(int index) { }

	// RVA: 0x1AFFC00 Offset: 0x1AFFD01 VA: 0x1AFFC00
	public void SetTransformActive(int index, bool value) { }

	// RVA: 0x1AFFC80 Offset: 0x1AFFD81 VA: 0x1AFFC80
	internal bool get_hasFeetIK() { }

	// RVA: 0x1AFFCD0 Offset: 0x1AFFDD1 VA: 0x1AFFCD0
	internal void Copy(AvatarMask other) { }
}

