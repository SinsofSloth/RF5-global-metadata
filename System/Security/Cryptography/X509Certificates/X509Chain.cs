public class X509Chain : IDisposable // TypeDefIndex: 1849
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainPolicy ChainPolicy { set; }

	// Methods

	// RVA: 0x1717C60 Offset: 0x1717D61 VA: 0x1717C60
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x1717D50 Offset: 0x1717E51 VA: 0x1717D50
	public void .ctor() { }

	// RVA: 0x1717DC0 Offset: 0x1717EC1 VA: 0x1717DC0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x1717EA0 Offset: 0x1717FA1 VA: 0x1717EA0
	public void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x1717F40 Offset: 0x1718041 VA: 0x1717F40 Slot: 4
	public void Dispose() { }

	// RVA: 0x1717FC0 Offset: 0x17180C1 VA: 0x1717FC0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17180F0 Offset: 0x17181F1 VA: 0x17180F0 Slot: 1
	protected override void Finalize() { }
}

