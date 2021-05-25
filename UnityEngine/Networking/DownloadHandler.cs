[NativeHeaderAttribute] // RVA: 0x104C40 Offset: 0x104D41 VA: 0x104C40
public class DownloadHandler : IDisposable // TypeDefIndex: 3712
{
	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x104E40 Offset: 0x104F41 VA: 0x104E40
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string text { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x105180 Offset: 0x105281 VA: 0x105180
	// RVA: 0x1BBB2E0 Offset: 0x1BBB3E1 VA: 0x1BBB2E0
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x1051C0 Offset: 0x1052C1 VA: 0x1051C0
	// RVA: 0x1BBB330 Offset: 0x1BBB431 VA: 0x1BBB330
	internal void .ctor() { }

	// RVA: 0x1BBB340 Offset: 0x1BBB441 VA: 0x1BBB340 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1BBB410 Offset: 0x1BBB511 VA: 0x1BBB410 Slot: 4
	public void Dispose() { }

	// RVA: 0x1BBB490 Offset: 0x1BBB591 VA: 0x1BBB490
	public string get_text() { }

	// RVA: 0x1BBB4A0 Offset: 0x1BBB5A1 VA: 0x1BBB4A0 Slot: 5
	protected virtual byte[] GetData() { }

	// RVA: 0x1BBB4B0 Offset: 0x1BBB5B1 VA: 0x1BBB4B0 Slot: 6
	protected virtual string GetText() { }

	// RVA: 0x1BBB550 Offset: 0x1BBB651 VA: 0x1BBB550
	private Encoding GetTextEncoder() { }

	// RVA: 0x1BBB7B0 Offset: 0x1BBB8B1 VA: 0x1BBB7B0
	private string GetContentType() { }

	[NativeThrowsAttribute] // RVA: 0x1051D0 Offset: 0x1052D1 VA: 0x1051D0
	[VisibleToOtherModulesAttribute] // RVA: 0x1051D0 Offset: 0x1052D1 VA: 0x1051D0
	// RVA: 0x1BBB800 Offset: 0x1BBB901 VA: 0x1BBB800
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }
}

