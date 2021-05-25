[NativeHeaderAttribute] // RVA: 0x104C00 Offset: 0x104D01 VA: 0x104C00
public class CertificateHandler // TypeDefIndex: 3711
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethodAttribute] // RVA: 0x105130 Offset: 0x105231 VA: 0x105130
	// RVA: 0x1BBB1F0 Offset: 0x1BBB2F1 VA: 0x1BBB1F0
	private void Release() { }

	// RVA: 0x1BBB240 Offset: 0x1BBB341 VA: 0x1BBB240 Slot: 4
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x105170 Offset: 0x105271 VA: 0x105170
	// RVA: 0x1BBB250 Offset: 0x1BBB351 VA: 0x1BBB250
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x1BBB260 Offset: 0x1BBB361 VA: 0x1BBB260 Slot: 5
	public void Dispose() { }
}

