[NativeHeaderAttribute] // RVA: 0xF4C90 Offset: 0xF4D91 VA: 0xF4C90
[Serializable]
public sealed class GUIStyleState // TypeDefIndex: 3606
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0xF8200 Offset: 0xF8301 VA: 0xF8200
	public Color textColor { set; }

	// Methods

	// RVA: 0x2D1F060 Offset: 0x2D1F161 VA: 0x2D1F060
	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0xF6C00 Offset: 0xF6D01 VA: 0xF6C00
	// RVA: 0x2D216C0 Offset: 0x2D217C1 VA: 0x2D216C0
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xF6C50 Offset: 0xF6D51 VA: 0xF6C50
	// RVA: 0x2D21700 Offset: 0x2D21801 VA: 0x2D21700
	private void Cleanup() { }

	// RVA: 0x2D21750 Offset: 0x2D21851 VA: 0x2D21750
	public void .ctor() { }

	// RVA: 0x2D217A0 Offset: 0x2D218A1 VA: 0x2D217A0
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x2D206E0 Offset: 0x2D207E1 VA: 0x2D206E0
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x2D217F0 Offset: 0x2D218F1 VA: 0x2D217F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2D21670 Offset: 0x2D21771 VA: 0x2D21670
	private void set_textColor_Injected(ref Color value) { }
}

