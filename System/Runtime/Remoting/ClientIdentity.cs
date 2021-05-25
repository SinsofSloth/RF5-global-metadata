internal class ClientIdentity : Identity // TypeDefIndex: 1107
{
	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0x1741DD0 Offset: 0x1741ED1 VA: 0x1741DD0
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0x1741F60 Offset: 0x1742061 VA: 0x1741F60
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0x1742000 Offset: 0x1742101 VA: 0x1742000
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x1742080 Offset: 0x1742181 VA: 0x1742080 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1742090 Offset: 0x1742191 VA: 0x1742090
	public string get_TargetUri() { }
}

