[RequiredByNativeCodeAttribute] // RVA: 0xE1210 Offset: 0xE1311 VA: 0xE1210
[NativeHeaderAttribute] // RVA: 0xE1210 Offset: 0xE1311 VA: 0xE1210
public class CapsuleCollider : Collider // TypeDefIndex: 3433
{
	// Properties
	public Vector3 center { get; set; }
	public float radius { get; set; }
	public float height { get; set; }
	public int direction { get; set; }

	// Methods

	// RVA: 0x350ABB0 Offset: 0x350ACB1 VA: 0x350ABB0
	public Vector3 get_center() { }

	// RVA: 0x350AC60 Offset: 0x350AD61 VA: 0x350AC60
	public void set_center(Vector3 value) { }

	// RVA: 0x350AD10 Offset: 0x350AE11 VA: 0x350AD10
	public float get_radius() { }

	// RVA: 0x350AD60 Offset: 0x350AE61 VA: 0x350AD60
	public void set_radius(float value) { }

	// RVA: 0x350ADB0 Offset: 0x350AEB1 VA: 0x350ADB0
	public float get_height() { }

	// RVA: 0x350AE00 Offset: 0x350AF01 VA: 0x350AE00
	public void set_height(float value) { }

	// RVA: 0x350AE50 Offset: 0x350AF51 VA: 0x350AE50
	public int get_direction() { }

	// RVA: 0x350AEA0 Offset: 0x350AFA1 VA: 0x350AEA0
	public void set_direction(int value) { }

	// RVA: 0x350AEF0 Offset: 0x350AFF1 VA: 0x350AEF0
	internal Vector2 GetGlobalExtents() { }

	// RVA: 0x350AFA0 Offset: 0x350B0A1 VA: 0x350AFA0
	internal Matrix4x4 CalculateTransform() { }

	// RVA: 0x350B080 Offset: 0x350B181 VA: 0x350B080
	public void .ctor() { }

	// RVA: 0x350AC10 Offset: 0x350AD11 VA: 0x350AC10
	private void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x350ACC0 Offset: 0x350ADC1 VA: 0x350ACC0
	private void set_center_Injected(ref Vector3 value) { }

	// RVA: 0x350AF50 Offset: 0x350B051 VA: 0x350AF50
	private void GetGlobalExtents_Injected(out Vector2 ret) { }

	// RVA: 0x350B030 Offset: 0x350B131 VA: 0x350B030
	private void CalculateTransform_Injected(out Matrix4x4 ret) { }
}

