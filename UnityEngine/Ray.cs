public struct Ray // TypeDefIndex: 2860
{
	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; }

	// Methods

	// RVA: 0x381FE0 Offset: 0x3820E1 VA: 0x381FE0
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x382030 Offset: 0x382131 VA: 0x382030
	public Vector3 get_origin() { }

	// RVA: 0x382040 Offset: 0x382141 VA: 0x382040
	public void set_origin(Vector3 value) { }

	// RVA: 0x382050 Offset: 0x382151 VA: 0x382050
	public Vector3 get_direction() { }

	// RVA: 0x382060 Offset: 0x382161 VA: 0x382060
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x382070 Offset: 0x382171 VA: 0x382070 Slot: 3
	public override string ToString() { }
}

