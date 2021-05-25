[NativeHeaderAttribute] // RVA: 0xE0F50 Offset: 0xE1051 VA: 0xE0F50
public class PhysicMaterial : Object // TypeDefIndex: 3427
{
	// Properties
	public float bounciness { get; set; }
	public float dynamicFriction { get; set; }
	public float staticFriction { get; set; }
	public PhysicMaterialCombine frictionCombine { get; set; }
	public PhysicMaterialCombine bounceCombine { get; set; }
	[ObsoleteAttribute] // RVA: 0xE4330 Offset: 0xE4431 VA: 0xE4330
	public float bouncyness { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xE4370 Offset: 0xE4471 VA: 0xE4370
	[ObsoleteAttribute] // RVA: 0xE4370 Offset: 0xE4471 VA: 0xE4370
	public Vector3 frictionDirection2 { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xE43D0 Offset: 0xE44D1 VA: 0xE43D0
	[ObsoleteAttribute] // RVA: 0xE43D0 Offset: 0xE44D1 VA: 0xE43D0
	public float dynamicFriction2 { get; set; }
	[ObsoleteAttribute] // RVA: 0xE4430 Offset: 0xE4531 VA: 0xE4430
	[EditorBrowsableAttribute] // RVA: 0xE4430 Offset: 0xE4531 VA: 0xE4430
	public float staticFriction2 { get; set; }
	[EditorBrowsableAttribute] // RVA: 0xE4490 Offset: 0xE4591 VA: 0xE4490
	[ObsoleteAttribute] // RVA: 0xE4490 Offset: 0xE4591 VA: 0xE4490
	public Vector3 frictionDirection { get; set; }

	// Methods

	// RVA: 0x350CFC0 Offset: 0x350D0C1 VA: 0x350CFC0
	public void .ctor() { }

	// RVA: 0x350D0C0 Offset: 0x350D1C1 VA: 0x350D0C0
	public void .ctor(string name) { }

	// RVA: 0x350D070 Offset: 0x350D171 VA: 0x350D070
	private static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name) { }

	// RVA: 0x350D160 Offset: 0x350D261 VA: 0x350D160
	public float get_bounciness() { }

	// RVA: 0x350D1B0 Offset: 0x350D2B1 VA: 0x350D1B0
	public void set_bounciness(float value) { }

	// RVA: 0x350D200 Offset: 0x350D301 VA: 0x350D200
	public float get_dynamicFriction() { }

	// RVA: 0x350D250 Offset: 0x350D351 VA: 0x350D250
	public void set_dynamicFriction(float value) { }

	// RVA: 0x350D2A0 Offset: 0x350D3A1 VA: 0x350D2A0
	public float get_staticFriction() { }

	// RVA: 0x350D2F0 Offset: 0x350D3F1 VA: 0x350D2F0
	public void set_staticFriction(float value) { }

	// RVA: 0x350D340 Offset: 0x350D441 VA: 0x350D340
	public PhysicMaterialCombine get_frictionCombine() { }

	// RVA: 0x350D390 Offset: 0x350D491 VA: 0x350D390
	public void set_frictionCombine(PhysicMaterialCombine value) { }

	// RVA: 0x350D3E0 Offset: 0x350D4E1 VA: 0x350D3E0
	public PhysicMaterialCombine get_bounceCombine() { }

	// RVA: 0x350D430 Offset: 0x350D531 VA: 0x350D430
	public void set_bounceCombine(PhysicMaterialCombine value) { }

	// RVA: 0x350D480 Offset: 0x350D581 VA: 0x350D480
	public float get_bouncyness() { }

	// RVA: 0x350D4D0 Offset: 0x350D5D1 VA: 0x350D4D0
	public void set_bouncyness(float value) { }

	// RVA: 0x350D520 Offset: 0x350D621 VA: 0x350D520
	public Vector3 get_frictionDirection2() { }

	// RVA: 0x350D590 Offset: 0x350D691 VA: 0x350D590
	public void set_frictionDirection2(Vector3 value) { }

	// RVA: 0x350D5A0 Offset: 0x350D6A1 VA: 0x350D5A0
	public float get_dynamicFriction2() { }

	// RVA: 0x350D5B0 Offset: 0x350D6B1 VA: 0x350D5B0
	public void set_dynamicFriction2(float value) { }

	// RVA: 0x350D5C0 Offset: 0x350D6C1 VA: 0x350D5C0
	public float get_staticFriction2() { }

	// RVA: 0x350D5D0 Offset: 0x350D6D1 VA: 0x350D5D0
	public void set_staticFriction2(float value) { }

	// RVA: 0x350D5E0 Offset: 0x350D6E1 VA: 0x350D5E0
	public Vector3 get_frictionDirection() { }

	// RVA: 0x350D650 Offset: 0x350D751 VA: 0x350D650
	public void set_frictionDirection(Vector3 value) { }
}

