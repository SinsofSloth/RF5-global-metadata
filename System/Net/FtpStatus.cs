internal class FtpStatus // TypeDefIndex: 1970
{
	// Fields
	private readonly FtpStatusCode statusCode; // 0x10
	private readonly string statusDescription; // 0x18

	// Properties
	public FtpStatusCode StatusCode { get; }
	public string StatusDescription { get; }

	// Methods

	// RVA: 0x17835D0 Offset: 0x17836D1 VA: 0x17835D0
	public void .ctor(FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1783620 Offset: 0x1783721 VA: 0x1783620
	public FtpStatusCode get_StatusCode() { }

	// RVA: 0x1783630 Offset: 0x1783731 VA: 0x1783630
	public string get_StatusDescription() { }
}

