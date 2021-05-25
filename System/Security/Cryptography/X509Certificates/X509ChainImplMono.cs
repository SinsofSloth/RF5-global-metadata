internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 1853
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private static X509ChainStatus[] Empty; // 0x0

	// Properties
	public override bool IsValid { get; }
	public override X509ChainPolicy ChainPolicy { set; }

	// Methods

	// RVA: 0x1718670 Offset: 0x1718771 VA: 0x1718670
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x17187C0 Offset: 0x17188C1 VA: 0x17187C0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x17187D0 Offset: 0x17188D1 VA: 0x17187D0 Slot: 6
	public override void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x17187E0 Offset: 0x17188E1 VA: 0x17187E0
	private static void .cctor() { }
}

