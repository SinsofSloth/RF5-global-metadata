internal abstract class ServerIdentity : Identity // TypeDefIndex: 1118
{
	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x15FA7F0 Offset: 0x15FA8F1 VA: 0x15FA7F0
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x15FA840 Offset: 0x15FA941 VA: 0x15FA840
	public Type get_ObjectType() { }

	// RVA: 0x15F82B0 Offset: 0x15F83B1 VA: 0x15F82B0
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x15FA850 Offset: 0x15FA951 VA: 0x15FA850 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x15FA920 Offset: 0x15FAA21 VA: 0x15FA920 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x15F9E20 Offset: 0x15F9F21 VA: 0x15F9E20
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x15FAEF0 Offset: 0x15FAFF1 VA: 0x15FAEF0
	public Lease get_Lease() { }

	// RVA: 0x15FAF00 Offset: 0x15FB001 VA: 0x15FAF00
	public Context get_Context() { }

	// RVA: 0x15FAF10 Offset: 0x15FB011 VA: 0x15FAF10
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x15FA860 Offset: 0x15FA961 VA: 0x15FA860
	protected void DisposeServerObject() { }
}

