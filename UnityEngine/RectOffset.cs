[NativeHeaderAttribute] // RVA: 0xC4880 Offset: 0xC4981 VA: 0xC4880
[UsedByNativeCodeAttribute] // RVA: 0xC4880 Offset: 0xC4981 VA: 0xC4880
[Serializable]
public class RectOffset // TypeDefIndex: 2863
{
	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0xC9C00 Offset: 0xC9D01 VA: 0xC9C00
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0xDE210 Offset: 0xDE311 VA: 0xDE210
	public int left { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE250 Offset: 0xDE351 VA: 0xDE250
	public int right { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE290 Offset: 0xDE391 VA: 0xDE290
	public int top { get; set; }
	[NativePropertyAttribute] // RVA: 0xDE2D0 Offset: 0xDE3D1 VA: 0xDE2D0
	public int bottom { get; set; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x2B775C0 Offset: 0x2B776C1 VA: 0x2B775C0
	public void .ctor() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCDDC0 Offset: 0xCDEC1 VA: 0xCDDC0
	// RVA: 0x2B77650 Offset: 0x2B77751 VA: 0x2B77650
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x2B776A0 Offset: 0x2B777A1 VA: 0x2B776A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2B77810 Offset: 0x2B77911 VA: 0x2B77810
	public void .ctor(int left, int right, int top, int bottom) { }

	// RVA: 0x2B77A70 Offset: 0x2B77B71 VA: 0x2B77A70 Slot: 3
	public override string ToString() { }

	// RVA: 0x2B77780 Offset: 0x2B77881 VA: 0x2B77780
	private void Destroy() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xCDE50 Offset: 0xCDF51 VA: 0xCDE50
	// RVA: 0x2B77610 Offset: 0x2B77711 VA: 0x2B77610
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xCDE60 Offset: 0xCDF61 VA: 0xCDE60
	// RVA: 0x2B77E20 Offset: 0x2B77F21 VA: 0x2B77E20
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x2B77CE0 Offset: 0x2B77DE1 VA: 0x2B77CE0
	public int get_left() { }

	// RVA: 0x2B77930 Offset: 0x2B77A31 VA: 0x2B77930
	public void set_left(int value) { }

	// RVA: 0x2B77D30 Offset: 0x2B77E31 VA: 0x2B77D30
	public int get_right() { }

	// RVA: 0x2B77980 Offset: 0x2B77A81 VA: 0x2B77980
	public void set_right(int value) { }

	// RVA: 0x2B77D80 Offset: 0x2B77E81 VA: 0x2B77D80
	public int get_top() { }

	// RVA: 0x2B779D0 Offset: 0x2B77AD1 VA: 0x2B779D0
	public void set_top(int value) { }

	// RVA: 0x2B77DD0 Offset: 0x2B77ED1 VA: 0x2B77DD0
	public int get_bottom() { }

	// RVA: 0x2B77A20 Offset: 0x2B77B21 VA: 0x2B77A20
	public void set_bottom(int value) { }

	// RVA: 0x2B77E70 Offset: 0x2B77F71 VA: 0x2B77E70
	public int get_horizontal() { }

	// RVA: 0x2B77EC0 Offset: 0x2B77FC1 VA: 0x2B77EC0
	public int get_vertical() { }

	// RVA: 0x2B77F10 Offset: 0x2B78011 VA: 0x2B77F10
	public Rect Add(Rect rect) { }

	// RVA: 0x2B77FE0 Offset: 0x2B780E1 VA: 0x2B77FE0
	public Rect Remove(Rect rect) { }

	// RVA: 0x2B77F80 Offset: 0x2B78081 VA: 0x2B77F80
	private void Add_Injected(ref Rect rect, out Rect ret) { }

	// RVA: 0x2B78050 Offset: 0x2B78151 VA: 0x2B78050
	private void Remove_Injected(ref Rect rect, out Rect ret) { }
}

