internal abstract class RuntimeAssembly : Assembly // TypeDefIndex: 585
{
	// Methods

	// RVA: 0x17F0A80 Offset: 0x17F0B81 VA: 0x17F0A80 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F0B30 Offset: 0x17F0C31 VA: 0x17F0B30
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x17F0BD0 Offset: 0x17F0CD1 VA: 0x17F0BD0
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x17F0C80 Offset: 0x17F0D81 VA: 0x17F0C80 Slot: 18
	public override AssemblyName GetName(bool copiedName) { }

	// RVA: 0x17F0C90 Offset: 0x17F0D91 VA: 0x17F0C90
	protected void .ctor() { }
}

