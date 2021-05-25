public class TCP2_GetPosOnWater : MonoBehaviour // TypeDefIndex: 8997
{
	// Fields
	public Material WaterMaterial; // 0x18
	[TooltipAttribute] // RVA: 0x175490 Offset: 0x175591 VA: 0x175490
	public float heightScale; // 0x20
	[SpaceAttribute] // RVA: 0x1754D0 Offset: 0x1755D1 VA: 0x1754D0
	[TooltipAttribute] // RVA: 0x1754D0 Offset: 0x1755D1 VA: 0x1754D0
	public bool followWaterHeight; // 0x24
	[TooltipAttribute] // RVA: 0x175520 Offset: 0x175621 VA: 0x175520
	public float heightOffset; // 0x28
	[SpaceAttribute] // RVA: 0x175560 Offset: 0x175661 VA: 0x175560
	[TooltipAttribute] // RVA: 0x175560 Offset: 0x175661 VA: 0x175560
	public bool followWaterNormal; // 0x2C
	[TooltipAttribute] // RVA: 0x1755B0 Offset: 0x1756B1 VA: 0x1755B0
	public Vector3 upAxis; // 0x30
	[TooltipAttribute] // RVA: 0x1755F0 Offset: 0x1756F1 VA: 0x1755F0
	public Vector3 postRotation; // 0x3C
	[SerializeField] // RVA: 0x175630 Offset: 0x175731 VA: 0x175630
	[HideInInspector] // RVA: 0x175630 Offset: 0x175731 VA: 0x175630
	private bool isValid; // 0x48
	[SerializeField] // RVA: 0x175670 Offset: 0x175771 VA: 0x175670
	[HideInInspector] // RVA: 0x175670 Offset: 0x175771 VA: 0x175670
	private int sineCount; // 0x4C
	private float[] sinePosOffsetsX; // 0x50
	private float[] sinePosOffsetsZ; // 0x58
	private float[] sinePhsOffsetsX; // 0x60
	private float[] sinePhsOffsetsZ; // 0x68

	// Methods

	// RVA: 0x1C718C0 Offset: 0x1C719C1 VA: 0x1C718C0
	private void LateUpdate() { }

	// RVA: 0x1C71A50 Offset: 0x1C71B51 VA: 0x1C71A50
	public Vector3 GetPositionOnWater(Vector3 worldPosition) { }

	// RVA: 0x1C724B0 Offset: 0x1C725B1 VA: 0x1C724B0
	public Vector3 GetNormalOnWater(Vector3 worldPosition) { }

	// RVA: 0x1C73160 Offset: 0x1C73261 VA: 0x1C73160
	public void .ctor() { }
}

