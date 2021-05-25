public class AdvancingFront // TypeDefIndex: 9252
{
	// Fields
	public AdvancingFrontNode Head; // 0x10
	public AdvancingFrontNode Tail; // 0x18
	protected AdvancingFrontNode Search; // 0x20

	// Methods

	// RVA: 0x220BCC0 Offset: 0x220BDC1 VA: 0x220BCC0
	public void .ctor(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	// RVA: 0x220BD20 Offset: 0x220BE21 VA: 0x220BD20
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x220BD30 Offset: 0x220BE31 VA: 0x220BD30
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x220BD40 Offset: 0x220BE41 VA: 0x220BD40 Slot: 3
	public override string ToString() { }

	// RVA: 0x220BE60 Offset: 0x220BF61 VA: 0x220BE60
	private AdvancingFrontNode FindSearchNode(double x) { }

	// RVA: 0x220BE70 Offset: 0x220BF71 VA: 0x220BE70
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x220BF20 Offset: 0x220C021 VA: 0x220BF20
	private AdvancingFrontNode LocateNode(double x) { }

	// RVA: 0x220BFB0 Offset: 0x220C0B1 VA: 0x220BFB0
	public AdvancingFrontNode LocatePoint(TriangulationPoint point) { }
}

