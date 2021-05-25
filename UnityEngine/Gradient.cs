[NativeHeaderAttribute] // RVA: 0xC5D10 Offset: 0xC5E11 VA: 0xC5D10
[RequiredByNativeCodeAttribute] // RVA: 0xC5D10 Offset: 0xC5E11 VA: 0xC5D10
public class Gradient : IEquatable<Gradient> // TypeDefIndex: 2963
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public GradientColorKey[] colorKeys { get; set; }
	public GradientAlphaKey[] alphaKeys { get; set; }
	public GradientMode mode { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xD4C30 Offset: 0xD4D31 VA: 0xD4C30
	// RVA: 0x1A28E30 Offset: 0x1A28F31 VA: 0x1A28E30
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0xD4C80 Offset: 0xD4D81 VA: 0xD4C80
	// RVA: 0x1A28E70 Offset: 0x1A28F71 VA: 0x1A28E70
	private void Cleanup() { }

	[FreeFunctionAttribute] // RVA: 0xD4CE0 Offset: 0xD4DE1 VA: 0xD4CE0
	// RVA: 0x1A28EC0 Offset: 0x1A28FC1 VA: 0x1A28EC0
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD4D30 Offset: 0xD4E31 VA: 0xD4D30
	// RVA: 0x1A28F10 Offset: 0x1A29011 VA: 0x1A28F10
	public void .ctor() { }

	// RVA: 0x1A28F60 Offset: 0x1A29061 VA: 0x1A28F60 Slot: 1
	protected override void Finalize() { }

	[FreeFunctionAttribute] // RVA: 0xD4D40 Offset: 0xD4E41 VA: 0xD4D40
	// RVA: 0x1A28FF0 Offset: 0x1A290F1 VA: 0x1A28FF0
	public GradientColorKey[] get_colorKeys() { }

	[FreeFunctionAttribute] // RVA: 0xD4D90 Offset: 0xD4E91 VA: 0xD4D90
	// RVA: 0x1A29040 Offset: 0x1A29141 VA: 0x1A29040
	public void set_colorKeys(GradientColorKey[] value) { }

	[FreeFunctionAttribute] // RVA: 0xD4DE0 Offset: 0xD4EE1 VA: 0xD4DE0
	// RVA: 0x1A29090 Offset: 0x1A29191 VA: 0x1A29090
	public GradientAlphaKey[] get_alphaKeys() { }

	[FreeFunctionAttribute] // RVA: 0xD4E30 Offset: 0xD4F31 VA: 0xD4E30
	// RVA: 0x1A290E0 Offset: 0x1A291E1 VA: 0x1A290E0
	public void set_alphaKeys(GradientAlphaKey[] value) { }

	// RVA: 0x1A29130 Offset: 0x1A29231 VA: 0x1A29130
	public GradientMode get_mode() { }

	// RVA: 0x1A29180 Offset: 0x1A29281 VA: 0x1A29180
	public void set_mode(GradientMode value) { }

	// RVA: 0x1A291D0 Offset: 0x1A292D1 VA: 0x1A291D0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1A29330 Offset: 0x1A29431 VA: 0x1A29330 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x1A29400 Offset: 0x1A29501 VA: 0x1A29400 Slot: 2
	public override int GetHashCode() { }
}

