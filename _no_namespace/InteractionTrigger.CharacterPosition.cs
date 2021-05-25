[Serializable]
public class InteractionTrigger.CharacterPosition // TypeDefIndex: 9522
{
	// Fields
	[TooltipAttribute] // RVA: 0x198250 Offset: 0x198351 VA: 0x198250
	public bool use; // 0x10
	[TooltipAttribute] // RVA: 0x198290 Offset: 0x198391 VA: 0x198290
	public Vector2 offset; // 0x14
	[TooltipAttribute] // RVA: 0x1982D0 Offset: 0x1983D1 VA: 0x1982D0
	[RangeAttribute] // RVA: 0x1982D0 Offset: 0x1983D1 VA: 0x1982D0
	public float angleOffset; // 0x1C
	[TooltipAttribute] // RVA: 0x198330 Offset: 0x198431 VA: 0x198330
	[RangeAttribute] // RVA: 0x198330 Offset: 0x198431 VA: 0x198330
	public float maxAngle; // 0x20
	[TooltipAttribute] // RVA: 0x198390 Offset: 0x198491 VA: 0x198390
	public float radius; // 0x24
	[TooltipAttribute] // RVA: 0x1983D0 Offset: 0x1984D1 VA: 0x1983D0
	public bool orbit; // 0x28
	[TooltipAttribute] // RVA: 0x198410 Offset: 0x198511 VA: 0x198410
	public bool fixYAxis; // 0x29

	// Properties
	public Vector3 offset3D { get; }
	public Vector3 direction3D { get; }

	// Methods

	// RVA: 0x29193B0 Offset: 0x29194B1 VA: 0x29193B0
	public Vector3 get_offset3D() { }

	// RVA: 0x29193F0 Offset: 0x29194F1 VA: 0x29193F0
	public Vector3 get_direction3D() { }

	// RVA: 0x29194F0 Offset: 0x29195F1 VA: 0x29194F0
	public bool IsInRange(Transform character, Transform trigger, out float error) { }

	// RVA: 0x2919B70 Offset: 0x2919C71 VA: 0x2919B70
	public void .ctor() { }
}

