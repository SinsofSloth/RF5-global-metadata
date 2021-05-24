internal abstract class Identity // TypeDefIndex: 1106
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x1741F20 Offset: 0x1742021 VA: 0x1741F20
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1749D70 Offset: 0x1749E71 VA: 0x1749D70
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x1749D80 Offset: 0x1749E81 VA: 0x1749D80
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x1749D90 Offset: 0x1749E91 VA: 0x1749D90
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x1749DA0 Offset: 0x1749EA1 VA: 0x1749DA0
	public string get_ObjectUri() { }

	// RVA: 0x1749DB0 Offset: 0x1749EB1 VA: 0x1749DB0
	public void set_ObjectUri(string value) { }

	// RVA: 0x1749DC0 Offset: 0x1749EC1 VA: 0x1749DC0
	public bool get_IsConnected() { }

	// RVA: 0x1749DD0 Offset: 0x1749ED1 VA: 0x1749DD0
	public bool get_Disposed() { }

	// RVA: 0x1749DE0 Offset: 0x1749EE1 VA: 0x1749DE0
	public void set_Disposed(bool value) { }

	// RVA: 0x17467E0 Offset: 0x17468E1 VA: 0x17467E0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1749DF0 Offset: 0x1749EF1 VA: 0x1749DF0
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1749E40 Offset: 0x1749F41 VA: 0x1749E40
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1749EE0 Offset: 0x1749FE1 VA: 0x1749EE0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

internal abstract class Identity // TypeDefIndex: 1106
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x1741F20 Offset: 0x1742021 VA: 0x1741F20
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1749D70 Offset: 0x1749E71 VA: 0x1749D70
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x1749D80 Offset: 0x1749E81 VA: 0x1749D80
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x1749D90 Offset: 0x1749E91 VA: 0x1749D90
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x1749DA0 Offset: 0x1749EA1 VA: 0x1749DA0
	public string get_ObjectUri() { }

	// RVA: 0x1749DB0 Offset: 0x1749EB1 VA: 0x1749DB0
	public void set_ObjectUri(string value) { }

	// RVA: 0x1749DC0 Offset: 0x1749EC1 VA: 0x1749DC0
	public bool get_IsConnected() { }

	// RVA: 0x1749DD0 Offset: 0x1749ED1 VA: 0x1749DD0
	public bool get_Disposed() { }

	// RVA: 0x1749DE0 Offset: 0x1749EE1 VA: 0x1749DE0
	public void set_Disposed(bool value) { }

	// RVA: 0x17467E0 Offset: 0x17468E1 VA: 0x17467E0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1749DF0 Offset: 0x1749EF1 VA: 0x1749DF0
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1749E40 Offset: 0x1749F41 VA: 0x1749E40
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1749EE0 Offset: 0x1749FE1 VA: 0x1749EE0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

internal abstract class Identity // TypeDefIndex: 1106
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x1741F20 Offset: 0x1742021 VA: 0x1741F20
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1749D70 Offset: 0x1749E71 VA: 0x1749D70
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x1749D80 Offset: 0x1749E81 VA: 0x1749D80
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x1749D90 Offset: 0x1749E91 VA: 0x1749D90
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x1749DA0 Offset: 0x1749EA1 VA: 0x1749DA0
	public string get_ObjectUri() { }

	// RVA: 0x1749DB0 Offset: 0x1749EB1 VA: 0x1749DB0
	public void set_ObjectUri(string value) { }

	// RVA: 0x1749DC0 Offset: 0x1749EC1 VA: 0x1749DC0
	public bool get_IsConnected() { }

	// RVA: 0x1749DD0 Offset: 0x1749ED1 VA: 0x1749DD0
	public bool get_Disposed() { }

	// RVA: 0x1749DE0 Offset: 0x1749EE1 VA: 0x1749DE0
	public void set_Disposed(bool value) { }

	// RVA: 0x17467E0 Offset: 0x17468E1 VA: 0x17467E0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1749DF0 Offset: 0x1749EF1 VA: 0x1749DF0
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1749E40 Offset: 0x1749F41 VA: 0x1749E40
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1749EE0 Offset: 0x1749FE1 VA: 0x1749EE0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

internal abstract class Identity // TypeDefIndex: 1106
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x1741F20 Offset: 0x1742021 VA: 0x1741F20
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1749D70 Offset: 0x1749E71 VA: 0x1749D70
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x1749D80 Offset: 0x1749E81 VA: 0x1749D80
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x1749D90 Offset: 0x1749E91 VA: 0x1749D90
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x1749DA0 Offset: 0x1749EA1 VA: 0x1749DA0
	public string get_ObjectUri() { }

	// RVA: 0x1749DB0 Offset: 0x1749EB1 VA: 0x1749DB0
	public void set_ObjectUri(string value) { }

	// RVA: 0x1749DC0 Offset: 0x1749EC1 VA: 0x1749DC0
	public bool get_IsConnected() { }

	// RVA: 0x1749DD0 Offset: 0x1749ED1 VA: 0x1749DD0
	public bool get_Disposed() { }

	// RVA: 0x1749DE0 Offset: 0x1749EE1 VA: 0x1749DE0
	public void set_Disposed(bool value) { }

	// RVA: 0x17467E0 Offset: 0x17468E1 VA: 0x17467E0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1749DF0 Offset: 0x1749EF1 VA: 0x1749DF0
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1749E40 Offset: 0x1749F41 VA: 0x1749E40
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1749EE0 Offset: 0x1749FE1 VA: 0x1749EE0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

internal abstract class Identity // TypeDefIndex: 1106
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x1741F20 Offset: 0x1742021 VA: 0x1741F20
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1749D70 Offset: 0x1749E71 VA: 0x1749D70
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x1749D80 Offset: 0x1749E81 VA: 0x1749D80
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x1749D90 Offset: 0x1749E91 VA: 0x1749D90
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x1749DA0 Offset: 0x1749EA1 VA: 0x1749DA0
	public string get_ObjectUri() { }

	// RVA: 0x1749DB0 Offset: 0x1749EB1 VA: 0x1749DB0
	public void set_ObjectUri(string value) { }

	// RVA: 0x1749DC0 Offset: 0x1749EC1 VA: 0x1749DC0
	public bool get_IsConnected() { }

	// RVA: 0x1749DD0 Offset: 0x1749ED1 VA: 0x1749DD0
	public bool get_Disposed() { }

	// RVA: 0x1749DE0 Offset: 0x1749EE1 VA: 0x1749DE0
	public void set_Disposed(bool value) { }

	// RVA: 0x17467E0 Offset: 0x17468E1 VA: 0x17467E0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1749DF0 Offset: 0x1749EF1 VA: 0x1749DF0
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1749E40 Offset: 0x1749F41 VA: 0x1749E40
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1749EE0 Offset: 0x1749FE1 VA: 0x1749EE0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

internal abstract class Identity // TypeDefIndex: 1106
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x1741F20 Offset: 0x1742021 VA: 0x1741F20
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1749D70 Offset: 0x1749E71 VA: 0x1749D70
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x1749D80 Offset: 0x1749E81 VA: 0x1749D80
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x1749D90 Offset: 0x1749E91 VA: 0x1749D90
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x1749DA0 Offset: 0x1749EA1 VA: 0x1749DA0
	public string get_ObjectUri() { }

	// RVA: 0x1749DB0 Offset: 0x1749EB1 VA: 0x1749DB0
	public void set_ObjectUri(string value) { }

	// RVA: 0x1749DC0 Offset: 0x1749EC1 VA: 0x1749DC0
	public bool get_IsConnected() { }

	// RVA: 0x1749DD0 Offset: 0x1749ED1 VA: 0x1749DD0
	public bool get_Disposed() { }

	// RVA: 0x1749DE0 Offset: 0x1749EE1 VA: 0x1749DE0
	public void set_Disposed(bool value) { }

	// RVA: 0x17467E0 Offset: 0x17468E1 VA: 0x17467E0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1749DF0 Offset: 0x1749EF1 VA: 0x1749DF0
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1749E40 Offset: 0x1749F41 VA: 0x1749E40
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1749EE0 Offset: 0x1749FE1 VA: 0x1749EE0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

internal abstract class Identity // TypeDefIndex: 1106
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x1741F20 Offset: 0x1742021 VA: 0x1741F20
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1749D70 Offset: 0x1749E71 VA: 0x1749D70
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x1749D80 Offset: 0x1749E81 VA: 0x1749D80
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x1749D90 Offset: 0x1749E91 VA: 0x1749D90
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x1749DA0 Offset: 0x1749EA1 VA: 0x1749DA0
	public string get_ObjectUri() { }

	// RVA: 0x1749DB0 Offset: 0x1749EB1 VA: 0x1749DB0
	public void set_ObjectUri(string value) { }

	// RVA: 0x1749DC0 Offset: 0x1749EC1 VA: 0x1749DC0
	public bool get_IsConnected() { }

	// RVA: 0x1749DD0 Offset: 0x1749ED1 VA: 0x1749DD0
	public bool get_Disposed() { }

	// RVA: 0x1749DE0 Offset: 0x1749EE1 VA: 0x1749DE0
	public void set_Disposed(bool value) { }

	// RVA: 0x17467E0 Offset: 0x17468E1 VA: 0x17467E0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1749DF0 Offset: 0x1749EF1 VA: 0x1749DF0
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1749E40 Offset: 0x1749F41 VA: 0x1749E40
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1749EE0 Offset: 0x1749FE1 VA: 0x1749EE0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

