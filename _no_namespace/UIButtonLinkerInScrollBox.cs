public abstract class UIButtonLinkerInScrollBox : ButtonLinker // TypeDefIndex: 8461
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16FC20 Offset: 0x16FD21 VA: 0x16FC20
	private int <SlotNo>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x16FC30 Offset: 0x16FD31 VA: 0x16FC30
	private bool <IsTop>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x16FC40 Offset: 0x16FD41 VA: 0x16FC40
	private bool <IsBottom>k__BackingField; // 0x61
	[CompilerGeneratedAttribute] // RVA: 0x16FC50 Offset: 0x16FD51 VA: 0x16FC50
	private UIScrollBoxBase <UIScrollBox>k__BackingField; // 0x68

	// Properties
	public int SlotNo { get; set; }
	public bool IsTop { get; set; }
	public bool IsBottom { get; set; }
	protected UIScrollBoxBase UIScrollBox { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7820 Offset: 0x1A7921 VA: 0x1A7820
	// RVA: 0x1F036F0 Offset: 0x1F037F1 VA: 0x1F036F0
	public int get_SlotNo() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7830 Offset: 0x1A7931 VA: 0x1A7830
	// RVA: 0x1F03700 Offset: 0x1F03801 VA: 0x1F03700
	private void set_SlotNo(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7840 Offset: 0x1A7941 VA: 0x1A7840
	// RVA: 0x1F03710 Offset: 0x1F03811 VA: 0x1F03710
	public bool get_IsTop() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7850 Offset: 0x1A7951 VA: 0x1A7850
	// RVA: 0x1F03720 Offset: 0x1F03821 VA: 0x1F03720
	private void set_IsTop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7860 Offset: 0x1A7961 VA: 0x1A7860
	// RVA: 0x1F03730 Offset: 0x1F03831 VA: 0x1F03730
	public bool get_IsBottom() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7870 Offset: 0x1A7971 VA: 0x1A7870
	// RVA: 0x1F03740 Offset: 0x1F03841 VA: 0x1F03740
	private void set_IsBottom(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7880 Offset: 0x1A7981 VA: 0x1A7880
	// RVA: 0x1F03750 Offset: 0x1F03851 VA: 0x1F03750
	protected UIScrollBoxBase get_UIScrollBox() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7890 Offset: 0x1A7991 VA: 0x1A7890
	// RVA: 0x1F03760 Offset: 0x1F03861 VA: 0x1F03760
	private void set_UIScrollBox(UIScrollBoxBase value) { }

	// RVA: 0x1F03770 Offset: 0x1F03871 VA: 0x1F03770
	public void Setup(int _slot_no, bool _top, bool _bottom, UIScrollBoxBase _scroll_box) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Init() { }

	// RVA: 0x1F03790 Offset: 0x1F03891 VA: 0x1F03790 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1F037D0 Offset: 0x1F038D1 VA: 0x1F037D0 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1F03850 Offset: 0x1F03951 VA: 0x1F03850 Slot: 15
	public override void OnTouch() { }

	// RVA: 0x1F03890 Offset: 0x1F03991 VA: 0x1F03890
	protected void .ctor() { }
}

