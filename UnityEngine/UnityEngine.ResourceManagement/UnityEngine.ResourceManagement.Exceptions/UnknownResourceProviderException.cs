public class UnknownResourceProviderException : ResourceManagerException // TypeDefIndex: 4461
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x129C20 Offset: 0x129D21 VA: 0x129C20
	private IResourceLocation <Location>k__BackingField; // 0x88

	// Properties
	public IResourceLocation Location { get; set; }
	public override string Message { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x12A210 Offset: 0x12A311 VA: 0x12A210
	// RVA: 0x19D8050 Offset: 0x19D8151 VA: 0x19D8050
	public IResourceLocation get_Location() { }

	[CompilerGeneratedAttribute] // RVA: 0x12A220 Offset: 0x12A321 VA: 0x12A220
	// RVA: 0x19D8060 Offset: 0x19D8161 VA: 0x19D8060
	private void set_Location(IResourceLocation value) { }

	// RVA: 0x19D8070 Offset: 0x19D8171 VA: 0x19D8070
	public void .ctor(IResourceLocation location) { }

	// RVA: 0x19D8100 Offset: 0x19D8201 VA: 0x19D8100
	public void .ctor() { }

	// RVA: 0x19D8170 Offset: 0x19D8271 VA: 0x19D8170
	public void .ctor(string message) { }

	// RVA: 0x19D81F0 Offset: 0x19D82F1 VA: 0x19D81F0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x19D8270 Offset: 0x19D8371 VA: 0x19D8270
	protected void .ctor(SerializationInfo message, StreamingContext context) { }

	// RVA: 0x19D8300 Offset: 0x19D8401 VA: 0x19D8300 Slot: 5
	public override string get_Message() { }

	// RVA: 0x19D8550 Offset: 0x19D8651 VA: 0x19D8550 Slot: 3
	public override string ToString() { }
}

