[ExtensionAttribute] // RVA: 0x12F320 Offset: 0x12F421 VA: 0x12F320
public static class UnityQuaternionExtensions // TypeDefIndex: 4907
{
	// Methods

	// RVA: 0x1A252C0 Offset: 0x1A253C1 VA: 0x1A252C0
	public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up) { }

	[ExtensionAttribute] // RVA: 0x1373B0 Offset: 0x1374B1 VA: 0x1373B0
	// RVA: 0x1A25630 Offset: 0x1A25731 VA: 0x1A25630
	public static Quaternion Normalized(Quaternion q) { }

	[ExtensionAttribute] // RVA: 0x1373C0 Offset: 0x1374C1 VA: 0x1373C0
	// RVA: 0x1A25690 Offset: 0x1A25791 VA: 0x1A25690
	public static Vector2 GetCameraRotationToTarget(Quaternion orient, Vector3 lookAtDir, Vector3 worldUp) { }

	[ExtensionAttribute] // RVA: 0x1373D0 Offset: 0x1374D1 VA: 0x1373D0
	// RVA: 0x1A25C00 Offset: 0x1A25D01 VA: 0x1A25C00
	public static Quaternion ApplyCameraRotation(Quaternion orient, Vector2 rot, Vector3 worldUp) { }
}

