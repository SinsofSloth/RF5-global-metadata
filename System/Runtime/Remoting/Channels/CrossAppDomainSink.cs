[MonoTODOAttribute] // RVA: 0xB0E40 Offset: 0xB0F41 VA: 0xB0E40
internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 1163
{
	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x1740960 Offset: 0x1740A61 VA: 0x1740960
	internal void .ctor(int domainID) { }

	// RVA: 0x17405E0 Offset: 0x17406E1 VA: 0x17405E0
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x1740990 Offset: 0x1740A91 VA: 0x1740990
	internal int get_TargetDomainId() { }

	// RVA: 0x17409A0 Offset: 0x1740AA1 VA: 0x17409A0
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0x1740BC0 Offset: 0x1740CC1 VA: 0x1740BC0 Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0x17414D0 Offset: 0x17415D1 VA: 0x17414D0 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0x17415A0 Offset: 0x17416A1 VA: 0x17415A0
	public void SendAsyncMessage(object data) { }

	// RVA: 0x17416C0 Offset: 0x17417C1 VA: 0x17416C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xB94B0 Offset: 0xB95B1 VA: 0xB94B0
	// RVA: 0x17417A0 Offset: 0x17418A1 VA: 0x17417A0
	private void <AsyncProcessMessage>b__10_0(object data) { }
}

