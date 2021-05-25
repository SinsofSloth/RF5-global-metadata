public class TriangulationConstraint : Edge // TypeDefIndex: 9278
{
	// Fields
	private uint mContraintCode; // 0x20

	// Properties
	public TriangulationPoint P { get; set; }
	public TriangulationPoint Q { get; set; }
	public uint ConstraintCode { get; }

	// Methods

	// RVA: 0x2770630 Offset: 0x2770731 VA: 0x2770630
	public TriangulationPoint get_P() { }

	// RVA: 0x27706D0 Offset: 0x27707D1 VA: 0x27706D0
	public void set_P(TriangulationPoint value) { }

	// RVA: 0x2770830 Offset: 0x2770931 VA: 0x2770830
	public TriangulationPoint get_Q() { }

	// RVA: 0x27708D0 Offset: 0x27709D1 VA: 0x27708D0
	public void set_Q(TriangulationPoint value) { }

	// RVA: 0x2770920 Offset: 0x2770A21 VA: 0x2770920
	public uint get_ConstraintCode() { }

	// RVA: 0x2770930 Offset: 0x2770A31 VA: 0x2770930
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x2770AA0 Offset: 0x2770BA1 VA: 0x2770AA0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2770720 Offset: 0x2770821 VA: 0x2770720
	public void CalculateContraintCode() { }

	// RVA: 0x2770DE0 Offset: 0x2770EE1 VA: 0x2770DE0
	public static uint CalculateContraintCode(TriangulationPoint p, TriangulationPoint q) { }
}

