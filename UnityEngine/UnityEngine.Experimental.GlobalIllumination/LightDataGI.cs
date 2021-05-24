[UsedByNativeCodeAttribute] // RVA: 0xC8F40 Offset: 0xC9041 VA: 0xC8F40
public struct LightDataGI // TypeDefIndex: 3375
{
	// Fields
	public int instanceID; // 0x0
	public LinearColor color; // 0x4
	public LinearColor indirectColor; // 0x14
	public Quaternion orientation; // 0x24
	public Vector3 position; // 0x34
	public float range; // 0x40
	public float coneAngle; // 0x44
	public float innerConeAngle; // 0x48
	public float shape0; // 0x4C
	public float shape1; // 0x50
	public LightType type; // 0x54
	public LightMode mode; // 0x55
	public byte shadow; // 0x56
	public FalloffType falloff; // 0x57

	// Methods

	// RVA: 0x37C8A0 Offset: 0x37C9A1 VA: 0x37C8A0
	public void Init(ref DirectionalLight light) { }

	// RVA: 0x37C8B0 Offset: 0x37C9B1 VA: 0x37C8B0
	public void Init(ref PointLight light) { }

	// RVA: 0x37C8C0 Offset: 0x37C9C1 VA: 0x37C8C0
	public void Init(ref SpotLight light) { }

	// RVA: 0x37C960 Offset: 0x37CA61 VA: 0x37C960
	public void Init(ref RectangleLight light) { }

	// RVA: 0x37C9F0 Offset: 0x37CAF1 VA: 0x37C9F0
	public void Init(ref DiscLight light) { }

	// RVA: 0x37CA70 Offset: 0x37CB71 VA: 0x37CA70
	public void InitNoBake(int lightInstanceID) { }
}

