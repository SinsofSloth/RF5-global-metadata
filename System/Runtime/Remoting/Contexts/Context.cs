[ComVisibleAttribute] // RVA: 0xB0CC0 Offset: 0xB0DC1 VA: 0xB0CC0
public class Context // TypeDefIndex: 1144
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0xB5520 Offset: 0xB5621 VA: 0xB5520
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1745BB0 Offset: 0x1745CB1 VA: 0x1745BB0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1745BC0 Offset: 0x1745CC1 VA: 0x1745BC0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1745BD0 Offset: 0x1745CD1 VA: 0x1745BD0
	public void .ctor() { }

	// RVA: 0x1745C70 Offset: 0x1745D71 VA: 0x1745C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1745D20 Offset: 0x1745E21 VA: 0x1745D20
	public static Context get_DefaultContext() { }

	// RVA: 0x1745D30 Offset: 0x1745E31 VA: 0x1745D30 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1745D40 Offset: 0x1745E41 VA: 0x1745D40 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1745DC0 Offset: 0x1745EC1 VA: 0x1745DC0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1745DD0 Offset: 0x1745ED1 VA: 0x1745DD0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1745F40 Offset: 0x1746041 VA: 0x1745F40
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x17465D0 Offset: 0x17466D1 VA: 0x17465D0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1745FD0 Offset: 0x17460D1 VA: 0x1745FD0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1746950 Offset: 0x1746A51 VA: 0x1746950
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1747080 Offset: 0x1747181 VA: 0x1747080
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1747150 Offset: 0x1747251 VA: 0x1747150
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17471F0 Offset: 0x17472F1 VA: 0x17471F0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1747240 Offset: 0x1747341 VA: 0x1747240
	internal bool get_HasExitSinks() { }

	// RVA: 0x1747500 Offset: 0x1747601 VA: 0x1747500 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x17476A0 Offset: 0x17477A1 VA: 0x17476A0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x17477E0 Offset: 0x17478E1 VA: 0x17477E0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1747960 Offset: 0x1747A61 VA: 0x1747960 Slot: 3
	public override string ToString() { }

	// RVA: 0x17479E0 Offset: 0x1747AE1 VA: 0x17479E0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1747320 Offset: 0x1747421 VA: 0x1747320
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1741B00 Offset: 0x1741C01 VA: 0x1741B00
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1747DA0 Offset: 0x1747EA1 VA: 0x1747DA0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1747F80 Offset: 0x1748081 VA: 0x1747F80
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1747F90 Offset: 0x1748091 VA: 0x1747F90
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x17487F0 Offset: 0x17488F1 VA: 0x17487F0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1748980 Offset: 0x1748A81 VA: 0x1748980
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1748B10 Offset: 0x1748C11 VA: 0x1748B10
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1748B90 Offset: 0x1748C91 VA: 0x1748B90
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1748C10 Offset: 0x1748D11 VA: 0x1748C10
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1748C90 Offset: 0x1748D91 VA: 0x1748C90
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1748D10 Offset: 0x1748E11 VA: 0x1748D10
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1748D50 Offset: 0x1748E51 VA: 0x1748D50
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1748DA0 Offset: 0x1748EA1 VA: 0x1748DA0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0CC0 Offset: 0xB0DC1 VA: 0xB0CC0
public class Context // TypeDefIndex: 1144
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0xB5520 Offset: 0xB5621 VA: 0xB5520
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1745BB0 Offset: 0x1745CB1 VA: 0x1745BB0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1745BC0 Offset: 0x1745CC1 VA: 0x1745BC0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1745BD0 Offset: 0x1745CD1 VA: 0x1745BD0
	public void .ctor() { }

	// RVA: 0x1745C70 Offset: 0x1745D71 VA: 0x1745C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1745D20 Offset: 0x1745E21 VA: 0x1745D20
	public static Context get_DefaultContext() { }

	// RVA: 0x1745D30 Offset: 0x1745E31 VA: 0x1745D30 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1745D40 Offset: 0x1745E41 VA: 0x1745D40 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1745DC0 Offset: 0x1745EC1 VA: 0x1745DC0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1745DD0 Offset: 0x1745ED1 VA: 0x1745DD0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1745F40 Offset: 0x1746041 VA: 0x1745F40
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x17465D0 Offset: 0x17466D1 VA: 0x17465D0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1745FD0 Offset: 0x17460D1 VA: 0x1745FD0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1746950 Offset: 0x1746A51 VA: 0x1746950
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1747080 Offset: 0x1747181 VA: 0x1747080
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1747150 Offset: 0x1747251 VA: 0x1747150
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17471F0 Offset: 0x17472F1 VA: 0x17471F0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1747240 Offset: 0x1747341 VA: 0x1747240
	internal bool get_HasExitSinks() { }

	// RVA: 0x1747500 Offset: 0x1747601 VA: 0x1747500 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x17476A0 Offset: 0x17477A1 VA: 0x17476A0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x17477E0 Offset: 0x17478E1 VA: 0x17477E0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1747960 Offset: 0x1747A61 VA: 0x1747960 Slot: 3
	public override string ToString() { }

	// RVA: 0x17479E0 Offset: 0x1747AE1 VA: 0x17479E0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1747320 Offset: 0x1747421 VA: 0x1747320
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1741B00 Offset: 0x1741C01 VA: 0x1741B00
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1747DA0 Offset: 0x1747EA1 VA: 0x1747DA0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1747F80 Offset: 0x1748081 VA: 0x1747F80
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1747F90 Offset: 0x1748091 VA: 0x1747F90
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x17487F0 Offset: 0x17488F1 VA: 0x17487F0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1748980 Offset: 0x1748A81 VA: 0x1748980
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1748B10 Offset: 0x1748C11 VA: 0x1748B10
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1748B90 Offset: 0x1748C91 VA: 0x1748B90
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1748C10 Offset: 0x1748D11 VA: 0x1748C10
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1748C90 Offset: 0x1748D91 VA: 0x1748C90
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1748D10 Offset: 0x1748E11 VA: 0x1748D10
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1748D50 Offset: 0x1748E51 VA: 0x1748D50
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1748DA0 Offset: 0x1748EA1 VA: 0x1748DA0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0CC0 Offset: 0xB0DC1 VA: 0xB0CC0
public class Context // TypeDefIndex: 1144
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0xB5520 Offset: 0xB5621 VA: 0xB5520
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1745BB0 Offset: 0x1745CB1 VA: 0x1745BB0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1745BC0 Offset: 0x1745CC1 VA: 0x1745BC0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1745BD0 Offset: 0x1745CD1 VA: 0x1745BD0
	public void .ctor() { }

	// RVA: 0x1745C70 Offset: 0x1745D71 VA: 0x1745C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1745D20 Offset: 0x1745E21 VA: 0x1745D20
	public static Context get_DefaultContext() { }

	// RVA: 0x1745D30 Offset: 0x1745E31 VA: 0x1745D30 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1745D40 Offset: 0x1745E41 VA: 0x1745D40 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1745DC0 Offset: 0x1745EC1 VA: 0x1745DC0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1745DD0 Offset: 0x1745ED1 VA: 0x1745DD0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1745F40 Offset: 0x1746041 VA: 0x1745F40
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x17465D0 Offset: 0x17466D1 VA: 0x17465D0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1745FD0 Offset: 0x17460D1 VA: 0x1745FD0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1746950 Offset: 0x1746A51 VA: 0x1746950
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1747080 Offset: 0x1747181 VA: 0x1747080
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1747150 Offset: 0x1747251 VA: 0x1747150
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17471F0 Offset: 0x17472F1 VA: 0x17471F0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1747240 Offset: 0x1747341 VA: 0x1747240
	internal bool get_HasExitSinks() { }

	// RVA: 0x1747500 Offset: 0x1747601 VA: 0x1747500 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x17476A0 Offset: 0x17477A1 VA: 0x17476A0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x17477E0 Offset: 0x17478E1 VA: 0x17477E0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1747960 Offset: 0x1747A61 VA: 0x1747960 Slot: 3
	public override string ToString() { }

	// RVA: 0x17479E0 Offset: 0x1747AE1 VA: 0x17479E0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1747320 Offset: 0x1747421 VA: 0x1747320
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1741B00 Offset: 0x1741C01 VA: 0x1741B00
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1747DA0 Offset: 0x1747EA1 VA: 0x1747DA0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1747F80 Offset: 0x1748081 VA: 0x1747F80
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1747F90 Offset: 0x1748091 VA: 0x1747F90
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x17487F0 Offset: 0x17488F1 VA: 0x17487F0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1748980 Offset: 0x1748A81 VA: 0x1748980
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1748B10 Offset: 0x1748C11 VA: 0x1748B10
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1748B90 Offset: 0x1748C91 VA: 0x1748B90
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1748C10 Offset: 0x1748D11 VA: 0x1748C10
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1748C90 Offset: 0x1748D91 VA: 0x1748C90
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1748D10 Offset: 0x1748E11 VA: 0x1748D10
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1748D50 Offset: 0x1748E51 VA: 0x1748D50
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1748DA0 Offset: 0x1748EA1 VA: 0x1748DA0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0CC0 Offset: 0xB0DC1 VA: 0xB0CC0
public class Context // TypeDefIndex: 1144
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0xB5520 Offset: 0xB5621 VA: 0xB5520
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1745BB0 Offset: 0x1745CB1 VA: 0x1745BB0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1745BC0 Offset: 0x1745CC1 VA: 0x1745BC0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1745BD0 Offset: 0x1745CD1 VA: 0x1745BD0
	public void .ctor() { }

	// RVA: 0x1745C70 Offset: 0x1745D71 VA: 0x1745C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1745D20 Offset: 0x1745E21 VA: 0x1745D20
	public static Context get_DefaultContext() { }

	// RVA: 0x1745D30 Offset: 0x1745E31 VA: 0x1745D30 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1745D40 Offset: 0x1745E41 VA: 0x1745D40 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1745DC0 Offset: 0x1745EC1 VA: 0x1745DC0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1745DD0 Offset: 0x1745ED1 VA: 0x1745DD0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1745F40 Offset: 0x1746041 VA: 0x1745F40
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x17465D0 Offset: 0x17466D1 VA: 0x17465D0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1745FD0 Offset: 0x17460D1 VA: 0x1745FD0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1746950 Offset: 0x1746A51 VA: 0x1746950
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1747080 Offset: 0x1747181 VA: 0x1747080
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1747150 Offset: 0x1747251 VA: 0x1747150
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17471F0 Offset: 0x17472F1 VA: 0x17471F0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1747240 Offset: 0x1747341 VA: 0x1747240
	internal bool get_HasExitSinks() { }

	// RVA: 0x1747500 Offset: 0x1747601 VA: 0x1747500 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x17476A0 Offset: 0x17477A1 VA: 0x17476A0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x17477E0 Offset: 0x17478E1 VA: 0x17477E0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1747960 Offset: 0x1747A61 VA: 0x1747960 Slot: 3
	public override string ToString() { }

	// RVA: 0x17479E0 Offset: 0x1747AE1 VA: 0x17479E0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1747320 Offset: 0x1747421 VA: 0x1747320
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1741B00 Offset: 0x1741C01 VA: 0x1741B00
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1747DA0 Offset: 0x1747EA1 VA: 0x1747DA0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1747F80 Offset: 0x1748081 VA: 0x1747F80
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1747F90 Offset: 0x1748091 VA: 0x1747F90
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x17487F0 Offset: 0x17488F1 VA: 0x17487F0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1748980 Offset: 0x1748A81 VA: 0x1748980
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1748B10 Offset: 0x1748C11 VA: 0x1748B10
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1748B90 Offset: 0x1748C91 VA: 0x1748B90
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1748C10 Offset: 0x1748D11 VA: 0x1748C10
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1748C90 Offset: 0x1748D91 VA: 0x1748C90
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1748D10 Offset: 0x1748E11 VA: 0x1748D10
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1748D50 Offset: 0x1748E51 VA: 0x1748D50
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1748DA0 Offset: 0x1748EA1 VA: 0x1748DA0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0CC0 Offset: 0xB0DC1 VA: 0xB0CC0
public class Context // TypeDefIndex: 1144
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0xB5520 Offset: 0xB5621 VA: 0xB5520
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1745BB0 Offset: 0x1745CB1 VA: 0x1745BB0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1745BC0 Offset: 0x1745CC1 VA: 0x1745BC0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1745BD0 Offset: 0x1745CD1 VA: 0x1745BD0
	public void .ctor() { }

	// RVA: 0x1745C70 Offset: 0x1745D71 VA: 0x1745C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1745D20 Offset: 0x1745E21 VA: 0x1745D20
	public static Context get_DefaultContext() { }

	// RVA: 0x1745D30 Offset: 0x1745E31 VA: 0x1745D30 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1745D40 Offset: 0x1745E41 VA: 0x1745D40 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1745DC0 Offset: 0x1745EC1 VA: 0x1745DC0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1745DD0 Offset: 0x1745ED1 VA: 0x1745DD0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1745F40 Offset: 0x1746041 VA: 0x1745F40
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x17465D0 Offset: 0x17466D1 VA: 0x17465D0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1745FD0 Offset: 0x17460D1 VA: 0x1745FD0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1746950 Offset: 0x1746A51 VA: 0x1746950
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1747080 Offset: 0x1747181 VA: 0x1747080
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1747150 Offset: 0x1747251 VA: 0x1747150
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17471F0 Offset: 0x17472F1 VA: 0x17471F0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1747240 Offset: 0x1747341 VA: 0x1747240
	internal bool get_HasExitSinks() { }

	// RVA: 0x1747500 Offset: 0x1747601 VA: 0x1747500 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x17476A0 Offset: 0x17477A1 VA: 0x17476A0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x17477E0 Offset: 0x17478E1 VA: 0x17477E0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1747960 Offset: 0x1747A61 VA: 0x1747960 Slot: 3
	public override string ToString() { }

	// RVA: 0x17479E0 Offset: 0x1747AE1 VA: 0x17479E0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1747320 Offset: 0x1747421 VA: 0x1747320
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1741B00 Offset: 0x1741C01 VA: 0x1741B00
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1747DA0 Offset: 0x1747EA1 VA: 0x1747DA0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1747F80 Offset: 0x1748081 VA: 0x1747F80
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1747F90 Offset: 0x1748091 VA: 0x1747F90
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x17487F0 Offset: 0x17488F1 VA: 0x17487F0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1748980 Offset: 0x1748A81 VA: 0x1748980
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1748B10 Offset: 0x1748C11 VA: 0x1748B10
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1748B90 Offset: 0x1748C91 VA: 0x1748B90
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1748C10 Offset: 0x1748D11 VA: 0x1748C10
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1748C90 Offset: 0x1748D91 VA: 0x1748C90
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1748D10 Offset: 0x1748E11 VA: 0x1748D10
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1748D50 Offset: 0x1748E51 VA: 0x1748D50
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1748DA0 Offset: 0x1748EA1 VA: 0x1748DA0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0CC0 Offset: 0xB0DC1 VA: 0xB0CC0
public class Context // TypeDefIndex: 1144
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0xB5520 Offset: 0xB5621 VA: 0xB5520
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1745BB0 Offset: 0x1745CB1 VA: 0x1745BB0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1745BC0 Offset: 0x1745CC1 VA: 0x1745BC0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1745BD0 Offset: 0x1745CD1 VA: 0x1745BD0
	public void .ctor() { }

	// RVA: 0x1745C70 Offset: 0x1745D71 VA: 0x1745C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1745D20 Offset: 0x1745E21 VA: 0x1745D20
	public static Context get_DefaultContext() { }

	// RVA: 0x1745D30 Offset: 0x1745E31 VA: 0x1745D30 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1745D40 Offset: 0x1745E41 VA: 0x1745D40 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1745DC0 Offset: 0x1745EC1 VA: 0x1745DC0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1745DD0 Offset: 0x1745ED1 VA: 0x1745DD0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1745F40 Offset: 0x1746041 VA: 0x1745F40
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x17465D0 Offset: 0x17466D1 VA: 0x17465D0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1745FD0 Offset: 0x17460D1 VA: 0x1745FD0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1746950 Offset: 0x1746A51 VA: 0x1746950
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1747080 Offset: 0x1747181 VA: 0x1747080
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1747150 Offset: 0x1747251 VA: 0x1747150
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17471F0 Offset: 0x17472F1 VA: 0x17471F0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1747240 Offset: 0x1747341 VA: 0x1747240
	internal bool get_HasExitSinks() { }

	// RVA: 0x1747500 Offset: 0x1747601 VA: 0x1747500 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x17476A0 Offset: 0x17477A1 VA: 0x17476A0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x17477E0 Offset: 0x17478E1 VA: 0x17477E0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1747960 Offset: 0x1747A61 VA: 0x1747960 Slot: 3
	public override string ToString() { }

	// RVA: 0x17479E0 Offset: 0x1747AE1 VA: 0x17479E0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1747320 Offset: 0x1747421 VA: 0x1747320
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1741B00 Offset: 0x1741C01 VA: 0x1741B00
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1747DA0 Offset: 0x1747EA1 VA: 0x1747DA0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1747F80 Offset: 0x1748081 VA: 0x1747F80
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1747F90 Offset: 0x1748091 VA: 0x1747F90
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x17487F0 Offset: 0x17488F1 VA: 0x17487F0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1748980 Offset: 0x1748A81 VA: 0x1748980
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1748B10 Offset: 0x1748C11 VA: 0x1748B10
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1748B90 Offset: 0x1748C91 VA: 0x1748B90
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1748C10 Offset: 0x1748D11 VA: 0x1748C10
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1748C90 Offset: 0x1748D91 VA: 0x1748C90
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1748D10 Offset: 0x1748E11 VA: 0x1748D10
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1748D50 Offset: 0x1748E51 VA: 0x1748D50
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1748DA0 Offset: 0x1748EA1 VA: 0x1748DA0
	private static void .cctor() { }
}

[ComVisibleAttribute] // RVA: 0xB0CC0 Offset: 0xB0DC1 VA: 0xB0CC0
public class Context // TypeDefIndex: 1144
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0xB5520 Offset: 0xB5621 VA: 0xB5520
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1745BB0 Offset: 0x1745CB1 VA: 0x1745BB0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1745BC0 Offset: 0x1745CC1 VA: 0x1745BC0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1745BD0 Offset: 0x1745CD1 VA: 0x1745BD0
	public void .ctor() { }

	// RVA: 0x1745C70 Offset: 0x1745D71 VA: 0x1745C70 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1745D20 Offset: 0x1745E21 VA: 0x1745D20
	public static Context get_DefaultContext() { }

	// RVA: 0x1745D30 Offset: 0x1745E31 VA: 0x1745D30 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1745D40 Offset: 0x1745E41 VA: 0x1745D40 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1745DC0 Offset: 0x1745EC1 VA: 0x1745DC0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1745DD0 Offset: 0x1745ED1 VA: 0x1745DD0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1745F40 Offset: 0x1746041 VA: 0x1745F40
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x17465D0 Offset: 0x17466D1 VA: 0x17465D0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1745FD0 Offset: 0x17460D1 VA: 0x1745FD0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1746950 Offset: 0x1746A51 VA: 0x1746950
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1747080 Offset: 0x1747181 VA: 0x1747080
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1747150 Offset: 0x1747251 VA: 0x1747150
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17471F0 Offset: 0x17472F1 VA: 0x17471F0
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1747240 Offset: 0x1747341 VA: 0x1747240
	internal bool get_HasExitSinks() { }

	// RVA: 0x1747500 Offset: 0x1747601 VA: 0x1747500 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x17476A0 Offset: 0x17477A1 VA: 0x17476A0 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x17477E0 Offset: 0x17478E1 VA: 0x17477E0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1747960 Offset: 0x1747A61 VA: 0x1747960 Slot: 3
	public override string ToString() { }

	// RVA: 0x17479E0 Offset: 0x1747AE1 VA: 0x17479E0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1747320 Offset: 0x1747421 VA: 0x1747320
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1741B00 Offset: 0x1741C01 VA: 0x1741B00
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1747DA0 Offset: 0x1747EA1 VA: 0x1747DA0
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1747F80 Offset: 0x1748081 VA: 0x1747F80
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1747F90 Offset: 0x1748091 VA: 0x1747F90
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x17487F0 Offset: 0x17488F1 VA: 0x17487F0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1748980 Offset: 0x1748A81 VA: 0x1748980
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1748B10 Offset: 0x1748C11 VA: 0x1748B10
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1748B90 Offset: 0x1748C91 VA: 0x1748B90
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1748C10 Offset: 0x1748D11 VA: 0x1748C10
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1748C90 Offset: 0x1748D91 VA: 0x1748C90
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1748D10 Offset: 0x1748E11 VA: 0x1748D10
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1748D50 Offset: 0x1748E51 VA: 0x1748D50
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1748DA0 Offset: 0x1748EA1 VA: 0x1748DA0
	private static void .cctor() { }
}

