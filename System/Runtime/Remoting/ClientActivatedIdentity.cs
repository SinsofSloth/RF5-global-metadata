internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 1119
{
	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0x1741950 Offset: 0x1741A51 VA: 0x1741950
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x1741960 Offset: 0x1741A61 VA: 0x1741960
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x1741970 Offset: 0x1741A71 VA: 0x1741970
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0x1741980 Offset: 0x1741A81 VA: 0x1741980 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0x1741A00 Offset: 0x1741B01 VA: 0x1741A00 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x1741CB0 Offset: 0x1741DB1 VA: 0x1741CB0 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

