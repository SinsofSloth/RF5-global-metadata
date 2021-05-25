[Serializable]
public class AngleLimits // TypeDefIndex: 9111
{
	// Fields
	public bool active; // 0x10
	[RangeAttribute] // RVA: 0x177300 Offset: 0x177401 VA: 0x177300
	public float min; // 0x14
	[RangeAttribute] // RVA: 0x177320 Offset: 0x177421 VA: 0x177320
	public float max; // 0x18

	// Methods

	// RVA: 0x1FF9CD0 Offset: 0x1FF9DD1 VA: 0x1FF9CD0
	public static Vector3 GetAngleVector(Vector3 sideVector, Vector3 forwardVector, float degrees) { }

	// RVA: 0x1FF9E00 Offset: 0x1FF9F01 VA: 0x1FF9E00
	public void CopyTo(AngleLimits target) { }

	// RVA: 0x1FF9E30 Offset: 0x1FF9F31 VA: 0x1FF9E30
	private static float ComputeFalloff(float value, float range) { }

	// RVA: 0x1FF9F10 Offset: 0x1FFA011 VA: 0x1FF9F10
	public bool ConstrainVector(Vector3 basisSide, Vector3 basisUp, Vector3 basisForward, float springStrength, float deltaTime, ref Vector3 vector) { }

	// RVA: 0x1FFA1C0 Offset: 0x1FFA2C1 VA: 0x1FFA1C0
	public void .ctor() { }
}

