[NativeHeaderAttribute] // RVA: 0xE8C80 Offset: 0xE8D81 VA: 0xE8C80
[UsedByNativeCodeAttribute] // RVA: 0xE8C80 Offset: 0xE8D81 VA: 0xE8C80
public class Avatar : Object // TypeDefIndex: 3492
{
	// Properties
	public bool isValid { get; }
	public bool isHuman { get; }
	public HumanDescription humanDescription { get; }

	// Methods

	// RVA: 0x1AFEAF0 Offset: 0x1AFEBF1 VA: 0x1AFEAF0
	private void .ctor() { }

	[NativeMethodAttribute] // RVA: 0xEC270 Offset: 0xEC371 VA: 0xEC270
	// RVA: 0x1AFEB60 Offset: 0x1AFEC61 VA: 0x1AFEB60
	public bool get_isValid() { }

	[NativeMethodAttribute] // RVA: 0xEC2B0 Offset: 0xEC3B1 VA: 0xEC2B0
	// RVA: 0x1AFEBB0 Offset: 0x1AFECB1 VA: 0x1AFEBB0
	public bool get_isHuman() { }

	// RVA: 0x1AFEC00 Offset: 0x1AFED01 VA: 0x1AFEC00
	public HumanDescription get_humanDescription() { }

	// RVA: 0x1AFECE0 Offset: 0x1AFEDE1 VA: 0x1AFECE0
	internal void SetMuscleMinMax(int muscleId, float min, float max) { }

	// RVA: 0x1AFED50 Offset: 0x1AFEE51 VA: 0x1AFED50
	internal void SetParameter(int parameterId, float value) { }

	// RVA: 0x1AFEDB0 Offset: 0x1AFEEB1 VA: 0x1AFEDB0
	internal float GetAxisLength(int humanId) { }

	// RVA: 0x1AFEE80 Offset: 0x1AFEF81 VA: 0x1AFEE80
	internal Quaternion GetPreRotation(int humanId) { }

	// RVA: 0x1AFEF90 Offset: 0x1AFF091 VA: 0x1AFEF90
	internal Quaternion GetPostRotation(int humanId) { }

	// RVA: 0x1AFF0A0 Offset: 0x1AFF1A1 VA: 0x1AFF0A0
	internal Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	// RVA: 0x1AFF220 Offset: 0x1AFF321 VA: 0x1AFF220
	internal Quaternion GetZYRoll(int humanId, Vector3 uvw) { }

	// RVA: 0x1AFF360 Offset: 0x1AFF461 VA: 0x1AFF360
	internal Vector3 GetLimitSign(int humanId) { }

	[NativeMethodAttribute] // RVA: 0xEC2F0 Offset: 0xEC3F1 VA: 0xEC2F0
	// RVA: 0x1AFEE30 Offset: 0x1AFEF31 VA: 0x1AFEE30
	internal float Internal_GetAxisLength(int humanId) { }

	[NativeMethodAttribute] // RVA: 0xEC330 Offset: 0xEC431 VA: 0xEC330
	// RVA: 0x1AFEF20 Offset: 0x1AFF021 VA: 0x1AFEF20
	internal Quaternion Internal_GetPreRotation(int humanId) { }

	[NativeMethodAttribute] // RVA: 0xEC370 Offset: 0xEC471 VA: 0xEC370
	// RVA: 0x1AFF030 Offset: 0x1AFF131 VA: 0x1AFF030
	internal Quaternion Internal_GetPostRotation(int humanId) { }

	[NativeMethodAttribute] // RVA: 0xEC3B0 Offset: 0xEC4B1 VA: 0xEC3B0
	// RVA: 0x1AFF190 Offset: 0x1AFF291 VA: 0x1AFF190
	internal Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q) { }

	[NativeMethodAttribute] // RVA: 0xEC3F0 Offset: 0xEC4F1 VA: 0xEC3F0
	// RVA: 0x1AFF2E0 Offset: 0x1AFF3E1 VA: 0x1AFF2E0
	internal Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw) { }

	[NativeMethodAttribute] // RVA: 0xEC430 Offset: 0xEC531 VA: 0xEC430
	// RVA: 0x1AFF400 Offset: 0x1AFF501 VA: 0x1AFF400
	internal Vector3 Internal_GetLimitSign(int humanId) { }

	// RVA: 0x1AFEC90 Offset: 0x1AFED91 VA: 0x1AFEC90
	private void get_humanDescription_Injected(out HumanDescription ret) { }

	// RVA: 0x1AFF470 Offset: 0x1AFF571 VA: 0x1AFF470
	private void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret) { }

	// RVA: 0x1AFF4D0 Offset: 0x1AFF5D1 VA: 0x1AFF4D0
	private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret) { }

	// RVA: 0x1AFF530 Offset: 0x1AFF631 VA: 0x1AFF530
	private void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret) { }

	// RVA: 0x1AFF5A0 Offset: 0x1AFF6A1 VA: 0x1AFF5A0
	private void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret) { }

	// RVA: 0x1AFF610 Offset: 0x1AFF711 VA: 0x1AFF610
	private void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret) { }
}

