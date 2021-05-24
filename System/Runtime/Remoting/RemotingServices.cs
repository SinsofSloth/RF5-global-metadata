[ComVisibleAttribute] // RVA: 0xB0AE0 Offset: 0xB0BE1 VA: 0xB0AE0
public static class RemotingServices // TypeDefIndex: 1116
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x15F6100 Offset: 0x15F6201 VA: 0x15F6100
	private static void .cctor() { }

	// RVA: 0x15F64F0 Offset: 0x15F65F1 VA: 0x15F64F0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x15F6500 Offset: 0x15F6601 VA: 0x15F6500
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x15F6510 Offset: 0x15F6611 VA: 0x15F6510
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x15F6570 Offset: 0x15F6671 VA: 0x15F6570
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0xB9410 Offset: 0xB9511 VA: 0xB9410
	// RVA: 0x15F7160 Offset: 0x15F7261 VA: 0x15F7160
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0xB9430 Offset: 0xB9531 VA: 0xB9430
	// RVA: 0x15F72F0 Offset: 0x15F73F1 VA: 0x15F72F0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x15F7400 Offset: 0x15F7501 VA: 0x15F7400
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x15F74E0 Offset: 0x15F75E1 VA: 0x15F74E0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x15F7550 Offset: 0x15F7651 VA: 0x15F7550
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x15F7B80 Offset: 0x15F7C81 VA: 0x15F7B80
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x15F7C10 Offset: 0x15F7D11 VA: 0x15F7C10
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x15F7C70 Offset: 0x15F7D71 VA: 0x15F7C70
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0xB9450 Offset: 0xB9551 VA: 0xB9450
	// RVA: 0x15F0120 Offset: 0x15F0221 VA: 0x15F0120
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x15F88D0 Offset: 0x15F89D1 VA: 0x15F88D0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x15F8B90 Offset: 0x15F8C91 VA: 0x15F8B90
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F8D70 Offset: 0x15F8E71 VA: 0x15F8D70
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F04F0 Offset: 0x15F05F1 VA: 0x15F04F0
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F8EC0 Offset: 0x15F8FC1 VA: 0x15F8EC0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x15F8F60 Offset: 0x15F9061 VA: 0x15F8F60
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x15F90D0 Offset: 0x15F91D1 VA: 0x15F90D0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x15F9330 Offset: 0x15F9431 VA: 0x15F9330
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x15F93B0 Offset: 0x15F94B1 VA: 0x15F93B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x15F1A90 Offset: 0x15F1B91 VA: 0x15F1A90
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x15F95F0 Offset: 0x15F96F1 VA: 0x15F95F0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x15F9730 Offset: 0x15F9831 VA: 0x15F9730
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x15F9240 Offset: 0x15F9341 VA: 0x15F9240
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x15F9D00 Offset: 0x15F9E01 VA: 0x15F9D00
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x15F87A0 Offset: 0x15F88A1 VA: 0x15F87A0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x15F4850 Offset: 0x15F4951 VA: 0x15F4850
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x15F8090 Offset: 0x15F8191 VA: 0x15F8090
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x15EFFC0 Offset: 0x15F00C1 VA: 0x15EFFC0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x15F7260 Offset: 0x15F7361 VA: 0x15F7260
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x15F9F50 Offset: 0x15FA051 VA: 0x15F9F50
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x15FA0E0 Offset: 0x15FA1E1 VA: 0x15FA0E0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x15FA260 Offset: 0x15FA361 VA: 0x15FA260
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x15F6480 Offset: 0x15F6581 VA: 0x15F6480
	private static void RegisterInternalChannels() { }

	// RVA: 0x15F2CB0 Offset: 0x15F2DB1 VA: 0x15F2CB0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x15FA320 Offset: 0x15FA421 VA: 0x15FA320
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x15FA6C0 Offset: 0x15FA7C1 VA: 0x15FA6C0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x15F1D90 Offset: 0x15F1E91 VA: 0x15F1D90
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x15F9570 Offset: 0x15F9671 VA: 0x15F9570
	private static string GetNormalizedUri(string uri) { }
}

[ComVisibleAttribute] // RVA: 0xB0AE0 Offset: 0xB0BE1 VA: 0xB0AE0
public static class RemotingServices // TypeDefIndex: 1116
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x15F6100 Offset: 0x15F6201 VA: 0x15F6100
	private static void .cctor() { }

	// RVA: 0x15F64F0 Offset: 0x15F65F1 VA: 0x15F64F0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x15F6500 Offset: 0x15F6601 VA: 0x15F6500
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x15F6510 Offset: 0x15F6611 VA: 0x15F6510
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x15F6570 Offset: 0x15F6671 VA: 0x15F6570
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0xB9410 Offset: 0xB9511 VA: 0xB9410
	// RVA: 0x15F7160 Offset: 0x15F7261 VA: 0x15F7160
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0xB9430 Offset: 0xB9531 VA: 0xB9430
	// RVA: 0x15F72F0 Offset: 0x15F73F1 VA: 0x15F72F0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x15F7400 Offset: 0x15F7501 VA: 0x15F7400
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x15F74E0 Offset: 0x15F75E1 VA: 0x15F74E0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x15F7550 Offset: 0x15F7651 VA: 0x15F7550
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x15F7B80 Offset: 0x15F7C81 VA: 0x15F7B80
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x15F7C10 Offset: 0x15F7D11 VA: 0x15F7C10
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x15F7C70 Offset: 0x15F7D71 VA: 0x15F7C70
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0xB9450 Offset: 0xB9551 VA: 0xB9450
	// RVA: 0x15F0120 Offset: 0x15F0221 VA: 0x15F0120
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x15F88D0 Offset: 0x15F89D1 VA: 0x15F88D0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x15F8B90 Offset: 0x15F8C91 VA: 0x15F8B90
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F8D70 Offset: 0x15F8E71 VA: 0x15F8D70
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F04F0 Offset: 0x15F05F1 VA: 0x15F04F0
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F8EC0 Offset: 0x15F8FC1 VA: 0x15F8EC0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x15F8F60 Offset: 0x15F9061 VA: 0x15F8F60
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x15F90D0 Offset: 0x15F91D1 VA: 0x15F90D0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x15F9330 Offset: 0x15F9431 VA: 0x15F9330
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x15F93B0 Offset: 0x15F94B1 VA: 0x15F93B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x15F1A90 Offset: 0x15F1B91 VA: 0x15F1A90
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x15F95F0 Offset: 0x15F96F1 VA: 0x15F95F0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x15F9730 Offset: 0x15F9831 VA: 0x15F9730
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x15F9240 Offset: 0x15F9341 VA: 0x15F9240
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x15F9D00 Offset: 0x15F9E01 VA: 0x15F9D00
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x15F87A0 Offset: 0x15F88A1 VA: 0x15F87A0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x15F4850 Offset: 0x15F4951 VA: 0x15F4850
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x15F8090 Offset: 0x15F8191 VA: 0x15F8090
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x15EFFC0 Offset: 0x15F00C1 VA: 0x15EFFC0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x15F7260 Offset: 0x15F7361 VA: 0x15F7260
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x15F9F50 Offset: 0x15FA051 VA: 0x15F9F50
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x15FA0E0 Offset: 0x15FA1E1 VA: 0x15FA0E0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x15FA260 Offset: 0x15FA361 VA: 0x15FA260
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x15F6480 Offset: 0x15F6581 VA: 0x15F6480
	private static void RegisterInternalChannels() { }

	// RVA: 0x15F2CB0 Offset: 0x15F2DB1 VA: 0x15F2CB0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x15FA320 Offset: 0x15FA421 VA: 0x15FA320
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x15FA6C0 Offset: 0x15FA7C1 VA: 0x15FA6C0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x15F1D90 Offset: 0x15F1E91 VA: 0x15F1D90
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x15F9570 Offset: 0x15F9671 VA: 0x15F9570
	private static string GetNormalizedUri(string uri) { }
}

[ComVisibleAttribute] // RVA: 0xB0AE0 Offset: 0xB0BE1 VA: 0xB0AE0
public static class RemotingServices // TypeDefIndex: 1116
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x15F6100 Offset: 0x15F6201 VA: 0x15F6100
	private static void .cctor() { }

	// RVA: 0x15F64F0 Offset: 0x15F65F1 VA: 0x15F64F0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x15F6500 Offset: 0x15F6601 VA: 0x15F6500
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x15F6510 Offset: 0x15F6611 VA: 0x15F6510
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x15F6570 Offset: 0x15F6671 VA: 0x15F6570
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0xB9410 Offset: 0xB9511 VA: 0xB9410
	// RVA: 0x15F7160 Offset: 0x15F7261 VA: 0x15F7160
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0xB9430 Offset: 0xB9531 VA: 0xB9430
	// RVA: 0x15F72F0 Offset: 0x15F73F1 VA: 0x15F72F0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x15F7400 Offset: 0x15F7501 VA: 0x15F7400
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x15F74E0 Offset: 0x15F75E1 VA: 0x15F74E0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x15F7550 Offset: 0x15F7651 VA: 0x15F7550
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x15F7B80 Offset: 0x15F7C81 VA: 0x15F7B80
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x15F7C10 Offset: 0x15F7D11 VA: 0x15F7C10
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x15F7C70 Offset: 0x15F7D71 VA: 0x15F7C70
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0xB9450 Offset: 0xB9551 VA: 0xB9450
	// RVA: 0x15F0120 Offset: 0x15F0221 VA: 0x15F0120
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x15F88D0 Offset: 0x15F89D1 VA: 0x15F88D0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x15F8B90 Offset: 0x15F8C91 VA: 0x15F8B90
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F8D70 Offset: 0x15F8E71 VA: 0x15F8D70
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F04F0 Offset: 0x15F05F1 VA: 0x15F04F0
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F8EC0 Offset: 0x15F8FC1 VA: 0x15F8EC0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x15F8F60 Offset: 0x15F9061 VA: 0x15F8F60
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x15F90D0 Offset: 0x15F91D1 VA: 0x15F90D0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x15F9330 Offset: 0x15F9431 VA: 0x15F9330
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x15F93B0 Offset: 0x15F94B1 VA: 0x15F93B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x15F1A90 Offset: 0x15F1B91 VA: 0x15F1A90
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x15F95F0 Offset: 0x15F96F1 VA: 0x15F95F0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x15F9730 Offset: 0x15F9831 VA: 0x15F9730
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x15F9240 Offset: 0x15F9341 VA: 0x15F9240
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x15F9D00 Offset: 0x15F9E01 VA: 0x15F9D00
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x15F87A0 Offset: 0x15F88A1 VA: 0x15F87A0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x15F4850 Offset: 0x15F4951 VA: 0x15F4850
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x15F8090 Offset: 0x15F8191 VA: 0x15F8090
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x15EFFC0 Offset: 0x15F00C1 VA: 0x15EFFC0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x15F7260 Offset: 0x15F7361 VA: 0x15F7260
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x15F9F50 Offset: 0x15FA051 VA: 0x15F9F50
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x15FA0E0 Offset: 0x15FA1E1 VA: 0x15FA0E0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x15FA260 Offset: 0x15FA361 VA: 0x15FA260
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x15F6480 Offset: 0x15F6581 VA: 0x15F6480
	private static void RegisterInternalChannels() { }

	// RVA: 0x15F2CB0 Offset: 0x15F2DB1 VA: 0x15F2CB0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x15FA320 Offset: 0x15FA421 VA: 0x15FA320
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x15FA6C0 Offset: 0x15FA7C1 VA: 0x15FA6C0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x15F1D90 Offset: 0x15F1E91 VA: 0x15F1D90
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x15F9570 Offset: 0x15F9671 VA: 0x15F9570
	private static string GetNormalizedUri(string uri) { }
}

[ComVisibleAttribute] // RVA: 0xB0AE0 Offset: 0xB0BE1 VA: 0xB0AE0
public static class RemotingServices // TypeDefIndex: 1116
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x15F6100 Offset: 0x15F6201 VA: 0x15F6100
	private static void .cctor() { }

	// RVA: 0x15F64F0 Offset: 0x15F65F1 VA: 0x15F64F0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x15F6500 Offset: 0x15F6601 VA: 0x15F6500
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x15F6510 Offset: 0x15F6611 VA: 0x15F6510
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x15F6570 Offset: 0x15F6671 VA: 0x15F6570
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0xB9410 Offset: 0xB9511 VA: 0xB9410
	// RVA: 0x15F7160 Offset: 0x15F7261 VA: 0x15F7160
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0xB9430 Offset: 0xB9531 VA: 0xB9430
	// RVA: 0x15F72F0 Offset: 0x15F73F1 VA: 0x15F72F0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x15F7400 Offset: 0x15F7501 VA: 0x15F7400
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x15F74E0 Offset: 0x15F75E1 VA: 0x15F74E0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x15F7550 Offset: 0x15F7651 VA: 0x15F7550
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x15F7B80 Offset: 0x15F7C81 VA: 0x15F7B80
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x15F7C10 Offset: 0x15F7D11 VA: 0x15F7C10
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x15F7C70 Offset: 0x15F7D71 VA: 0x15F7C70
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0xB9450 Offset: 0xB9551 VA: 0xB9450
	// RVA: 0x15F0120 Offset: 0x15F0221 VA: 0x15F0120
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x15F88D0 Offset: 0x15F89D1 VA: 0x15F88D0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x15F8B90 Offset: 0x15F8C91 VA: 0x15F8B90
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F8D70 Offset: 0x15F8E71 VA: 0x15F8D70
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F04F0 Offset: 0x15F05F1 VA: 0x15F04F0
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F8EC0 Offset: 0x15F8FC1 VA: 0x15F8EC0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x15F8F60 Offset: 0x15F9061 VA: 0x15F8F60
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x15F90D0 Offset: 0x15F91D1 VA: 0x15F90D0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x15F9330 Offset: 0x15F9431 VA: 0x15F9330
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x15F93B0 Offset: 0x15F94B1 VA: 0x15F93B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x15F1A90 Offset: 0x15F1B91 VA: 0x15F1A90
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x15F95F0 Offset: 0x15F96F1 VA: 0x15F95F0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x15F9730 Offset: 0x15F9831 VA: 0x15F9730
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x15F9240 Offset: 0x15F9341 VA: 0x15F9240
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x15F9D00 Offset: 0x15F9E01 VA: 0x15F9D00
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x15F87A0 Offset: 0x15F88A1 VA: 0x15F87A0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x15F4850 Offset: 0x15F4951 VA: 0x15F4850
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x15F8090 Offset: 0x15F8191 VA: 0x15F8090
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x15EFFC0 Offset: 0x15F00C1 VA: 0x15EFFC0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x15F7260 Offset: 0x15F7361 VA: 0x15F7260
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x15F9F50 Offset: 0x15FA051 VA: 0x15F9F50
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x15FA0E0 Offset: 0x15FA1E1 VA: 0x15FA0E0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x15FA260 Offset: 0x15FA361 VA: 0x15FA260
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x15F6480 Offset: 0x15F6581 VA: 0x15F6480
	private static void RegisterInternalChannels() { }

	// RVA: 0x15F2CB0 Offset: 0x15F2DB1 VA: 0x15F2CB0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x15FA320 Offset: 0x15FA421 VA: 0x15FA320
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x15FA6C0 Offset: 0x15FA7C1 VA: 0x15FA6C0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x15F1D90 Offset: 0x15F1E91 VA: 0x15F1D90
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x15F9570 Offset: 0x15F9671 VA: 0x15F9570
	private static string GetNormalizedUri(string uri) { }
}

[ComVisibleAttribute] // RVA: 0xB0AE0 Offset: 0xB0BE1 VA: 0xB0AE0
public static class RemotingServices // TypeDefIndex: 1116
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x15F6100 Offset: 0x15F6201 VA: 0x15F6100
	private static void .cctor() { }

	// RVA: 0x15F64F0 Offset: 0x15F65F1 VA: 0x15F64F0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x15F6500 Offset: 0x15F6601 VA: 0x15F6500
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x15F6510 Offset: 0x15F6611 VA: 0x15F6510
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x15F6570 Offset: 0x15F6671 VA: 0x15F6570
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0xB9410 Offset: 0xB9511 VA: 0xB9410
	// RVA: 0x15F7160 Offset: 0x15F7261 VA: 0x15F7160
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0xB9430 Offset: 0xB9531 VA: 0xB9430
	// RVA: 0x15F72F0 Offset: 0x15F73F1 VA: 0x15F72F0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x15F7400 Offset: 0x15F7501 VA: 0x15F7400
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x15F74E0 Offset: 0x15F75E1 VA: 0x15F74E0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x15F7550 Offset: 0x15F7651 VA: 0x15F7550
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x15F7B80 Offset: 0x15F7C81 VA: 0x15F7B80
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x15F7C10 Offset: 0x15F7D11 VA: 0x15F7C10
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x15F7C70 Offset: 0x15F7D71 VA: 0x15F7C70
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0xB9450 Offset: 0xB9551 VA: 0xB9450
	// RVA: 0x15F0120 Offset: 0x15F0221 VA: 0x15F0120
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x15F88D0 Offset: 0x15F89D1 VA: 0x15F88D0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x15F8B90 Offset: 0x15F8C91 VA: 0x15F8B90
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F8D70 Offset: 0x15F8E71 VA: 0x15F8D70
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F04F0 Offset: 0x15F05F1 VA: 0x15F04F0
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F8EC0 Offset: 0x15F8FC1 VA: 0x15F8EC0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x15F8F60 Offset: 0x15F9061 VA: 0x15F8F60
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x15F90D0 Offset: 0x15F91D1 VA: 0x15F90D0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x15F9330 Offset: 0x15F9431 VA: 0x15F9330
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x15F93B0 Offset: 0x15F94B1 VA: 0x15F93B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x15F1A90 Offset: 0x15F1B91 VA: 0x15F1A90
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x15F95F0 Offset: 0x15F96F1 VA: 0x15F95F0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x15F9730 Offset: 0x15F9831 VA: 0x15F9730
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x15F9240 Offset: 0x15F9341 VA: 0x15F9240
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x15F9D00 Offset: 0x15F9E01 VA: 0x15F9D00
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x15F87A0 Offset: 0x15F88A1 VA: 0x15F87A0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x15F4850 Offset: 0x15F4951 VA: 0x15F4850
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x15F8090 Offset: 0x15F8191 VA: 0x15F8090
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x15EFFC0 Offset: 0x15F00C1 VA: 0x15EFFC0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x15F7260 Offset: 0x15F7361 VA: 0x15F7260
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x15F9F50 Offset: 0x15FA051 VA: 0x15F9F50
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x15FA0E0 Offset: 0x15FA1E1 VA: 0x15FA0E0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x15FA260 Offset: 0x15FA361 VA: 0x15FA260
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x15F6480 Offset: 0x15F6581 VA: 0x15F6480
	private static void RegisterInternalChannels() { }

	// RVA: 0x15F2CB0 Offset: 0x15F2DB1 VA: 0x15F2CB0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x15FA320 Offset: 0x15FA421 VA: 0x15FA320
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x15FA6C0 Offset: 0x15FA7C1 VA: 0x15FA6C0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x15F1D90 Offset: 0x15F1E91 VA: 0x15F1D90
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x15F9570 Offset: 0x15F9671 VA: 0x15F9570
	private static string GetNormalizedUri(string uri) { }
}

[ComVisibleAttribute] // RVA: 0xB0AE0 Offset: 0xB0BE1 VA: 0xB0AE0
public static class RemotingServices // TypeDefIndex: 1116
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x15F6100 Offset: 0x15F6201 VA: 0x15F6100
	private static void .cctor() { }

	// RVA: 0x15F64F0 Offset: 0x15F65F1 VA: 0x15F64F0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x15F6500 Offset: 0x15F6601 VA: 0x15F6500
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x15F6510 Offset: 0x15F6611 VA: 0x15F6510
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x15F6570 Offset: 0x15F6671 VA: 0x15F6570
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0xB9410 Offset: 0xB9511 VA: 0xB9410
	// RVA: 0x15F7160 Offset: 0x15F7261 VA: 0x15F7160
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0xB9430 Offset: 0xB9531 VA: 0xB9430
	// RVA: 0x15F72F0 Offset: 0x15F73F1 VA: 0x15F72F0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x15F7400 Offset: 0x15F7501 VA: 0x15F7400
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x15F74E0 Offset: 0x15F75E1 VA: 0x15F74E0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x15F7550 Offset: 0x15F7651 VA: 0x15F7550
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x15F7B80 Offset: 0x15F7C81 VA: 0x15F7B80
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x15F7C10 Offset: 0x15F7D11 VA: 0x15F7C10
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x15F7C70 Offset: 0x15F7D71 VA: 0x15F7C70
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0xB9450 Offset: 0xB9551 VA: 0xB9450
	// RVA: 0x15F0120 Offset: 0x15F0221 VA: 0x15F0120
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x15F88D0 Offset: 0x15F89D1 VA: 0x15F88D0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x15F8B90 Offset: 0x15F8C91 VA: 0x15F8B90
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F8D70 Offset: 0x15F8E71 VA: 0x15F8D70
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F04F0 Offset: 0x15F05F1 VA: 0x15F04F0
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F8EC0 Offset: 0x15F8FC1 VA: 0x15F8EC0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x15F8F60 Offset: 0x15F9061 VA: 0x15F8F60
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x15F90D0 Offset: 0x15F91D1 VA: 0x15F90D0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x15F9330 Offset: 0x15F9431 VA: 0x15F9330
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x15F93B0 Offset: 0x15F94B1 VA: 0x15F93B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x15F1A90 Offset: 0x15F1B91 VA: 0x15F1A90
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x15F95F0 Offset: 0x15F96F1 VA: 0x15F95F0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x15F9730 Offset: 0x15F9831 VA: 0x15F9730
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x15F9240 Offset: 0x15F9341 VA: 0x15F9240
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x15F9D00 Offset: 0x15F9E01 VA: 0x15F9D00
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x15F87A0 Offset: 0x15F88A1 VA: 0x15F87A0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x15F4850 Offset: 0x15F4951 VA: 0x15F4850
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x15F8090 Offset: 0x15F8191 VA: 0x15F8090
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x15EFFC0 Offset: 0x15F00C1 VA: 0x15EFFC0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x15F7260 Offset: 0x15F7361 VA: 0x15F7260
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x15F9F50 Offset: 0x15FA051 VA: 0x15F9F50
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x15FA0E0 Offset: 0x15FA1E1 VA: 0x15FA0E0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x15FA260 Offset: 0x15FA361 VA: 0x15FA260
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x15F6480 Offset: 0x15F6581 VA: 0x15F6480
	private static void RegisterInternalChannels() { }

	// RVA: 0x15F2CB0 Offset: 0x15F2DB1 VA: 0x15F2CB0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x15FA320 Offset: 0x15FA421 VA: 0x15FA320
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x15FA6C0 Offset: 0x15FA7C1 VA: 0x15FA6C0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x15F1D90 Offset: 0x15F1E91 VA: 0x15F1D90
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x15F9570 Offset: 0x15F9671 VA: 0x15F9570
	private static string GetNormalizedUri(string uri) { }
}

[ComVisibleAttribute] // RVA: 0xB0AE0 Offset: 0xB0BE1 VA: 0xB0AE0
public static class RemotingServices // TypeDefIndex: 1116
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x15F6100 Offset: 0x15F6201 VA: 0x15F6100
	private static void .cctor() { }

	// RVA: 0x15F64F0 Offset: 0x15F65F1 VA: 0x15F64F0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x15F6500 Offset: 0x15F6601 VA: 0x15F6500
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x15F6510 Offset: 0x15F6611 VA: 0x15F6510
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x15F6570 Offset: 0x15F6671 VA: 0x15F6570
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisibleAttribute] // RVA: 0xB9410 Offset: 0xB9511 VA: 0xB9410
	// RVA: 0x15F7160 Offset: 0x15F7261 VA: 0x15F7160
	public static object Connect(Type classToProxy, string url) { }

	[ComVisibleAttribute] // RVA: 0xB9430 Offset: 0xB9531 VA: 0xB9430
	// RVA: 0x15F72F0 Offset: 0x15F73F1 VA: 0x15F72F0
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x15F7400 Offset: 0x15F7501 VA: 0x15F7400
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x15F74E0 Offset: 0x15F75E1 VA: 0x15F74E0
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x15F7550 Offset: 0x15F7651 VA: 0x15F7550
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x15F7B80 Offset: 0x15F7C81 VA: 0x15F7B80
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x15F7C10 Offset: 0x15F7D11 VA: 0x15F7C10
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x15F7C70 Offset: 0x15F7D71 VA: 0x15F7C70
	private static string NewUri() { }

	[ReliabilityContractAttribute] // RVA: 0xB9450 Offset: 0xB9551 VA: 0xB9450
	// RVA: 0x15F0120 Offset: 0x15F0221 VA: 0x15F0120
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x15F88D0 Offset: 0x15F89D1 VA: 0x15F88D0
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x15F8B90 Offset: 0x15F8C91 VA: 0x15F8B90
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F8D70 Offset: 0x15F8E71 VA: 0x15F8D70
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x15F04F0 Offset: 0x15F05F1 VA: 0x15F04F0
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x15F8EC0 Offset: 0x15F8FC1 VA: 0x15F8EC0
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x15F8F60 Offset: 0x15F9061 VA: 0x15F8F60
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x15F90D0 Offset: 0x15F91D1 VA: 0x15F90D0
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x15F9330 Offset: 0x15F9431 VA: 0x15F9330
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x15F93B0 Offset: 0x15F94B1 VA: 0x15F93B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x15F1A90 Offset: 0x15F1B91 VA: 0x15F1A90
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x15F95F0 Offset: 0x15F96F1 VA: 0x15F95F0
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x15F9730 Offset: 0x15F9831 VA: 0x15F9730
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x15F9240 Offset: 0x15F9341 VA: 0x15F9240
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x15F9D00 Offset: 0x15F9E01 VA: 0x15F9D00
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x15F87A0 Offset: 0x15F88A1 VA: 0x15F87A0
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x15F4850 Offset: 0x15F4951 VA: 0x15F4850
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x15F8090 Offset: 0x15F8191 VA: 0x15F8090
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x15EFFC0 Offset: 0x15F00C1 VA: 0x15EFFC0
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x15F7260 Offset: 0x15F7361 VA: 0x15F7260
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x15F9F50 Offset: 0x15FA051 VA: 0x15F9F50
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x15FA0E0 Offset: 0x15FA1E1 VA: 0x15FA0E0
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x15FA260 Offset: 0x15FA361 VA: 0x15FA260
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x15F6480 Offset: 0x15F6581 VA: 0x15F6480
	private static void RegisterInternalChannels() { }

	// RVA: 0x15F2CB0 Offset: 0x15F2DB1 VA: 0x15F2CB0
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x15FA320 Offset: 0x15FA421 VA: 0x15FA320
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x15FA6C0 Offset: 0x15FA7C1 VA: 0x15FA6C0
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x15F1D90 Offset: 0x15F1E91 VA: 0x15F1D90
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x15F9570 Offset: 0x15F9671 VA: 0x15F9570
	private static string GetNormalizedUri(string uri) { }
}

