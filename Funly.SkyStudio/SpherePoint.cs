[Serializable]
public class SpherePoint // TypeDefIndex: 9688
{
	// Fields
	public float horizontalRotation; // 0x10
	public float verticalRotation; // 0x14
	public const float MinHorizontalRotation = -3.1415927;
	public const float MaxHorizontalRotation = 3.1415927;
	public const float MinVerticalRotation = -1.5707964;
	public const float MaxVerticalRotation = 1.5707964;

	// Methods

	// RVA: 0x22B5890 Offset: 0x22B5991 VA: 0x22B5890
	public void .ctor(float horizontalRotation, float verticalRotation) { }

	// RVA: 0x22BF490 Offset: 0x22BF591 VA: 0x22BF490
	public void .ctor(Vector3 worldDirection) { }

	// RVA: 0x22BF4F0 Offset: 0x22BF5F1 VA: 0x22BF4F0
	public void SetFromWorldDirection(Vector3 worldDirection) { }

	// RVA: 0x22B58D0 Offset: 0x22B59D1 VA: 0x22B58D0
	public Vector3 GetWorldDirection() { }
}

