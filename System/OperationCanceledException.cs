[ComVisibleAttribute] // RVA: 0xAC500 Offset: 0xAC601 VA: 0xAC500
[Serializable]
public class OperationCanceledException : SystemException // TypeDefIndex: 291
{
	// Fields
	private CancellationToken _cancellationToken; // 0x88

	// Properties
	public CancellationToken CancellationToken { get; set; }

	// Methods

	// RVA: 0x18EC1F0 Offset: 0x18EC2F1 VA: 0x18EC1F0
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x18EC200 Offset: 0x18EC301 VA: 0x18EC200
	private void set_CancellationToken(CancellationToken value) { }

	// RVA: 0x18D6E80 Offset: 0x18D6F81 VA: 0x18D6E80
	public void .ctor() { }

	// RVA: 0x18EC210 Offset: 0x18EC311 VA: 0x18EC210
	public void .ctor(string message) { }

	// RVA: 0x18EC250 Offset: 0x18EC351 VA: 0x18EC250
	public void .ctor(string message, CancellationToken token) { }

	// RVA: 0x18EC2A0 Offset: 0x18EC3A1 VA: 0x18EC2A0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

