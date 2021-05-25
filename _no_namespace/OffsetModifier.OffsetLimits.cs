[Serializable]
public class OffsetModifier.OffsetLimits // TypeDefIndex: 9567
{
	// Fields
	[TooltipAttribute] // RVA: 0x198EB0 Offset: 0x198FB1 VA: 0x198EB0
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x198EF0 Offset: 0x198FF1 VA: 0x198EF0
	public float spring; // 0x14
	[TooltipAttribute] // RVA: 0x198F30 Offset: 0x199031 VA: 0x198F30
	public bool x; // 0x18
	[TooltipAttribute] // RVA: 0x198F70 Offset: 0x199071 VA: 0x198F70
	public bool y; // 0x19
	[TooltipAttribute] // RVA: 0x198FB0 Offset: 0x1990B1 VA: 0x198FB0
	public bool z; // 0x1A
	[TooltipAttribute] // RVA: 0x198FF0 Offset: 0x1990F1 VA: 0x198FF0
	public float minX; // 0x1C
	[TooltipAttribute] // RVA: 0x199030 Offset: 0x199131 VA: 0x199030
	public float maxX; // 0x20
	[TooltipAttribute] // RVA: 0x199070 Offset: 0x199171 VA: 0x199070
	public float minY; // 0x24
	[TooltipAttribute] // RVA: 0x1990B0 Offset: 0x1991B1 VA: 0x1990B0
	public float maxY; // 0x28
	[TooltipAttribute] // RVA: 0x1990F0 Offset: 0x1991F1 VA: 0x1990F0
	public float minZ; // 0x2C
	[TooltipAttribute] // RVA: 0x199130 Offset: 0x199231 VA: 0x199130
	public float maxZ; // 0x30

	// Methods

	// RVA: 0x291B2F0 Offset: 0x291B3F1 VA: 0x291B2F0
	public void Apply(IKEffector e, Quaternion rootRotation) { }

	// RVA: 0x291B890 Offset: 0x291B991 VA: 0x291B890
	private float SpringAxis(float value, float min, float max) { }

	// RVA: 0x291B9B0 Offset: 0x291BAB1 VA: 0x291B9B0
	private float Spring(float value, float limit, bool negative) { }

	// RVA: 0x291BA90 Offset: 0x291BB91 VA: 0x291BA90
	public void .ctor() { }
}

