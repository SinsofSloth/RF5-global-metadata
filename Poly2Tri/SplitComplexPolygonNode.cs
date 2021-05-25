[DefaultMemberAttribute] // RVA: 0x147C30 Offset: 0x147D31 VA: 0x147C30
public class SplitComplexPolygonNode // TypeDefIndex: 9272
{
	// Fields
	private List<SplitComplexPolygonNode> mConnected; // 0x10
	private Point2D mPosition; // 0x18

	// Properties
	public int NumConnected { get; }
	public Point2D Position { get; set; }
	public SplitComplexPolygonNode Item { get; }

	// Methods

	// RVA: 0x276E770 Offset: 0x276E871 VA: 0x276E770
	public int get_NumConnected() { }

	// RVA: 0x2770190 Offset: 0x2770291 VA: 0x2770190
	public Point2D get_Position() { }

	// RVA: 0x27701A0 Offset: 0x27702A1 VA: 0x27701A0
	public void set_Position(Point2D value) { }

	// RVA: 0x276E190 Offset: 0x276E291 VA: 0x276E190
	public SplitComplexPolygonNode get_Item(int index) { }

	// RVA: 0x27701B0 Offset: 0x27702B1 VA: 0x27701B0
	public void .ctor() { }

	// RVA: 0x276E030 Offset: 0x276E131 VA: 0x276E030
	public void .ctor(Point2D pos) { }

	// RVA: 0x2770230 Offset: 0x2770331 VA: 0x2770230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2770300 Offset: 0x2770401 VA: 0x2770300
	public bool Equals(SplitComplexPolygonNode pn) { }

	// RVA: 0x2770330 Offset: 0x2770431 VA: 0x2770330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x276E210 Offset: 0x276E311 VA: 0x276E210
	public static bool op_Equality(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs) { }

	// RVA: 0x276E7C0 Offset: 0x276E8C1 VA: 0x276E7C0
	public static bool op_Inequality(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs) { }

	// RVA: 0x2770340 Offset: 0x2770441 VA: 0x2770340 Slot: 3
	public override string ToString() { }

	// RVA: 0x27704D0 Offset: 0x27705D1 VA: 0x27704D0
	private bool IsRighter(double sinA, double cosA, double sinB, double cosB) { }

	// RVA: 0x2770510 Offset: 0x2770611 VA: 0x2770510
	private int remainder(int x, int modulus) { }

	// RVA: 0x276E0D0 Offset: 0x276E1D1 VA: 0x276E0D0
	public void AddConnection(SplitComplexPolygonNode toMe) { }

	// RVA: 0x276E700 Offset: 0x276E801 VA: 0x276E700
	public void RemoveConnection(SplitComplexPolygonNode fromMe) { }

	// RVA: 0x2770530 Offset: 0x2770631 VA: 0x2770530
	private void RemoveConnectionByIndex(int index) { }

	// RVA: 0x276E830 Offset: 0x276E931 VA: 0x276E830
	public void ClearConnections() { }

	// RVA: 0x27705C0 Offset: 0x27706C1 VA: 0x27705C0
	private bool IsConnectedTo(SplitComplexPolygonNode me) { }

	// RVA: 0x276EDF0 Offset: 0x276EEF1 VA: 0x276EDF0
	public SplitComplexPolygonNode GetRightestConnection(SplitComplexPolygonNode incoming) { }

	// RVA: 0x276E890 Offset: 0x276E991 VA: 0x276E890
	public SplitComplexPolygonNode GetRightestConnection(Point2D incomingDir) { }
}

