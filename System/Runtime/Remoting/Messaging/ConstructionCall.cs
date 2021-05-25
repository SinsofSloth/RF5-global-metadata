[CLSCompliantAttribute] // RVA: 0xB1170 Offset: 0xB1271 VA: 0xB1170
[ComVisibleAttribute] // RVA: 0xB1170 Offset: 0xB1271 VA: 0xB1170
[Serializable]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1205
{
	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x1750E50 Offset: 0x1750F51 VA: 0x1750E50
	internal void .ctor(Type type) { }

	// RVA: 0x1750ED0 Offset: 0x1750FD1 VA: 0x1750ED0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1750F90 Offset: 0x1751091 VA: 0x1750F90 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x17511B0 Offset: 0x17512B1 VA: 0x17511B0
	internal bool get_IsContextOk() { }

	// RVA: 0x17511C0 Offset: 0x17512C1 VA: 0x17511C0
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x17511D0 Offset: 0x17512D1 VA: 0x17511D0 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x17512B0 Offset: 0x17513B1 VA: 0x17512B0 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x17512C0 Offset: 0x17513C1 VA: 0x17512C0 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x17512D0 Offset: 0x17513D1 VA: 0x17512D0 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x17512E0 Offset: 0x17513E1 VA: 0x17512E0 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x17512F0 Offset: 0x17513F1 VA: 0x17512F0
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x1751300 Offset: 0x1751401 VA: 0x1751300 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x1751390 Offset: 0x1751491 VA: 0x1751390 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x1751960 Offset: 0x1751A61 VA: 0x1751960 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1751EA0 Offset: 0x1751FA1 VA: 0x1751EA0 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x1751F40 Offset: 0x1752041 VA: 0x1751F40
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x1751F50 Offset: 0x1752051 VA: 0x1751F50
	internal void set_SourceProxy(RemotingProxy value) { }
}

