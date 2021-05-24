[AddComponentMenu] // RVA: 0x11A110 Offset: 0x11A211 VA: 0x11A110
public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 3963
{
	// Fields
	[SerializeField] // RVA: 0x11C000 Offset: 0x11C101 VA: 0x11C000
	protected GridLayoutGroup.Corner m_StartCorner; // 0x58
	[SerializeField] // RVA: 0x11C010 Offset: 0x11C111 VA: 0x11C010
	protected GridLayoutGroup.Axis m_StartAxis; // 0x5C
	[SerializeField] // RVA: 0x11C020 Offset: 0x11C121 VA: 0x11C020
	protected Vector2 m_CellSize; // 0x60
	[SerializeField] // RVA: 0x11C030 Offset: 0x11C131 VA: 0x11C030
	protected Vector2 m_Spacing; // 0x68
	[SerializeField] // RVA: 0x11C040 Offset: 0x11C141 VA: 0x11C040
	protected GridLayoutGroup.Constraint m_Constraint; // 0x70
	[SerializeField] // RVA: 0x11C050 Offset: 0x11C151 VA: 0x11C050
	protected int m_ConstraintCount; // 0x74

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0x186B040 Offset: 0x186B141 VA: 0x186B040
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x186B050 Offset: 0x186B151 VA: 0x186B050
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x186B0C0 Offset: 0x186B1C1 VA: 0x186B0C0
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x186B0D0 Offset: 0x186B1D1 VA: 0x186B0D0
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x186B140 Offset: 0x186B241 VA: 0x186B140
	public Vector2 get_cellSize() { }

	// RVA: 0x186B150 Offset: 0x186B251 VA: 0x186B150
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x186B1C0 Offset: 0x186B2C1 VA: 0x186B1C0
	public Vector2 get_spacing() { }

	// RVA: 0x186B1D0 Offset: 0x186B2D1 VA: 0x186B1D0
	public void set_spacing(Vector2 value) { }

	// RVA: 0x186B240 Offset: 0x186B341 VA: 0x186B240
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x186B250 Offset: 0x186B351 VA: 0x186B250
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0x186B2C0 Offset: 0x186B3C1 VA: 0x186B2C0
	public int get_constraintCount() { }

	// RVA: 0x186B2D0 Offset: 0x186B3D1 VA: 0x186B2D0
	public void set_constraintCount(int value) { }

	// RVA: 0x186B370 Offset: 0x186B471 VA: 0x186B370
	protected void .ctor() { }

	// RVA: 0x186B420 Offset: 0x186B521 VA: 0x186B420 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x186B5D0 Offset: 0x186B6D1 VA: 0x186B5D0 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x186B7C0 Offset: 0x186B8C1 VA: 0x186B7C0 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x186BE60 Offset: 0x186BF61 VA: 0x186BE60 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x186B7D0 Offset: 0x186B8D1 VA: 0x186B7D0
	private void SetCellsAlongAxis(int axis) { }
}

